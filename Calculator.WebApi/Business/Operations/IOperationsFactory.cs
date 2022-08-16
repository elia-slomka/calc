namespace Calculator.WebApi.Business.Operations
{
    public interface IOperationsFactory
    {
        IOperation GetOperator(string op);
    }
}