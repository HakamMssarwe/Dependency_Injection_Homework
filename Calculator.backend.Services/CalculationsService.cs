using Calculator.backend.Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.backend.Services
{
    public class CalculationsService : ICalculationsService
    {
        public double Add(double numberOne, double numberTwo)
        {
            return numberOne + numberTwo;
        }

        public double Substract(double numberOne, double numberTwo)
        {
            return numberOne - numberTwo;
        }

        public double Multiply(double numberOne, double numberTwo)
        {
            return numberOne * numberTwo;
        }

        public double Divide(double numberOne, double numberTwo)
        {
            return numberOne / numberTwo;
        }
    }
}
