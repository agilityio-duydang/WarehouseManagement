using System;
using System.Data;
using System.Data.SqlClient;
using Company.WM.BLL;
using System.Collections;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Collections.Generic;

namespace Company.WM.BLL.Administration
{
    public partial class User
    {
        SqlDatabase db = (SqlDatabase)DatabaseFactory.CreateDatabase();

        public ArrayList RoleList = new ArrayList();
        private bool _Check = false;
        public bool Check
        {
            set { _Check = value; }
            get { return _Check; }
        }
        public bool Load(string user_name)
        {
            string spName = "select * from [User] where [UserName]=@USER_NAME";
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(spName);

            this.db.AddInParameter(dbCommand, "@USER_NAME", SqlDbType.VarChar, user_name);

            IDataReader reader = this.db.ExecuteReader(dbCommand);
            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) this.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("Password"))) this.Password = reader.GetString(reader.GetOrdinal("Password"));
                if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) this.FullName = reader.GetString(reader.GetOrdinal("FullName"));
                if (!reader.IsDBNull(reader.GetOrdinal("SoDienThoai"))) this.SoDienThoai = reader.GetString(reader.GetOrdinal("SoDienThoai"));
                if (!reader.IsDBNull(reader.GetOrdinal("DiaChi"))) this.DiaChi = reader.GetString(reader.GetOrdinal("DiaChi"));
                if (!reader.IsDBNull(reader.GetOrdinal("Email"))) this.Email = reader.GetString(reader.GetOrdinal("Email"));
                if (!reader.IsDBNull(reader.GetOrdinal("isAdmin"))) this.isAdmin = reader.GetBoolean(reader.GetOrdinal("isAdmin"));
                if (!reader.IsDBNull(reader.GetOrdinal("ID"))) this.ID = reader.GetInt64(reader.GetOrdinal("ID"));
                if (!reader.IsDBNull(reader.GetOrdinal("isOnline"))) this.isOnline = reader.GetBoolean(reader.GetOrdinal("isOnline"));
                if (!reader.IsDBNull(reader.GetOrdinal("HostName"))) this.HostName = reader.GetString(reader.GetOrdinal("HostName"));
                if (!reader.IsDBNull(reader.GetOrdinal("IP"))) this.IP = reader.GetString(reader.GetOrdinal("IP"));
                if (!reader.IsDBNull(reader.GetOrdinal("DataBase"))) this.DataBase = reader.GetString(reader.GetOrdinal("DataBase"));
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        public bool TestPassWord(long ID, string password)
        {
            string spName = "select * from [User] where ID=@ID and [PASSWORD]=@PASSWORD";
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(spName);

            this.db.AddInParameter(dbCommand, "@ID", SqlDbType.BigInt, ID);
            this.db.AddInParameter(dbCommand, "@PASSWORD", SqlDbType.VarChar, password);

            IDataReader reader = this.db.ExecuteReader(dbCommand);
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }
        public ArrayList GetEffectivePermissionList()
        {
            string sql = "Select  ID from ROLE ";
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(sql);

            ArrayList permissions = new ArrayList();
            IDataReader reader = this.db.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                permissions.Add(reader.GetInt64(0));
            }
            reader.Close();
            return permissions;
        }
        public ArrayList GetUserRoles()
        {
            string sql = "select MA_NHOM from GROUPS";
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(sql);

            ArrayList permissions = new ArrayList();
            IDataReader reader = this.db.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                permissions.Add(reader.GetInt64(0));
            }
            reader.Close();
            return permissions;
        }
        public ArrayList GetEffectivePermissionList(long UserID)
        {
            string sql = "Select distinct ID_ROLE from GROUP_ROLE where GROUP_ID in(select MA_NHOM from USER_GROUP where USER_ID=@USER_ID)";
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(sql);

            this.db.AddInParameter(dbCommand, "@USER_ID", SqlDbType.BigInt, UserID);
            ArrayList permissions = new ArrayList();
            IDataReader reader = this.db.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                permissions.Add(reader.GetInt64(0));
            }
            reader.Close();
            return permissions;
        }
        public ArrayList GetUserRoles(long UserID)
        {
            string sql = "select distinct MA_NHOM from USER_GROUP where USER_ID=@USER_ID";
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(sql);

            this.db.AddInParameter(dbCommand, "@USER_ID", SqlDbType.BigInt, UserID);
            ArrayList permissions = new ArrayList();
            IDataReader reader = this.db.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                permissions.Add(reader.GetInt64(0));
            }
            reader.Close();
            return permissions;
        }
        public void LoadRoleList()
        {
            RoleList = GetUserRoles(this.ID);
        }
        public long ValidateLogin(string UserName, string password)
        {
            string spName = "select ID from [User] where [UserName]=@USER_NAME and [Password]=@PASSWORD";
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(spName);

            this.db.AddInParameter(dbCommand, "@USER_NAME", SqlDbType.VarChar, UserName);
            this.db.AddInParameter(dbCommand, "@PASSWORD", SqlDbType.VarChar, password);

            object o = this.db.ExecuteScalar(dbCommand);
            return Convert.ToInt64(o);
        }

        public bool CheckUserName(string UserName)
        {
            string spName = "select ID from [User] where [UserName]=@USER_NAME and ID<>@ID";
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(spName);

            this.db.AddInParameter(dbCommand, "@USER_NAME", SqlDbType.VarChar, UserName);
            this.db.AddInParameter(dbCommand, "@ID", SqlDbType.BigInt, this.ID);

            object o = this.db.ExecuteScalar(dbCommand);
            return (o != null);
        }
        public void InsertUpdateFull()
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    if (this.ID > 0)
                        this.Update(transaction);
                    else
                        this.Insert(transaction);
                    DeleteRoleTransaction(transaction);
                    for (int i = 0; i < RoleList.Count; ++i)
                    {
                        USER_GROUP ug = new USER_GROUP();
                        ug.USER_ID = this.ID;
                        ug.MA_NHOM = Convert.ToInt64(RoleList[i]);
                        ug.InsertTransaction(transaction);
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public int DeleteRoleTransaction(SqlTransaction transaction)
        {
            string spName = "delete from USER_GROUP where USER_ID=@USER_ID";
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(spName);

            this.db.AddInParameter(dbCommand, "@USER_ID", SqlDbType.BigInt, this.ID);

            if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);
        }
    }
}