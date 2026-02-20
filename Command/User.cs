using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // 4. The Invoker (Manager of history)
    public class User
    {
        private readonly Stack<ICommand> _history = new();
        private readonly Calculator _calculator = new();

        public void Compute(char op, int operand)
        {
            var command = new CalculateCommand(_calculator, op, operand);
            command.Execute();
            _history.Push(command);
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                _history.Pop().Undo();
            }
        }
    }
}
