using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace TestSystem.Tools
{
    public class CommonTools
    {
        public static Dictionary<int, string> TestState = new Dictionary<int, string>() { { 0, "closed" }, { 1, "draft" }, { 2, "actual" } };
        public enum States { Closed, Draft, Actual };
        
        public static string MakeHash(string originalPassword)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            Byte[] originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            Byte[] encodedBytes = md5.ComputeHash(originalBytes);
            return BitConverter.ToString(encodedBytes);
        }
    }
}