using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Security.Cryptography;
using Company.WM.BLL.Administration;

namespace WarehouseManagement
{
   public class Principal : System.Security.Principal.IPrincipal
    {
        #region IPrincipal Members

        protected System.Security.Principal.IIdentity identity;
        protected ArrayList permissionList;
        protected ArrayList roleList;
        public System.Security.Principal.IIdentity Identity
        {
            get
            {
                return identity;
            }
            set
            {
                identity = value;
            }
        }
        public ArrayList Roles
        {
            get
            {
                return roleList;
            }
        }
        public bool IsInRole(string role)
        {
            return roleList.Contains(role);
        }

        #endregion
        public Principal(long UserID)
        {
            User dataUser = new User();
            identity = new SiteIdentity(UserID);
            //if (SiteIdentity)identity).user.isAdmin)
            //{
            //    permissionList = dataUser.GetEffectivePermissionList();
            //    roleList = dataUser.GetUserRoles();
            //}
            //else
            //{
            //    permissionList = dataUser.GetEffectivePermissionList(UserID);
            //    roleList = dataUser.GetUserRoles(UserID);
            //}
        }
        public static Principal ValidateLogin(string username, string password)
        {
            long newID;
            string cryptPassword = EncryptPassword(password);

            User dataUser = new User();

            if ((newID = dataUser.ValidateLogin(username, cryptPassword)) > 0)
                return new Principal(newID);
            else
                return null;
        }
        public static string EncryptPassword(string password)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] hashBytes = encoding.GetBytes(password);

            // compute SHA-1 hash.
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytePassword = sha1.ComputeHash(hashBytes);
            string cryptPassword = Convert.ToBase64String(bytePassword);

            return cryptPassword;
        }
    }
}
