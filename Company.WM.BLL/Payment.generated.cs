using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace Company.WM.BLL
{
	public partial class Payment : ICloneable
	{
		#region Properties.
		
		public long Id { set; get; }
		public DateTime ThoiGian { set; get; }
		public long PaymentTypeId { set; get; }
		public string GhiChu { set; get; }
		public string NguoiNhan { set; get; }
		public decimal GiaTri { set; get; }
		public long NhaCungCapId { set; get; }
		public long PhieuNhapKhoId { set; get; }
		public string MaPhieu { set; get; }
		public long NhanVienId { set; get; }
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Methods
		protected static List<Payment> ConvertToCollection(IDataReader reader)
		{
			List<Payment> collection = new List<Payment>();
			while (reader.Read())
			{
				Payment entity = new Payment();
				if (!reader.IsDBNull(reader.GetOrdinal("Id"))) entity.Id = reader.GetInt64(reader.GetOrdinal("Id"));
				if (!reader.IsDBNull(reader.GetOrdinal("ThoiGian"))) entity.ThoiGian = reader.GetDateTime(reader.GetOrdinal("ThoiGian"));
				if (!reader.IsDBNull(reader.GetOrdinal("PaymentTypeId"))) entity.PaymentTypeId = reader.GetInt64(reader.GetOrdinal("PaymentTypeId"));
				if (!reader.IsDBNull(reader.GetOrdinal("GhiChu"))) entity.GhiChu = reader.GetString(reader.GetOrdinal("GhiChu"));
				if (!reader.IsDBNull(reader.GetOrdinal("NguoiNhan"))) entity.NguoiNhan = reader.GetString(reader.GetOrdinal("NguoiNhan"));
				if (!reader.IsDBNull(reader.GetOrdinal("GiaTri"))) entity.GiaTri = reader.GetDecimal(reader.GetOrdinal("GiaTri"));
				if (!reader.IsDBNull(reader.GetOrdinal("NhaCungCapId"))) entity.NhaCungCapId = reader.GetInt64(reader.GetOrdinal("NhaCungCapId"));
				if (!reader.IsDBNull(reader.GetOrdinal("PhieuNhapKhoId"))) entity.PhieuNhapKhoId = reader.GetInt64(reader.GetOrdinal("PhieuNhapKhoId"));
				if (!reader.IsDBNull(reader.GetOrdinal("MaPhieu"))) entity.MaPhieu = reader.GetString(reader.GetOrdinal("MaPhieu"));
				if (!reader.IsDBNull(reader.GetOrdinal("NhanVienId"))) entity.NhanVienId = reader.GetInt64(reader.GetOrdinal("NhanVienId"));
				collection.Add(entity);
			}
			reader.Close();
			return collection;
		}
		
		public static bool Find(List<Payment> collection, long id)
        {
            foreach (Payment item in collection)
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
            string insert = "Insert INTO t_Payment VALUES(@ThoiGian, @PaymentTypeId, @GhiChu, @NguoiNhan, @GiaTri, @NhaCungCapId, @PhieuNhapKhoId, @MaPhieu, @NhanVienId)";
            string update = "UPDATE t_Payment SET ThoiGian = @ThoiGian, PaymentTypeId = @PaymentTypeId, GhiChu = @GhiChu, NguoiNhan = @NguoiNhan, GiaTri = @GiaTri, NhaCungCapId = @NhaCungCapId, PhieuNhapKhoId = @PhieuNhapKhoId, MaPhieu = @MaPhieu, NhanVienId = @NhanVienId WHERE Id = @Id";
            string delete = "DELETE FROM t_Payment WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@PaymentTypeId", SqlDbType.BigInt, "PaymentTypeId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NguoiNhan", SqlDbType.NVarChar, "NguoiNhan", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GiaTri", SqlDbType.Decimal, "GiaTri", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhaCungCapId", SqlDbType.BigInt, "NhaCungCapId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, "PhieuNhapKhoId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaPhieu", SqlDbType.NVarChar, "MaPhieu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@PaymentTypeId", SqlDbType.BigInt, "PaymentTypeId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NguoiNhan", SqlDbType.NVarChar, "NguoiNhan", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GiaTri", SqlDbType.Decimal, "GiaTri", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhaCungCapId", SqlDbType.BigInt, "NhaCungCapId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, "PhieuNhapKhoId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaPhieu", SqlDbType.NVarChar, "MaPhieu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, ds.Tables[0].TableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }
				
		public static void UpdateDataSet(DataSet ds, string tableName)
        {
            string insert = "Insert INTO t_Payment VALUES(@ThoiGian, @PaymentTypeId, @GhiChu, @NguoiNhan, @GiaTri, @NhaCungCapId, @PhieuNhapKhoId, @MaPhieu, @NhanVienId)";
            string update = "UPDATE t_Payment SET ThoiGian = @ThoiGian, PaymentTypeId = @PaymentTypeId, GhiChu = @GhiChu, NguoiNhan = @NguoiNhan, GiaTri = @GiaTri, NhaCungCapId = @NhaCungCapId, PhieuNhapKhoId = @PhieuNhapKhoId, MaPhieu = @MaPhieu, NhanVienId = @NhanVienId WHERE Id = @Id";
            string delete = "DELETE FROM t_Payment WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@PaymentTypeId", SqlDbType.BigInt, "PaymentTypeId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NguoiNhan", SqlDbType.NVarChar, "NguoiNhan", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GiaTri", SqlDbType.Decimal, "GiaTri", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhaCungCapId", SqlDbType.BigInt, "NhaCungCapId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, "PhieuNhapKhoId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaPhieu", SqlDbType.NVarChar, "MaPhieu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@PaymentTypeId", SqlDbType.BigInt, "PaymentTypeId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NguoiNhan", SqlDbType.NVarChar, "NguoiNhan", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GiaTri", SqlDbType.Decimal, "GiaTri", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhaCungCapId", SqlDbType.BigInt, "NhaCungCapId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, "PhieuNhapKhoId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaPhieu", SqlDbType.NVarChar, "MaPhieu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, tableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }

		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Select methods.
		
		public static Payment Load(long id)
		{
			const string spName = "[dbo].[p_Payment_Load]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, id);
            IDataReader reader = db.ExecuteReader(dbCommand);
			List<Payment> collection = ConvertToCollection(reader);	
			if (collection.Count > 0)
			{
				return collection[0];
			}
			return null;
		}		
		
		//---------------------------------------------------------------------------------------------
		public static List<Payment> SelectCollectionAll()
		{
			IDataReader reader = SelectReaderAll();
			return ConvertToCollection(reader);			
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public static List<Payment> SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			IDataReader reader = SelectReaderDynamic(whereCondition, orderByExpression);
			return ConvertToCollection(reader);		
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		public static List<Payment> SelectCollectionBy_NhaCungCapId(long nhaCungCapId)
		{
            IDataReader reader = SelectReaderBy_NhaCungCapId(nhaCungCapId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<Payment> SelectCollectionBy_NhanVienId(long nhanVienId)
		{
            IDataReader reader = SelectReaderBy_NhanVienId(nhanVienId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<Payment> SelectCollectionBy_PaymentTypeId(long paymentTypeId)
		{
            IDataReader reader = SelectReaderBy_PaymentTypeId(paymentTypeId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<Payment> SelectCollectionBy_PhieuNhapKhoId(long phieuNhapKhoId)
		{
            IDataReader reader = SelectReaderBy_PhieuNhapKhoId(phieuNhapKhoId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectBy_NhaCungCapId(long nhaCungCapId)
		{
			const string spName = "[dbo].[p_Payment_SelectBy_NhaCungCapId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, nhaCungCapId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_Payment_SelectBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_PaymentTypeId(long paymentTypeId)
		{
			const string spName = "[dbo].[p_Payment_SelectBy_PaymentTypeId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@PaymentTypeId", SqlDbType.BigInt, paymentTypeId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_PhieuNhapKhoId(long phieuNhapKhoId)
		{
			const string spName = "[dbo].[p_Payment_SelectBy_PhieuNhapKhoId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, phieuNhapKhoId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------

		public static DataSet SelectAll()
        {
            const string spName = "[dbo].[p_Payment_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			
            return db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_Payment_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
				
		public static IDataReader SelectReaderAll()
        {
            const string spName = "[dbo].[p_Payment_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
            return db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_Payment_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteReader(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		public static IDataReader SelectReaderBy_NhaCungCapId(long nhaCungCapId)
		{
			const string spName = "p_Payment_SelectBy_NhaCungCapId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, nhaCungCapId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_NhanVienId(long nhanVienId)
		{
			const string spName = "p_Payment_SelectBy_NhanVienId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_PaymentTypeId(long paymentTypeId)
		{
			const string spName = "p_Payment_SelectBy_PaymentTypeId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@PaymentTypeId", SqlDbType.BigInt, paymentTypeId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_PhieuNhapKhoId(long phieuNhapKhoId)
		{
			const string spName = "p_Payment_SelectBy_PhieuNhapKhoId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, phieuNhapKhoId);
			
            return db.ExecuteReader(dbCommand);
		}

        public static DataSet SelectReportPaymentTotal(string fromDate, string toDate)
        {
            const string spName = "[dbo].[p_ReportPaymentTotal]";
            SqlDatabase db = (SqlDatabase)DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand)db.GetStoredProcCommand(spName);

            db.AddInParameter(dbCommand, "@FromDate", SqlDbType.NVarChar, fromDate);
            db.AddInParameter(dbCommand, "@ToDate", SqlDbType.NVarChar, toDate);

            return db.ExecuteDataSet(dbCommand);
        }

		//---------------------------------------------------------------------------------------------
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert methods.
		
		public static long InsertPayment(DateTime thoiGian, long paymentTypeId, string ghiChu, string nguoiNhan, decimal giaTri, long nhaCungCapId, long phieuNhapKhoId, string maPhieu, long nhanVienId)
		{
			Payment entity = new Payment();	
			entity.ThoiGian = thoiGian;
			entity.PaymentTypeId = paymentTypeId;
			entity.GhiChu = ghiChu;
			entity.NguoiNhan = nguoiNhan;
			entity.GiaTri = giaTri;
			entity.NhaCungCapId = nhaCungCapId;
			entity.PhieuNhapKhoId = phieuNhapKhoId;
			entity.MaPhieu = maPhieu;
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
			const string spName = "[dbo].[p_Payment_Insert]";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddOutParameter(dbCommand, "@Id", SqlDbType.BigInt, 8);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@PaymentTypeId", SqlDbType.BigInt, PaymentTypeId);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@NguoiNhan", SqlDbType.NVarChar, NguoiNhan);
			db.AddInParameter(dbCommand, "@GiaTri", SqlDbType.Decimal, GiaTri);
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, NhaCungCapId);
			db.AddInParameter(dbCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, PhieuNhapKhoId);
			db.AddInParameter(dbCommand, "@MaPhieu", SqlDbType.NVarChar, MaPhieu);
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
		public static bool InsertCollection(List<Payment> collection)
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
						foreach (Payment item in collection)
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
		
		public static int InsertUpdatePayment(long id, DateTime thoiGian, long paymentTypeId, string ghiChu, string nguoiNhan, decimal giaTri, long nhaCungCapId, long phieuNhapKhoId, string maPhieu, long nhanVienId)
		{
			Payment entity = new Payment();			
			entity.Id = id;
			entity.ThoiGian = thoiGian;
			entity.PaymentTypeId = paymentTypeId;
			entity.GhiChu = ghiChu;
			entity.NguoiNhan = nguoiNhan;
			entity.GiaTri = giaTri;
			entity.NhaCungCapId = nhaCungCapId;
			entity.PhieuNhapKhoId = phieuNhapKhoId;
			entity.MaPhieu = maPhieu;
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
			const string spName = "p_Payment_InsertUpdate";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@PaymentTypeId", SqlDbType.BigInt, PaymentTypeId);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@NguoiNhan", SqlDbType.NVarChar, NguoiNhan);
			db.AddInParameter(dbCommand, "@GiaTri", SqlDbType.Decimal, GiaTri);
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, NhaCungCapId);
			db.AddInParameter(dbCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, PhieuNhapKhoId);
			db.AddInParameter(dbCommand, "@MaPhieu", SqlDbType.NVarChar, MaPhieu);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);			
		}
		
		//---------------------------------------------------------------------------------------------
		public static bool InsertUpdateCollection(List<Payment> collection)
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
						foreach (Payment item in collection)
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
		
		public static int UpdatePayment(long id, DateTime thoiGian, long paymentTypeId, string ghiChu, string nguoiNhan, decimal giaTri, long nhaCungCapId, long phieuNhapKhoId, string maPhieu, long nhanVienId)
		{
			Payment entity = new Payment();			
			entity.Id = id;
			entity.ThoiGian = thoiGian;
			entity.PaymentTypeId = paymentTypeId;
			entity.GhiChu = ghiChu;
			entity.NguoiNhan = nguoiNhan;
			entity.GiaTri = giaTri;
			entity.NhaCungCapId = nhaCungCapId;
			entity.PhieuNhapKhoId = phieuNhapKhoId;
			entity.MaPhieu = maPhieu;
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
			const string spName = "[dbo].[p_Payment_Update]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@PaymentTypeId", SqlDbType.BigInt, PaymentTypeId);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@NguoiNhan", SqlDbType.NVarChar, NguoiNhan);
			db.AddInParameter(dbCommand, "@GiaTri", SqlDbType.Decimal, GiaTri);
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, NhaCungCapId);
			db.AddInParameter(dbCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, PhieuNhapKhoId);
			db.AddInParameter(dbCommand, "@MaPhieu", SqlDbType.NVarChar, MaPhieu);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
				
		//---------------------------------------------------------------------------------------------
		public static bool UpdateCollection(List<Payment> collection)
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
						foreach (Payment item in collection)
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
		
		public static int DeletePayment(long id)
		{
			Payment entity = new Payment();
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
			const string spName = "[dbo].[p_Payment_Delete]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
		
		public static int DeleteBy_NhaCungCapId(long nhaCungCapId)
		{
			const string spName = "[dbo].[p_Payment_DeleteBy_NhaCungCapId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, nhaCungCapId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_Payment_DeleteBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_PaymentTypeId(long paymentTypeId)
		{
			const string spName = "[dbo].[p_Payment_DeleteBy_PaymentTypeId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@PaymentTypeId", SqlDbType.BigInt, paymentTypeId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_PhieuNhapKhoId(long phieuNhapKhoId)
		{
			const string spName = "[dbo].[p_Payment_DeleteBy_PhieuNhapKhoId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, phieuNhapKhoId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		
		public static int DeleteDynamic(string whereCondition)
		{
			const string spName = "[dbo].[p_Payment_DeleteDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            
            return db.ExecuteNonQuery(dbCommand);   
		}
		//---------------------------------------------------------------------------------------------
		
		public static bool DeleteCollection(List<Payment> collection)
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
						foreach (Payment item in collection)
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