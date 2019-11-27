namespace QuadraticEquations.Core.Services
{
    public interface ICalculationService
    {
        decimal QuadraticPos(int a, int b, int c);

        decimal QuadraticNeg(int a, int b, int c);
    }
}
