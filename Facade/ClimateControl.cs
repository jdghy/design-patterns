using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ClimateControl
    {
        public void SetTemperature(int temp) => Console.WriteLine($"AC set to {temp}°C");
    }
}
