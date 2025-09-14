using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Composite
    public class Branch : GitComponent
    {
        private readonly string _name;

        public Branch(string name)
        {
            _name = name;
        }

        public override void ShowDetail()
        {
            Console.WriteLine($"Branch: {_name} with commits:");

            foreach (GitComponent component in _components)
            {
                component.ShowDetail();
            }
        }
    }
}
