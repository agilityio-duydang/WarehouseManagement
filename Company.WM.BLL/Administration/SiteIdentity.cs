using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Security.Cryptography;

namespace Company.WM.BLL.Administration
{
    public class SiteIdentity : System.Security.Principal.IIdentity
    {
        public User user;
        public long User_ID;
        public string AuthenticationType
        {
            get
            {
                return "Custom Authentication";
            }
            set
            {
                // Do Nothing
            }
        }
        public bool IsAuthenticated
        {
            get
            {
                return true;
            }
        }
        public string Name
        {
            get
            {
                return user.UserName;
            }
        }
        public SiteIdentity(string currentUserName)
        {
            user = new User();
            if (!user.Load(currentUserName))
                user = null;
        }
        public SiteIdentity(long currentUserID)
        {
            User_ID = currentUserID;
            user = User.Load(User_ID);
            if (user == null)
            {
                User_ID = 0;
            }
        }
        public bool TestPassword(string password)
        {
            // At some point, we may have a more complex way of encrypting or storing the passwords
            // so by supplying this procedure, we can simply replace its contents to move password
            // comparison to the database (as we've done below) or somewhere else (e.g. another
            // web service, etc).

            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] hashBytes = encoding.GetBytes(password);

            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytePassword = sha1.ComputeHash(hashBytes);
            string cryptPassword = Convert.ToBase64String(bytePassword);

            return user.TestPassWord(user.ID, cryptPassword);
        }
    }
}
