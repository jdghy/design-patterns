using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Student : Person
    {
        public Teacher Teacher { get; set; }

        public Student(string name, Teacher teacher ) : base(name)
        {
            Teacher = teacher;
        }
        public override Person ShallowClone()
        {
            return (Person)MemberwiseClone();
        }
    }
   
}
