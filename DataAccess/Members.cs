using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class Members
    {
        private static List<Member> members;
        public Member Get(int id)
        {
            return members.First(m => m.ID == id);
        }

        public IEnumerable<Member> GetAll()
        {
            return members;
        }
            

        public bool AddMember(Member member)
        {
            members.Add(member);
            return true;                        //дописать логику
        }

        //public void Update(Member member)
        //{
            
        //}

        public void Remove(int id)
        {
            members = members.Where(m => m.ID != id).ToList();
        }
    }
}
