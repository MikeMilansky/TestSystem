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

        public static TestShortModel[] GetAll()
        {
            //var members = DAL.Member.GetAll();
            //return members.Select(member => new MemberShortModel
            //{
            //    ID = member.ID,
            //    FirstName = member.FirstName,
            //    LastName = member.LastName,
            //    About = member.About,
            //}).OrderByDescending(member => member.ID).ToArray();
            return FAKEDAL.Tests;
        }
        #endregion

    }
}