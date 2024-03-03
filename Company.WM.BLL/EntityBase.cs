using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.IO;
using System.Windows.Forms;

namespace Company.WM.BLL
{
    public class EntityBase
    {
        protected SqlDatabase db = (SqlDatabase) DatabaseFactory.CreateDatabase();
        public static string GetPathProgram()
        {
            FileInfo fileInfo = new FileInfo(Application.ExecutablePath);
            return fileInfo.DirectoryName;
        }
    }
}