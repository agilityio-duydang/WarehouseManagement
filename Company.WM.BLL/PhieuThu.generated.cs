using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace Company.WM.BLL
{
	public partial class PhieuThu : ICloneable
	{
		#region Properties.
		
		public long Id { set; get; }
		public long NhanVienId { set; get; }
		public DateTime ThoiGian { set; get; }
		public long LoaiThuId { set; get; }
		public string GhiChu { set; get; }
		public string NguoiThu { set; get; }
		public decimal GiaTri { set; get; }
		public long KhachHangId { set; get; }
		public long HoaDonId { set; get; }
		public string MaPhieu { set; get; }
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Methods
		protected static List<PhieuThu> ConvertToCollection(IDataReader reader)
		{
			List<PhieuThu> collection = new List<PhieuThu>();
			while (reader.Read())
			{
				PhieuThu entity = new PhieuThu();
				if (!reader.IsDBNull(reader.GetOrdinal("Id"))) entity.Id = reader.GetInt64(reader.GetOrdinal("Id"));
				if (!reader.IsDBNull(reader.GetOrdinal("NhanVienId"))) entity.NhanVienId = reader.GetInt64(reader.GetOrdinal("NhanVienId"));
				if (!reader.IsDBNull(reader.GetOrdinal("ThoiGian"))) entity.ThoiGian = reader.GetDateTime(reader.GetOrdinal("ThoiGian"));
				if (!reader.IsDBNull(reader.GetOrdinal("LoaiThuId"))) entity.LoaiThuId = reader.GetInt64(reader.GetOrdinal("LoaiThuId"));
				if (!reader.IsDBNull(reader.GetOrdinal("GhiChu"))) entity.GhiChu = reader.GetString(reader.GetOrdinal("GhiChu"));
				if (!reader.IsDBNull(reader.GetOrdinal("NguoiThu"))) entity.NguoiThu = reader.GetString(reader.GetOrdinal("NguoiThu"));
				if (!reader.IsDBNull(reader.GetOrdinal("GiaTri"))) entity.GiaTri = reader.GetDecimal(reader.GetOrdinal("GiaTri"));
				if (!reader.IsDBNull(reader.GetOrdinal("KhachHangId"))) entity.KhachHangId = reader.GetInt64(reader.GetOrdinal("KhachHangId"));
				if (!reader.IsDBNull(reader.GetOrdinal("HoaDonId"))) entity.HoaDonId = reader.GetInt64(reader.GetOrdinal("HoaDonId"));
				if (!reader.IsDBNull(reader.GetOrdinal("MaPhieu"))) entity.MaPhieu = reader.GetString(reader.GetOrdinal("MaPhieu"));
				collection.Add(entity);
			}
			reader.Close();
			return collection;
		}
		
		public static bool Find(List<PhieuThu> collection, long id)
        {
            foreach (PhieuThu item in collection)
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
            string insert = "Insert INTO t_PhieuThu VALUES(@NhanVienId, @ThoiGian, @LoaiThuId, @GhiChu, @NguoiThu, @GiaTri, @KhachHangId, @HoaDonId, @MaPhieu)";
            string update = "UPDATE t_PhieuThu SET NhanVienId = @NhanVienId, ThoiGian = @ThoiGian, LoaiThuId = @LoaiThuId, GhiChu = @GhiChu, NguoiThu = @NguoiThu, GiaTri = @GiaTri, KhachHangId = @KhachHangId, HoaDonId = @HoaDonId, MaPhieu = @MaPhieu WHERE Id = @Id";
            string delete = "DELETE FROM t_PhieuThu WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@LoaiThuId", SqlDbType.BigInt, "LoaiThuId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NguoiThu", SqlDbType.NVarChar, "NguoiThu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GiaTri", SqlDbType.Decimal, "GiaTri", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@HoaDonId", SqlDbType.BigInt, "HoaDonId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaPhieu", SqlDbType.NVarChar, "MaPhieu", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@LoaiThuId", SqlDbType.BigInt, "LoaiThuId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NguoiThu", SqlDbType.NVarChar, "NguoiThu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GiaTri", SqlDbType.Decimal, "GiaTri", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@HoaDonId", SqlDbType.BigInt, "HoaDonId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaPhieu", SqlDbType.NVarChar, "MaPhieu", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, ds.Tables[0].TableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }
				
		public static void UpdateDataSet(DataSet ds, string tableName)
        {
            string insert = "Insert INTO t_PhieuThu VALUES(@NhanVienId, @ThoiGian, @LoaiThuId, @GhiChu, @NguoiThu, @GiaTri, @KhachHangId, @HoaDonId, @MaPhieu)";
            string update = "UPDATE t_PhieuThu SET NhanVienId = @NhanVienId, ThoiGian = @ThoiGian, LoaiThuId = @LoaiThuId, GhiChu = @GhiChu, NguoiThu = @NguoiThu, GiaTri = @GiaTri, KhachHangId = @KhachHangId, HoaDonId = @HoaDonId, MaPhieu = @MaPhieu WHERE Id = @Id";
            string delete = "DELETE FROM t_PhieuThu WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@LoaiThuId", SqlDbType.BigInt, "LoaiThuId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NguoiThu", SqlDbType.NVarChar, "NguoiThu", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GiaTri", SqlDbType.Decimal, "GiaTri", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@HoaDonId", SqlDbType.BigInt, "HoaDonId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaPhieu", SqlDbType.NVarChar, "MaPhieu", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhanVienId", SqlDbType.BigInt, "NhanVienId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThoiGian", SqlDbType.DateTime, "ThoiGian", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@LoaiThuId", SqlDbType.BigInt, "LoaiThuId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NguoiThu", SqlDbType.NVarChar, "NguoiThu", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GiaTri", SqlDbType.Decimal, "GiaTri", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@KhachHangId", SqlDbType.BigInt, "KhachHangId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@HoaDonId", SqlDbType.BigInt, "HoaDonId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaPhieu", SqlDbType.NVarChar, "MaPhieu", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, tableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }

		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Select methods.
		
		public static PhieuThu Load(long id)
		{
			const string spName = "[dbo].[p_PhieuThu_Load]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, id);
            IDataReader reader = db.ExecuteReader(dbCommand);
			List<PhieuThu> collection = ConvertToCollection(reader);	
			if (collection.Count > 0)
			{
				return collection[0];
			}
			return null;
		}		
		
		//---------------------------------------------------------------------------------------------
		public static List<PhieuThu> SelectCollectionAll()
		{
			IDataReader reader = SelectReaderAll();
			return ConvertToCollection(reader);			
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public static List<PhieuThu> SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			IDataReader reader = SelectReaderDynamic(whereCondition, orderByExpression);
			return ConvertToCollection(reader);		
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		public static List<PhieuThu> SelectCollectionBy_HoaDonId(long hoaDonId)
		{
            IDataReader reader = SelectReaderBy_HoaDonId(hoaDonId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<PhieuThu> SelectCollectionBy_KhachHangId(long khachHangId)
		{
            IDataReader reader = SelectReaderBy_KhachHangId(khachHangId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<PhieuThu> SelectCollectionBy_LoaiThuId(long loaiThuId)
		{
            IDataReader reader = SelectReaderBy_LoaiThuId(loaiThuId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<PhieuThu> SelectCollectionBy_NhanVienId(long nhanVienId)
		{
            IDataReader reader = SelectReaderBy_NhanVienId(nhanVienId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectBy_HoaDonId(long hoaDonId)
		{
			const string spName = "[dbo].[p_PhieuThu_SelectBy_HoaDonId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, hoaDonId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_KhachHangId(long khachHangId)
		{
			const string spName = "[dbo].[p_PhieuThu_SelectBy_KhachHangId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, khachHangId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_LoaiThuId(long loaiThuId)
		{
			const string spName = "[dbo].[p_PhieuThu_SelectBy_LoaiThuId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@LoaiThuId", SqlDbType.BigInt, loaiThuId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_PhieuThu_SelectBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------

		public static DataSet SelectAll()
        {
            const string spName = "[dbo].[p_PhieuThu_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			
            return db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_PhieuThu_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
				
		public static IDataReader SelectReaderAll()
        {
            const string spName = "[dbo].[p_PhieuThu_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
            return db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_PhieuThu_SelectDynamic]";
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
			const string spName = "p_PhieuThu_SelectBy_HoaDonId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, hoaDonId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_KhachHangId(long khachHangId)
		{
			const string spName = "p_PhieuThu_SelectBy_KhachHangId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, khachHangId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_LoaiThuId(long loaiThuId)
		{
			const string spName = "p_PhieuThu_SelectBy_LoaiThuId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@LoaiThuId", SqlDbType.BigInt, loaiThuId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_NhanVienId(long nhanVienId)
		{
			const string spName = "p_PhieuThu_SelectBy_NhanVienId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert methods.
		
		public static long InsertPhieuThu(long nhanVienId, DateTime thoiGian, long loaiThuId, string ghiChu, string nguoiThu, decimal giaTri, long khachHangId, long hoaDonId, string maPhieu)
		{
			PhieuThu entity = new PhieuThu();	
			entity.NhanVienId = nhanVienId;
			entity.ThoiGian = thoiGian;
			entity.LoaiThuId = loaiThuId;
			entity.GhiChu = ghiChu;
			entity.NguoiThu = nguoiThu;
			entity.GiaTri = giaTri;
			entity.KhachHangId = khachHangId;
			entity.HoaDonId = hoaDonId;
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
			const string spName = "[dbo].[p_PhieuThu_Insert]";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddOutParameter(dbCommand, "@Id", SqlDbType.BigInt, 8);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@LoaiThuId", SqlDbType.BigInt, LoaiThuId);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@NguoiThu", SqlDbType.NVarChar, NguoiThu);
			db.AddInParameter(dbCommand, "@GiaTri", SqlDbType.Decimal, GiaTri);
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, KhachHangId);
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, HoaDonId);
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
		public static bool InsertCollection(List<PhieuThu> collection)
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
						foreach (PhieuThu item in collection)
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
		
		public static int InsertUpdatePhieuThu(long id, long nhanVienId, DateTime thoiGian, long loaiThuId, string ghiChu, string nguoiThu, decimal giaTri, long khachHangId, long hoaDonId, string maPhieu)
		{
			PhieuThu entity = new PhieuThu();			
			entity.Id = id;
			entity.NhanVienId = nhanVienId;
			entity.ThoiGian = thoiGian;
			entity.LoaiThuId = loaiThuId;
			entity.GhiChu = ghiChu;
			entity.NguoiThu = nguoiThu;
			entity.GiaTri = giaTri;
			entity.KhachHangId = khachHangId;
			entity.HoaDonId = hoaDonId;
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
			const string spName = "p_PhieuThu_InsertUpdate";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@LoaiThuId", SqlDbType.BigInt, LoaiThuId);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@NguoiThu", SqlDbType.NVarChar, NguoiThu);
			db.AddInParameter(dbCommand, "@GiaTri", SqlDbType.Decimal, GiaTri);
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, KhachHangId);
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, HoaDonId);
			db.AddInParameter(dbCommand, "@MaPhieu", SqlDbType.NVarChar, MaPhieu);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);			
		}
		
		//---------------------------------------------------------------------------------------------
		public static bool InsertUpdateCollection(List<PhieuThu> collection)
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
						foreach (PhieuThu item in collection)
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
		
		public static int UpdatePhieuThu(long id, long nhanVienId, DateTime thoiGian, long loaiThuId, string ghiChu, string nguoiThu, decimal giaTri, long khachHangId, long hoaDonId, string maPhieu)
		{
			PhieuThu entity = new PhieuThu();			
			entity.Id = id;
			entity.NhanVienId = nhanVienId;
			entity.ThoiGian = thoiGian;
			entity.LoaiThuId = loaiThuId;
			entity.GhiChu = ghiChu;
			entity.NguoiThu = nguoiThu;
			entity.GiaTri = giaTri;
			entity.KhachHangId = khachHangId;
			entity.HoaDonId = hoaDonId;
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
			const string spName = "[dbo].[p_PhieuThu_Update]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, NhanVienId);
			db.AddInParameter(dbCommand, "@ThoiGian", SqlDbType.DateTime, ThoiGian.Year <= 1753 ? DBNull.Value : (object) ThoiGian);
			db.AddInParameter(dbCommand, "@LoaiThuId", SqlDbType.BigInt, LoaiThuId);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			db.AddInParameter(dbCommand, "@NguoiThu", SqlDbType.NVarChar, NguoiThu);
			db.AddInParameter(dbCommand, "@GiaTri", SqlDbType.Decimal, GiaTri);
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, KhachHangId);
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, HoaDonId);
			db.AddInParameter(dbCommand, "@MaPhieu", SqlDbType.NVarChar, MaPhieu);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
				
		//---------------------------------------------------------------------------------------------
		public static bool UpdateCollection(List<PhieuThu> collection)
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
						foreach (PhieuThu item in collection)
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
		
		public static int DeletePhieuThu(long id)
		{
			PhieuThu entity = new PhieuThu();
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
			const string spName = "[dbo].[p_PhieuThu_Delete]";		
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
			const string spName = "[dbo].[p_PhieuThu_DeleteBy_HoaDonId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, hoaDonId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_KhachHangId(long khachHangId)
		{
			const string spName = "[dbo].[p_PhieuThu_DeleteBy_KhachHangId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@KhachHangId", SqlDbType.BigInt, khachHangId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_LoaiThuId(long loaiThuId)
		{
			const string spName = "[dbo].[p_PhieuThu_DeleteBy_LoaiThuId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@LoaiThuId", SqlDbType.BigInt, loaiThuId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_NhanVienId(long nhanVienId)
		{
			const string spName = "[dbo].[p_PhieuThu_DeleteBy_NhanVienId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhanVienId", SqlDbType.BigInt, nhanVienId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		
		public static int DeleteDynamic(string whereCondition)
		{
			const string spName = "[dbo].[p_PhieuThu_DeleteDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            
            return db.ExecuteNonQuery(dbCommand);   
		}
		//---------------------------------------------------------------------------------------------
		
		public static bool DeleteCollection(List<PhieuThu> collection)
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
						foreach (PhieuThu item in collection)
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