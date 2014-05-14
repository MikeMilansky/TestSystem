using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSystem.Tools
{
    public class CommonTools
    {
        public static Dictionary<int, string> TestState = new Dictionary<int, string>() { { 0, "Closed" }, { 1, "Draft" }, { 2, "Actual" } };
        //public enum TestStates { Closed, Draft, Actual };
    }
}