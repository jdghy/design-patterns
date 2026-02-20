using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // 1. The Command Interface
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
