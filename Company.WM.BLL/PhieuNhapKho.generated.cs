using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace Company.WM.BLL
{
	public partial class PhieuNhapKho : ICloneable
	{
		#region Properties.
		
		public long Id { set; get; }
		public long NhanVienId { set; get; }
		public string MaKho { set; get; }
		public string TenKho { set; get; }
		public DateTime ThoiGian { set; get; }
		public long NhaCungCapId { set; get; }
		public decimal TongTien { set; get; }
		public decimal ChiPhiNhap { set; get; }
		public decimal GiamGia { set; get; }
		public string GhiChu { set; get; }
		public decimal TongDaThanhToan { set; get; }
		public decimal TongConNo { set; get; }
		public string MaPhieu { set; get; }
        public List<PhieuNhapKho_HangHoa> HangHoaCollection = new List<PhieuNhapKho_HangHoa>();
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Methods
		protected static List<PhieuNhapKho> ConvertToCollection(IDataReader reader)
		{
			List<PhieuNhapKho> collection = new List<PhieuNhapKho>();
			while (reader.Read())
			{
				PhieuNhapKho entity = new PhieuNhapKho();
				if (!reader.IsDBNull(reader.GetOrdinal("Id"))) entity.Id = reader.GetInt64(reader.GetOrdinal("Id"));
				if (!reader.IsDBNull(reader.GetOrdinal("NhanVienId"))) entity.NhanVienId = reader.GetInt64(reader.GetOrdinal("NhanVienId"));
				if (!reader.IsDBNull(reader.GetOrdinal("MaKho"))) entity.MaKho = reader.GetString(reader.GetOrdinal("MaKho"));
				if (!reader.IsDBNull(reader.GetOrdinal("TenKho"))) entity.TenKho = reader.GetString(reader.GetOrdinal("TenKho"));
				if (!reader.IsDBNull(reader.GetOrdinal("ThoiGian"))) entity.ThoiGian = reader.GetDateTime(reader.GetOrdinal("ThoiGian"));
				if (!reader.IsDBNull(reader.GetOrdinal("NhaCungCapId"))) entity.NhaCungCapId = reader.GetInt64(reader.GetOrdinal("NhaCungCapId"));
				if (!reader.IsDBNull(reader.GetOrdinal("TongTien"))) entity.TongTien = reader.GetDecimal(reader.GetOrdinal("TongTien"));
				if (!reader.IsDBNull(reader.GetOrdinal("ChiPhiNhap"))) entity.ChiPhiNhap = reader.GetDecimal(reader.GetOrdinal("ChiPhiNhap"));
				if (!reader.IsDBNull(reader.GetOrdinal("GiamGia"))) entity.GiamGia = reader.GetDecimal(reader.GetOrdinal("GiamGia"));
				if (!reader.IsDBNull(reader.GetOrdinal("GhiChu"))) entity.GhiChu = reader.GetString(reader.GetOrdinal("GhiChu"));
				if (!reader.IsDBNull(reader.GetOrdinal("TongDaThanhToan"))) entity.TongDaThanhToan = reader.GetDecimal(reader.GetOrdinal("TongDaThanhToan"));
				if (!reader.IsDBNull(reader.GetOrdinal("TongConNo"))) entity.TongConNo = reader.GetDecimal(reader.GetOrdinal("TongConNo"));
				if (!reader.IsDBNull(reader.GetOrdinal("MaPhieu"))) entity.MaPhieu = reader.GetString(reader.GetOrdinal("MaPhieu"));
				collection.Add(entity);
			}
			reader.Close();
			return collection;
		}
		
		public static bool Find(List<PhieuNhapKho> collection, long id)
        {
            foreach (PhieuNhapKho item in collection)
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
            string insert = "Insert INTO t_PhieuNhapKho VALUES(@NhanVienId, @MaKho, @TenKho, @ThoiGian, @NhaCungCapId, @TongTien, @ChiPhiNhap, @GiamGia, @GhiChu, @TongDaThanhToan, @TongConNo, @MaPhieu)";
            string update = "UPDATE t_PhieuNhapKho SET NhanVienId = @NhanVienId, MaKho = @MaKho, TenKho = @TenKho, ThoiGian = @ThoiGian, NhaCungCapId = @NhaCungCapId, TongTien = @TongTien, ChiPhiNhap = @ChiPhiNhap, GiamGia = @GiamGia, GhiChu = @GhiChu, TongDaThanhToan = @TongDaThanhToan, TongConNo = @TongConNo, MaPhieu = @MaPhieu WHERE Id = @Id";
            string delete = "DELETE FROM t_PhieuNhapKho WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaKho", SqlDbType.NVarChar, "MaKho", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TenKho", SqlDbType.NVarChar, "TenKho", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhaCungCapId", SqlDbType.BigInt, "NhaCungCapId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ChiPhiNhap", SqlDbType.Decimal, "ChiPhiNhap", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GiamGia", SqlDbType.Decimal, "GiamGia", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongDaThanhToan", SqlDbType.Decimal, "TongDaThanhToan", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongConNo", SqlDbType.Decimal, "TongConNo", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaPhieu", SqlDbType.NVarChar, "MaPhieu", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaKho", SqlDbType.NVarChar, "MaKho", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TenKho", SqlDbType.NVarChar, "TenKho", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhaCungCapId", SqlDbType.BigInt, "NhaCungCapId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ChiPhiNhap", SqlDbType.Decimal, "ChiPhiNhap", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GiamGia", SqlDbType.Decimal, "GiamGia", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongDaThanhToan", SqlDbType.Decimal, "TongDaThanhToan", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongConNo", SqlDbType.Decimal, "TongConNo", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaPhieu", SqlDbType.NVarChar, "MaPhieu", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, ds.Tables[0].TableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }
				
		public static void UpdateDataSet(DataSet ds, string tableName)
        {
            string insert = "Insert INTO t_PhieuNhapKho VALUES(@NhanVienId, @MaKho, @TenKho, @ThoiGian, @NhaCungCapId, @TongTien, @ChiPhiNhap, @GiamGia, @GhiChu, @TongDaThanhToan, @TongConNo, @MaPhieu)";
            string update = "UPDATE t_PhieuNhapKho SET NhanVienId = @NhanVienId, MaKho = @MaKho, TenKho = @TenKho, ThoiGian = @ThoiGian, NhaCungCapId = @NhaCungCapId, TongTien = @TongTien, ChiPhiNhap = @ChiPhiNhap, GiamGia = @GiamGia, GhiChu = @GhiChu, TongDaThanhToan = @TongDaThanhToan, TongConNo = @TongConNo, MaPhieu = @MaPhieu WHERE Id = @Id";
            string delete = "DELETE FROM t_PhieuNhapKho WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaKho", SqlDbType.NVarChar, "MaKho", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TenKho", SqlDbType.NVarChar, "TenKho", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhaCungCapId", SqlDbType.BigInt, "NhaCungCapId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ChiPhiNhap", SqlDbType.Decimal, "ChiPhiNhap", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GiamGia", SqlDbType.Decimal, "GiamGia", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongDaThanhToan", SqlDbType.Decimal, "TongDaThanhToan", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongConNo", SqlDbType.Decimal, "TongConNo", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaPhieu", SqlDbType.NVarChar, "MaPhieu", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaKho", SqlDbType.NVarChar, "MaKho", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TenKho", SqlDbType.NVarChar, "TenKho", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhaCungCapId", SqlDbType.BigInt, "NhaCungCapId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ChiPhiNhap", SqlDbType.Decimal, "ChiPhiNhap", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GiamGia", SqlDbType.Decimal, "GiamGia", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongDaThanhToan", SqlDbType.Decimal, "TongDaThanhToan", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongConNo", SqlDbType.Decimal, "TongConNo", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaPhieu", SqlDbType.NVarChar, "MaPhieu", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, tableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }

		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Select methods.
		
		public static PhieuNhapKho Load(long id)
		{
			const string spName = "[dbo].[p_PhieuNhapKho_Load]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, id);
            IDataReader reader = db.ExecuteReader(dbCommand);
			List<PhieuNhapKho> collection = ConvertToCollection(reader);	
			if (collection.Count > 0)
			{
				return collection[0];
			}
			return null;
		}		
		
		//---------------------------------------------------------------------------------------------
		public static List<PhieuNhapKho> SelectCollectionAll()
		{
			IDataReader reader = SelectReaderAll();
			return ConvertToCollection(reader);			
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public static List<PhieuNhapKho> SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			IDataReader reader = SelectReaderDynamic(whereCondition, orderByExpression);
			return ConvertToCollection(reader);		
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		public static List<PhieuNhapKho> SelectCollectionBy_NhaCungCapId(long nhaCungCapId)
		{
            IDataReader reader = SelectReaderBy_NhaCungCapId(nhaCungCapId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<PhieuNhapKho> SelectCollectionBy_NhanVienId(long nhanVienId)
		{
            IDataReader reader = SelectReaderBy_NhanVienId(nhanVienId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectBy_NhaCungCapId(long nhaCungCapId)
		{
			const string spName = "[dbo].[p_PhieuNhapKho_SelectBy_NhaCungCapId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, nhaCungCapId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_PhieuNhapKho_SelectBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------

		public static DataSet SelectAll()
        {
            const string spName = "[dbo].[p_PhieuNhapKho_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			
            return db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_PhieuNhapKho_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
				
		public static IDataReader SelectReaderAll()
        {
            const string spName = "[dbo].[p_PhieuNhapKho_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
            return db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_PhieuNhapKho_SelectDynamic]";
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
			const string spName = "p_PhieuNhapKho_SelectBy_NhaCungCapId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, nhaCungCapId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_NhanVienId(long nhanVienId)
		{
			const string spName = "p_PhieuNhapKho_SelectBy_NhanVienId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert methods.
		
		public static long InsertPhieuNhapKho(long nhanVienId, string maKho, string tenKho, DateTime thoiGian, long nhaCungCapId, decimal tongTien, decimal chiPhiNhap, decimal giamGia, string ghiChu, decimal tongDaThanhToan, decimal tongConNo, string maPhieu)
		{
			PhieuNhapKho entity = new PhieuNhapKho();	
			entity.NhanVienId = nhanVienId;
			entity.MaKho = maKho;
			entity.TenKho = tenKho;
			entity.ThoiGian = thoiGian;
			entity.NhaCungCapId = nhaCungCapId;
			entity.TongTien = tongTien;
			entity.ChiPhiNhap = chiPhiNhap;
			entity.GiamGia = giamGia;
			entity.GhiChu = ghiChu;
			entity.TongDaThanhToan = tongDaThanhToan;
			entity.TongConNo = tongConNo;
			entity.MaPhieu = maPhieu;
			return entity.Insert();
		}
		
		public long Insert()
		{
			return this.Insert(null);
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public long Insert(SqlTransaction transaction)
		{			
			const string spName = "[dbo].[p_PhieuNhapKho_Insert]";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddOutParameter(dbCommand, "@Id", SqlDbType.BigInt, 8);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@MaKho", SqlDbType.NVarChar, MaKho);
			db.AddInParameter(dbCommand, "@TenKho", SqlDbType.NVarChar, TenKho);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, NhaCungCapId);
			db.AddInParameter(dbCommand, "@TongTien", SqlDbType.Decimal, TongTien);
			db.AddInParameter(dbCommand, "@ChiPhiNhap", SqlDbType.Decimal, ChiPhiNhap);
			db.AddInParameter(dbCommand, "@GiamGia", SqlDbType.Decimal, GiamGia);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@TongDaThanhToan", SqlDbType.Decimal, TongDaThanhToan);
			db.AddInParameter(dbCommand, "@TongConNo", SqlDbType.Decimal, TongConNo);
			db.AddInParameter(dbCommand, "@MaPhieu", SqlDbType.NVarChar, MaPhieu);
			
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
		public static bool InsertCollection(List<PhieuNhapKho> collection)
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
						foreach (PhieuNhapKho item in collection)
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
		
		public static int InsertUpdatePhieuNhapKho(long id, long nhanVienId, string maKho, string tenKho, DateTime thoiGian, long nhaCungCapId, decimal tongTien, decimal chiPhiNhap, decimal giamGia, string ghiChu, decimal tongDaThanhToan, decimal tongConNo, string maPhieu)
		{
			PhieuNhapKho entity = new PhieuNhapKho();			
			entity.Id = id;
			entity.NhanVienId = nhanVienId;
			entity.MaKho = maKho;
			entity.TenKho = tenKho;
			entity.ThoiGian = thoiGian;
			entity.NhaCungCapId = nhaCungCapId;
			entity.TongTien = tongTien;
			entity.ChiPhiNhap = chiPhiNhap;
			entity.GiamGia = giamGia;
			entity.GhiChu = ghiChu;
			entity.TongDaThanhToan = tongDaThanhToan;
			entity.TongConNo = tongConNo;
			entity.MaPhieu = maPhieu;
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
			const string spName = "p_PhieuNhapKho_InsertUpdate";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@MaKho", SqlDbType.NVarChar, MaKho);
			db.AddInParameter(dbCommand, "@TenKho", SqlDbType.NVarChar, TenKho);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, NhaCungCapId);
			db.AddInParameter(dbCommand, "@TongTien", SqlDbType.Decimal, TongTien);
			db.AddInParameter(dbCommand, "@ChiPhiNhap", SqlDbType.Decimal, ChiPhiNhap);
			db.AddInParameter(dbCommand, "@GiamGia", SqlDbType.Decimal, GiamGia);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@TongDaThanhToan", SqlDbType.Decimal, TongDaThanhToan);
			db.AddInParameter(dbCommand, "@TongConNo", SqlDbType.Decimal, TongConNo);
			db.AddInParameter(dbCommand, "@MaPhieu", SqlDbType.NVarChar, MaPhieu);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);			
		}
		
		//---------------------------------------------------------------------------------------------
		public static bool InsertUpdateCollection(List<PhieuNhapKho> collection)
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
						foreach (PhieuNhapKho item in collection)
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
		
		public static int UpdatePhieuNhapKho(long id, long nhanVienId, string maKho, string tenKho, DateTime thoiGian, long nhaCungCapId, decimal tongTien, decimal chiPhiNhap, decimal giamGia, string ghiChu, decimal tongDaThanhToan, decimal tongConNo, string maPhieu)
		{
			PhieuNhapKho entity = new PhieuNhapKho();			
			entity.Id = id;
			entity.NhanVienId = nhanVienId;
			entity.MaKho = maKho;
			entity.TenKho = tenKho;
			entity.ThoiGian = thoiGian;
			entity.NhaCungCapId = nhaCungCapId;
			entity.TongTien = tongTien;
			entity.ChiPhiNhap = chiPhiNhap;
			entity.GiamGia = giamGia;
			entity.GhiChu = ghiChu;
			entity.TongDaThanhToan = tongDaThanhToan;
			entity.TongConNo = tongConNo;
			entity.MaPhieu = maPhieu;
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
			const string spName = "[dbo].[p_PhieuNhapKho_Update]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@MaKho", SqlDbType.NVarChar, MaKho);
			db.AddInParameter(dbCommand, "@TenKho", SqlDbType.NVarChar, TenKho);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, NhaCungCapId);
			db.AddInParameter(dbCommand, "@TongTien", SqlDbType.Decimal, TongTien);
			db.AddInParameter(dbCommand, "@ChiPhiNhap", SqlDbType.Decimal, ChiPhiNhap);
			db.AddInParameter(dbCommand, "@GiamGia", SqlDbType.Decimal, GiamGia);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@TongDaThanhToan", SqlDbType.Decimal, TongDaThanhToan);
			db.AddInParameter(dbCommand, "@TongConNo", SqlDbType.Decimal, TongConNo);
			db.AddInParameter(dbCommand, "@MaPhieu", SqlDbType.NVarChar, MaPhieu);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
				
		//---------------------------------------------------------------------------------------------
		public static bool UpdateCollection(List<PhieuNhapKho> collection)
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
						foreach (PhieuNhapKho item in collection)
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
		
		public static int DeletePhieuNhapKho(long id)
		{
			PhieuNhapKho entity = new PhieuNhapKho();
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
			const string spName = "[dbo].[p_PhieuNhapKho_Delete]";		
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
			const string spName = "[dbo].[p_PhieuNhapKho_DeleteBy_NhaCungCapId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhaCungCapId", SqlDbType.BigInt, nhaCungCapId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_PhieuNhapKho_DeleteBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		
		public static int DeleteDynamic(string whereCondition)
		{
			const string spName = "[dbo].[p_PhieuNhapKho_DeleteDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            
            return db.ExecuteNonQuery(dbCommand);   
		}
		//---------------------------------------------------------------------------------------------
		
		public static bool DeleteCollection(List<PhieuNhapKho> collection)
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
						foreach (PhieuNhapKho item in collection)
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

                    foreach (PhieuNhapKho_HangHoa item in HangHoaCollection)
                    {
                        item.PhieuNhapKhoId = this.Id;
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
                    foreach (PhieuNhapKho_HangHoa item in HangHoaCollection)
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