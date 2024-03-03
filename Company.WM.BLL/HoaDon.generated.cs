using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace Company.WM.BLL
{
	public partial class HoaDon : ICloneable
	{
		#region Properties.
		
		public long Id { set; get; }
		public string MaHoaDon { set; get; }
		public DateTime ThoiGianTao { set; get; }
		public DateTime ThoiGianThanhToan { set; get; }
		public long BanHangId { set; get; }
		public long KhachHangId { set; get; }
		public long NhanVienId { set; get; }
		public decimal TongTien { set; get; }
		public int ThueSuat { set; get; }
		public string GhiChu { set; get; }
		public decimal TongTienHang { set; get; }
		public decimal TienThue { set; get; }
		public int GiamGia { set; get; }
		public decimal TriGiaGiam { set; get; }
        public List<HoaDon_HangHoa> HangHoaCollection { set; get; }

		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Methods
		protected static List<HoaDon> ConvertToCollection(IDataReader reader)
		{
			List<HoaDon> collection = new List<HoaDon>();
			while (reader.Read())
			{
				HoaDon entity = new HoaDon();
				if (!reader.IsDBNull(reader.GetOrdinal("Id"))) entity.Id = reader.GetInt64(reader.GetOrdinal("Id"));
				if (!reader.IsDBNull(reader.GetOrdinal("MaHoaDon"))) entity.MaHoaDon = reader.GetString(reader.GetOrdinal("MaHoaDon"));
				if (!reader.IsDBNull(reader.GetOrdinal("ThoiGianTao"))) entity.ThoiGianTao = reader.GetDateTime(reader.GetOrdinal("ThoiGianTao"));
				if (!reader.IsDBNull(reader.GetOrdinal("ThoiGianThanhToan"))) entity.ThoiGianThanhToan = reader.GetDateTime(reader.GetOrdinal("ThoiGianThanhToan"));
				if (!reader.IsDBNull(reader.GetOrdinal("BanHangId"))) entity.BanHangId = reader.GetInt64(reader.GetOrdinal("BanHangId"));
				if (!reader.IsDBNull(reader.GetOrdinal("KhachHangId"))) entity.KhachHangId = reader.GetInt64(reader.GetOrdinal("KhachHangId"));
				if (!reader.IsDBNull(reader.GetOrdinal("NhanVienId"))) entity.NhanVienId = reader.GetInt64(reader.GetOrdinal("NhanVienId"));
				if (!reader.IsDBNull(reader.GetOrdinal("TongTien"))) entity.TongTien = reader.GetDecimal(reader.GetOrdinal("TongTien"));
				if (!reader.IsDBNull(reader.GetOrdinal("ThueSuat"))) entity.ThueSuat = reader.GetInt32(reader.GetOrdinal("ThueSuat"));
				if (!reader.IsDBNull(reader.GetOrdinal("GhiChu"))) entity.GhiChu = reader.GetString(reader.GetOrdinal("GhiChu"));
				if (!reader.IsDBNull(reader.GetOrdinal("TongTienHang"))) entity.TongTienHang = reader.GetDecimal(reader.GetOrdinal("TongTienHang"));
				if (!reader.IsDBNull(reader.GetOrdinal("TienThue"))) entity.TienThue = reader.GetDecimal(reader.GetOrdinal("TienThue"));
				if (!reader.IsDBNull(reader.GetOrdinal("GiamGia"))) entity.GiamGia = reader.GetInt32(reader.GetOrdinal("GiamGia"));
				if (!reader.IsDBNull(reader.GetOrdinal("TriGiaGiam"))) entity.TriGiaGiam = reader.GetDecimal(reader.GetOrdinal("TriGiaGiam"));
				collection.Add(entity);
			}
			reader.Close();
			return collection;
		}
		
		public static bool Find(List<HoaDon> collection, long id)
        {
            foreach (HoaDon item in collection)
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
            string insert = "Insert INTO t_HoaDon VALUES(@MaHoaDon, @ThoiGianTao, @ThoiGianThanhToan, @BanHangId, @KhachHangId, @NhanVienId, @TongTien, @ThueSuat, @GhiChu, @TongTienHang, @TienThue, @GiamGia, @TriGiaGiam)";
            string update = "UPDATE t_HoaDon SET MaHoaDon = @MaHoaDon, ThoiGianTao = @ThoiGianTao, ThoiGianThanhToan = @ThoiGianThanhToan, BanHangId = @BanHangId, KhachHangId = @KhachHangId, NhanVienId = @NhanVienId, TongTien = @TongTien, ThueSuat = @ThueSuat, GhiChu = @GhiChu, TongTienHang = @TongTienHang, TienThue = @TienThue, GiamGia = @GiamGia, TriGiaGiam = @TriGiaGiam WHERE Id = @Id";
            string delete = "DELETE FROM t_HoaDon WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaHoaDon", SqlDbType.NVarChar, "MaHoaDon", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGianTao", SqlDbType.DateTime, "ThoiGianTao", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGianThanhToan", SqlDbType.DateTime, "ThoiGianThanhToan", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@BanHangId", SqlDbType.BigInt, "BanHangId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThueSuat", SqlDbType.Int, "ThueSuat", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongTienHang", SqlDbType.Decimal, "TongTienHang", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TienThue", SqlDbType.Decimal, "TienThue", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GiamGia", SqlDbType.Int, "GiamGia", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TriGiaGiam", SqlDbType.Decimal, "TriGiaGiam", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaHoaDon", SqlDbType.NVarChar, "MaHoaDon", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGianTao", SqlDbType.DateTime, "ThoiGianTao", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGianThanhToan", SqlDbType.DateTime, "ThoiGianThanhToan", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@BanHangId", SqlDbType.BigInt, "BanHangId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThueSuat", SqlDbType.Int, "ThueSuat", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongTienHang", SqlDbType.Decimal, "TongTienHang", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TienThue", SqlDbType.Decimal, "TienThue", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GiamGia", SqlDbType.Int, "GiamGia", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TriGiaGiam", SqlDbType.Decimal, "TriGiaGiam", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, ds.Tables[0].TableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }
				
		public static void UpdateDataSet(DataSet ds, string tableName)
        {
            string insert = "Insert INTO t_HoaDon VALUES(@MaHoaDon, @ThoiGianTao, @ThoiGianThanhToan, @BanHangId, @KhachHangId, @NhanVienId, @TongTien, @ThueSuat, @GhiChu, @TongTienHang, @TienThue, @GiamGia, @TriGiaGiam)";
            string update = "UPDATE t_HoaDon SET MaHoaDon = @MaHoaDon, ThoiGianTao = @ThoiGianTao, ThoiGianThanhToan = @ThoiGianThanhToan, BanHangId = @BanHangId, KhachHangId = @KhachHangId, NhanVienId = @NhanVienId, TongTien = @TongTien, ThueSuat = @ThueSuat, GhiChu = @GhiChu, TongTienHang = @TongTienHang, TienThue = @TienThue, GiamGia = @GiamGia, TriGiaGiam = @TriGiaGiam WHERE Id = @Id";
            string delete = "DELETE FROM t_HoaDon WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaHoaDon", SqlDbType.NVarChar, "MaHoaDon", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGianTao", SqlDbType.DateTime, "ThoiGianTao", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGianThanhToan", SqlDbType.DateTime, "ThoiGianThanhToan", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@BanHangId", SqlDbType.BigInt, "BanHangId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThueSuat", SqlDbType.Int, "ThueSuat", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TongTienHang", SqlDbType.Decimal, "TongTienHang", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TienThue", SqlDbType.Decimal, "TienThue", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GiamGia", SqlDbType.Int, "GiamGia", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TriGiaGiam", SqlDbType.Decimal, "TriGiaGiam", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaHoaDon", SqlDbType.NVarChar, "MaHoaDon", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGianTao", SqlDbType.DateTime, "ThoiGianTao", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGianThanhToan", SqlDbType.DateTime, "ThoiGianThanhToan", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@BanHangId", SqlDbType.BigInt, "BanHangId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongTien", SqlDbType.Decimal, "TongTien", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThueSuat", SqlDbType.Int, "ThueSuat", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TongTienHang", SqlDbType.Decimal, "TongTienHang", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TienThue", SqlDbType.Decimal, "TienThue", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GiamGia", SqlDbType.Int, "GiamGia", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TriGiaGiam", SqlDbType.Decimal, "TriGiaGiam", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, tableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }

		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Select methods.
		
		public static HoaDon Load(long id)
		{
			const string spName = "[dbo].[p_HoaDon_Load]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, id);
            IDataReader reader = db.ExecuteReader(dbCommand);
			List<HoaDon> collection = ConvertToCollection(reader);	
			if (collection.Count > 0)
			{
				return collection[0];
			}
			return null;
		}		
		
		//---------------------------------------------------------------------------------------------
		public static List<HoaDon> SelectCollectionAll()
		{
			IDataReader reader = SelectReaderAll();
			return ConvertToCollection(reader);			
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public static List<HoaDon> SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			IDataReader reader = SelectReaderDynamic(whereCondition, orderByExpression);
			return ConvertToCollection(reader);		
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		public static List<HoaDon> SelectCollectionBy_KhachHangId(long khachHangId)
		{
            IDataReader reader = SelectReaderBy_KhachHangId(khachHangId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<HoaDon> SelectCollectionBy_NhanVienId(long nhanVienId)
		{
            IDataReader reader = SelectReaderBy_NhanVienId(nhanVienId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectBy_KhachHangId(long khachHangId)
		{
			const string spName = "[dbo].[p_HoaDon_SelectBy_KhachHangId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, khachHangId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_HoaDon_SelectBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------

		public static DataSet SelectAll()
        {
            const string spName = "[dbo].[p_HoaDon_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			
            return db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_HoaDon_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
				
		public static IDataReader SelectReaderAll()
        {
            const string spName = "[dbo].[p_HoaDon_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
            return db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_HoaDon_SelectDynamic]";
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
			const string spName = "p_HoaDon_SelectBy_KhachHangId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, khachHangId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_NhanVienId(long nhanVienId)
		{
			const string spName = "p_HoaDon_SelectBy_NhanVienId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert methods.
		
		public static long InsertHoaDon(string maHoaDon, DateTime thoiGianTao, DateTime thoiGianThanhToan, long banHangId, long khachHangId, long nhanVienId, decimal tongTien, int thueSuat, string ghiChu, decimal tongTienHang, decimal tienThue, int giamGia, decimal triGiaGiam)
		{
			HoaDon entity = new HoaDon();	
			entity.MaHoaDon = maHoaDon;
			entity.ThoiGianTao = thoiGianTao;
			entity.ThoiGianThanhToan = thoiGianThanhToan;
			entity.BanHangId = banHangId;
			entity.KhachHangId = khachHangId;
			entity.NhanVienId = nhanVienId;
			entity.TongTien = tongTien;
			entity.ThueSuat = thueSuat;
			entity.GhiChu = ghiChu;
			entity.TongTienHang = tongTienHang;
			entity.TienThue = tienThue;
			entity.GiamGia = giamGia;
			entity.TriGiaGiam = triGiaGiam;
			return entity.Insert();
		}
		
		public long Insert()
		{
			return this.Insert(null);
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public long Insert(SqlTransaction transaction)
		{			
			const string spName = "[dbo].[p_HoaDon_Insert]";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddOutParameter(dbCommand, "@Id", SqlDbType.BigInt, 8);
			db.AddInParameter(dbCommand, "@MaHoaDon", SqlDbType.NVarChar, MaHoaDon);
			db.AddInParameter(dbCommand, "@ThoiGianTao", SqlDbType.DateTime, ThoiGianTao.Year <= 1753 ? DBNull.Value : (object) ThoiGianTao);
			db.AddInParameter(dbCommand, "@ThoiGianThanhToan", SqlDbType.DateTime, ThoiGianThanhToan.Year <= 1753 ? DBNull.Value : (object) ThoiGianThanhToan);
			db.AddInParameter(dbCommand, "@BanHangId", SqlDbType.BigInt, BanHangId);
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, KhachHangId);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@TongTien", SqlDbType.Decimal, TongTien);
			db.AddInParameter(dbCommand, "@ThueSuat", SqlDbType.Int, ThueSuat);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@TongTienHang", SqlDbType.Decimal, TongTienHang);
			db.AddInParameter(dbCommand, "@TienThue", SqlDbType.Decimal, TienThue);
			db.AddInParameter(dbCommand, "@GiamGia", SqlDbType.Int, GiamGia);
			db.AddInParameter(dbCommand, "@TriGiaGiam", SqlDbType.Decimal, TriGiaGiam);
			
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
		public static bool InsertCollection(List<HoaDon> collection)
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
						foreach (HoaDon item in collection)
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
		
		public static int InsertUpdateHoaDon(long id, string maHoaDon, DateTime thoiGianTao, DateTime thoiGianThanhToan, long banHangId, long khachHangId, long nhanVienId, decimal tongTien, int thueSuat, string ghiChu, decimal tongTienHang, decimal tienThue, int giamGia, decimal triGiaGiam)
		{
			HoaDon entity = new HoaDon();			
			entity.Id = id;
			entity.MaHoaDon = maHoaDon;
			entity.ThoiGianTao = thoiGianTao;
			entity.ThoiGianThanhToan = thoiGianThanhToan;
			entity.BanHangId = banHangId;
			entity.KhachHangId = khachHangId;
			entity.NhanVienId = nhanVienId;
			entity.TongTien = tongTien;
			entity.ThueSuat = thueSuat;
			entity.GhiChu = ghiChu;
			entity.TongTienHang = tongTienHang;
			entity.TienThue = tienThue;
			entity.GiamGia = giamGia;
			entity.TriGiaGiam = triGiaGiam;
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
			const string spName = "p_HoaDon_InsertUpdate";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@MaHoaDon", SqlDbType.NVarChar, MaHoaDon);
			db.AddInParameter(dbCommand, "@ThoiGianTao", SqlDbType.DateTime, ThoiGianTao.Year <= 1753 ? DBNull.Value : (object) ThoiGianTao);
			db.AddInParameter(dbCommand, "@ThoiGianThanhToan", SqlDbType.DateTime, ThoiGianThanhToan.Year <= 1753 ? DBNull.Value : (object) ThoiGianThanhToan);
			db.AddInParameter(dbCommand, "@BanHangId", SqlDbType.BigInt, BanHangId);
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, KhachHangId);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@TongTien", SqlDbType.Decimal, TongTien);
			db.AddInParameter(dbCommand, "@ThueSuat", SqlDbType.Int, ThueSuat);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@TongTienHang", SqlDbType.Decimal, TongTienHang);
			db.AddInParameter(dbCommand, "@TienThue", SqlDbType.Decimal, TienThue);
			db.AddInParameter(dbCommand, "@GiamGia", SqlDbType.Int, GiamGia);
			db.AddInParameter(dbCommand, "@TriGiaGiam", SqlDbType.Decimal, TriGiaGiam);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);			
		}
		
		//---------------------------------------------------------------------------------------------
		public static bool InsertUpdateCollection(List<HoaDon> collection)
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
						foreach (HoaDon item in collection)
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
		
		public static int UpdateHoaDon(long id, string maHoaDon, DateTime thoiGianTao, DateTime thoiGianThanhToan, long banHangId, long khachHangId, long nhanVienId, decimal tongTien, int thueSuat, string ghiChu, decimal tongTienHang, decimal tienThue, int giamGia, decimal triGiaGiam)
		{
			HoaDon entity = new HoaDon();			
			entity.Id = id;
			entity.MaHoaDon = maHoaDon;
			entity.ThoiGianTao = thoiGianTao;
			entity.ThoiGianThanhToan = thoiGianThanhToan;
			entity.BanHangId = banHangId;
			entity.KhachHangId = khachHangId;
			entity.NhanVienId = nhanVienId;
			entity.TongTien = tongTien;
			entity.ThueSuat = thueSuat;
			entity.GhiChu = ghiChu;
			entity.TongTienHang = tongTienHang;
			entity.TienThue = tienThue;
			entity.GiamGia = giamGia;
			entity.TriGiaGiam = triGiaGiam;
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
			const string spName = "[dbo].[p_HoaDon_Update]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@MaHoaDon", SqlDbType.NVarChar, MaHoaDon);
			db.AddInParameter(dbCommand, "@ThoiGianTao", SqlDbType.DateTime, ThoiGianTao.Year <= 1753 ? DBNull.Value : (object) ThoiGianTao);
			db.AddInParameter(dbCommand, "@ThoiGianThanhToan", SqlDbType.DateTime, ThoiGianThanhToan.Year <= 1753 ? DBNull.Value : (object) ThoiGianThanhToan);
			db.AddInParameter(dbCommand, "@BanHangId", SqlDbType.BigInt, BanHangId);
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, KhachHangId);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@TongTien", SqlDbType.Decimal, TongTien);
			db.AddInParameter(dbCommand, "@ThueSuat", SqlDbType.Int, ThueSuat);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@TongTienHang", SqlDbType.Decimal, TongTienHang);
			db.AddInParameter(dbCommand, "@TienThue", SqlDbType.Decimal, TienThue);
			db.AddInParameter(dbCommand, "@GiamGia", SqlDbType.Int, GiamGia);
			db.AddInParameter(dbCommand, "@TriGiaGiam", SqlDbType.Decimal, TriGiaGiam);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
				
		//---------------------------------------------------------------------------------------------
		public static bool UpdateCollection(List<HoaDon> collection)
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
						foreach (HoaDon item in collection)
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
		
		public static int DeleteHoaDon(long id)
		{
			HoaDon entity = new HoaDon();
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
			const string spName = "[dbo].[p_HoaDon_Delete]";		
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
			const string spName = "[dbo].[p_HoaDon_DeleteBy_KhachHangId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, khachHangId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_HoaDon_DeleteBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		
		public static int DeleteDynamic(string whereCondition)
		{
			const string spName = "[dbo].[p_HoaDon_DeleteDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            
            return db.ExecuteNonQuery(dbCommand);   
		}
		//---------------------------------------------------------------------------------------------
		
		public static bool DeleteCollection(List<HoaDon> collection)
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
						foreach (HoaDon item in collection)
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

        public static DataSet SelectReportReport(string fromDate, string toDate)
        {
            const string spName = "[dbo].[p_ReportTotal]";
            SqlDatabase db = (SqlDatabase)DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand)db.GetStoredProcCommand(spName);

            db.AddInParameter(dbCommand, "@FromDate", SqlDbType.NVarChar, fromDate);
            db.AddInParameter(dbCommand, "@ToDate", SqlDbType.NVarChar, toDate);

            return db.ExecuteDataSet(dbCommand);
        }

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

                    foreach (HoaDon_HangHoa item in HangHoaCollection)
                    {
                        item.HoaDonId = this.Id;
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
                    foreach (HoaDon_HangHoa item in HangHoaCollection)
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