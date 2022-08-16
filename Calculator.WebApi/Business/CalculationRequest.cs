namespace Calculator.WebApi.Business
{
    public class CalculationRequest
    {
        public string[] Operators { get; set; }
        public double[] Operands { get; set; }
    }
}