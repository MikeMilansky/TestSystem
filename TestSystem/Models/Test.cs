using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSystem.Models
{
    public class Test: ShortTest
    {
        public List<Question> Questions { get; set; }

        #region Business methods
        public static Test Get(int id)
        {
            var test = DAL.Test.Get(id);
            return new Test { ID = test.ID, Title = test.Title, State = test.State, Questions = Mapper.Map<List<Question>>(test.Questions) };
        }

        #endregion
    }
}