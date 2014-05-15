using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSystem.Tools
{
    public class CommonTools
    {
        public static Dictionary<int, string> TestState = new Dictionary<int, string>() { { 0, "closed" }, { 1, "draft" }, { 2, "actual" } };
        public enum States { Closed, Draft, Actual };
    }
}