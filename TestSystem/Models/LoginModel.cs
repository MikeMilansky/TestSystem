using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;
using TestSystem.Tools;

namespace TestSystem.Models
{
    public class LoginModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Remember { get; set; }

        #region Business methods
        public bool TryToLogin()
        {
            string hashFromBase = DAL.Member.GetHash(Login);
            string generatedHash = CommonTools.MakeHash(Password);
            bool cookieOn = (Remember != null) ? true : false;
            if (hashFromBase == generatedHash)
            {
                FormsAuthentication.RedirectFromLoginPage(Login, createPersistentCookie: cookieOn);
                return true;
            }
            return false;
        }
        #endregion Business methods
    }
}