using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class LightSystem
    {
        public void TurnOn() => Console.WriteLine("Lights are ON");
        public void TurnOff() => Console.WriteLine("Lights are OFF");

    }
}
