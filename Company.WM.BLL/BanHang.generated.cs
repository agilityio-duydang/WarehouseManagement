using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace Company.WM.BLL
{
	public partial class BanHang : ICloneable
	{
		#region Properties.
		
		public long Id { set; get; }
		public string GhiChu { set; get; }
		public DateTime ThoiGianTao { set; get; }
		public long KhachHangId { set; get; }
		public long NhanVienId { set; get; }
        public List<BanHang_HangHoa> HangHoaCollection { set; get; }
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Methods
		protected static List<BanHang> ConvertToCollection(IDataReader reader)
		{
			List<BanHang> collection = new List<BanHang>();
			while (reader.Read())
			{
				BanHang entity = new BanHang();
				if (!reader.IsDBNull(reader.GetOrdinal("Id"))) entity.Id = reader.GetInt64(reader.GetOrdinal("Id"));
				if (!reader.IsDBNull(reader.GetOrdinal("GhiChu"))) entity.GhiChu = reader.GetString(reader.GetOrdinal("GhiChu"));
				if (!reader.IsDBNull(reader.GetOrdinal("ThoiGianTao"))) entity.ThoiGianTao = reader.GetDateTime(reader.GetOrdinal("ThoiGianTao"));
				if (!reader.IsDBNull(reader.GetOrdinal("KhachHangId"))) entity.KhachHangId = reader.GetInt64(reader.GetOrdinal("KhachHangId"));
				if (!reader.IsDBNull(reader.GetOrdinal("NhanVienId"))) entity.NhanVienId = reader.GetInt64(reader.GetOrdinal("NhanVienId"));
				collection.Add(entity);
			}
			reader.Close();
			return collection;
		}
		
		public static bool Find(List<BanHang> collection, long id)
        {
            foreach (BanHang item in collection)
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
            string insert = "Insert INTO t_BanHang VALUES(@GhiChu, @ThoiGianTao, @KhachHangId, @NhanVienId)";
            string update = "UPDATE t_BanHang SET GhiChu = @GhiChu, ThoiGianTao = @ThoiGianTao, KhachHangId = @KhachHangId, NhanVienId = @NhanVienId WHERE Id = @Id";
            string delete = "DELETE FROM t_BanHang WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGianTao", SqlDbType.DateTime, "ThoiGianTao", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGianTao", SqlDbType.DateTime, "ThoiGianTao", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, ds.Tables[0].TableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }
				
		public static void UpdateDataSet(DataSet ds, string tableName)
        {
            string insert = "Insert INTO t_BanHang VALUES(@GhiChu, @ThoiGianTao, @KhachHangId, @NhanVienId)";
            string update = "UPDATE t_BanHang SET GhiChu = @GhiChu, ThoiGianTao = @ThoiGianTao, KhachHangId = @KhachHangId, NhanVienId = @NhanVienId WHERE Id = @Id";
            string delete = "DELETE FROM t_BanHang WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGianTao", SqlDbType.DateTime, "ThoiGianTao", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGianTao", SqlDbType.DateTime, "ThoiGianTao", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, tableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }

		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Select methods.
		
		public static BanHang Load(long id)
		{
			const string spName = "[dbo].[p_BanHang_Load]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, id);
            IDataReader reader = db.ExecuteReader(dbCommand);
			List<BanHang> collection = ConvertToCollection(reader);	
			if (collection.Count > 0)
			{
				return collection[0];
			}
			return null;
		}		
		
		//---------------------------------------------------------------------------------------------
		public static List<BanHang> SelectCollectionAll()
		{
			IDataReader reader = SelectReaderAll();
			return ConvertToCollection(reader);			
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public static List<BanHang> SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			IDataReader reader = SelectReaderDynamic(whereCondition, orderByExpression);
			return ConvertToCollection(reader);		
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		public static List<BanHang> SelectCollectionBy_KhachHangId(long khachHangId)
		{
            IDataReader reader = SelectReaderBy_KhachHangId(khachHangId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<BanHang> SelectCollectionBy_NhanVienId(long nhanVienId)
		{
            IDataReader reader = SelectReaderBy_NhanVienId(nhanVienId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectBy_KhachHangId(long khachHangId)
		{
			const string spName = "[dbo].[p_BanHang_SelectBy_KhachHangId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, khachHangId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_BanHang_SelectBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------

		public static DataSet SelectAll()
        {
            const string spName = "[dbo].[p_BanHang_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			
            return db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_BanHang_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
				
		public static IDataReader SelectReaderAll()
        {
            const string spName = "[dbo].[p_BanHang_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
            return db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_BanHang_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteReader(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		public static IDataReader SelectReaderBy_KhachHangId(long khachHangId)
		{
			const string spName = "p_BanHang_SelectBy_KhachHangId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, khachHangId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_NhanVienId(long nhanVienId)
		{
			const string spName = "p_BanHang_SelectBy_NhanVienId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert methods.
		
		public static long InsertBanHang(string ghiChu, DateTime thoiGianTao, long khachHangId, long nhanVienId)
		{
			BanHang entity = new BanHang();	
			entity.GhiChu = ghiChu;
			entity.ThoiGianTao = thoiGianTao;
			entity.KhachHangId = khachHangId;
			entity.NhanVienId = nhanVienId;
			return entity.Insert();
		}
		
		public long Insert()
		{
			return this.Insert(null);
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public long Insert(SqlTransaction transaction)
		{			
			const string spName = "[dbo].[p_BanHang_Insert]";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddOutParameter(dbCommand, "@Id", SqlDbType.BigInt, 8);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@ThoiGianTao", SqlDbType.DateTime, ThoiGianTao.Year <= 1753 ? DBNull.Value : (object) ThoiGianTao);
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, KhachHangId);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			
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
		public static bool InsertCollection(List<BanHang> collection)
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
						foreach (BanHang item in collection)
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
		
		public static int InsertUpdateBanHang(long id, string ghiChu, DateTime thoiGianTao, long khachHangId, long nhanVienId)
		{
			BanHang entity = new BanHang();			
			entity.Id = id;
			entity.GhiChu = ghiChu;
			entity.ThoiGianTao = thoiGianTao;
			entity.KhachHangId = khachHangId;
			entity.NhanVienId = nhanVienId;
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
			const string spName = "p_BanHang_InsertUpdate";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@ThoiGianTao", SqlDbType.DateTime, ThoiGianTao.Year <= 1753 ? DBNull.Value : (object) ThoiGianTao);
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, KhachHangId);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);			
		}
		
		//---------------------------------------------------------------------------------------------
		public static bool InsertUpdateCollection(List<BanHang> collection)
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
						foreach (BanHang item in collection)
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
		
		public static int UpdateBanHang(long id, string ghiChu, DateTime thoiGianTao, long khachHangId, long nhanVienId)
		{
			BanHang entity = new BanHang();			
			entity.Id = id;
			entity.GhiChu = ghiChu;
			entity.ThoiGianTao = thoiGianTao;
			entity.KhachHangId = khachHangId;
			entity.NhanVienId = nhanVienId;
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
			const string spName = "[dbo].[p_BanHang_Update]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@ThoiGianTao", SqlDbType.DateTime, ThoiGianTao.Year <= 1753 ? DBNull.Value : (object) ThoiGianTao);
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, KhachHangId);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
				
		//---------------------------------------------------------------------------------------------
		public static bool UpdateCollection(List<BanHang> collection)
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
						foreach (BanHang item in collection)
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
		
		public static int DeleteBanHang(long id)
		{
			BanHang entity = new BanHang();
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
			const string spName = "[dbo].[p_BanHang_Delete]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
		
		public static int DeleteBy_KhachHangId(long khachHangId)
		{
			const string spName = "[dbo].[p_BanHang_DeleteBy_KhachHangId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, khachHangId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_BanHang_DeleteBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		
		public static int DeleteDynamic(string whereCondition)
		{
			const string spName = "[dbo].[p_BanHang_DeleteDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            
            return db.ExecuteNonQuery(dbCommand);   
		}
		//---------------------------------------------------------------------------------------------
		
		public static bool DeleteCollection(List<BanHang> collection)
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
						foreach (BanHang item in collection)
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

        public void InsertUpdateFull()
        {
            SqlDatabase db = (SqlDatabase)DatabaseFactory.CreateDatabase();
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    if (this.Id == 0)
                    {
                        this.Id = this.Insert(transaction);
                    }
                    else
                    {
                        this.Update(transaction);
                    }

                    foreach (BanHang_HangHoa item in HangHoaCollection)
                    {
                        item.BanHangId = this.Id;
                        if (item.Id == 0)
                        {
                            item.Insert(transaction);
                        }
                        else
                        {
                            item.Update(transaction);
                        }
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

        public void DeleteFull()
        {
            SqlDatabase db = (SqlDatabase)DatabaseFactory.CreateDatabase();
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    foreach (BanHang_HangHoa item in HangHoaCollection)
                    {
                        item.Delete();
                    }
                    this.Delete();
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