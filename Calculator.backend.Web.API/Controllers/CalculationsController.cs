using Calculator.backend.Core.IServices;
using Calculator.backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.backend.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationsController : ControllerBase
    {

        readonly ICalculationsService _calculationsService;
        readonly ILogger<CalculationsController> _logger;

        public CalculationsController(ICalculationsService calculationsService, ILogger<CalculationsController> logger)
        {
            _calculationsService = calculationsService;
            _logger = logger;
        }

        [HttpGet]
        [Route("Add/{numberOne}/{numberTwo}")]
        public IActionResult Add(double numberOne, double numberTwo)
        {
            try
            {
                var result = _calculationsService.Add(numberOne, numberTwo);
                return Ok(result);
            }
            catch(Exception ex)
            {
                _logger.LogError("We caught an error in the Add function", ex);
                return BadRequest("Something went wrong.");
            }

        }

        [HttpGet]
        [Route("Substract/{numberOne}/{numberTwo}")]
        public IActionResult Substract(double numberOne, double numberTwo)
        {
            try
            {
                var result = _calculationsService.Substract(numberOne, numberTwo);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("We caught an error in the Substract function", ex);
                return BadRequest("Something went wrong.");
            }

        }

        [HttpGet]
        [Route("Multiply/{numberOne}/{numberTwo}")]
        public IActionResult Multiply(double numberOne, double numberTwo)
        {
            try
            {
                var result = _calculationsService.Multiply(numberOne, numberTwo);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("We caught an error in the Multiply function", ex);
                return BadRequest("Something went wrong.");
            }

        }

        [HttpGet]
        [Route("Divide/{numberOne}/{numberTwo}")]
        public IActionResult Divide(double numberOne, double numberTwo)
        {
            try
            {
                var result = _calculationsService.Divide(numberOne, numberTwo);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("We caught an error in the Divide function", ex);
                return BadRequest("Something went wrong.");
            }

        }
    }
}
