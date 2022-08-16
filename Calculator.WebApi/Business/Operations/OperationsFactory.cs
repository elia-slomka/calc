using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.WebApi.Business.Operations
{
    public class OperationsFactory : IOperationsFactory
    {
        private readonly IDictionary<string, IOperation> _operations;

        public OperationsFactory(IEnumerable<IOperation> operations)
        {
            _operations = operations.ToDictionary(o => o.Operand, o => o);
        }

        public IOperation GetOperator(string op)
        {
            if (!_operations.TryGetValue(op, out var operation))
                throw new ArgumentException($"Operand {op} is not supported");
            return operation;
        }
    }
}