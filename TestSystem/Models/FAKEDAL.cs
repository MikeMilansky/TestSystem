using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSystem.Models
{
    public class FAKEDAL
    {
        public static TestShortModel[] Tests = { 
                                                 new TestShortModel { Title = "First", ID = 1, State = 1 }, 
                                                 new TestShortModel { Title = "Second", ID = 2, State = 0 }, 
                                                 new TestShortModel { Title = "Third", ID = 3, State = 0 } 
                                               };
    }
}