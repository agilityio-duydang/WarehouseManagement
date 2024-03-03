using System;
using System.Data;
using System.Data.SqlClient;
using Company.WM.BLL;

namespace Company.WM.BLL.Administration
{
	public partial class USER_GROUP : EntityBase
	{
		#region Private members.
		
		protected long _MA_NHOM;
		protected long _USER_ID;

		#endregion
		
		//---------------------------------------------------------------------------------------------

		#region Properties.
		
		public long MA_NHOM
		{
			set {this._MA_NHOM = value;}
			get {return this._MA_NHOM;}
		}
		public long USER_ID
		{
			set {this._USER_ID = value;}
			get {return this._USER_ID;}
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
			string spName = "p_USER_GROUP_Load";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this._MA_NHOM);
			this.db.AddInParameter(dbCommand, "@USER_ID", SqlDbType.BigInt, this._USER_ID);
			
            IDataReader reader = this.db.ExecuteReader(dbCommand);
			if (reader.Read())
			{
				if (!reader.IsDBNull(reader.GetOrdinal("MA_NHOM"))) this._MA_NHOM = reader.GetInt64(reader.GetOrdinal("MA_NHOM"));
				if (!reader.IsDBNull(reader.GetOrdinal("USER_ID"))) this._USER_ID = reader.GetInt64(reader.GetOrdinal("USER_ID"));
				return true;
			}
			return false;
		}		
		
		//---------------------------------------------------------------------------------------------
		
		public USER_GROUPCollection SelectCollectionBy_MA_NHOM()
		{
			string spName = "p_USER_GROUP_SelectBy_MA_NHOM";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this._MA_NHOM);
			
