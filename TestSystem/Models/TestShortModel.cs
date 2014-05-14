using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSystem.Models
{
    public class TestShortModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int State { get; set; }

        #region Business methods

        //public static TestShortModel[] GetAll()
        //{
        //    var tests = DAL.Test.GetAll();

        //    return tests.Select<,>(test => new TestShortModel()
        //    {
        //        ID = test.ID,
        //        Title = test.Title,
        //    }).OrderByDescending(member => member.ID).ToArray();            


        //    //return tests.Select(test => new TestShortModel
        //    //{
        //    //    ID = test.ID,
        //    //    Title = test.Title,
        //    //}).ToArray();
        //}

        public static TestShortModel[] GetAll()
        {
            var tests = DAL.Test.GetAll();
            return tests.Select(test => new TestShortModel
            {
                ID = test.ID,
                Title = test.Title,
                State = test.State,
            }).OrderByDescending(test => test.ID).ToArray();

        }

        #endregion

    }
}