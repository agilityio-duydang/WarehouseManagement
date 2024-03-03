using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace Company.WM.BLL
{
	public partial class CongNoNhaCungCap : ICloneable
	{
		#region Properties.
		
		public long Id { set; get; }
		public DateTime ThoiGian { set; get; }
		public long PhieuNhapKhoId { set; get; }
		public long NhaCungCapId { set; get; }
		public long NhanVienId { set; get; }
		public decimal TongTien { set; get; }
		public decimal ChiPhiNhap { set; get; }
		public decimal GiamGia { set; get; }
		public string GhiChu { set; get; }
		public decimal TongDaThanhToan { set; get; }
		public decimal TongConNo { set; get; }
		public int TrangThai { set; get; }
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Methods
		protected static List<CongNoNhaCungCap> ConvertToCollection(IDataReader reader)
		{
			List<CongNoNhaCungCap> collection = new List<CongNoNhaCungCap>();
			while (reader.Read())
			{
				CongNoNhaCungCap entity = new CongNoNhaCungCap();
				if (!reader.IsDBNull(reader.GetOrdinal("Id"))) entity.Id = reader.GetInt64(reader.GetOrdinal("Id"));
				if (!reader.IsDBNull(reader.GetOrdinal("ThoiGian"))) entity.ThoiGian = reader.GetDateTime(reader.GetOrdinal("ThoiGian"));
				if (!reader.IsDBNull(reader.GetOrdinal("PhieuNhapKhoId"))) entity.PhieuNhapKhoId = reader.GetInt64(reader.GetOrdinal("PhieuNhapKhoId"));
				if (!reader.IsDBNull(reader.GetOrdinal("NhaCungCapId"))) entity.NhaCungCapId = reader.GetInt64(reader.GetOrdinal("NhaCungCapId"));
				if (!reader.IsDBNull(reader.GetOrdinal("NhanVienId"))) entity.NhanVienId = reader.GetInt64(reader.GetOrdinal("NhanVienId"));
				if (!reader.IsDBNull(reader.GetOrdinal("TongTien"))) entity.TongTien = reader.GetDecimal(reader.GetOrdinal("TongTien"));
				if (!reader.IsDBNull(reader.GetOrdinal("ChiPhiNhap"))) entity.ChiPhiNhap = reader.GetDecimal(reader.GetOrdinal("ChiPhiNhap"));
				if (!reader.IsDBNull(reader.GetOrdinal("GiamGia"))) entity.GiamGia = reader.GetDecimal(reader.GetOrdinal("GiamGia"));
				if (!reader.IsDBNull(reader.GetOrdinal("GhiChu"))) entity.GhiChu = reader.GetString(reader.GetOrdinal("GhiChu"));
				if (!reader.IsDBNull(reader.GetOrdinal("TongDaThanhToan"))) entity.TongDaThanhToan = reader.GetDecimal(reader.GetOrdinal("TongDaThanhToan"));
				if (!reader.IsDBNull(reader.GetOrdinal("TongConNo"))) entity.TongConNo = reader.GetDecimal(reader.GetOrdinal("TongConNo"));
				if (!reader.IsDBNull(reader.GetOrdinal("TrangThai"))) entity.TrangThai = reader.GetInt32(reader.GetOrdinal("TrangThai"));
				collection.Add(entity);
			}
			reader.Close();
			return collection;
		}
		
		public static bool Find(List<CongNoNhaCungCap> collection, long id)
        {
            foreach (CongNoNhaCungCap item in collection)
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
            string insert = "Insert INTO t_CongNoNhaCungCap VALUES(@ThoiGian, @PhieuNhapKhoId, @NhaCungCapId, @NhanVienId, @TongTien, @ChiPhiNhap, @GiamGia, @GhiChu, @TongDaThanhToan, @TongConNo, @TrangThai)";
            string update = "UPDATE t_CongNoNhaCungCap SET ThoiGian = @ThoiGian, PhieuNhapKhoId = @PhieuNhapKhoId, NhaCungCapId = @NhaCungCapId, NhanVienId = @NhanVienId, TongTien = @TongTien, ChiPhiNhap = @ChiPhiNhap, GiamGia = @GiamGia, GhiChu = @GhiChu, TongDaThanhToan = @TongDaThanhToan, TongConNo = @TongConNo, TrangThai = @TrangThai WHERE Id = @Id";
            string delete = "DELETE FROM t_CongNoNhaCungCap WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, "PhieuNhapKhoId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhaCungCapId", SqlDbType.BigInt, "NhaCungCapId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ChiPhiNhap", SqlDbType.Decimal, "ChiPhiNhap", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GiamGia", SqlDbType.Decimal, "GiamGia", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongDaThanhToan", SqlDbType.Decimal, "TongDaThanhToan", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongConNo", SqlDbType.Decimal, "TongConNo", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TrangThai", SqlDbType.Int, "TrangThai", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, "PhieuNhapKhoId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhaCungCapId", SqlDbType.BigInt, "NhaCungCapId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ChiPhiNhap", SqlDbType.Decimal, "ChiPhiNhap", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GiamGia", SqlDbType.Decimal, "GiamGia", DataRowVersion.Current);
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
            string insert = "Insert INTO t_CongNoNhaCungCap VALUES(@ThoiGian, @PhieuNhapKhoId, @NhaCungCapId, @NhanVienId, @TongTien, @ChiPhiNhap, @GiamGia, @GhiChu, @TongDaThanhToan, @TongConNo, @TrangThai)";
            string update = "UPDATE t_CongNoNhaCungCap SET ThoiGian = @ThoiGian, PhieuNhapKhoId = @PhieuNhapKhoId, NhaCungCapId = @NhaCungCapId, NhanVienId = @NhanVienId, TongTien = @TongTien, ChiPhiNhap = @ChiPhiNhap, GiamGia = @GiamGia, GhiChu = @GhiChu, TongDaThanhToan = @TongDaThanhToan, TongConNo = @TongConNo, TrangThai = @TrangThai WHERE Id = @Id";
            string delete = "DELETE FROM t_CongNoNhaCungCap WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, "PhieuNhapKhoId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhaCungCapId", SqlDbType.BigInt, "NhaCungCapId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ChiPhiNhap", SqlDbType.Decimal, "ChiPhiNhap", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GiamGia", SqlDbType.Decimal, "GiamGia", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongDaThanhToan", SqlDbType.Decimal, "TongDaThanhToan", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongConNo", SqlDbType.Decimal, "TongConNo", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TrangThai", SqlDbType.Int, "TrangThai", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, "PhieuNhapKhoId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhaCungCapId", SqlDbType.BigInt, "NhaCungCapId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ChiPhiNhap", SqlDbType.Decimal, "ChiPhiNhap", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GiamGia", SqlDbType.Decimal, "GiamGia", DataRowVersion.Current);
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
		
		public static CongNoNhaCungCap Load(long id)
		{
			const string spName = "[dbo].[p_CongNoNhaCungCap_Load]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, id);
            IDataReader reader = db.ExecuteReader(dbCommand);
			List<CongNoNhaCungCap> collection = ConvertToCollection(reader);	
			if (collection.Count > 0)
			{
				return collection[0];
			}
			return null;
		}		
		
		//---------------------------------------------------------------------------------------------
		public static List<CongNoNhaCungCap> SelectCollectionAll()
		{
			IDataReader reader = SelectReaderAll();
			return ConvertToCollection(reader);			
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public static List<CongNoNhaCungCap> SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			IDataReader reader = SelectReaderDynamic(whereCondition, orderByExpression);
			return ConvertToCollection(reader);		
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		public static List<CongNoNhaCungCap> SelectCollectionBy_NhaCungCapId(long nhaCungCapId)
		{
            IDataReader reader = SelectReaderBy_NhaCungCapId(nhaCungCapId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<CongNoNhaCungCap> SelectCollectionBy_NhanVienId(long nhanVienId)
		{
            IDataReader reader = SelectReaderBy_NhanVienId(nhanVienId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<CongNoNhaCungCap> SelectCollectionBy_PhieuNhapKhoId(long phieuNhapKhoId)
		{
            IDataReader reader = SelectReaderBy_PhieuNhapKhoId(phieuNhapKhoId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectBy_NhaCungCapId(long nhaCungCapId)
		{
			const string spName = "[dbo].[p_CongNoNhaCungCap_SelectBy_NhaCungCapId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, nhaCungCapId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_CongNoNhaCungCap_SelectBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_PhieuNhapKhoId(long phieuNhapKhoId)
		{
			const string spName = "[dbo].[p_CongNoNhaCungCap_SelectBy_PhieuNhapKhoId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, phieuNhapKhoId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------

		public static DataSet SelectAll()
        {
            const string spName = "[dbo].[p_CongNoNhaCungCap_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			
            return db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_CongNoNhaCungCap_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
				
		public static IDataReader SelectReaderAll()
        {
            const string spName = "[dbo].[p_CongNoNhaCungCap_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
            return db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_CongNoNhaCungCap_SelectDynamic]";
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
			const string spName = "p_CongNoNhaCungCap_SelectBy_NhaCungCapId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, nhaCungCapId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_NhanVienId(long nhanVienId)
		{
			const string spName = "p_CongNoNhaCungCap_SelectBy_NhanVienId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_PhieuNhapKhoId(long phieuNhapKhoId)
		{
			const string spName = "p_CongNoNhaCungCap_SelectBy_PhieuNhapKhoId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, phieuNhapKhoId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert methods.
		
		public static long InsertCongNoNhaCungCap(DateTime thoiGian, long phieuNhapKhoId, long nhaCungCapId, long nhanVienId, decimal tongTien, decimal chiPhiNhap, decimal giamGia, string ghiChu, decimal tongDaThanhToan, decimal tongConNo, int trangThai)
		{
			CongNoNhaCungCap entity = new CongNoNhaCungCap();	
			entity.ThoiGian = thoiGian;
			entity.PhieuNhapKhoId = phieuNhapKhoId;
			entity.NhaCungCapId = nhaCungCapId;
			entity.NhanVienId = nhanVienId;
			entity.TongTien = tongTien;
			entity.ChiPhiNhap = chiPhiNhap;
			entity.GiamGia = giamGia;
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
			const string spName = "[dbo].[p_CongNoNhaCungCap_Insert]";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddOutParameter(dbCommand, "@Id", SqlDbType.BigInt, 8);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, PhieuNhapKhoId);
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, NhaCungCapId);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@TongTien", SqlDbType.Decimal, TongTien);
			db.AddInParameter(dbCommand, "@ChiPhiNhap", SqlDbType.Decimal, ChiPhiNhap);
			db.AddInParameter(dbCommand, "@GiamGia", SqlDbType.Decimal, GiamGia);
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
		public static bool InsertCollection(List<CongNoNhaCungCap> collection)
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
						foreach (CongNoNhaCungCap item in collection)
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
		
		public static int InsertUpdateCongNoNhaCungCap(long id, DateTime thoiGian, long phieuNhapKhoId, long nhaCungCapId, long nhanVienId, decimal tongTien, decimal chiPhiNhap, decimal giamGia, string ghiChu, decimal tongDaThanhToan, decimal tongConNo, int trangThai)
		{
			CongNoNhaCungCap entity = new CongNoNhaCungCap();			
			entity.Id = id;
			entity.ThoiGian = thoiGian;
			entity.PhieuNhapKhoId = phieuNhapKhoId;
			entity.NhaCungCapId = nhaCungCapId;
			entity.NhanVienId = nhanVienId;
			entity.TongTien = tongTien;
			entity.ChiPhiNhap = chiPhiNhap;
			entity.GiamGia = giamGia;
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
			const string spName = "p_CongNoNhaCungCap_InsertUpdate";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, PhieuNhapKhoId);
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, NhaCungCapId);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@TongTien", SqlDbType.Decimal, TongTien);
			db.AddInParameter(dbCommand, "@ChiPhiNhap", SqlDbType.Decimal, ChiPhiNhap);
			db.AddInParameter(dbCommand, "@GiamGia", SqlDbType.Decimal, GiamGia);
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
		public static bool InsertUpdateCollection(List<CongNoNhaCungCap> collection)
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
						foreach (CongNoNhaCungCap item in collection)
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
		
		public static int UpdateCongNoNhaCungCap(long id, DateTime thoiGian, long phieuNhapKhoId, long nhaCungCapId, long nhanVienId, decimal tongTien, decimal chiPhiNhap, decimal giamGia, string ghiChu, decimal tongDaThanhToan, decimal tongConNo, int trangThai)
		{
			CongNoNhaCungCap entity = new CongNoNhaCungCap();			
			entity.Id = id;
			entity.ThoiGian = thoiGian;
			entity.PhieuNhapKhoId = phieuNhapKhoId;
			entity.NhaCungCapId = nhaCungCapId;
			entity.NhanVienId = nhanVienId;
			entity.TongTien = tongTien;
			entity.ChiPhiNhap = chiPhiNhap;
			entity.GiamGia = giamGia;
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
			const string spName = "[dbo].[p_CongNoNhaCungCap_Update]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, PhieuNhapKhoId);
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, NhaCungCapId);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@TongTien", SqlDbType.Decimal, TongTien);
			db.AddInParameter(dbCommand, "@ChiPhiNhap", SqlDbType.Decimal, ChiPhiNhap);
			db.AddInParameter(dbCommand, "@GiamGia", SqlDbType.Decimal, GiamGia);
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
		public static bool UpdateCollection(List<CongNoNhaCungCap> collection)
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
						foreach (CongNoNhaCungCap item in collection)
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
		
		public static int DeleteCongNoNhaCungCap(long id)
		{
			CongNoNhaCungCap entity = new CongNoNhaCungCap();
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
			const string spName = "[dbo].[p_CongNoNhaCungCap_Delete]";		
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
			const string spName = "[dbo].[p_CongNoNhaCungCap_DeleteBy_NhaCungCapId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, nhaCungCapId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_CongNoNhaCungCap_DeleteBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_PhieuNhapKhoId(long phieuNhapKhoId)
		{
			const string spName = "[dbo].[p_CongNoNhaCungCap_DeleteBy_PhieuNhapKhoId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@PhieuNhapKhoId", SqlDbType.BigInt, phieuNhapKhoId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		
		public static int DeleteDynamic(string whereCondition)
		{
			const string spName = "[dbo].[p_CongNoNhaCungCap_DeleteDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            
            return db.ExecuteNonQuery(dbCommand);   
		}
		//---------------------------------------------------------------------------------------------
		
		public static bool DeleteCollection(List<CongNoNhaCungCap> collection)
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
						foreach (CongNoNhaCungCap item in collection)
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