			USER_GROUPCollection collection = new USER_GROUPCollection();
            IDataReader reader = this.db.ExecuteReader(dbCommand);
			while (reader.Read())
			{
				USER_GROUP entity = new USER_GROUP();
				if (!reader.IsDBNull(reader.GetOrdinal("MA_NHOM"))) entity.MA_NHOM = reader.GetInt64(reader.GetOrdinal("MA_NHOM"));
				if (!reader.IsDBNull(reader.GetOrdinal("USER_ID"))) entity.USER_ID = reader.GetInt64(reader.GetOrdinal("USER_ID"));
				collection.Add(entity);
			}
			return collection;
		}

		//---------------------------------------------------------------------------------------------
		public USER_GROUPCollection SelectCollectionBy_USER_ID()
		{
			string spName = "p_USER_GROUP_SelectBy_USER_ID";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@USER_ID", SqlDbType.BigInt, this._USER_ID);
			
			USER_GROUPCollection collection = new USER_GROUPCollection();
            IDataReader reader = this.db.ExecuteReader(dbCommand);
			while (reader.Read())
			{
				USER_GROUP entity = new USER_GROUP();
				if (!reader.IsDBNull(reader.GetOrdinal("MA_NHOM"))) entity.MA_NHOM = reader.GetInt64(reader.GetOrdinal("MA_NHOM"));
				if (!reader.IsDBNull(reader.GetOrdinal("USER_ID"))) entity.USER_ID = reader.GetInt64(reader.GetOrdinal("USER_ID"));
				collection.Add(entity);
			}
			return collection;
		}

		//---------------------------------------------------------------------------------------------

		public DataSet SelectBy_MA_NHOM()
		{
			string spName = "p_USER_GROUP_SelectBy_MA_NHOM";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this._MA_NHOM);
						
            return this.db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------
		public DataSet SelectBy_USER_ID()
		{
			string spName = "p_USER_GROUP_SelectBy_USER_ID";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@USER_ID", SqlDbType.BigInt, this._USER_ID);
						
            return this.db.ExecuteDataSet(dbCommand);
		}
		//---------------------------------------------------------------------------------------------

		public DataSet SelectAll()
        {
            string spName = "p_USER_GROUP_SelectAll";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
            return this.db.ExecuteDataSet(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------

		public IDataReader SelectReaderAll()
        {
            string spName = "p_USER_GROUP_SelectAll";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
            return this.db.ExecuteReader(dbCommand);
        }
		
		//---------------------------------------------------------------------------------------------
		
		public DataSet SelectDynamic(string whereCondition, string orderByExpression)
		{
            string spName = "p_USER_GROUP_SelectDynamic";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);

			this.db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            this.db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return this.db.ExecuteDataSet(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------

		public IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
		{
            string spName = "p_USER_GROUP_SelectDynamic";
            SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);

			this.db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            this.db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);
            
            return this.db.ExecuteReader(dbCommand);        				
		}
		
		//---------------------------------------------------------------------------------------------
		
		public USER_GROUPCollection SelectCollectionAll()
		{
			USER_GROUPCollection collection = new USER_GROUPCollection();

			IDataReader reader = this.SelectReaderAll();
			while (reader.Read())
			{
				USER_GROUP entity = new USER_GROUP();
				
				if (!reader.IsDBNull(reader.GetOrdinal("MA_NHOM"))) entity.MA_NHOM = reader.GetInt64(reader.GetOrdinal("MA_NHOM"));
				if (!reader.IsDBNull(reader.GetOrdinal("USER_ID"))) entity.USER_ID = reader.GetInt64(reader.GetOrdinal("USER_ID"));
				collection.Add(entity);
			}
			return collection;			
		}
		
		//---------------------------------------------------------------------------------------------
		
		public USER_GROUPCollection SelectCollectionDynamic(string whereCondition, string orderByExpression)
		{
			USER_GROUPCollection collection = new USER_GROUPCollection();

			IDataReader reader = this.SelectReaderDynamic(whereCondition, orderByExpression);
			while (reader.Read())
			{
				USER_GROUP entity = new USER_GROUP();
				
				if (!reader.IsDBNull(reader.GetOrdinal("MA_NHOM"))) entity.MA_NHOM = reader.GetInt64(reader.GetOrdinal("MA_NHOM"));
				if (!reader.IsDBNull(reader.GetOrdinal("USER_ID"))) entity.USER_ID = reader.GetInt64(reader.GetOrdinal("USER_ID"));
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
			string spName = "p_USER_GROUP_Insert";		
			SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this._MA_NHOM);
			this.db.AddInParameter(dbCommand, "@USER_ID", SqlDbType.BigInt, this._USER_ID);
			
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
		
		public bool Insert(USER_GROUPCollection collection)
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
					bool ret01 = true;
                    foreach (USER_GROUP item in collection)
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
        
		public void InsertTransaction(SqlTransaction transaction, USER_GROUPCollection collection)
        {
            foreach (USER_GROUP item in collection)
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
			string spName = "p_USER_GROUP_InsertUpdate";		
			SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this._MA_NHOM);
			this.db.AddInParameter(dbCommand, "@USER_ID", SqlDbType.BigInt, this._USER_ID);
			
			if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);			
		}
		
		//---------------------------------------------------------------------------------------------
		
		public bool InsertUpdate(USER_GROUPCollection collection)
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
					bool ret01 = true;
                    foreach (USER_GROUP item in collection)
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
			string spName = "p_USER_GROUP_Update";		
			SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);

			this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this._MA_NHOM);
			this.db.AddInParameter(dbCommand, "@USER_ID", SqlDbType.BigInt, this._USER_ID);
			
			if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
		
		public void UpdateCollection(USER_GROUPCollection collection, SqlTransaction transaction)
        {
            foreach (USER_GROUP item in collection)
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
			string spName = "p_USER_GROUP_Delete";		
			SqlCommand dbCommand = (SqlCommand) this.db.GetStoredProcCommand(spName);
			
			this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this._MA_NHOM);
			this.db.AddInParameter(dbCommand, "@USER_ID", SqlDbType.BigInt, this._USER_ID);
			
			if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);
		}
		
		//---------------------------------------------------------------------------------------------
		
        public void DeleteCollection(USER_GROUPCollection collection, SqlTransaction transaction)
        {
            foreach (USER_GROUP item in collection)
            {
                item.DeleteTransaction(transaction);
            }
        }

		//---------------------------------------------------------------------------------------------
		
		public bool DeleteCollection(USER_GROUPCollection collection)
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
					bool ret01 = true;
                    foreach (USER_GROUP item in collection)
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