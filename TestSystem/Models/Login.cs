using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;
using TestSystem.Tools;

namespace TestSystem.Models
{
    public class Login
    {
        [Required]
        public string MemberLogin { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Remember { get; set; }

        #region Business methods
        public bool TryToLogin()
        {
            string hashFromBase = DAL.Member.GetHash(MemberLogin);
            string generatedHash = CommonTools.MakeHash(Password);
            bool cookieOn = (Remember != null) ? true : false;
            if (hashFromBase == generatedHash)
            {
                FormsAuthentication.RedirectFromLoginPage(MemberLogin, createPersistentCookie: cookieOn);
                return true;
            }
            return false;
        }
        #endregion Business methods
    }
}