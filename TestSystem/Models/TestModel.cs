using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;

namespace TestSystem.Models
{
    public class TestModel: TestShortModel
    {
        public List<Question> Questions { get; set; }

        #region Business methods
        public static TestModel Get(int id)
        {
            var test = DAL.Test.Get(id);
            var quest = (SingleQuestion)test.Questions.First(q => q.ID == 2);
            return new TestModel {ID = test.ID, Title = test.Title, State = test.State, Questions = test.Questions };
        }

        #endregion
    }
}