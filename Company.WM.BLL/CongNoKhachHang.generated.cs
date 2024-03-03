using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace Company.WM.BLL
{
	public partial class CongNoKhachHang : ICloneable
	{
		#region Properties.
		
		public long Id { set; get; }
		public DateTime ThoiGian { set; get; }
		public long HoaDonId { set; get; }
		public long KhachHangId { set; get; }
		public long NhanVienId { set; get; }
		public decimal TongTien { set; get; }
		public int ThueSuat { set; get; }
		public string GhiChu { set; get; }
		public decimal TongDaThanhToan { set; get; }
		public decimal TongConNo { set; get; }
		public int TrangThai { set; get; }
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Methods
		protected static List<CongNoKhachHang> ConvertToCollection(IDataReader reader)
		{
			List<CongNoKhachHang> collection = new List<CongNoKhachHang>();
			while (reader.Read())
			{
				CongNoKhachHang entity = new CongNoKhachHang();
				if (!reader.IsDBNull(reader.GetOrdinal("Id"))) entity.Id = reader.GetInt64(reader.GetOrdinal("Id"));
				if (!reader.IsDBNull(reader.GetOrdinal("ThoiGian"))) entity.ThoiGian = reader.GetDateTime(reader.GetOrdinal("ThoiGian"));
				if (!reader.IsDBNull(reader.GetOrdinal("HoaDonId"))) entity.HoaDonId = reader.GetInt64(reader.GetOrdinal("HoaDonId"));
				if (!reader.IsDBNull(reader.GetOrdinal("KhachHangId"))) entity.KhachHangId = reader.GetInt64(reader.GetOrdinal("KhachHangId"));
				if (!reader.IsDBNull(reader.GetOrdinal("NhanVienId"))) entity.NhanVienId = reader.GetInt64(reader.GetOrdinal("NhanVienId"));
				if (!reader.IsDBNull(reader.GetOrdinal("TongTien"))) entity.TongTien = reader.GetDecimal(reader.GetOrdinal("TongTien"));
				if (!reader.IsDBNull(reader.GetOrdinal("ThueSuat"))) entity.ThueSuat = reader.GetInt32(reader.GetOrdinal("ThueSuat"));
				if (!reader.IsDBNull(reader.GetOrdinal("GhiChu"))) entity.GhiChu = reader.GetString(reader.GetOrdinal("GhiChu"));
				if (!reader.IsDBNull(reader.GetOrdinal("TongDaThanhToan"))) entity.TongDaThanhToan = reader.GetDecimal(reader.GetOrdinal("TongDaThanhToan"));
				if (!reader.IsDBNull(reader.GetOrdinal("TongConNo"))) entity.TongConNo = reader.GetDecimal(reader.GetOrdinal("TongConNo"));
				if (!reader.IsDBNull(reader.GetOrdinal("TrangThai"))) entity.TrangThai = reader.GetInt32(reader.GetOrdinal("TrangThai"));
				collection.Add(entity);
			}
			reader.Close();
			return collection;
		}
		
		public static bool Find(List<CongNoKhachHang> collection, long id)
        {
            foreach (CongNoKhachHang item in collection)
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
            string insert = "Insert INTO t_CongNoKhachHang VALUES(@ThoiGian, @HoaDonId, @KhachHangId, @NhanVienId, @TongTien, @ThueSuat, @GhiChu, @TongDaThanhToan, @TongConNo, @TrangThai)";
            string update = "UPDATE t_CongNoKhachHang SET ThoiGian = @ThoiGian, HoaDonId = @HoaDonId, KhachHangId = @KhachHangId, NhanVienId = @NhanVienId, TongTien = @TongTien, ThueSuat = @ThueSuat, GhiChu = @GhiChu, TongDaThanhToan = @TongDaThanhToan, TongConNo = @TongConNo, TrangThai = @TrangThai WHERE Id = @Id";
            string delete = "DELETE FROM t_CongNoKhachHang WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@HoaDonId", SqlDbType.BigInt, "HoaDonId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThueSuat", SqlDbType.Int, "ThueSuat", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongDaThanhToan", SqlDbType.Decimal, "TongDaThanhToan", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongConNo", SqlDbType.Decimal, "TongConNo", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TrangThai", SqlDbType.Int, "TrangThai", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@HoaDonId", SqlDbType.BigInt, "HoaDonId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThueSuat", SqlDbType.Int, "ThueSuat", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongDaThanhToan", SqlDbType.Decimal, "TongDaThanhToan", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongConNo", SqlDbType.Decimal, "TongConNo", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TrangThai", SqlDbType.Int, "TrangThai", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, ds.Tables[0].TableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }
				
		public static void UpdateDataSet(DataSet ds, string tableName)
        {
            string insert = "Insert INTO t_CongNoKhachHang VALUES(@ThoiGian, @HoaDonId, @KhachHangId, @NhanVienId, @TongTien, @ThueSuat, @GhiChu, @TongDaThanhToan, @TongConNo, @TrangThai)";
            string update = "UPDATE t_CongNoKhachHang SET ThoiGian = @ThoiGian, HoaDonId = @HoaDonId, KhachHangId = @KhachHangId, NhanVienId = @NhanVienId, TongTien = @TongTien, ThueSuat = @ThueSuat, GhiChu = @GhiChu, TongDaThanhToan = @TongDaThanhToan, TongConNo = @TongConNo, TrangThai = @TrangThai WHERE Id = @Id";
            string delete = "DELETE FROM t_CongNoKhachHang WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@HoaDonId", SqlDbType.BigInt, "HoaDonId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThueSuat", SqlDbType.Int, "ThueSuat", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongDaThanhToan", SqlDbType.Decimal, "TongDaThanhToan", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongConNo", SqlDbType.Decimal, "TongConNo", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TrangThai", SqlDbType.Int, "TrangThai", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@HoaDonId", SqlDbType.BigInt, "HoaDonId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThueSuat", SqlDbType.Int, "ThueSuat", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongDaThanhToan", SqlDbType.Decimal, "TongDaThanhToan", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongConNo", SqlDbType.Decimal, "TongConNo", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TrangThai", SqlDbType.Int, "TrangThai", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, tableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }

		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Select methods.
		
		public static CongNoKhachHang Load(long id)
		{
			const string spName = "[dbo].[p_CongNoKhachHang_Load]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, id);
            IDataReader reader = db.ExecuteReader(dbCommand);
			List<CongNoKhachHang> collection = ConvertToCollection(reader);	
			if (collection.Count > 0)
			{
				return collection[0];
			}
			return null;
		}		
		
		//---------------------------------------------------------------------------------------------
		public static List<CongNoKhachHang> SelectCollectionAll()
		{
			IDataReader reader = SelectReaderAll();
			return ConvertToCollection(reader);			
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public static List<CongNoKhachHang> SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			IDataReader reader = SelectReaderDynamic(whereCondition, orderByExpression);
			return ConvertToCollection(reader);		
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		public static List<CongNoKhachHang> SelectCollectionBy_HoaDonId(long hoaDonId)
		{
            IDataReader reader = SelectReaderBy_HoaDonId(hoaDonId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<CongNoKhachHang> SelectCollectionBy_KhachHangId(long khachHangId)
		{
            IDataReader reader = SelectReaderBy_KhachHangId(khachHangId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<CongNoKhachHang> SelectCollectionBy_NhanVienId(long nhanVienId)
		{
            IDataReader reader = SelectReaderBy_NhanVienId(nhanVienId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectBy_HoaDonId(long hoaDonId)
		{
			const string spName = "[dbo].[p_CongNoKhachHang_SelectBy_HoaDonId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, hoaDonId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_KhachHangId(long khachHangId)
		{
			const string spName = "[dbo].[p_CongNoKhachHang_SelectBy_KhachHangId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, khachHangId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_CongNoKhachHang_SelectBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------

		public static DataSet SelectAll()
        {
            const string spName = "[dbo].[p_CongNoKhachHang_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			
            return db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_CongNoKhachHang_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
				
		public static IDataReader SelectReaderAll()
        {
            const string spName = "[dbo].[p_CongNoKhachHang_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
            return db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_CongNoKhachHang_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteReader(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		public static IDataReader SelectReaderBy_HoaDonId(long hoaDonId)
		{
			const string spName = "p_CongNoKhachHang_SelectBy_HoaDonId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, hoaDonId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_KhachHangId(long khachHangId)
		{
			const string spName = "p_CongNoKhachHang_SelectBy_KhachHangId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, khachHangId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_NhanVienId(long nhanVienId)
		{
			const string spName = "p_CongNoKhachHang_SelectBy_NhanVienId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert methods.
		
		public static long InsertCongNoKhachHang(DateTime thoiGian, long hoaDonId, long khachHangId, long nhanVienId, decimal tongTien, int thueSuat, string ghiChu, decimal tongDaThanhToan, decimal tongConNo, int trangThai)
		{
			CongNoKhachHang entity = new CongNoKhachHang();	
			entity.ThoiGian = thoiGian;
			entity.HoaDonId = hoaDonId;
			entity.KhachHangId = khachHangId;
			entity.NhanVienId = nhanVienId;
			entity.TongTien = tongTien;
			entity.ThueSuat = thueSuat;
			entity.GhiChu = ghiChu;
			entity.TongDaThanhToan = tongDaThanhToan;
			entity.TongConNo = tongConNo;
			entity.TrangThai = trangThai;
			return entity.Insert();
		}
		
		public long Insert()
		{
			return this.Insert(null);
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public long Insert(SqlTransaction transaction)
		{			
			const string spName = "[dbo].[p_CongNoKhachHang_Insert]";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddOutParameter(dbCommand, "@Id", SqlDbType.BigInt, 8);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, HoaDonId);
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, KhachHangId);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@TongTien", SqlDbType.Decimal, TongTien);
			db.AddInParameter(dbCommand, "@ThueSuat", SqlDbType.Int, ThueSuat);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@TongDaThanhToan", SqlDbType.Decimal, TongDaThanhToan);
			db.AddInParameter(dbCommand, "@TongConNo", SqlDbType.Decimal, TongConNo);
			db.AddInParameter(dbCommand, "@TrangThai", SqlDbType.Int, TrangThai);
			
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
		public static bool InsertCollection(List<CongNoKhachHang> collection)
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
						foreach (CongNoKhachHang item in collection)
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
		
		public static int InsertUpdateCongNoKhachHang(long id, DateTime thoiGian, long hoaDonId, long khachHangId, long nhanVienId, decimal tongTien, int thueSuat, string ghiChu, decimal tongDaThanhToan, decimal tongConNo, int trangThai)
		{
			CongNoKhachHang entity = new CongNoKhachHang();			
			entity.Id = id;
			entity.ThoiGian = thoiGian;
			entity.HoaDonId = hoaDonId;
			entity.KhachHangId = khachHangId;
			entity.NhanVienId = nhanVienId;
			entity.TongTien = tongTien;
			entity.ThueSuat = thueSuat;
			entity.GhiChu = ghiChu;
			entity.TongDaThanhToan = tongDaThanhToan;
			entity.TongConNo = tongConNo;
			entity.TrangThai = trangThai;
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
			const string spName = "p_CongNoKhachHang_InsertUpdate";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, HoaDonId);
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, KhachHangId);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@TongTien", SqlDbType.Decimal, TongTien);
			db.AddInParameter(dbCommand, "@ThueSuat", SqlDbType.Int, ThueSuat);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@TongDaThanhToan", SqlDbType.Decimal, TongDaThanhToan);
			db.AddInParameter(dbCommand, "@TongConNo", SqlDbType.Decimal, TongConNo);
			db.AddInParameter(dbCommand, "@TrangThai", SqlDbType.Int, TrangThai);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);			
		}
		
		//---------------------------------------------------------------------------------------------
		public static bool InsertUpdateCollection(List<CongNoKhachHang> collection)
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
						foreach (CongNoKhachHang item in collection)
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
		
		public static int UpdateCongNoKhachHang(long id, DateTime thoiGian, long hoaDonId, long khachHangId, long nhanVienId, decimal tongTien, int thueSuat, string ghiChu, decimal tongDaThanhToan, decimal tongConNo, int trangThai)
		{
			CongNoKhachHang entity = new CongNoKhachHang();			
			entity.Id = id;
			entity.ThoiGian = thoiGian;
			entity.HoaDonId = hoaDonId;
			entity.KhachHangId = khachHangId;
			entity.NhanVienId = nhanVienId;
			entity.TongTien = tongTien;
			entity.ThueSuat = thueSuat;
			entity.GhiChu = ghiChu;
			entity.TongDaThanhToan = tongDaThanhToan;
			entity.TongConNo = tongConNo;
			entity.TrangThai = trangThai;
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
			const string spName = "[dbo].[p_CongNoKhachHang_Update]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, HoaDonId);
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, KhachHangId);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@TongTien", SqlDbType.Decimal, TongTien);
			db.AddInParameter(dbCommand, "@ThueSuat", SqlDbType.Int, ThueSuat);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@TongDaThanhToan", SqlDbType.Decimal, TongDaThanhToan);
			db.AddInParameter(dbCommand, "@TongConNo", SqlDbType.Decimal, TongConNo);
			db.AddInParameter(dbCommand, "@TrangThai", SqlDbType.Int, TrangThai);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
				
		//---------------------------------------------------------------------------------------------
		public static bool UpdateCollection(List<CongNoKhachHang> collection)
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
						foreach (CongNoKhachHang item in collection)
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
		
		public static int DeleteCongNoKhachHang(long id)
		{
			CongNoKhachHang entity = new CongNoKhachHang();
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
			const string spName = "[dbo].[p_CongNoKhachHang_Delete]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
		
		public static int DeleteBy_HoaDonId(long hoaDonId)
		{
			const string spName = "[dbo].[p_CongNoKhachHang_DeleteBy_HoaDonId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, hoaDonId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_KhachHangId(long khachHangId)
		{
			const string spName = "[dbo].[p_CongNoKhachHang_DeleteBy_KhachHangId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, khachHangId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_CongNoKhachHang_DeleteBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		
		public static int DeleteDynamic(string whereCondition)
		{
			const string spName = "[dbo].[p_CongNoKhachHang_DeleteDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            
            return db.ExecuteNonQuery(dbCommand);   
		}
		//---------------------------------------------------------------------------------------------
		
		public static bool DeleteCollection(List<CongNoKhachHang> collection)
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
						foreach (CongNoKhachHang item in collection)
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