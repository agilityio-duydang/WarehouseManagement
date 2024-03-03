using System;
using System.Collections;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace Company.WM.BLL.Administration
{
    public class ECSPrincipal:System.Security.Principal.IPrincipal
    {
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
            return roleList.Contains( role );
        }
        public bool HasPermission( long permissionID )
        {
            return permissionList.Contains( permissionID );
        }
       
        public ArrayList Permissions
        {
            get {
                return permissionList;
            }
        }        

        public ECSPrincipal(long UserID)
        {
            User dataUser = new User();
            identity = new SiteIdentity(UserID);
            if (((Company.WM.BLL.Administration.SiteIdentity)identity).user.isAdmin)
            {
                permissionList = dataUser.GetEffectivePermissionList();
                roleList = dataUser.GetUserRoles();
            }
            else
            {
                permissionList = dataUser.GetEffectivePermissionList(UserID);
                roleList = dataUser.GetUserRoles(UserID);
            }
        }
        public ECSPrincipal( string UserName )
		{
            User dataUser = new User();			
			identity = new SiteIdentity( UserName );
            if (((Company.WM.BLL.Administration.SiteIdentity)identity).user.isAdmin)
            {
                permissionList = dataUser.GetEffectivePermissionList();
                roleList = dataUser.GetUserRoles();
            }
            else
            {
                roleList = dataUser.GetUserRoles(((Company.WM.BLL.Administration.SiteIdentity)identity).User_ID);		
			    permissionList = dataUser.GetEffectivePermissionList(((Company.WM.BLL.Administration.SiteIdentity)identity).User_ID);			
            }
		}
        public static ECSPrincipal LayDanhSachQuyen()
        {
            return new ECSPrincipal("admin");
        }
        public static ECSPrincipal ValidateLogin(string username, string password)
        {
            long newID;
            string cryptPassword = EncryptPassword(password);

            User dataUser = new User();

            if ((newID = dataUser.ValidateLogin(username, cryptPassword)) > 0)
                return new ECSPrincipal(newID);
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
