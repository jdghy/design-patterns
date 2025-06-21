using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Madrid : ICapitalCity
    {
        public int GetPopulation()
        {
            return 3200000;
        }

        public List<string> ListTopAttractions()
        {
            return new List<string> { "Royal Palace", "Pardo" };
        }
    }
}
