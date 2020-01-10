using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithASP_NET_Udemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {


        // GET api/calculator/sum/5/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input");
        }

        // GET api/calculator/sub/5/5
        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid input");
        }

        // GET api/calculator/mul/5/5
        [HttpGet("mul/{firstNumber}/{secondNumber}")]
        public IActionResult Mul(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var mul = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(mul.ToString());
            }
            return BadRequest("Invalid input");
        }

        // GET api/calculator/div/5/5
        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var div = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(div.ToString());
            }
            return BadRequest("Invalid input");
        }

        // GET api/calculator/average/5/5
        [HttpGet("average/{firstNumber}/{secondNumber}")]
        public IActionResult Average(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var avg = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok(avg.ToString());
            }
            return BadRequest("Invalid input");
        }

        // GET api/calculator/square-root/5
        [HttpGet("square-root/{number}")]
        public IActionResult SquareRoot(string number)
        {
            if (IsNumeric(number))
            {
                var sqrt = Math.Sqrt((double) ConvertToDecimal(number));
                return Ok(sqrt.ToString());
            }
            return BadRequest("Invalid input");
        }


        private decimal ConvertToDecimal(string number)
        {
            decimal decimalValue;
            if (decimal.TryParse(number, out decimalValue))
                return decimalValue;
            return 0;
        }


        private bool IsNumeric(string strnumber)
        {
            double number;
            bool isNumber = double.TryParse(strnumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }
    }
}
