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
            Add(new Test { Title = "DraftTest", State = (int)States.Draft });
            Add(new Test { Title = "ClosedTest", State = (int)States.Closed });
            for (int i = 1; i <= 10; i++)
            {
                Add(new Test()
                {
                    Title = String.Format("Test {0}", i),
                    State = (int)States.Actual,
                    Questions = new List<Question>() {new InputQuestion(){ID = 1, Text = "Quest 1" },
                                                      new SingleQuestion(){ID = 2, Text = "Quest 2", Options = new string[] {"first", "second", "third"}},
                                                      new MultiplyQuestion(){ID = 3, Text = "Quest 3", Options = new List<Option> {new Option {ID = 1, IsChecked = true, Text = "first" }, 
                                                                                                                                   new Option {ID = 2, IsChecked = false, Text = "second" },
                                                                                                                                   new Option {ID = 3, IsChecked = false, Text = "third" },}}
                    },
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
