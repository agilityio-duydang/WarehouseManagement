using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace Company.WM.BLL
{
	public partial class NhomHangHoa : ICloneable
	{
		#region Properties.
		
		public long Id { set; get; }
		public string TenNhom { set; get; }
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Methods
		protected static List<NhomHangHoa> ConvertToCollection(IDataReader reader)
		{
			List<NhomHangHoa> collection = new List<NhomHangHoa>();
			while (reader.Read())
			{
				NhomHangHoa entity = new NhomHangHoa();
				if (!reader.IsDBNull(reader.GetOrdinal("Id"))) entity.Id = reader.GetInt64(reader.GetOrdinal("Id"));
				if (!reader.IsDBNull(reader.GetOrdinal("TenNhom"))) entity.TenNhom = reader.GetString(reader.GetOrdinal("TenNhom"));
				collection.Add(entity);
			}
			reader.Close();
			return collection;
		}
		
		public static bool Find(List<NhomHangHoa> collection, long id)
        {
            foreach (NhomHangHoa item in collection)
            {
                if (item.Id == id)
                {
                    return true;
                }
            }

            return false;
        }
		
		public static void UpdateDataSet(DataSet ds)
        {
            string insert = "Insert INTO t_NhomHangHoa VALUES(@TenNhom)";
            string update = "UPDATE t_NhomHangHoa SET TenNhom = @TenNhom WHERE Id = @Id";
            string delete = "DELETE FROM t_NhomHangHoa WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TenNhom", SqlDbType.NVarChar, "TenNhom", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TenNhom", SqlDbType.NVarChar, "TenNhom", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, ds.Tables[0].TableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }
				
		public static void UpdateDataSet(DataSet ds, string tableName)
        {
            string insert = "Insert INTO t_NhomHangHoa VALUES(@TenNhom)";
            string update = "UPDATE t_NhomHangHoa SET TenNhom = @TenNhom WHERE Id = @Id";
            string delete = "DELETE FROM t_NhomHangHoa WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TenNhom", SqlDbType.NVarChar, "TenNhom", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TenNhom", SqlDbType.NVarChar, "TenNhom", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, tableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }

		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Select methods.
		
		public static NhomHangHoa Load(long id)
		{
			const string spName = "[dbo].[p_NhomHangHoa_Load]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, id);
            IDataReader reader = db.ExecuteReader(dbCommand);
			List<NhomHangHoa> collection = ConvertToCollection(reader);	
			if (collection.Count > 0)
			{
				return collection[0];
			}
			return null;
		}		
		
		//---------------------------------------------------------------------------------------------
		public static List<NhomHangHoa> SelectCollectionAll()
		{
			IDataReader reader = SelectReaderAll();
			return ConvertToCollection(reader);			
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public static List<NhomHangHoa> SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			IDataReader reader = SelectReaderDynamic(whereCondition, orderByExpression);
			return ConvertToCollection(reader);		
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		

		public static DataSet SelectAll()
        {
            const string spName = "[dbo].[p_NhomHangHoa_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			
            return db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_NhomHangHoa_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
				
		public static IDataReader SelectReaderAll()
        {
            const string spName = "[dbo].[p_NhomHangHoa_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
            return db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_NhomHangHoa_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteReader(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert methods.
		
		public static long InsertNhomHangHoa(string tenNhom)
		{
			NhomHangHoa entity = new NhomHangHoa();	
			entity.TenNhom = tenNhom;
			return entity.Insert();
		}
		
		public long Insert()
		{
			return this.Insert(null);
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public long Insert(SqlTransaction transaction)
		{			
			const string spName = "[dbo].[p_NhomHangHoa_Insert]";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddOutParameter(dbCommand, "@Id", SqlDbType.BigInt, 8);
			db.AddInParameter(dbCommand, "@TenNhom", SqlDbType.NVarChar, TenNhom);
			
			if (transaction != null)
			{
				db.ExecuteNonQuery(dbCommand, transaction);
				Id = (long) db.GetParameterValue(dbCommand, "@Id");
				return Id;
			}
            else
			{
				db.ExecuteNonQuery(dbCommand);
				Id = (long) db.GetParameterValue(dbCommand, "@Id");
				return Id;
			}			
		}
				
		//---------------------------------------------------------------------------------------------
		public static bool InsertCollection(List<NhomHangHoa> collection)
        {
            bool ret;
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                using(SqlTransaction transaction = connection.BeginTransaction())
				{
					try
					{
						bool ret01 = true;
						foreach (NhomHangHoa item in collection)
						{
							if (item.Insert(transaction) <= 0)
							{							
								ret01 = false;
								break;
							}
						}
						if (ret01)
						{
							transaction.Commit();
							ret = true;
						}
						else
						{
							transaction.Rollback();
							ret = false;                    	
						}
					}
					catch (Exception ex)
					{
						transaction.Rollback();
						throw new Exception("Error at InsertCollection method: " + ex.Message);
					}
					finally 
					{
						connection.Close();
					}
				}
            }
            return ret;		
		}
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert / Update methods.
		
		public static int InsertUpdateNhomHangHoa(long id, string tenNhom)
		{
			NhomHangHoa entity = new NhomHangHoa();			
			entity.Id = id;
			entity.TenNhom = tenNhom;
			return entity.InsertUpdate();
		}
		
		//---------------------------------------------------------------------------------------------
		
		public int InsertUpdate()
		{
			return this.InsertUpdate(null);
		}
		
		//---------------------------------------------------------------------------------------------

		public int InsertUpdate(SqlTransaction transaction)
		{			
			const string spName = "p_NhomHangHoa_InsertUpdate";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@TenNhom", SqlDbType.NVarChar, TenNhom);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);			
		}
		
		//---------------------------------------------------------------------------------------------
		public static bool InsertUpdateCollection(List<NhomHangHoa> collection)
        {
            bool ret;
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
				{
					try
					{
						bool ret01 = true;
						foreach (NhomHangHoa item in collection)
						{
							if (item.InsertUpdate(transaction) <= 0)
							{
								ret01 = false;
								break;
							}
						}
						if (ret01)
						{
							transaction.Commit();
							ret = true;
						}
						else
						{
							transaction.Rollback();
							ret = false;                    	
						}
					}
					catch (Exception ex)
					{
						transaction.Rollback();
						throw new Exception("Error at InsertUpdateCollection method: " + ex.Message);
						
					}
					finally 
					{
						connection.Close();
					}
				}
            }
            return ret;		
		}	
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Update methods.
		
		public static int UpdateNhomHangHoa(long id, string tenNhom)
		{
			NhomHangHoa entity = new NhomHangHoa();			
			entity.Id = id;
			entity.TenNhom = tenNhom;
			return entity.Update();
		}
		
		//---------------------------------------------------------------------------------------------
		
		public int Update()
		{
			return this.Update(null);
		}
		
		//---------------------------------------------------------------------------------------------

		public int Update(SqlTransaction transaction)
		{
			const string spName = "[dbo].[p_NhomHangHoa_Update]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@TenNhom", SqlDbType.NVarChar, TenNhom);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
				
		//---------------------------------------------------------------------------------------------
		public static bool UpdateCollection(List<NhomHangHoa> collection)
        {
            bool ret;
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
				{
					try
					{
						bool ret01 = true;
						foreach (NhomHangHoa item in collection)
						{
							if (item.Update(transaction) <= 0)
							{
								ret01 = false;
								break;
							}
						}
						if (ret01)
						{
							transaction.Commit();
							ret = true;
						}
						else
						{
							transaction.Rollback();
							ret = false;                    	
						}
					}
					catch (Exception ex)
					{
						transaction.Rollback();
						throw new Exception("Error at UpdateCollection method: " + ex.Message);
					}
					finally 
					{
						connection.Close();
					}
				}
            }
            return ret;		
		}
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Delete methods.
		
		public static int DeleteNhomHangHoa(long id)
		{
			NhomHangHoa entity = new NhomHangHoa();
			entity.Id = id;
			
			return entity.Delete();
		}
		
		public int Delete()
		{
			return this.Delete(null);
		}
		
		//---------------------------------------------------------------------------------------------

		public int Delete(SqlTransaction transaction)
		{
			const string spName = "[dbo].[p_NhomHangHoa_Delete]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
		
		
		public static int DeleteDynamic(string whereCondition)
		{
			const string spName = "[dbo].[p_NhomHangHoa_DeleteDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            
            return db.ExecuteNonQuery(dbCommand);   
		}
		//---------------------------------------------------------------------------------------------
		
		public static bool DeleteCollection(List<NhomHangHoa> collection)
        {
            bool ret;
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
				{
					try
					{
						bool ret01 = true;
						foreach (NhomHangHoa item in collection)
						{
							if (item.Delete(transaction) <= 0)
							{
								ret01 = false;
								break;
							}
						}
						if (ret01)
						{
							transaction.Commit();
							ret = true;
						}
						else
						{
							transaction.Rollback();
							ret = false;                    	
						}
					}
					catch (Exception ex)
					{
						transaction.Rollback();
						throw new Exception("Error at DeleteCollection method: " + ex.Message);
					}
					finally 
					{
						connection.Close();
					}
				}
            }
            return ret;		
		}
		#endregion
		
		
        #region ICloneable Members

        public object Clone()
        {
            return base.MemberwiseClone();
        }

        #endregion
	}	
}