namespace Calculator.WebApi.Business.Operations
{
    public class Subtraction : IOperation
    {
        public string Operand => "-";
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public double Result { get; private set; }
        public void PerformOperation()
        {
            Result = Operand1 - Operand2;
        }
    }
}