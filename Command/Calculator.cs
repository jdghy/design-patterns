using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // 2. The Receiver (Logic specialist)
    public class Calculator
    {
        public int CurrentValue { get; private set; } = 0;

        public void Operation(char op, int operand)
        {
            switch (op)
            {
                case '+': CurrentValue += operand; break;
                case '-': CurrentValue -= operand; break;
            }
            Console.WriteLine($"Current Value: {CurrentValue}");
        }
    }

}
