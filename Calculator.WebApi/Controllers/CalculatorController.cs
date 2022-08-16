using Microsoft.AspNetCore.Mvc;
using Calculator.WebApi.Business;

namespace Calculator.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        
        private readonly ICalculator _calculator;

        public CalculatorController( ICalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpPost]
        public CalculationResult Get(CalculationRequest request)
        {
            return _calculator.Calculate(request);
        }
    }
}
