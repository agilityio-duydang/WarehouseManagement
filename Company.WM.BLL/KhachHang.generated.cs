﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace Company.WM.BLL
{
	public partial class KhachHang : ICloneable
	{
		#region Properties.
		
		public long Id { set; get; }
		public string MaKhachHang { set; get; }
		public string TenKhachHang { set; get; }
		public string DiaChi { set; get; }
		public string Email { set; get; }
		public string SoDienThoai { set; get; }
		public string GhiChu { set; get; }
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Methods
		protected static List<KhachHang> ConvertToCollection(IDataReader reader)
		{
			List<KhachHang> collection = new List<KhachHang>();
			while (reader.Read())
			{
				KhachHang entity = new KhachHang();
				if (!reader.IsDBNull(reader.GetOrdinal("Id"))) entity.Id = reader.GetInt64(reader.GetOrdinal("Id"));
				if (!reader.IsDBNull(reader.GetOrdinal("MaKhachHang"))) entity.MaKhachHang = reader.GetString(reader.GetOrdinal("MaKhachHang"));
				if (!reader.IsDBNull(reader.GetOrdinal("TenKhachHang"))) entity.TenKhachHang = reader.GetString(reader.GetOrdinal("TenKhachHang"));
				if (!reader.IsDBNull(reader.GetOrdinal("DiaChi"))) entity.DiaChi = reader.GetString(reader.GetOrdinal("DiaChi"));
				if (!reader.IsDBNull(reader.GetOrdinal("Email"))) entity.Email = reader.GetString(reader.GetOrdinal("Email"));
				if (!reader.IsDBNull(reader.GetOrdinal("SoDienThoai"))) entity.SoDienThoai = reader.GetString(reader.GetOrdinal("SoDienThoai"));
				if (!reader.IsDBNull(reader.GetOrdinal("GhiChu"))) entity.GhiChu = reader.GetString(reader.GetOrdinal("GhiChu"));
				collection.Add(entity);
			}
			reader.Close();
			return collection;
		}
		
		public static bool Find(List<KhachHang> collection, long id)
        {
            foreach (KhachHang item in collection)
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
            string insert = "Insert INTO t_KhachHang VALUES(@MaKhachHang, @TenKhachHang, @DiaChi, @Email, @SoDienThoai, @GhiChu)";
            string update = "UPDATE t_KhachHang SET MaKhachHang = @MaKhachHang, TenKhachHang = @TenKhachHang, DiaChi = @DiaChi, Email = @Email, SoDienThoai = @SoDienThoai, GhiChu = @GhiChu WHERE Id = @Id";
            string delete = "DELETE FROM t_KhachHang WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaKhachHang", SqlDbType.NVarChar, "MaKhachHang", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TenKhachHang", SqlDbType.NVarChar, "TenKhachHang", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@DiaChi", SqlDbType.NVarChar, "DiaChi", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@Email", SqlDbType.NVarChar, "Email", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@SoDienThoai", SqlDbType.NVarChar, "SoDienThoai", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaKhachHang", SqlDbType.NVarChar, "MaKhachHang", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TenKhachHang", SqlDbType.NVarChar, "TenKhachHang", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@DiaChi", SqlDbType.NVarChar, "DiaChi", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@Email", SqlDbType.NVarChar, "Email", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@SoDienThoai", SqlDbType.NVarChar, "SoDienThoai", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, ds.Tables[0].TableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }
				
		public static void UpdateDataSet(DataSet ds, string tableName)
        {
            string insert = "Insert INTO t_KhachHang VALUES(@MaKhachHang, @TenKhachHang, @DiaChi, @Email, @SoDienThoai, @GhiChu)";
            string update = "UPDATE t_KhachHang SET MaKhachHang = @MaKhachHang, TenKhachHang = @TenKhachHang, DiaChi = @DiaChi, Email = @Email, SoDienThoai = @SoDienThoai, GhiChu = @GhiChu WHERE Id = @Id";
            string delete = "DELETE FROM t_KhachHang WHERE Id = @Id";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@MaKhachHang", SqlDbType.NVarChar, "MaKhachHang", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@TenKhachHang", SqlDbType.NVarChar, "TenKhachHang", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@DiaChi", SqlDbType.NVarChar, "DiaChi", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@Email", SqlDbType.NVarChar, "Email", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@SoDienThoai", SqlDbType.NVarChar, "SoDienThoai", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@MaKhachHang", SqlDbType.NVarChar, "MaKhachHang", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@TenKhachHang", SqlDbType.NVarChar, "TenKhachHang", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@DiaChi", SqlDbType.NVarChar, "DiaChi", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@Email", SqlDbType.NVarChar, "Email", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@SoDienThoai", SqlDbType.NVarChar, "SoDienThoai", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@GhiChu", SqlDbType.NVarChar, "GhiChu", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@Id", SqlDbType.BigInt, "Id", DataRowVersion.Current);

            db.UpdateDataSet(ds, tableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }

		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Select methods.
		
		public static KhachHang Load(long id)
		{
			const string spName = "[dbo].[p_KhachHang_Load]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, id);
            IDataReader reader = db.ExecuteReader(dbCommand);
			List<KhachHang> collection = ConvertToCollection(reader);	
			if (collection.Count > 0)
			{
				return collection[0];
			}
			return null;
		}		
		
		//---------------------------------------------------------------------------------------------
		public static List<KhachHang> SelectCollectionAll()
		{
			IDataReader reader = SelectReaderAll();
			return ConvertToCollection(reader);			
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public static List<KhachHang> SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			IDataReader reader = SelectReaderDynamic(whereCondition, orderByExpression);
			return ConvertToCollection(reader);		
		}
		
		//---------------------------------------------------------------------------------------------
		
		// Select by foreign key return collection		
		

		public static DataSet SelectAll()
        {
            const string spName = "[dbo].[p_KhachHang_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			
            return db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_KhachHang_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
				
		public static IDataReader SelectReaderAll()
        {
            const string spName = "[dbo].[p_KhachHang_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
            return db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_KhachHang_SelectDynamic]";
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
		
		public static long InsertKhachHang(string maKhachHang, string tenKhachHang, string diaChi, string email, string soDienThoai, string ghiChu)
		{
			KhachHang entity = new KhachHang();	
			entity.MaKhachHang = maKhachHang;
			entity.TenKhachHang = tenKhachHang;
			entity.DiaChi = diaChi;
			entity.Email = email;
			entity.SoDienThoai = soDienThoai;
			entity.GhiChu = ghiChu;
			return entity.Insert();
		}
		
		public long Insert()
		{
			return this.Insert(null);
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public long Insert(SqlTransaction transaction)
		{			
			const string spName = "[dbo].[p_KhachHang_Insert]";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddOutParameter(dbCommand, "@Id", SqlDbType.BigInt, 8);
			db.AddInParameter(dbCommand, "@MaKhachHang", SqlDbType.NVarChar, MaKhachHang);
			db.AddInParameter(dbCommand, "@TenKhachHang", SqlDbType.NVarChar, TenKhachHang);
			db.AddInParameter(dbCommand, "@DiaChi", SqlDbType.NVarChar, DiaChi);
			db.AddInParameter(dbCommand, "@Email", SqlDbType.NVarChar, Email);
			db.AddInParameter(dbCommand, "@SoDienThoai", SqlDbType.NVarChar, SoDienThoai);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			
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
		public static bool InsertCollection(List<KhachHang> collection)
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
						foreach (KhachHang item in collection)
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
		
		public static int InsertUpdateKhachHang(long id, string maKhachHang, string tenKhachHang, string diaChi, string email, string soDienThoai, string ghiChu)
		{
			KhachHang entity = new KhachHang();			
			entity.Id = id;
			entity.MaKhachHang = maKhachHang;
			entity.TenKhachHang = tenKhachHang;
			entity.DiaChi = diaChi;
			entity.Email = email;
			entity.SoDienThoai = soDienThoai;
			entity.GhiChu = ghiChu;
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
			const string spName = "p_KhachHang_InsertUpdate";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@MaKhachHang", SqlDbType.NVarChar, MaKhachHang);
			db.AddInParameter(dbCommand, "@TenKhachHang", SqlDbType.NVarChar, TenKhachHang);
			db.AddInParameter(dbCommand, "@DiaChi", SqlDbType.NVarChar, DiaChi);
			db.AddInParameter(dbCommand, "@Email", SqlDbType.NVarChar, Email);
			db.AddInParameter(dbCommand, "@SoDienThoai", SqlDbType.NVarChar, SoDienThoai);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);			
		}
		
		//---------------------------------------------------------------------------------------------
		public static bool InsertUpdateCollection(List<KhachHang> collection)
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
						foreach (KhachHang item in collection)
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
		
		public static int UpdateKhachHang(long id, string maKhachHang, string tenKhachHang, string diaChi, string email, string soDienThoai, string ghiChu)
		{
			KhachHang entity = new KhachHang();			
			entity.Id = id;
			entity.MaKhachHang = maKhachHang;
			entity.TenKhachHang = tenKhachHang;
			entity.DiaChi = diaChi;
			entity.Email = email;
			entity.SoDienThoai = soDienThoai;
			entity.GhiChu = ghiChu;
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
			const string spName = "[dbo].[p_KhachHang_Update]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@Id", SqlDbType.BigInt, Id);
			db.AddInParameter(dbCommand, "@MaKhachHang", SqlDbType.NVarChar, MaKhachHang);
			db.AddInParameter(dbCommand, "@TenKhachHang", SqlDbType.NVarChar, TenKhachHang);
			db.AddInParameter(dbCommand, "@DiaChi", SqlDbType.NVarChar, DiaChi);
			db.AddInParameter(dbCommand, "@Email", SqlDbType.NVarChar, Email);
			db.AddInParameter(dbCommand, "@SoDienThoai", SqlDbType.NVarChar, SoDienThoai);
			db.AddInParameter(dbCommand, "@GhiChu", SqlDbType.NVarChar, GhiChu);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
				
		//---------------------------------------------------------------------------------------------
		public static bool UpdateCollection(List<KhachHang> collection)
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
						foreach (KhachHang item in collection)
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
		
		public static int DeleteKhachHang(long id)
		{
			KhachHang entity = new KhachHang();
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
			const string spName = "[dbo].[p_KhachHang_Delete]";		
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
			const string spName = "[dbo].[p_KhachHang_DeleteDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            
            return db.ExecuteNonQuery(dbCommand);   
		}
		//---------------------------------------------------------------------------------------------
		
		public static bool DeleteCollection(List<KhachHang> collection)
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
						foreach (KhachHang item in collection)
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