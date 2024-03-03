using System;
using System.Data;
using System.Data.SqlClient;
using Company.WM.BLL;

namespace Company.WM.BLL.Administration
{
	public partial class GROUP_ROLE : EntityBase
	{
        public GROUP_ROLECollection SelectCollectionBy_GROUP_IDAndModule(int Module)
        {
            string sql = "select gr.* from [ROLE] r " +
                        "inner join GROUP_ROLE gr on r.ID=gr.ID_ROLE " +
                        "where GROUP_ID=@GROUP_ID " +
                        (Module > 0 ? " and ID_MODULE =@ID_MODULE " : "");
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(sql);

            this.db.AddInParameter(dbCommand, "@GROUP_ID", SqlDbType.BigInt, this.GROUP_ID);
            if (Module > 0)
                this.db.AddInParameter(dbCommand, "@ID_MODULE", SqlDbType.Int, Module);

            GROUP_ROLECollection collection = new GROUP_ROLECollection();
            IDataReader reader = this.db.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                GROUP_ROLE entity = new GROUP_ROLE();
                if (!reader.IsDBNull(reader.GetOrdinal("GROUP_ID"))) entity.GROUP_ID = reader.GetInt64(reader.GetOrdinal("GROUP_ID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ID_ROLE"))) entity.ID_ROLE = reader.GetInt64(reader.GetOrdinal("ID_ROLE"));
                collection.Add(entity);
            }
            return collection;
        }
        public int DeleteRoleTransaction(SqlTransaction transaction)
        {
            string spName = "delete from GROUP_ROLE where GROUP_ID=@GROUP_ID";
            SqlCommand dbCommand = (SqlCommand)this.db.GetSqlStringCommand(spName);

            this.db.AddInParameter(dbCommand, "@GROUP_ID", SqlDbType.BigInt, this.GROUP_ID);

            if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);
        }
        public void InsertUpdateFull(GROUP_ROLECollection collection)
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    this.DeleteRoleTransaction(transaction);
                    foreach (GROUP_ROLE gr in collection)
                    {
                        gr.InsertTransaction(transaction);
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

	}	
}