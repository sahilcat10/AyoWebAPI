using AYOAPI.Data;
using AYOAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq.Expressions;

namespace AYOAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConversionController : ControllerBase
    {
        private IUnitConversionService _unitConversionService;

        public ConversionController(IUnitConversionService unitConversionService)
        {
            _unitConversionService = unitConversionService;
        }

        [HttpGet(Name = "GetConversion")]
        public async Task<IActionResult> Get(string fromUnit, string toUnit, string val)
        {
            try
            {
                //var expression = "2 + 3 * (5 * 3 / 2)";
                //var result = new DataTable().Compute(expression, "") + "";
                //Console.WriteLine(result);

                string ret = "";

                List<string> units = new List<string>
                {
                    fromUnit.ToLower(),
                    toUnit.ToLower()
                };

                SuccessConversionObject retObj = new SuccessConversionObject();

                var obj = await _unitConversionService.GetConversionRateByNameAsync(units);
                if (obj != null)
                {
                    if (obj.MetricUnitName == fromUnit.ToLower())
                    {
                        var formula = obj.MetricToImperialRate.Replace("M", val);
                        ret = Convert.ToDecimal(new DataTable().Compute(formula, "")).ToString("N");
                    }
                    else
                    {
                        var formula = obj.ImperialToMetricRate.Replace("I", val);
                        ret = Convert.ToDecimal(new DataTable().Compute(formula, "")).ToString("N");
                    }

                    retObj.FromUnitName = fromUnit;
                    retObj.ToUnitName = toUnit;
                    retObj.Value = val;
                    retObj.ConvertedValue = ret;
                    retObj.Message = "Success";

                    return Ok(retObj);
                }
                else
                {
                    ret = $"Conversion rate is not defined for the unit {fromUnit} to {toUnit}.";
                    retObj.FromUnitName = fromUnit;
                    retObj.ToUnitName = toUnit;
                    retObj.Value = val;
                    retObj.Message = ret;
                    return NotFound(retObj);
                }
            }
            catch (Exception ex)
            {
                ErrorConversion errObj = new ErrorConversion();
                errObj.Message = "Internal server error.";
                errObj.InnerException = ex.Message;
                errObj.StackTrace = ex.StackTrace;

                return StatusCode(500, errObj);
            }

        }
    }
}