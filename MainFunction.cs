using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUDT
{
    class MainFunction
    {
        public double firstNumber, secondNumber;

        public double Add()
        {
            return WrongResult();
        }

        public double Substract()
        {
            return firstNumber - secondNumber;
        }

        public double Multiply()
        {
            return firstNumber*secondNumber;
        }

        public double Divide()
        {
            return firstNumber/secondNumber;
        }

        private double WrongResult()
        {
            return firstNumber + secondNumber;
        }
    }
}
