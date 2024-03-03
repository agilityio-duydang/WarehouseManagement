using System;
using System.Data;
using System.Data.SqlClient;
using Company.WM.BLL;

namespace Company.WM.BLL.Administration
{
    public partial class GROUPS : EntityBase
    {
        #region Private members.

        protected long _MA_NHOM;
        protected string _TEN_NHOM = String.Empty;
        protected string _MO_TA = String.Empty;

        #endregion

        //---------------------------------------------------------------------------------------------

        #region Properties.

        public long MA_NHOM
        {
            set { this._MA_NHOM = value; }
            get { return this._MA_NHOM; }
        }
        public string TEN_NHOM
        {
            set { this._TEN_NHOM = value; }
            get { return this._TEN_NHOM; }
        }
        public string MO_TA
        {
            set { this._MO_TA = value; }
            get { return this._MO_TA; }
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
            string spName = "p_GROUP_Load";
            SqlCommand dbCommand = (SqlCommand)this.db.GetStoredProcCommand(spName);

            this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this._MA_NHOM);

            IDataReader reader = this.db.ExecuteReader(dbCommand);
            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("MA_NHOM"))) this._MA_NHOM = reader.GetInt64(reader.GetOrdinal("MA_NHOM"));
                if (!reader.IsDBNull(reader.GetOrdinal("TEN_NHOM"))) this._TEN_NHOM = reader.GetString(reader.GetOrdinal("TEN_NHOM"));
                if (!reader.IsDBNull(reader.GetOrdinal("MO_TA"))) this._MO_TA = reader.GetString(reader.GetOrdinal("MO_TA"));
                return true;
            }
            return false;
        }

        //---------------------------------------------------------------------------------------------



        public DataSet SelectAll()
        {
            string spName = "p_GROUP_SelectAll";
            SqlCommand dbCommand = (SqlCommand)this.db.GetStoredProcCommand(spName);
            return this.db.ExecuteDataSet(dbCommand);
        }

        //---------------------------------------------------------------------------------------------

        public IDataReader SelectReaderAll()
        {
            string spName = "p_GROUP_SelectAll";
            SqlCommand dbCommand = (SqlCommand)this.db.GetStoredProcCommand(spName);
            return this.db.ExecuteReader(dbCommand);
        }

        //---------------------------------------------------------------------------------------------

        public DataSet SelectDynamic(string whereCondition, string orderByExpression)
        {
            string spName = "p_GROUP_SelectDynamic";
            SqlCommand dbCommand = (SqlCommand)this.db.GetStoredProcCommand(spName);

            this.db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            this.db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);

            return this.db.ExecuteDataSet(dbCommand);
        }

        //---------------------------------------------------------------------------------------------

        public IDataReader SelectReaderDynamic(string whereCondition, string orderByExpression)
        {
            string spName = "p_GROUP_SelectDynamic";
            SqlCommand dbCommand = (SqlCommand)this.db.GetStoredProcCommand(spName);

            this.db.AddInParameter(dbCommand, "@WhereCondition", SqlDbType.NVarChar, whereCondition);
            this.db.AddInParameter(dbCommand, "@OrderByExpression", SqlDbType.NVarChar, orderByExpression);

            return this.db.ExecuteReader(dbCommand);
        }

        //---------------------------------------------------------------------------------------------

        public GROUPSCollection SelectCollectionAll()
        {
            GROUPSCollection collection = new GROUPSCollection();

            IDataReader reader = this.SelectReaderAll();
            while (reader.Read())
            {
                GROUPS entity = new GROUPS();

                if (!reader.IsDBNull(reader.GetOrdinal("MA_NHOM"))) entity.MA_NHOM = reader.GetInt64(reader.GetOrdinal("MA_NHOM"));
                if (!reader.IsDBNull(reader.GetOrdinal("TEN_NHOM"))) entity.TEN_NHOM = reader.GetString(reader.GetOrdinal("TEN_NHOM"));
                if (!reader.IsDBNull(reader.GetOrdinal("MO_TA"))) entity.MO_TA = reader.GetString(reader.GetOrdinal("MO_TA"));
                collection.Add(entity);
            }
            return collection;
        }

        //---------------------------------------------------------------------------------------------

        public GROUPSCollection SelectCollectionDynamic(string whereCondition, string orderByExpression)
        {
            GROUPSCollection collection = new GROUPSCollection();

            IDataReader reader = this.SelectReaderDynamic(whereCondition, orderByExpression);
            while (reader.Read())
            {
                GROUPS entity = new GROUPS();

                if (!reader.IsDBNull(reader.GetOrdinal("MA_NHOM"))) entity.MA_NHOM = reader.GetInt64(reader.GetOrdinal("MA_NHOM"));
                if (!reader.IsDBNull(reader.GetOrdinal("TEN_NHOM"))) entity.TEN_NHOM = reader.GetString(reader.GetOrdinal("TEN_NHOM"));
                if (!reader.IsDBNull(reader.GetOrdinal("MO_TA"))) entity.MO_TA = reader.GetString(reader.GetOrdinal("MO_TA"));
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
            string spName = "p_GROUP_Insert";
            SqlCommand dbCommand = (SqlCommand)this.db.GetStoredProcCommand(spName);
            this.db.AddOutParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt,8);
            this.db.AddInParameter(dbCommand, "@TEN_NHOM", SqlDbType.NVarChar, this._TEN_NHOM);
            this.db.AddInParameter(dbCommand, "@MO_TA", SqlDbType.NVarChar, this._MO_TA);

            if (transaction != null)
            {
                this.db.ExecuteNonQuery(dbCommand, transaction);
                this._MA_NHOM = (long)this.db.GetParameterValue(dbCommand, "@MA_NHOM");
                return this._MA_NHOM;
            }
            else
            {
                this.db.ExecuteNonQuery(dbCommand);
                this._MA_NHOM = (long)this.db.GetParameterValue(dbCommand, "@MA_NHOM");
                return this._MA_NHOM;
            }			
        }

        //---------------------------------------------------------------------------------------------

        public bool Insert(GROUPSCollection collection)
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    bool ret01 = true;
                    foreach (GROUPS item in collection)
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

        public void InsertTransaction(SqlTransaction transaction, GROUPSCollection collection)
        {
            foreach (GROUPS item in collection)
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
            string spName = "p_GROUP_InsertUpdate";
            SqlCommand dbCommand = (SqlCommand)this.db.GetStoredProcCommand(spName);
            this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this._MA_NHOM);
            this.db.AddInParameter(dbCommand, "@TEN_NHOM", SqlDbType.NVarChar, this._TEN_NHOM);
            this.db.AddInParameter(dbCommand, "@MO_TA", SqlDbType.NVarChar, this._MO_TA);

            if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);
        }

        //---------------------------------------------------------------------------------------------

        public bool InsertUpdate(GROUPSCollection collection)
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    bool ret01 = true;
                    foreach (GROUPS item in collection)
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
            string spName = "p_GROUP_Update";
            SqlCommand dbCommand = (SqlCommand)this.db.GetStoredProcCommand(spName);

            this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this._MA_NHOM);
            this.db.AddInParameter(dbCommand, "@TEN_NHOM", SqlDbType.NVarChar, this._TEN_NHOM);
            this.db.AddInParameter(dbCommand, "@MO_TA", SqlDbType.NVarChar, this._MO_TA);

            if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);
        }

        //---------------------------------------------------------------------------------------------

        public void UpdateCollection(GROUPSCollection collection, SqlTransaction transaction)
        {
            foreach (GROUPS item in collection)
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
            string spName = "p_GROUP_Delete";
            SqlCommand dbCommand = (SqlCommand)this.db.GetStoredProcCommand(spName);

            this.db.AddInParameter(dbCommand, "@MA_NHOM", SqlDbType.BigInt, this._MA_NHOM);

            if (transaction != null)
                return this.db.ExecuteNonQuery(dbCommand, transaction);
            else
                return this.db.ExecuteNonQuery(dbCommand);
        }

        //---------------------------------------------------------------------------------------------

        public void DeleteCollection(GROUPSCollection collection, SqlTransaction transaction)
        {
            foreach (GROUPS item in collection)
            {
                item.DeleteTransaction(transaction);
            }
        }

        //---------------------------------------------------------------------------------------------

        public bool DeleteCollection(GROUPSCollection collection)
        {
            bool ret;
            using (SqlConnection connection = (SqlConnection)db.CreateConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    bool ret01 = true;
                    foreach (GROUPS item in collection)
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