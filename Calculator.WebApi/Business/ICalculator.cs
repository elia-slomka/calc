namespace Calculator.WebApi.Business
{
    public interface ICalculator
    {
        CalculationResult Calculate(CalculationRequest request);
    }
}
