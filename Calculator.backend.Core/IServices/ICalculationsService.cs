using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.backend.Core.IServices
{
    public interface ICalculationsService
    {
        public double Add(double numberOne, double numberTwo);
        public double Substract(double numberOne, double numberTwo);
        public double Multiply(double numberOne, double numberTwo);
        public double Divide(double numberOne, double numberTwo);
    }
}
