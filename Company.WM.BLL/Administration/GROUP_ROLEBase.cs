using System;
using System.Data;
using System.Data.SqlClient;
using Company.WM.BLL;

namespace Company.WM.BLL.Administration
{
	public partial class GROUP_ROLE : EntityBase
	{
		#region Private members.
		
		protected long _GROUP_ID;
		protected long _ID_ROLE;

		#endregion
		
		//---------------------------------------------------------------------------------------------

		#region Properties.
		
		public long GROUP_ID
		{
			set {this._GROUP_ID = value;}
			get {return this._GROUP_ID;}
		}
		public long ID_ROLE
		{
			set {this._ID_ROLE = value;}
			get {return this._ID_ROLE;}
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
			string spName = "p_GROUP_ROLE_Load";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@GROUP_ID", SqlDbType.BigInt, this._GROUP_ID);
			this.db.AddInParameter(dbCommand, "@ID_ROLE", SqlDbType.BigInt, this._ID_ROLE);
			
            IDataReader reader = this.db.ExecuteReader(dbCommand);
			if (reader.Read())
			{
				if (!reader.IsDBNull(reader.GetOrdinal("GROUP_ID"))) this._GROUP_ID = reader.GetInt64(reader.GetOrdinal("GROUP_ID"));
				if (!reader.IsDBNull(reader.GetOrdinal("ID_ROLE"))) this._ID_ROLE = reader.GetInt64(reader.GetOrdinal("ID_ROLE"));
				return true;
			}
			return false;
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public GROUP_ROLECollection SelectCollectionBy_GROUP_ID()
		{
			string spName = "p_GROUP_ROLE_SelectBy_GROUP_ID";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@GROUP_ID", SqlDbType.BigInt, this._GROUP_ID);
			
			GROUP_ROLECollection collection = new GROUP_ROLECollection();
            IDataReader reader = this.db.ExecuteReader(dbCommand);
			while (reader.Read())
			{
				GROUP_ROLE entity = new GROUP_ROLE();
				if (!reader.IsDBNull(reader.GetOrdinal("GROUP_ID"))) entity.GROUP_ID = reader.GetInt64(reader.GetOrdinal("GROUP_ID"));
				if (!reader.IsDBNull(reader.GetOrdinal("ID_ROLE"))) entity.ID_ROLE = reader.GetInt64(reader.GetOrdinal("ID_ROLE"));
				collection.Add(entity);
			}
			return collection;
		}

		//---------------------------------------------------------------------------------------------
		public GROUP_ROLECollection SelectCollectionBy_ID_ROLE()
		{
			string spName = "p_GROUP_ROLE_SelectBy_ID_ROLE";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@ID_ROLE", SqlDbType.BigInt, this._ID_ROLE);
			
			GROUP_ROLECollection collection = new GROUP_ROLECollection();
            IDataReader reader = this.db.ExecuteReader(dbCommand);
			while (reader.Read())
			{
				GROUP_ROLE entity = new GROUP_ROLE();
				if (!reader.IsDBNull(reader.GetOrdinal("GROUP_ID"))) entity.GROUP_ID = reader.GetInt64(reader.GetOrdinal("GROUP_ID"));
				if (!reader.IsDBNull(reader.GetOrdinal("ID_ROLE"))) entity.ID_ROLE = reader.GetInt64(reader.GetOrdinal("ID_ROLE"));
				collection.Add(entity);
			}
			return collection;
		}

		//---------------------------------------------------------------------------------------------

		public DataSet SelectBy_GROUP_ID()
		{
			string spName = "p_GROUP_ROLE_SelectBy_GROUP_ID";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@GROUP_ID", SqlDbType.BigInt, this._GROUP_ID);
						
            return this.db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public DataSet SelectBy_ID_ROLE()
		{
			string spName = "p_GROUP_ROLE_SelectBy_ID_ROLE";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@ID_ROLE", SqlDbType.BigInt, this._ID_ROLE);
						
            return this.db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------

		public DataSet SelectAll()
        {
            string spName = "p_GROUP_ROLE_SelectAll";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
            return this.db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------

		public IDataReader SelectReaderAll()
        {
            string spName = "p_GROUP_ROLE_SelectAll";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
            return this.db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            string spName = "p_GROUP_ROLE_SelectDynamic";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);

			this.db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            this.db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return this.db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------

		public IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            string spName = "p_GROUP_ROLE_SelectDynamic";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);

			this.db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            this.db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return this.db.ExecuteReader(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
		
		public GROUP_ROLECollection SelectCollectionAll()
		{
			GROUP_ROLECollection collection = new GROUP_ROLECollection();

			IDataReader reader = this.SelectReaderAll();
			while (reader.Read())
			{
				GROUP_ROLE entity = new GROUP_ROLE();
				
				if (!reader.IsDBNull(reader.GetOrdinal("GROUP_ID"))) entity.GROUP_ID = reader.GetInt64(reader.GetOrdinal("GROUP_ID"));
				if (!reader.IsDBNull(reader.GetOrdinal("ID_ROLE"))) entity.ID_ROLE = reader.GetInt64(reader.GetOrdinal("ID_ROLE"));
				collection.Add(entity);
			}
			return collection;			
		}
		
		//---------------------------------------------------------------------------------------------
		
		public GROUP_ROLECollection SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			GROUP_ROLECollection collection = new GROUP_ROLECollection();

			IDataReader reader = this.SelectReaderDynamic(whereCondition, orderByExpression);
			while (reader.Read())
			{
				GROUP_ROLE entity = new GROUP_ROLE();
				
				if (!reader.IsDBNull(reader.GetOrdinal("GROUP_ID"))) entity.GROUP_ID = reader.GetInt64(reader.GetOrdinal("GROUP_ID"));
				if (!reader.IsDBNull(reader.GetOrdinal("ID_ROLE"))) entity.ID_ROLE = reader.GetInt64(reader.GetOrdinal("ID_ROLE"));
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
			string spName = "p_GROUP_ROLE_Insert";		
			SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			this.db.AddInParameter(dbCommand, "@GROUP_ID", SqlDbType.BigInt, this._GROUP_ID);
			this.db.AddInParameter(dbCommand, "@ID_ROLE", SqlDbType.BigInt, this._ID_ROLE);
			
			if (transaction != null)
			{
				return this.db.ExecuteNonQuery(dbCommand, transaction);
			}
            else
			{
				return this.db.ExecuteNonQuery(dbCommand);
			}			
		}
		
		//---------------------------------------------------------------------------------------------
		
		public bool Insert(GROUP_ROLECollection collection)
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
					bool ret01 = true;
                    foreach (GROUP_ROLE item in collection)
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
        
		public void InsertTransaction(SqlTransaction transaction, GROUP_ROLECollection collection)
        {
            foreach (GROUP_ROLE item in collection)
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
			string spName = "p_GROUP_ROLE_InsertUpdate";		
			SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			this.db.AddInParameter(dbCommand, "@GROUP_ID", SqlDbType.BigInt, this._GROUP_ID);
			this.db.AddInParameter(dbCommand, "@ID_ROLE", SqlDbType.BigInt, this._ID_ROLE);
			
			if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);			
		}
		
		//---------------------------------------------------------------------------------------------
		
		public bool InsertUpdate(GROUP_ROLECollection collection)
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
					bool ret01 = true;
                    foreach (GROUP_ROLE item in collection)
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
			string spName = "p_GROUP_ROLE_Update";		
			SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);

			this.db.AddInParameter(dbCommand, "@GROUP_ID", SqlDbType.BigInt, this._GROUP_ID);
			this.db.AddInParameter(dbCommand, "@ID_ROLE", SqlDbType.BigInt, this._ID_ROLE);
			
			if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
		
		public void UpdateCollection(GROUP_ROLECollection collection, SqlTransaction transaction)
        {
            foreach (GROUP_ROLE item in collection)
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
			string spName = "p_GROUP_ROLE_Delete";		
			SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@GROUP_ID", SqlDbType.BigInt, this._GROUP_ID);
			this.db.AddInParameter(dbCommand, "@ID_ROLE", SqlDbType.BigInt, this._ID_ROLE);
			
			if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
		
        public void DeleteCollection(GROUP_ROLECollection collection, SqlTransaction transaction)
        {
            foreach (GROUP_ROLE item in collection)
            {
                item.DeleteTransaction(transaction);
            }
        }

		//---------------------------------------------------------------------------------------------
		
		public bool DeleteCollection(GROUP_ROLECollection collection)
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
					bool ret01 = true;
                    foreach (GROUP_ROLE item in collection)
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