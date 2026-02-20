using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // 3. Concrete Command
    public class CalculateCommand : ICommand
    {
        private readonly Calculator _calculator;
        private readonly char _op;
        private readonly int _operand;

        public CalculateCommand(Calculator calculator, char op, int operand)
        {
            _calculator = calculator;
            _op = op;
            _operand = operand;
        }

        public void Execute() => _calculator.Operation(_op, _operand);

        public void Undo()
        {
            char reverseOp = _op == '+' ? '-' : '+';
            _calculator.Operation(reverseOp, _operand);
        }
    }
}
