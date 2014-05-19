using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSystem.Models
{
    public class ShortTest
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int State { get; set; }

        #region Business methods

        public static ShortTest[] GetAll()
        {
            var tests = DAL.Test.GetAll();
            return tests.Select(test => new ShortTest
            {
                ID = test.ID,
                Title = test.Title,
                State = test.State,
            }).OrderBy(test => test.ID).ToArray();

        }

        #endregion

    }
}