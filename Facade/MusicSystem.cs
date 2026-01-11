using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class MusicSystem
    {
        public void StartMusic() => Console.WriteLine("Playing music...");
        public void StopMusic() => Console.WriteLine("Music stopped.");
    }
}
