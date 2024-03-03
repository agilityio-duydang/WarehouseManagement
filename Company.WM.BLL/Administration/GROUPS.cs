using System;
using System.Data;
using System.Data.SqlClient;
using Company.WM.BLL;
using System.Collections;

namespace Company.WM.BLL.Administration
{
	public partial class GROUPS : EntityBase
	{
        public ArrayList UserList = new ArrayList();
        private bool _Check = false;
        public bool Check
        {
            set { _Check = value; }
            get { return _Check; }
        }
        public bool CheckGroupName(string name)
        {
            string spName = "select MA_NHOM from GROUPS where MA_NHOM<>@MA_NHOM and TEN_NHOM=@TEN_NHOM";
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(spName);

            this.db.AddInParameter(dbCommand, "@TEN_NHOM", SqlDbType.VarChar, name);
            this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this.MA_NHOM);

            object o = this.db.ExecuteScalar(dbCommand);
            return (o != null);
        }
        public void InsertUpdateFull()
        {            
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    if (this.MA_NHOM > 0)
                        this.UpdateTransaction(transaction);
                    else
                        this.InsertTransaction(transaction);
                    DeleteUserTransaction(transaction);
                    for (int i = 0; i < UserList.Count; ++i)
                    {
                        USER_GROUP ug = new USER_GROUP();
                        ug.USER_ID = Convert.ToInt64(UserList[i]);
                        ug.MA_NHOM = this.MA_NHOM;
                        ug.InsertTransaction(transaction);
                    }
                    transaction.Commit();
                }
                catch(Exception ex)
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
        public void LoadUserList()
        {
            string spName = "select USER_ID from USER_GROUP where MA_NHOM=@MA_NHOM";
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(spName);            
            this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this.MA_NHOM);
            IDataReader reader=db.ExecuteReader(dbCommand);
            UserList.Clear();
            while (reader.Read())
            {
                UserList.Add(reader.GetInt64(0));
            }
            reader.Close();
        }
        public bool CheckUserInGroup()
        {
            return UserList.Count > 0;
        }
        public int DeleteUserTransaction(SqlTransaction transaction)
        {
            string spName = "delete from USER_GROUP where MA_NHOM=@MA_NHOM";
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(spName);

            this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this.MA_NHOM);

            if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);
        }
   
	}	
}