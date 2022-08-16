using Calculator.WebApi.Business.Operations;

namespace Calculator.WebApi.Business
{
    public class Calculator : ICalculator
    {
        private readonly IOperationsFactory _operationsFactory;

        public Calculator(IOperationsFactory operationsFactory)
        {
            _operationsFactory = operationsFactory;
        }

        public CalculationResult Calculate(CalculationRequest request)
        {
            var op = request.Operators[0];
            var operation = _operationsFactory.GetOperator(op);
           
            operation.Operand1 = request.Operands[0];
            operation.Operand2 = request.Operands[1];
            operation.PerformOperation();

            return new CalculationResult
            {
                Result = operation.Result
            };
        }
    }
}