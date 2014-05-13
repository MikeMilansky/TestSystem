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
        private static List<Test> Tests;
        private static int lastId = 0;
        public Test Get(int id)
        {
            return Tests.FirstOrDefault(q => q.ID == id);
        }

        public IEnumerable<Test> GetAll()
        {
            return Tests;
        }

        public int Add(Test Test)
        {
            Test.ID = ++lastId;
            Tests.Add(Test);
            return lastId;
        }

        public void Remove(int id)
        {
            Tests.RemoveAt(Tests.FindIndex(q => q.ID == id));     //грохнуть по эксепшену!
        }
    }
}
