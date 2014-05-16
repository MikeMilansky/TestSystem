using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Test
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int State { get; set; }
        public List<Question> Questions { get; set; }
    }
}
