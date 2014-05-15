using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class Tests
    {
        private static List<Test> tests = new List<Test>();
        private enum States { Closed, Draft, Actual };
        private static int lastId = 0;
        public Tests()
        {
            for (int i = 1; i <= 10; i++)
            {
                Add(new Test() {
                    Title = String.Format("Test {0}", i),
                    State = (int)States.Actual,
                });
            }            
        }
        
        public Test Get(int id)
        {
            return tests.FirstOrDefault(q => q.ID == id);
        }

        public IEnumerable<Test> GetAll()
        {
            return tests;
        }


        public int Add(Test test)
        {
            test.ID = ++lastId;
            tests.Add(test);
            return lastId;

        }

        public void Remove(int id)
        {
            tests.RemoveAt(tests.FindIndex(q => q.ID == id));     //грохнуть по эксепшену!
        }
    }
}
