using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    class Questions
    {
        private static List<Question> questions;
        private static int lastId = 0;
        public Question Get(int id)
        {
            return questions.FirstOrDefault(q => q.ID == id);
        }

        public IEnumerable<Question> GetAll()
        {
            return questions;
        }

        public int Add(Question question)
        {
            question.ID = ++lastId;
            questions.Add(question);
            return lastId;
            
        }

        public void Remove(int id)
        {
            questions.RemoveAt(questions.FindIndex(q => q.ID == id));
        }
    }
}
