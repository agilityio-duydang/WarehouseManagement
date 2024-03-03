using System;
using System.Data;
using System.Data.SqlClient;
using Company.WM.BLL;

namespace Company.WM.BLL.Administration
{
	public partial class ROLE : EntityBase
	{
		#region Private members.
		
		protected long _ID;
		protected string _RoleName = String.Empty;
		protected string _MO_TA = String.Empty;
		protected int _ID_MODULE;

		#endregion
		
		//---------------------------------------------------------------------------------------------

		#region Properties.
		
		public long ID
		{
			set {this._ID = value;}
			get {return this._ID;}
		}
		public string RoleName
		{
			set {this._RoleName = value;}
			get {return this._RoleName;}
		}
		public string MO_TA
		{
			set {this._MO_TA = value;}
			get {return this._MO_TA;}
		}
		public int ID_MODULE
		{
			set {this._ID_MODULE = value;}
			get {return this._ID_MODULE;}
		}
		
		//---------------------------------------------------------------------------------------------
        
		public bool IsExist
        {
            get 
            { 
                return this.Load();  
            }
        }
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Select methods.
		
		public bool Load()
		{
			string spName = "p_ROLE_Load";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@ID", SqlDbType.BigInt, this._ID);
			
            IDataReader reader = this.db.ExecuteReader(dbCommand);
			if (reader.Read())
			{
				if (!reader.IsDBNull(reader.GetOrdinal("ID"))) this._ID = reader.GetInt64(reader.GetOrdinal("ID"));
				if (!reader.IsDBNull(reader.GetOrdinal("RoleName"))) this._RoleName = reader.GetString(reader.GetOrdinal("RoleName"));
				if (!reader.IsDBNull(reader.GetOrdinal("MO_TA"))) this._MO_TA = reader.GetString(reader.GetOrdinal("MO_TA"));
				if (!reader.IsDBNull(reader.GetOrdinal("ID_MODULE"))) this._ID_MODULE = reader.GetInt32(reader.GetOrdinal("ID_MODULE"));
				return true;
			}
			return false;
		}		
		
		//---------------------------------------------------------------------------------------------
		


		public DataSet SelectAll()
        {
            string spName = "p_ROLE_SelectAll";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
            return this.db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------

		public IDataReader SelectReaderAll()
        {
            string spName = "p_ROLE_SelectAll";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
            return this.db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            string spName = "p_ROLE_SelectDynamic";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);

			this.db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            this.db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return this.db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------

		public IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            string spName = "p_ROLE_SelectDynamic";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);

			this.db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            this.db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return this.db.ExecuteReader(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
		
		public ROLECollection SelectCollectionAll()
		{
			ROLECollection collection = new ROLECollection();

			IDataReader reader = this.SelectReaderAll();
			while (reader.Read())
			{
				ROLE entity = new ROLE();
				
				if (!reader.IsDBNull(reader.GetOrdinal("ID"))) entity.ID = reader.GetInt64(reader.GetOrdinal("ID"));
				if (!reader.IsDBNull(reader.GetOrdinal("RoleName"))) entity.RoleName = reader.GetString(reader.GetOrdinal("RoleName"));
				if (!reader.IsDBNull(reader.GetOrdinal("MO_TA"))) entity.MO_TA = reader.GetString(reader.GetOrdinal("MO_TA"));
				if (!reader.IsDBNull(reader.GetOrdinal("ID_MODULE"))) entity.ID_MODULE = reader.GetInt32(reader.GetOrdinal("ID_MODULE"));
				collection.Add(entity);
			}
			return collection;			
		}
		
		//---------------------------------------------------------------------------------------------
		
		public ROLECollection SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			ROLECollection collection = new ROLECollection();

			IDataReader reader = this.SelectReaderDynamic(whereCondition, orderByExpression);
			while (reader.Read())
			{
				ROLE entity = new ROLE();
				
				if (!reader.IsDBNull(reader.GetOrdinal("ID"))) entity.ID = reader.GetInt64(reader.GetOrdinal("ID"));
				if (!reader.IsDBNull(reader.GetOrdinal("RoleName"))) entity.RoleName = reader.GetString(reader.GetOrdinal("RoleName"));
				if (!reader.IsDBNull(reader.GetOrdinal("MO_TA"))) entity.MO_TA = reader.GetString(reader.GetOrdinal("MO_TA"));
				if (!reader.IsDBNull(reader.GetOrdinal("ID_MODULE"))) entity.ID_MODULE = reader.GetInt32(reader.GetOrdinal("ID_MODULE"));
				collection.Add(entity);
			}
			return collection;			
		}
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert methods.
		
