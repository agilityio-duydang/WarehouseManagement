using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WarehouseManagement
{
   public class SQL
    {
        //public static Microsoft.SqlServer.Management.Smo.Server server;
        static SqlConnection sqlConnection = new SqlConnection();
        /// <summary>
        /// Initializes the field 'server'
        /// </summary>
        public static void InitializeServer()
        {
            // To Connect to our SQL Server - we Can use the Connection from the System.Data.SqlClient Namespace.
            SqlConnection sqlConnection = new SqlConnection(@"Integrated Security=SSPI; Data Source=(local)\ECSEXPRESS");

            //build a "serverConnection" with the information of the "sqlConnection"
            //Microsoft.SqlServer.Management.Common.ServerConnection serverConnection = new Microsoft.SqlServer.Management.Common.ServerConnection(sqlConnection);

            //The "serverConnection is used in the ctor of the Server.
            //server = new Server(serverConnection);
        }
        /// <summary>
        /// Initializes the field 'server'
        /// </summary>
        public static void InitializeServer(string sqlConnectionString)
        {
            // To Connect to our SQL Server - we Can use the Connection from the System.Data.SqlClient Namespace.
            sqlConnection = new SqlConnection(sqlConnectionString);

            //build a "serverConnection" with the information of the "sqlConnection"
            //Microsoft.SqlServer.Management.Common.ServerConnection serverConnection = new Microsoft.SqlServer.Management.Common.ServerConnection(sqlConnection);

            //The "serverConnection is used in the ctor of the Server.
            //server = new Server(serverConnection);
        }
        public static List<string> ListDatabases()
        {
            List<string> listData = new List<string>();
            DataTable dtSource = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string query = "SELECT name FROM sys.sysdatabases";
            adapter.SelectCommand = new SqlCommand(query, sqlConnection);
            adapter.Fill(dtSource);
            foreach (DataRow dr in dtSource.Rows)
            {
                listData.Add(dr[0].ToString());
            }
            return listData;
        }
        public static string GetFolderDatabaseRemote(string serverName, string dbName, string dbUser, string dbPassWord)
        {
            if (string.IsNullOrEmpty(serverName) || string.IsNullOrEmpty(dbName) || string.IsNullOrEmpty(dbUser))
                return "";
            else
            {
                string folderRemote = "";
                bool connection = false;
                try
                {
                    using (SqlConnection cnn = new SqlConnection())
                    {
                        cnn.ConnectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Connect Timeout={4}", new object[] { serverName, dbName, dbUser, dbPassWord, GlobalSettings.TimeoutBackup * 60 }); //TimeoutBackup = phút * 60 giây.
                        cnn.Open();
                        connection = true;
                        string cmdText = @"
			                                --Default backup database
                                            --Created 09-2012
                                            --Modified 09-2012
                                            --Backup database at folder data *.mdf with format dbName_yyyy_MM_dd.bak
                                            BEGIN

                                            DECLARE @filedata  AS NVARCHAR(max)
                                            DECLARE @filename  AS NVARCHAR(max)
                                            DECLARE @dir  AS NVARCHAR(max)
                                            DECLARE @dbName AS NVARCHAR(255)

                                            SET @filedata=(
                                            SELECT TOP(1) 	filename
                                                from sysfiles
                                                order by fileid)
                                            SET @dbName = (select TOP(1) name from sys.sysdatabases  WHERE filename=@filedata)
                                            SET @filename =
                                            LTRIM(
                                              RTRIM(
                                               REVERSE(
                                                SUBSTRING(
                                                 REVERSE(@filedata),
                                                 0,
                                                 CHARINDEX('\', REVERSE(@filedata),0)
                                                )
                                               )
                                              )
                                             )
                                            SET @dir = REPLACE(@filedata,@filename,'')
                                            
                                            Select @dir

                                            END
                                         ";
                        SqlCommand sqlCmd = new SqlCommand(cmdText);
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Connection = cnn;
                        folderRemote = (string)sqlCmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    Logger.LocalLogger.Instance().WriteMessage(ex);
                    throw ex;
                }

                return folderRemote;
            }
        }
        public static void CheckAndCreateProcedureCheckTerminalOnline(string serverName, string dbName, string dbUser, string dbPassWord)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection())
                {
                    cnn.ConnectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3}", new object[] { serverName, dbName, dbUser, dbPassWord });
                    cnn.Open();

                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Connection = cnn;

                    string cmdText = "";

                    #region Bo sung them store Kiem tra trang thai Terminal
                    cmdText = @"DECLARE @sql NVARCHAR(max)
                                SET @sql = 
                                'IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N''[dbo].[CheckAndUpdateTerminalStatus]'') AND type in (N''P'', N''PC''))
                                DROP PROCEDURE [dbo].[CheckAndUpdateTerminalStatus]
                                '
                                EXEC sp_executesql @sql

                                SET @sql = 
                                '
                                CREATE PROC [dbo].[CheckAndUpdateTerminalStatus]
                                AS
                                	
                                DECLARE @user VARCHAR(100), @database VARCHAR(200)

                                DECLARE cur CURSOR FAST_FORWARD READ_ONLY FOR
                                SELECT [UserName], [DataBase] FROM [User]

                                OPEN cur

                                FETCH NEXT FROM cur INTO @user, @database

                                WHILE @@FETCH_STATUS = 0
                                BEGIN

                                if(SELECT COUNT(*) from sys.dm_exec_connections c INNER JOIN sys.dm_exec_sessions s ON c.session_id = s.session_id
                                LEFT JOIN sys.sysprocesses pr ON pr.spid = c.session_id
                                where client_net_address is not null 
                                and (client_net_address = (select IP from [User] where [UserName]  = @user) OR client_net_address = ''<local machine>'') 
                                AND ISNULL(DB_NAME(pr.dbid), N'''') = ( SELECT [DataBase] FROM [User] WHERE [DataBase] = @database and [DataBase] is not null and [UserName]  = @user )
                                and s.program_name = ''.Net SqlClient Data Provider'') > 0
                                    begin
                                        update [User] set isOnline = 1 where [UserName]  = @user
                                    end
                                else
                                    begin
                                        update [User] set isOnline = 0 where [UserName]  = @user
                                    END
                                	
                                FETCH NEXT FROM cur INTO @user, @database

                                END

                                CLOSE cur
                                DEALLOCATE cur
                                '
                                EXEC sp_executesql @sql";
                    #endregion
                    sqlCmd.CommandText = cmdText;
                    sqlCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LocalLogger.Instance().WriteMessage(ex);
            }
        }
    }
}
