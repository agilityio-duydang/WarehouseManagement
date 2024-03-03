using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace Company.WM.BLL.Administration
{
	public partial class User : ICloneable
	{
		#region Properties.

        public string UserName { set; get; }
		public string Password { set; get; }
		public string FullName { set; get; }
		public string SoDienThoai { set; get; }
		public string DiaChi { set; get; }
		public string Email { set; get; }
		public bool isAdmin { set; get; }
		public long ID { set; get; }
		public bool isOnline { set; get; }
		public string HostName { set; get; }
		public string IP { set; get; }
		public string DataBase { set; get; }
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Methods
		protected static List<User> ConvertToCollection(IDataReader reader)
		{
			List<User> collection = new List<User>();
			while (reader.Read())
			{
				User entity = new User();
				if (!reader.IsDBNull(reader.GetOrdinal("UserName"))) entity.UserName = reader.GetString(reader.GetOrdinal("UserName"));
				if (!reader.IsDBNull(reader.GetOrdinal("Password"))) entity.Password = reader.GetString(reader.GetOrdinal("Password"));
				if (!reader.IsDBNull(reader.GetOrdinal("FullName"))) entity.FullName = reader.GetString(reader.GetOrdinal("FullName"));
				if (!reader.IsDBNull(reader.GetOrdinal("SoDienThoai"))) entity.SoDienThoai = reader.GetString(reader.GetOrdinal("SoDienThoai"));
				if (!reader.IsDBNull(reader.GetOrdinal("DiaChi"))) entity.DiaChi = reader.GetString(reader.GetOrdinal("DiaChi"));
				if (!reader.IsDBNull(reader.GetOrdinal("Email"))) entity.Email = reader.GetString(reader.GetOrdinal("Email"));
				if (!reader.IsDBNull(reader.GetOrdinal("isAdmin"))) entity.isAdmin = reader.GetBoolean(reader.GetOrdinal("isAdmin"));
				if (!reader.IsDBNull(reader.GetOrdinal("ID"))) entity.ID = reader.GetInt64(reader.GetOrdinal("ID"));
				if (!reader.IsDBNull(reader.GetOrdinal("isOnline"))) entity.isOnline = reader.GetBoolean(reader.GetOrdinal("isOnline"));
				if (!reader.IsDBNull(reader.GetOrdinal("HostName"))) entity.HostName = reader.GetString(reader.GetOrdinal("HostName"));
				if (!reader.IsDBNull(reader.GetOrdinal("IP"))) entity.IP = reader.GetString(reader.GetOrdinal("IP"));
				if (!reader.IsDBNull(reader.GetOrdinal("DataBase"))) entity.DataBase = reader.GetString(reader.GetOrdinal("DataBase"));
				collection.Add(entity);
			}
			reader.Close();
			return collection;
		}
		
		public static bool Find(List<User> collection, long id)
        {
            foreach (User item in collection)
            {
                if (item.ID == id)
                {
                    return true;
                }
            }

            return false;
        }
		
		public static void UpdateDataSet(DataSet ds)
        {
            string insert = "Insert INTO User VALUES(@UserName, @Password, @FullName, @SoDienThoai, @DiaChi, @Email, @isAdmin, @isOnline, @HostName, @IP, @DataBase)";
            string update = "UPDATE User SET UserName = @UserName, Password = @Password, FullName = @FullName, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, Email = @Email, isAdmin = @isAdmin, isOnline = @isOnline, HostName = @HostName, IP = @IP, DataBase = @DataBase WHERE ID = @ID";
            string delete = "DELETE FROM User WHERE ID = @ID";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@UserName", SqlDbType.VarChar, "UserName", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@Password", SqlDbType.VarChar, "Password", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@FullName", SqlDbType.NVarChar, "FullName", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@SoDienThoai", SqlDbType.NVarChar, "SoDienThoai", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@DiaChi", SqlDbType.NVarChar, "DiaChi", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@Email", SqlDbType.NVarChar, "Email", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@isAdmin", SqlDbType.Bit, "isAdmin", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ID", SqlDbType.BigInt, "ID", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@isOnline", SqlDbType.Bit, "isOnline", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@HostName", SqlDbType.VarChar, "HostName", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@IP", SqlDbType.VarChar, "IP", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@DataBase", SqlDbType.VarChar, "DataBase", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@UserName", SqlDbType.VarChar, "UserName", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@Password", SqlDbType.VarChar, "Password", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@FullName", SqlDbType.NVarChar, "FullName", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@SoDienThoai", SqlDbType.NVarChar, "SoDienThoai", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@DiaChi", SqlDbType.NVarChar, "DiaChi", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@Email", SqlDbType.NVarChar, "Email", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@isAdmin", SqlDbType.Bit, "isAdmin", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ID", SqlDbType.BigInt, "ID", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@isOnline", SqlDbType.Bit, "isOnline", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@HostName", SqlDbType.VarChar, "HostName", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@IP", SqlDbType.VarChar, "IP", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@DataBase", SqlDbType.VarChar, "DataBase", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@ID", SqlDbType.BigInt, "ID", DataRowVersion.Current);

            db.UpdateDataSet(ds, ds.Tables[0].TableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }
				
		public static void UpdateDataSet(DataSet ds, string tableName)
        {
            string insert = "Insert INTO User VALUES(@UserName, @Password, @FullName, @SoDienThoai, @DiaChi, @Email, @isAdmin, @isOnline, @HostName, @IP, @DataBase)";
            string update = "UPDATE User SET UserName = @UserName, Password = @Password, FullName = @FullName, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, Email = @Email, isAdmin = @isAdmin, isOnline = @isOnline, HostName = @HostName, IP = @IP, DataBase = @DataBase WHERE ID = @ID";
            string delete = "DELETE FROM User WHERE ID = @ID";

			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();

            System.Data.Common.DbCommand InsertCommand = db.GetSqlStringCommand(insert);
			db.AddInParameter(InsertCommand, "@UserName", SqlDbType.VarChar, "UserName", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@Password", SqlDbType.VarChar, "Password", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@FullName", SqlDbType.NVarChar, "FullName", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@SoDienThoai", SqlDbType.NVarChar, "SoDienThoai", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@DiaChi", SqlDbType.NVarChar, "DiaChi", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@Email", SqlDbType.NVarChar, "Email", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@isAdmin", SqlDbType.Bit, "isAdmin", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@ID", SqlDbType.BigInt, "ID", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@isOnline", SqlDbType.Bit, "isOnline", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@HostName", SqlDbType.VarChar, "HostName", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@IP", SqlDbType.VarChar, "IP", DataRowVersion.Current);
			db.AddInParameter(InsertCommand, "@DataBase", SqlDbType.VarChar, "DataBase", DataRowVersion.Current);

            System.Data.Common.DbCommand UpdateCommand = db.GetSqlStringCommand(update);
			db.AddInParameter(UpdateCommand, "@UserName", SqlDbType.VarChar, "UserName", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@Password", SqlDbType.VarChar, "Password", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@FullName", SqlDbType.NVarChar, "FullName", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@SoDienThoai", SqlDbType.NVarChar, "SoDienThoai", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@DiaChi", SqlDbType.NVarChar, "DiaChi", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@Email", SqlDbType.NVarChar, "Email", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@isAdmin", SqlDbType.Bit, "isAdmin", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@ID", SqlDbType.BigInt, "ID", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@isOnline", SqlDbType.Bit, "isOnline", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@HostName", SqlDbType.VarChar, "HostName", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@IP", SqlDbType.VarChar, "IP", DataRowVersion.Current);
			db.AddInParameter(UpdateCommand, "@DataBase", SqlDbType.VarChar, "DataBase", DataRowVersion.Current);
			
            System.Data.Common.DbCommand DeleteCommand = db.GetSqlStringCommand(delete);
			db.AddInParameter(DeleteCommand, "@ID", SqlDbType.BigInt, "ID", DataRowVersion.Current);

            db.UpdateDataSet(ds, tableName, InsertCommand, UpdateCommand, DeleteCommand, UpdateBehavior.Standard);
        }

		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Select methods.
		
		public static User Load(long id)
		{
			const string spName = "[dbo].[p_User_Load]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@ID", SqlDbType.BigInt, id);
            IDataReader reader = db.ExecuteReader(dbCommand);
			List<User> collection = ConvertToCollection(reader);	
			if (collection.Count > 0)
			{
				return collection[0];
			}
			return null;
		}		
		
		//---------------------------------------------------------------------------------------------
		

		public static DataSet SelectAll()
        {
            const string spName = "[dbo].[p_User_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			
            return db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_User_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
				
		public static IDataReader SelectReaderAll()
        {
            const string spName = "[dbo].[p_User_SelectAll]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
            return db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public static IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            const string spName = "[dbo].[p_User_SelectDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return db.ExecuteReader(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
		
        // Select by foreign key return collection		
        public static List<User> SelectCollectionAll()
        {
            IDataReader reader = SelectReaderAll();
            return ConvertToCollection(reader);
        }
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert methods.
		
		public static long InsertUser(string userName, string password, string fullName, string soDienThoai, string diaChi, string email, bool isAdmin, bool isOnline, string hostName, string iP, string dataBase)
		{
			User entity = new User();	
			entity.UserName = userName;
			entity.Password = password;
			entity.FullName = fullName;
			entity.SoDienThoai = soDienThoai;
			entity.DiaChi = diaChi;
			entity.Email = email;
			entity.isAdmin = isAdmin;
			entity.isOnline = isOnline;
			entity.HostName = hostName;
			entity.IP = iP;
			entity.DataBase = dataBase;
			return entity.Insert();
		}
		
		public long Insert()
		{
			return this.Insert(null);
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public long Insert(SqlTransaction transaction)
		{			
			const string spName = "[dbo].[p_User_Insert]";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@UserName", SqlDbType.VarChar, UserName);
			db.AddInParameter(dbCommand, "@Password", SqlDbType.VarChar, Password);
			db.AddInParameter(dbCommand, "@FullName", SqlDbType.NVarChar, FullName);
			db.AddInParameter(dbCommand, "@SoDienThoai", SqlDbType.NVarChar, SoDienThoai);
			db.AddInParameter(dbCommand, "@DiaChi", SqlDbType.NVarChar, DiaChi);
			db.AddInParameter(dbCommand, "@Email", SqlDbType.NVarChar, Email);
			db.AddInParameter(dbCommand, "@isAdmin", SqlDbType.Bit, isAdmin);
			db.AddOutParameter(dbCommand, "@ID", SqlDbType.BigInt, 8);
			db.AddInParameter(dbCommand, "@isOnline", SqlDbType.Bit, isOnline);
			db.AddInParameter(dbCommand, "@HostName", SqlDbType.VarChar, HostName);
			db.AddInParameter(dbCommand, "@IP", SqlDbType.VarChar, IP);
			db.AddInParameter(dbCommand, "@DataBase", SqlDbType.VarChar, DataBase);
			
			if (transaction != null)
			{
				db.ExecuteNonQuery(dbCommand, transaction);
				ID = (long) db.GetParameterValue(dbCommand, "@UserName");
				return ID;
			}
            else
			{
				db.ExecuteNonQuery(dbCommand);
				ID = (long) db.GetParameterValue(dbCommand, "@UserName");
				return ID;
			}			
		}
				
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert / Update methods.
		
		public static int InsertUpdateUser(string userName, string password, string fullName, string soDienThoai, string diaChi, string email, bool isAdmin, long id, bool isOnline, string hostName, string iP, string dataBase)
		{
			User entity = new User();			
			entity.UserName = userName;
			entity.Password = password;
			entity.FullName = fullName;
			entity.SoDienThoai = soDienThoai;
			entity.DiaChi = diaChi;
			entity.Email = email;
			entity.isAdmin = isAdmin;
			entity.ID = id;
			entity.isOnline = isOnline;
			entity.HostName = hostName;
			entity.IP = iP;
			entity.DataBase = dataBase;
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
			const string spName = "p_User_InsertUpdate";		
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@UserName", SqlDbType.VarChar, UserName);
			db.AddInParameter(dbCommand, "@Password", SqlDbType.VarChar, Password);
			db.AddInParameter(dbCommand, "@FullName", SqlDbType.NVarChar, FullName);
			db.AddInParameter(dbCommand, "@SoDienThoai", SqlDbType.NVarChar, SoDienThoai);
			db.AddInParameter(dbCommand, "@DiaChi", SqlDbType.NVarChar, DiaChi);
			db.AddInParameter(dbCommand, "@Email", SqlDbType.NVarChar, Email);
			db.AddInParameter(dbCommand, "@isAdmin", SqlDbType.Bit, isAdmin);
			db.AddInParameter(dbCommand, "@ID", SqlDbType.BigInt, ID);
			db.AddInParameter(dbCommand, "@isOnline", SqlDbType.Bit, isOnline);
			db.AddInParameter(dbCommand, "@HostName", SqlDbType.VarChar, HostName);
			db.AddInParameter(dbCommand, "@IP", SqlDbType.VarChar, IP);
			db.AddInParameter(dbCommand, "@DataBase", SqlDbType.VarChar, DataBase);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);			
		}
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Update methods.
		
		public static int UpdateUser(string userName, string password, string fullName, string soDienThoai, string diaChi, string email, bool isAdmin, long id, bool isOnline, string hostName, string iP, string dataBase)
		{
			User entity = new User();			
			entity.UserName = userName;
			entity.Password = password;
			entity.FullName = fullName;
			entity.SoDienThoai = soDienThoai;
			entity.DiaChi = diaChi;
			entity.Email = email;
			entity.isAdmin = isAdmin;
			entity.ID = id;
			entity.isOnline = isOnline;
			entity.HostName = hostName;
			entity.IP = iP;
			entity.DataBase = dataBase;
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
			const string spName = "[dbo].[p_User_Update]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@UserName", SqlDbType.VarChar, UserName);
			db.AddInParameter(dbCommand, "@Password", SqlDbType.VarChar, Password);
			db.AddInParameter(dbCommand, "@FullName", SqlDbType.NVarChar, FullName);
			db.AddInParameter(dbCommand, "@SoDienThoai", SqlDbType.NVarChar, SoDienThoai);
			db.AddInParameter(dbCommand, "@DiaChi", SqlDbType.NVarChar, DiaChi);
			db.AddInParameter(dbCommand, "@Email", SqlDbType.NVarChar, Email);
			db.AddInParameter(dbCommand, "@isAdmin", SqlDbType.Bit, isAdmin);
			db.AddInParameter(dbCommand, "@ID", SqlDbType.BigInt, ID);
			db.AddInParameter(dbCommand, "@isOnline", SqlDbType.Bit, isOnline);
			db.AddInParameter(dbCommand, "@HostName", SqlDbType.VarChar, HostName);
			db.AddInParameter(dbCommand, "@IP", SqlDbType.VarChar, IP);
			db.AddInParameter(dbCommand, "@DataBase", SqlDbType.VarChar, DataBase);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
				
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Delete methods.
		
		public static int DeleteUser(long id)
		{
			User entity = new User();
			entity.ID = id;
			
			return entity.Delete();
		}
		
		public int Delete()
		{
			return this.Delete(null);
		}
		
		//---------------------------------------------------------------------------------------------

		public int Delete(SqlTransaction transaction)
		{
			const string spName = "[dbo].[p_User_Delete]";		
			SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
			SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);
			
			db.AddInParameter(dbCommand, "@ID", SqlDbType.BigInt, ID);
			
			if (transaction != null)
                return db.ExecuteNonQuery(dbCommand, transaction);
            else
                return db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
		
		
		public static int DeleteDynamic(string whereCondition)
		{
			const string spName = "[dbo].[p_User_DeleteDynamic]";
            SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
            SqlCommand dbCommand = (SqlCommand) db.GetStoredProcCommand(spName);

			db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            
            return db.ExecuteNonQuery(dbCommand);   
		}
		//---------------------------------------------------------------------------------------------
		
		#endregion
		
		
        #region ICloneable Members

        public object Clone()
        {
            return base.MemberwiseClone();
        }

        #endregion
	}	
}