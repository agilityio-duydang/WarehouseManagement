using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace Company.WM.BLL
{
	public partial class PaymentType : ICloneable
	{
		#region Properties.
		
		public long Id { set; get; }
		public string Ten { set; get; }
		public string MoTa { set; get; }
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Methods
		protected static List<PaymentType> ConvertToCollection(IDataReader reader)
		{
			List<PaymentType> collection = new List<PaymentType>();
			while (reader.Read())
			{
				PaymentType entity = new PaymentType();
				if (!reader.IsDBNull(reader.GetOrdinal("Id"))) entity.Id = reader.GetInt64(reader.GetOrdinal("Id"));
				if (!reader.IsDBNull(reader.GetOrdinal("Ten"))) entity.Ten = reader.GetString(reader.GetOrdinal("Ten"));
				if (!reader.IsDBNull(reader.GetOrdinal("MoTa"))) entity.MoTa = reader.GetString(reader.GetOrdinal("MoTa"));
				collection.Add(entity);
			}
			reader.Close();
			return collection;
		}
		
		public static bool Find(List<PaymentType> collection, long id)
        {
            foreach (PaymentType item in collection)
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
            string insert = "Insert INTO t_PaymentType VALUES(@Ten, @MoTa)";
            string update = "UPDATE t_PaymentType SET Ten = @Ten, MoTa = @MoTa WHERE Id = @Id";
            string delete = "DELETE FROM t_PaymentType WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@Ten", SqlDbType.NVarChar, "Ten", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MoTa", SqlDbType.NVarChar, "MoTa", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@Ten", SqlDbType.NVarChar, "Ten", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MoTa", SqlDbType.NVarChar, "MoTa", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, ds.Tables[0].TableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }
				
		public static void UpdateDataSet(DataSet ds, string tableName)
        {
            string insert = "Insert INTO t_PaymentType VALUES(@Ten, @MoTa)";
            string update = "UPDATE t_PaymentType SET Ten = @Ten, MoTa = @MoTa WHERE Id = @Id";
            string delete = "DELETE FROM t_PaymentType WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@Ten", SqlDbType.NVarChar, "Ten", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MoTa", SqlDbType.NVarChar, "MoTa", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@Ten", SqlDbType.NVarChar, "Ten", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MoTa", SqlDbType.NVarChar, "MoTa", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, tableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }

		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Select methods.
		
		public static PaymentType Load(long id)
		{
			const string spName = "[dbo].[p_PaymentType_Load]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, id);
            IDataReader reader = db.ExecuteReader(dbCommand);
			List<PaymentType> collection = ConvertToCollection(reader);	
			if (collection.Count > 0)
			{
				return collection[0];
			}
			return null;
		}		
		
		//---------------------------------------------------------------------------------------------
		public static List<PaymentType> SelectCollectionAll()
		{
			IDataReader reader = SelectReaderAll();
			return ConvertToCollection(reader);			
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public static List<PaymentType> SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			IDataReader reader = SelectReaderDynamic(whereCondition, orderByExpression);
			return ConvertToCollection(reader);		
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		

		public static DataSet SelectAll()
        {
            const string spName = "[dbo].[p_PaymentType_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			
            return db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_PaymentType_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
				
		public static IDataReader SelectReaderAll()
        {
            const string spName = "[dbo].[p_PaymentType_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
            return db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_PaymentType_SelectDynamic]";
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
		
		public static long InsertPaymentType(string ten, string moTa)
		{
			PaymentType entity = new PaymentType();	
			entity.Ten = ten;
			entity.MoTa = moTa;
			return entity.Insert();
		}
		
		public long Insert()
		{
			return this.Insert(null);
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public long Insert(SqlTransaction transaction)
		{			
			const string spName = "[dbo].[p_PaymentType_Insert]";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddOutParameter(dbCommand, "@Id", SqlDbType.BigInt, 8);
			db.AddInParameter(dbCommand, "@Ten", SqlDbType.NVarChar, Ten);
			db.AddInParameter(dbCommand, "@MoTa", SqlDbType.NVarChar, MoTa);
			
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
		public static bool InsertCollection(List<PaymentType> collection)
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
						foreach (PaymentType item in collection)
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
		
		public static int InsertUpdatePaymentType(long id, string ten, string moTa)
		{
			PaymentType entity = new PaymentType();			
			entity.Id = id;
			entity.Ten = ten;
			entity.MoTa = moTa;
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
			const string spName = "p_PaymentType_InsertUpdate";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@Ten", SqlDbType.NVarChar, Ten);
			db.AddInParameter(dbCommand, "@MoTa", SqlDbType.NVarChar, MoTa);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);			
		}
		
		//---------------------------------------------------------------------------------------------
		public static bool InsertUpdateCollection(List<PaymentType> collection)
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
						foreach (PaymentType item in collection)
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
		
		public static int UpdatePaymentType(long id, string ten, string moTa)
		{
			PaymentType entity = new PaymentType();			
			entity.Id = id;
			entity.Ten = ten;
			entity.MoTa = moTa;
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
			const string spName = "[dbo].[p_PaymentType_Update]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@Ten", SqlDbType.NVarChar, Ten);
			db.AddInParameter(dbCommand, "@MoTa", SqlDbType.NVarChar, MoTa);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
				
		//---------------------------------------------------------------------------------------------
		public static bool UpdateCollection(List<PaymentType> collection)
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
						foreach (PaymentType item in collection)
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
		
		public static int DeletePaymentType(long id)
		{
			PaymentType entity = new PaymentType();
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
			const string spName = "[dbo].[p_PaymentType_Delete]";		
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
			const string spName = "[dbo].[p_PaymentType_DeleteDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            
            return db.ExecuteNonQuery(dbCommand);   
		}
		//---------------------------------------------------------------------------------------------
		
		public static bool DeleteCollection(List<PaymentType> collection)
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
						foreach (PaymentType item in collection)
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