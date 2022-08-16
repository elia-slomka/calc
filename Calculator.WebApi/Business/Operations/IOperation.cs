namespace Calculator.WebApi.Business.Operations
{
    public interface IOperation
    {
        public string Operand { get; }
        double Operand1 { get; set; }
        double Operand2 { get; set; }
        double Result { get; }

        void PerformOperation();
    }
}