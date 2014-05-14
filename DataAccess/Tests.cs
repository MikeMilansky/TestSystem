using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    class Tests
    {
        private static List<Test> tests;
        private static int lastId = 0;
        public Test Get(int id)
        {
            return tests.FirstOrDefault(q => q.ID == id);
        }

        public IEnumerable<Test> GetAll()
        {
            return tests;
        }

        public int Add(Test Test)
        {
            Test.ID = ++lastId;
            tests.Add(Test);
            return lastId;
        }

        public void Remove(int id)
        {
            tests.RemoveAt(tests.FindIndex(q => q.ID == id));     //грохнуть по эксепшену!
        }
    }
}