		public long Insert()
		{
			return this.InsertTransaction(null);
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public long InsertTransaction(SqlTransaction transaction)
		{			
			string spName = "p_ROLE_Insert";		
			SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			this.db.AddOutParameter(dbCommand, "@ID", SqlDbType.BigInt, 8);
			this.db.AddInParameter(dbCommand, "@RoleName", SqlDbType.NVarChar, this._RoleName);
			this.db.AddInParameter(dbCommand, "@MO_TA", SqlDbType.NVarChar, this._MO_TA);
			this.db.AddInParameter(dbCommand, "@ID_MODULE", SqlDbType.Int, this._ID_MODULE);
			
			if (transaction != null)
			{
				this.db.ExecuteNonQuery(dbCommand, transaction);
				this._ID = (long) this.db.GetParameterValue(dbCommand, "@ID");
				return this._ID;
			}
            else
			{
				this.db.ExecuteNonQuery(dbCommand);
				this._ID = (long) this.db.GetParameterValue(dbCommand, "@ID");
				return this._ID;
			}			
		}
		
		//---------------------------------------------------------------------------------------------
		
		public bool Insert(ROLECollection collection)
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
					bool ret01 = true;
                    foreach (ROLE item in collection)
                    {
                        if (item.InsertTransaction(transaction) <= 0)
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
                catch
                {
                    ret = false;
                    transaction.Rollback();
                }
                finally 
                {
                    connection.Close();
                }
            }
            return ret;		
		}
		
		//---------------------------------------------------------------------------------------------		
        
		public void InsertTransaction(SqlTransaction transaction, ROLECollection collection)
        {
            foreach (ROLE item in collection)
            {
               	item.InsertTransaction(transaction);
            }
        }
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Insert / Update methods.
		public int InsertUpdate()
		{
			return this.InsertUpdateTransaction(null);
		}
		
		//---------------------------------------------------------------------------------------------

		public int InsertUpdateTransaction(SqlTransaction transaction)
		{			
			string spName = "p_ROLE_InsertUpdate";		
			SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			this.db.AddInParameter(dbCommand, "@ID", SqlDbType.BigInt, this._ID);
			this.db.AddInParameter(dbCommand, "@RoleName", SqlDbType.NVarChar, this._RoleName);
			this.db.AddInParameter(dbCommand, "@MO_TA", SqlDbType.NVarChar, this._MO_TA);
			this.db.AddInParameter(dbCommand, "@ID_MODULE", SqlDbType.Int, this._ID_MODULE);
			
			if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);			
		}
		
		//---------------------------------------------------------------------------------------------
		
		public bool InsertUpdate(ROLECollection collection)
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
					bool ret01 = true;
                    foreach (ROLE item in collection)
                    {
                        if (item.InsertUpdateTransaction(transaction) <= 0)
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
                catch
                {
                    ret = false;
                    transaction.Rollback();
                }
                finally 
                {
                    connection.Close();
                }
            }
            return ret;		
		}		
		
		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Update methods.
		
		public int Update()
		{
			return this.UpdateTransaction(null);
		}
		
		//---------------------------------------------------------------------------------------------

		public int UpdateTransaction(SqlTransaction transaction)
		{
			string spName = "p_ROLE_Update";		
			SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);

			this.db.AddInParameter(dbCommand, "@ID", SqlDbType.BigInt, this._ID);
			this.db.AddInParameter(dbCommand, "@RoleName", SqlDbType.NVarChar, this._RoleName);
			this.db.AddInParameter(dbCommand, "@MO_TA", SqlDbType.NVarChar, this._MO_TA);
			this.db.AddInParameter(dbCommand, "@ID_MODULE", SqlDbType.Int, this._ID_MODULE);
			
			if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
		
		public void UpdateCollection(ROLECollection collection, SqlTransaction transaction)
        {
            foreach (ROLE item in collection)
            {
                item.UpdateTransaction(transaction);
            }
        }

		#endregion
		
		//---------------------------------------------------------------------------------------------
		
		#region Delete methods.
		
		public int Delete()
		{
			return this.DeleteTransaction(null);
		}
		
		//---------------------------------------------------------------------------------------------

		public int DeleteTransaction(SqlTransaction transaction)
		{
			string spName = "p_ROLE_Delete";		
			SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@ID", SqlDbType.BigInt, this._ID);
			
			if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
		
        public void DeleteCollection(ROLECollection collection, SqlTransaction transaction)
        {
            foreach (ROLE item in collection)
            {
                item.DeleteTransaction(transaction);
            }
        }

		//---------------------------------------------------------------------------------------------
		
		public bool DeleteCollection(ROLECollection collection)
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
					bool ret01 = true;
                    foreach (ROLE item in collection)
                    {
                        if (item.DeleteTransaction(transaction) <= 0)
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
                catch
                {
                    ret = false;
                    transaction.Rollback();
                }
                finally 
                {
                    connection.Close();
                }
            }
            return ret;		
		}
		#endregion
	}	
}