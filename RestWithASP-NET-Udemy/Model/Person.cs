using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NET_Udemy.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string FirrstName { get; set; }
        public string LastName{ get; set; }
        public string Address{ get; set; }
        public string Gender { get; set; }
    }
}
