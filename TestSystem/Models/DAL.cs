using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;

namespace TestSystem.Models
{
    public class DAL
    {
        static DAL()
        {
        }
        public static Members Member { get; set; }
        public static Tests Test { get; set; }
    }
}