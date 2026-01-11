using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <summary>
    /// The Facade (Simplified interface)
    /// In this scenario, a single HomeFacade automates multiple devices (lights, music, and AC) with simple "Arrive" or "Leave" commands. 
    public class HomeFacade
    {
        private readonly LightSystem _lights = new();
        private readonly MusicSystem _music = new();
        private readonly ClimateControl _climate = new();

        public void ArriveAtHome()
        {
            Console.WriteLine("\n--- Arriving Home ---");
            _lights.TurnOn();
            _climate.SetTemperature(22);
            _music.StartMusic();
        }

        public void LeaveHome()
        {
            Console.WriteLine("\n--- Leaving Home ---");
            _music.StopMusic();
            _lights.TurnOff();
        }
    }
}
