using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Teacher : Person
    {
        public string Course { get; set; }
        public Teacher(string name, string course) : base(name)
        {
            Course = course;
        }
        
        public override Person ShallowClone()
        {
            return (Person)MemberwiseClone();
        }
    }
   
}
