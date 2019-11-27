using System;

namespace QuadraticEquations.Core.Services
{
    public class CalculationService : ICalculationService
    {
        public decimal QuadraticNeg(int a, int b, int c)
        {
            return (decimal)((-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
        }

        public decimal QuadraticPos(int a, int b, int c)
        {
            return (decimal)((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
        }
    }
}
