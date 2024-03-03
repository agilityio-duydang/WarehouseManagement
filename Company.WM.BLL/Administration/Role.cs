using System;
using System.Data;
using System.Data.SqlClient;
using Company.WM.BLL;

namespace Company.WM.BLL.Administration
{
	public partial class ROLE : EntityBase
	{
        private bool _Check = false;
        public bool Check
        {
            set { _Check = value; }
            get { return _Check; }
        }   
	}	
}