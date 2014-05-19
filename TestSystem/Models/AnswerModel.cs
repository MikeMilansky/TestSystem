using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;

namespace TestSystem.Models
{
    public class AnswerModel
    {
        public int ID { get; set; }
        public List<Question> Questions { get; set; }
    }
}