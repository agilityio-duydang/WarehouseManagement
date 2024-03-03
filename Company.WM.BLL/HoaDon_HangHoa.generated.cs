using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace Company.WM.BLL
{
	public partial class HoaDon_HangHoa : ICloneable
	{
		#region Properties.
		
		public long Id { set; get; }
		public int STT { set; get; }
		public long HoaDonId { set; get; }
		public string MaHangHoa { set; get; }
		public string TenHangHoa { set; get; }
		public decimal SoLuong { set; get; }
		public long NhomHangHoaId { set; get; }
		public decimal DonGiaNhap { set; get; }
		public decimal DonGiaBan { set; get; }
		public string DonViTinh { set; get; }
		public decimal ThanhTienNhap { set; get; }
		public decimal ThanhTienBan { set; get; }
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Methods
		protected static List<HoaDon_HangHoa> ConvertToCollection(IDataReader reader)
		{
			List<HoaDon_HangHoa> collection = new List<HoaDon_HangHoa>();
			while (reader.Read())
			{
				HoaDon_HangHoa entity = new HoaDon_HangHoa();
				if (!reader.IsDBNull(reader.GetOrdinal("Id"))) entity.Id = reader.GetInt64(reader.GetOrdinal("Id"));
				if (!reader.IsDBNull(reader.GetOrdinal("STT"))) entity.STT = reader.GetInt32(reader.GetOrdinal("STT"));
				if (!reader.IsDBNull(reader.GetOrdinal("HoaDonId"))) entity.HoaDonId = reader.GetInt64(reader.GetOrdinal("HoaDonId"));
				if (!reader.IsDBNull(reader.GetOrdinal("MaHangHoa"))) entity.MaHangHoa = reader.GetString(reader.GetOrdinal("MaHangHoa"));
				if (!reader.IsDBNull(reader.GetOrdinal("TenHangHoa"))) entity.TenHangHoa = reader.GetString(reader.GetOrdinal("TenHangHoa"));
				if (!reader.IsDBNull(reader.GetOrdinal("SoLuong"))) entity.SoLuong = reader.GetDecimal(reader.GetOrdinal("SoLuong"));
				if (!reader.IsDBNull(reader.GetOrdinal("NhomHangHoaId"))) entity.NhomHangHoaId = reader.GetInt64(reader.GetOrdinal("NhomHangHoaId"));
				if (!reader.IsDBNull(reader.GetOrdinal("DonGiaNhap"))) entity.DonGiaNhap = reader.GetDecimal(reader.GetOrdinal("DonGiaNhap"));
				if (!reader.IsDBNull(reader.GetOrdinal("DonGiaBan"))) entity.DonGiaBan = reader.GetDecimal(reader.GetOrdinal("DonGiaBan"));
				if (!reader.IsDBNull(reader.GetOrdinal("DonViTinh"))) entity.DonViTinh = reader.GetString(reader.GetOrdinal("DonViTinh"));
				if (!reader.IsDBNull(reader.GetOrdinal("ThanhTienNhap"))) entity.ThanhTienNhap = reader.GetDecimal(reader.GetOrdinal("ThanhTienNhap"));
				if (!reader.IsDBNull(reader.GetOrdinal("ThanhTienBan"))) entity.ThanhTienBan = reader.GetDecimal(reader.GetOrdinal("ThanhTienBan"));
				collection.Add(entity);
			}
			reader.Close();
			return collection;
		}
		
		public static bool Find(List<HoaDon_HangHoa> collection, long id)
        {
            foreach (HoaDon_HangHoa item in collection)
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
            string insert = "Insert INTO t_HoaDon_HangHoa VALUES(@STT, @HoaDonId, @MaHangHoa, @TenHangHoa, @SoLuong, @NhomHangHoaId, @DonGiaNhap, @DonGiaBan, @DonViTinh, @ThanhTienNhap, @ThanhTienBan)";
            string update = "UPDATE t_HoaDon_HangHoa SET STT = @STT, HoaDonId = @HoaDonId, MaHangHoa = @MaHangHoa, TenHangHoa = @TenHangHoa, SoLuong = @SoLuong, NhomHangHoaId = @NhomHangHoaId, DonGiaNhap = @DonGiaNhap, DonGiaBan = @DonGiaBan, DonViTinh = @DonViTinh, ThanhTienNhap = @ThanhTienNhap, ThanhTienBan = @ThanhTienBan WHERE Id = @Id";
            string delete = "DELETE FROM t_HoaDon_HangHoa WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@STT", SqlDbType.Int, "STT", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@HoaDonId", SqlDbType.BigInt, "HoaDonId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaHangHoa", SqlDbType.NVarChar, "MaHangHoa", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TenHangHoa", SqlDbType.NVarChar, "TenHangHoa", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@SoLuong", SqlDbType.Decimal, "SoLuong", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhomHangHoaId", SqlDbType.BigInt, "NhomHangHoaId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@DonGiaNhap", SqlDbType.Decimal, "DonGiaNhap", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@DonGiaBan", SqlDbType.Decimal, "DonGiaBan", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@DonViTinh", SqlDbType.NVarChar, "DonViTinh", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThanhTienNhap", SqlDbType.Decimal, "ThanhTienNhap", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThanhTienBan", SqlDbType.Decimal, "ThanhTienBan", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@STT", SqlDbType.Int, "STT", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@HoaDonId", SqlDbType.BigInt, "HoaDonId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaHangHoa", SqlDbType.NVarChar, "MaHangHoa", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TenHangHoa", SqlDbType.NVarChar, "TenHangHoa", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@SoLuong", SqlDbType.Decimal, "SoLuong", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhomHangHoaId", SqlDbType.BigInt, "NhomHangHoaId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@DonGiaNhap", SqlDbType.Decimal, "DonGiaNhap", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@DonGiaBan", SqlDbType.Decimal, "DonGiaBan", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@DonViTinh", SqlDbType.NVarChar, "DonViTinh", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThanhTienNhap", SqlDbType.Decimal, "ThanhTienNhap", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThanhTienBan", SqlDbType.Decimal, "ThanhTienBan", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, ds.Tables[0].TableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }
				
		public static void UpdateDataSet(DataSet ds, string tableName)
        {
            string insert = "Insert INTO t_HoaDon_HangHoa VALUES(@STT, @HoaDonId, @MaHangHoa, @TenHangHoa, @SoLuong, @NhomHangHoaId, @DonGiaNhap, @DonGiaBan, @DonViTinh, @ThanhTienNhap, @ThanhTienBan)";
            string update = "UPDATE t_HoaDon_HangHoa SET STT = @STT, HoaDonId = @HoaDonId, MaHangHoa = @MaHangHoa, TenHangHoa = @TenHangHoa, SoLuong = @SoLuong, NhomHangHoaId = @NhomHangHoaId, DonGiaNhap = @DonGiaNhap, DonGiaBan = @DonGiaBan, DonViTinh = @DonViTinh, ThanhTienNhap = @ThanhTienNhap, ThanhTienBan = @ThanhTienBan WHERE Id = @Id";
            string delete = "DELETE FROM t_HoaDon_HangHoa WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@STT", SqlDbType.Int, "STT", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@HoaDonId", SqlDbType.BigInt, "HoaDonId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaHangHoa", SqlDbType.NVarChar, "MaHangHoa", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TenHangHoa", SqlDbType.NVarChar, "TenHangHoa", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@SoLuong", SqlDbType.Decimal, "SoLuong", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@NhomHangHoaId", SqlDbType.BigInt, "NhomHangHoaId", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@DonGiaNhap", SqlDbType.Decimal, "DonGiaNhap", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@DonGiaBan", SqlDbType.Decimal, "DonGiaBan", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@DonViTinh", SqlDbType.NVarChar, "DonViTinh", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThanhTienNhap", SqlDbType.Decimal, "ThanhTienNhap", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ThanhTienBan", SqlDbType.Decimal, "ThanhTienBan", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@STT", SqlDbType.Int, "STT", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@HoaDonId", SqlDbType.BigInt, "HoaDonId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaHangHoa", SqlDbType.NVarChar, "MaHangHoa", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TenHangHoa", SqlDbType.NVarChar, "TenHangHoa", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@SoLuong", SqlDbType.Decimal, "SoLuong", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@NhomHangHoaId", SqlDbType.BigInt, "NhomHangHoaId", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@DonGiaNhap", SqlDbType.Decimal, "DonGiaNhap", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@DonGiaBan", SqlDbType.Decimal, "DonGiaBan", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@DonViTinh", SqlDbType.NVarChar, "DonViTinh", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThanhTienNhap", SqlDbType.Decimal, "ThanhTienNhap", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ThanhTienBan", SqlDbType.Decimal, "ThanhTienBan", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, tableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }

		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Select methods.
		
		public static HoaDon_HangHoa Load(long id)
		{
			const string spName = "[dbo].[p_HoaDon_HangHoa_Load]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, id);
            IDataReader reader = db.ExecuteReader(dbCommand);
			List<HoaDon_HangHoa> collection = ConvertToCollection(reader);	
			if (collection.Count > 0)
			{
				return collection[0];
			}
			return null;
		}		
		
		//---------------------------------------------------------------------------------------------
		public static List<HoaDon_HangHoa> SelectCollectionAll()
		{
			IDataReader reader = SelectReaderAll();
			return ConvertToCollection(reader);			
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public static List<HoaDon_HangHoa> SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			IDataReader reader = SelectReaderDynamic(whereCondition, orderByExpression);
			return ConvertToCollection(reader);		
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		public static List<HoaDon_HangHoa> SelectCollectionBy_HoaDonId(long hoaDonId)
		{
            IDataReader reader = SelectReaderBy_HoaDonId(hoaDonId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		public static List<HoaDon_HangHoa> SelectCollectionBy_NhomHangHoaId(long nhomHangHoaId)
		{
            IDataReader reader = SelectReaderBy_NhomHangHoaId(nhomHangHoaId);
			return ConvertToCollection(reader);	
		}		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectBy_HoaDonId(long hoaDonId)
		{
			const string spName = "[dbo].[p_HoaDon_HangHoa_SelectBy_HoaDonId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, hoaDonId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public static DataSet SelectBy_NhomHangHoaId(long nhomHangHoaId)
		{
			const string spName = "[dbo].[p_HoaDon_HangHoa_SelectBy_NhomHangHoaId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhomHangHoaId", SqlDbType.BigInt, nhomHangHoaId);
						
            return db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------

		public static DataSet SelectAll()
        {
            const string spName = "[dbo].[p_HoaDon_HangHoa_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			
            return db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_HoaDon_HangHoa_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
				
		public static IDataReader SelectReaderAll()
        {
            const string spName = "[dbo].[p_HoaDon_HangHoa_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
            return db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_HoaDon_HangHoa_SelectDynamic]";
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
			const string spName = "p_HoaDon_HangHoa_SelectBy_HoaDonId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, hoaDonId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		public static IDataReader SelectReaderBy_NhomHangHoaId(long nhomHangHoaId)
		{
			const string spName = "p_HoaDon_HangHoa_SelectBy_NhomHangHoaId";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhomHangHoaId", SqlDbType.BigInt, nhomHangHoaId);
			
            return db.ExecuteReader(dbCommand);
		}		
		//---------------------------------------------------------------------------------------------
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert methods.
		
		public static long InsertHoaDon_HangHoa(int sTT, long hoaDonId, string maHangHoa, string tenHangHoa, decimal soLuong, long nhomHangHoaId, decimal donGiaNhap, decimal donGiaBan, string donViTinh, decimal thanhTienNhap, decimal thanhTienBan)
		{
			HoaDon_HangHoa entity = new HoaDon_HangHoa();	
			entity.STT = sTT;
			entity.HoaDonId = hoaDonId;
			entity.MaHangHoa = maHangHoa;
			entity.TenHangHoa = tenHangHoa;
			entity.SoLuong = soLuong;
			entity.NhomHangHoaId = nhomHangHoaId;
			entity.DonGiaNhap = donGiaNhap;
			entity.DonGiaBan = donGiaBan;
			entity.DonViTinh = donViTinh;
			entity.ThanhTienNhap = thanhTienNhap;
			entity.ThanhTienBan = thanhTienBan;
			return entity.Insert();
		}
		
		public long Insert()
		{
			return this.Insert(null);
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public long Insert(SqlTransaction transaction)
		{			
			const string spName = "[dbo].[p_HoaDon_HangHoa_Insert]";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddOutParameter(dbCommand, "@Id", SqlDbType.BigInt, 8);
			db.AddInParameter(dbCommand, "@STT", SqlDbType.Int, STT);
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, HoaDonId);
			db.AddInParameter(dbCommand, "@MaHangHoa", SqlDbType.NVarChar, MaHangHoa);
			db.AddInParameter(dbCommand, "@TenHangHoa", SqlDbType.NVarChar, TenHangHoa);
			db.AddInParameter(dbCommand, "@SoLuong", SqlDbType.Decimal, SoLuong);
			db.AddInParameter(dbCommand, "@NhomHangHoaId", SqlDbType.BigInt, NhomHangHoaId);
			db.AddInParameter(dbCommand, "@DonGiaNhap", SqlDbType.Decimal, DonGiaNhap);
			db.AddInParameter(dbCommand, "@DonGiaBan", SqlDbType.Decimal, DonGiaBan);
			db.AddInParameter(dbCommand, "@DonViTinh", SqlDbType.NVarChar, DonViTinh);
			db.AddInParameter(dbCommand, "@ThanhTienNhap", SqlDbType.Decimal, ThanhTienNhap);
			db.AddInParameter(dbCommand, "@ThanhTienBan", SqlDbType.Decimal, ThanhTienBan);
			
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
		public static bool InsertCollection(List<HoaDon_HangHoa> collection)
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
						foreach (HoaDon_HangHoa item in collection)
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
		
		public static int InsertUpdateHoaDon_HangHoa(long id, int sTT, long hoaDonId, string maHangHoa, string tenHangHoa, decimal soLuong, long nhomHangHoaId, decimal donGiaNhap, decimal donGiaBan, string donViTinh, decimal thanhTienNhap, decimal thanhTienBan)
		{
			HoaDon_HangHoa entity = new HoaDon_HangHoa();			
			entity.Id = id;
			entity.STT = sTT;
			entity.HoaDonId = hoaDonId;
			entity.MaHangHoa = maHangHoa;
			entity.TenHangHoa = tenHangHoa;
			entity.SoLuong = soLuong;
			entity.NhomHangHoaId = nhomHangHoaId;
			entity.DonGiaNhap = donGiaNhap;
			entity.DonGiaBan = donGiaBan;
			entity.DonViTinh = donViTinh;
			entity.ThanhTienNhap = thanhTienNhap;
			entity.ThanhTienBan = thanhTienBan;
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
			const string spName = "p_HoaDon_HangHoa_InsertUpdate";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@STT", SqlDbType.Int, STT);
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, HoaDonId);
			db.AddInParameter(dbCommand, "@MaHangHoa", SqlDbType.NVarChar, MaHangHoa);
			db.AddInParameter(dbCommand, "@TenHangHoa", SqlDbType.NVarChar, TenHangHoa);
			db.AddInParameter(dbCommand, "@SoLuong", SqlDbType.Decimal, SoLuong);
			db.AddInParameter(dbCommand, "@NhomHangHoaId", SqlDbType.BigInt, NhomHangHoaId);
			db.AddInParameter(dbCommand, "@DonGiaNhap", SqlDbType.Decimal, DonGiaNhap);
			db.AddInParameter(dbCommand, "@DonGiaBan", SqlDbType.Decimal, DonGiaBan);
			db.AddInParameter(dbCommand, "@DonViTinh", SqlDbType.NVarChar, DonViTinh);
			db.AddInParameter(dbCommand, "@ThanhTienNhap", SqlDbType.Decimal, ThanhTienNhap);
			db.AddInParameter(dbCommand, "@ThanhTienBan", SqlDbType.Decimal, ThanhTienBan);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);			
		}
		
		//---------------------------------------------------------------------------------------------
		public static bool InsertUpdateCollection(List<HoaDon_HangHoa> collection)
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
						foreach (HoaDon_HangHoa item in collection)
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
		
		public static int UpdateHoaDon_HangHoa(long id, int sTT, long hoaDonId, string maHangHoa, string tenHangHoa, decimal soLuong, long nhomHangHoaId, decimal donGiaNhap, decimal donGiaBan, string donViTinh, decimal thanhTienNhap, decimal thanhTienBan)
		{
			HoaDon_HangHoa entity = new HoaDon_HangHoa();			
			entity.Id = id;
			entity.STT = sTT;
			entity.HoaDonId = hoaDonId;
			entity.MaHangHoa = maHangHoa;
			entity.TenHangHoa = tenHangHoa;
			entity.SoLuong = soLuong;
			entity.NhomHangHoaId = nhomHangHoaId;
			entity.DonGiaNhap = donGiaNhap;
			entity.DonGiaBan = donGiaBan;
			entity.DonViTinh = donViTinh;
			entity.ThanhTienNhap = thanhTienNhap;
			entity.ThanhTienBan = thanhTienBan;
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
			const string spName = "[dbo].[p_HoaDon_HangHoa_Update]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@STT", SqlDbType.Int, STT);
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, HoaDonId);
			db.AddInParameter(dbCommand, "@MaHangHoa", SqlDbType.NVarChar, MaHangHoa);
			db.AddInParameter(dbCommand, "@TenHangHoa", SqlDbType.NVarChar, TenHangHoa);
			db.AddInParameter(dbCommand, "@SoLuong", SqlDbType.Decimal, SoLuong);
			db.AddInParameter(dbCommand, "@NhomHangHoaId", SqlDbType.BigInt, NhomHangHoaId);
			db.AddInParameter(dbCommand, "@DonGiaNhap", SqlDbType.Decimal, DonGiaNhap);
			db.AddInParameter(dbCommand, "@DonGiaBan", SqlDbType.Decimal, DonGiaBan);
			db.AddInParameter(dbCommand, "@DonViTinh", SqlDbType.NVarChar, DonViTinh);
			db.AddInParameter(dbCommand, "@ThanhTienNhap", SqlDbType.Decimal, ThanhTienNhap);
			db.AddInParameter(dbCommand, "@ThanhTienBan", SqlDbType.Decimal, ThanhTienBan);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
				
		//---------------------------------------------------------------------------------------------
		public static bool UpdateCollection(List<HoaDon_HangHoa> collection)
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
						foreach (HoaDon_HangHoa item in collection)
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
		
		public static int DeleteHoaDon_HangHoa(long id)
		{
			HoaDon_HangHoa entity = new HoaDon_HangHoa();
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
			const string spName = "[dbo].[p_HoaDon_HangHoa_Delete]";		
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
			const string spName = "[dbo].[p_HoaDon_HangHoa_DeleteBy_HoaDonId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@HoaDonId", SqlDbType.BigInt, hoaDonId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		public static int DeleteBy_NhomHangHoaId(long nhomHangHoaId)
		{
			const string spName = "[dbo].[p_HoaDon_HangHoa_DeleteBy_NhomHangHoaId]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@NhomHangHoaId", SqlDbType.BigInt, nhomHangHoaId);
						
            return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
			
		
		public static int DeleteDynamic(string whereCondition)
		{
			const string spName = "[dbo].[p_HoaDon_HangHoa_DeleteDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            
            return db.ExecuteNonQuery(dbCommand);   
		}
		//---------------------------------------------------------------------------------------------
		
		public static bool DeleteCollection(List<HoaDon_HangHoa> collection)
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
						foreach (HoaDon_HangHoa item in collection)
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