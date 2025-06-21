using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class EnglandFactory: IInternationalFactory
    {
        public ILanguage CreateLanguage()
        {
            return new English();
        }
        public ICapitalCity CreateCapital()
        {
            return new London();
        }
    }
   
}
