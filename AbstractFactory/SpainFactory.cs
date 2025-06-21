using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SpainFactory : IInternationalFactory
    {
        public ILanguage CreateLanguage()
        {
            return new Spanish();
        }
        public ICapitalCity CreateCapital()
        {
            return new Madrid();
        }
    }
    
}
