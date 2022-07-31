using Hadi_MathAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace Hadi_MathAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MathController : ControllerBase
    {
        [HttpPost(Name = "Add")]
        public double Add(MathValue mVal)
        {
            return MathOperator.Add(mVal);
        }

        [HttpPost(Name = "Substract")]
        public double Substract(MathValue mVal)
        {
            return MathOperator.Substract(mVal);
        }

        [HttpPost(Name = "Multiply")]
        public double Multiply(MathValue mVal)
        {
            return MathOperator.Multiply(mVal);
        }

        [HttpPost(Name = "Divide")]
        public double Divide(MathValue mVal)
        {
            return MathOperator.Divide(mVal);
        }
    }
}
