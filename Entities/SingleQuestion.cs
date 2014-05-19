using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SingleQuestion : Question
    {
        public List<Option> Options { get; set; }
    }
}
