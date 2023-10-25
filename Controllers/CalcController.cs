using lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Controllers
{

    [ApiController]
    [Route("calc")]
    public class CalcController : ControllerBase
    {
        private readonly CalcService service;
        //використання  цього конструктору дає можливість скористатись методами calcService
        public CalcController(CalcService calcService)
        {
            service = calcService;
        }

        [HttpGet("add")]
        public IActionResult Add(int oneNum, int twoNum)//це інтерфейс, який представляє результат відповіді на HTTP-запит
        {
            var result = service.Add(oneNum, twoNum);
            return Ok($"Введені числа {oneNum} та {twoNum}отримуємо результат при додавані : {result}");
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(int oneNum, int twoNum)
        {
            var result = service.Subtract(oneNum, twoNum);
            return Ok($"Введені числа {oneNum} та {twoNum}отримуємо результат при віднімані: {result}");
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(int oneNum, int twoNum)
        {
            var result = service.Multiply(oneNum, twoNum);
            return Ok($"Введені числа {oneNum} та {twoNum}отримуємо результат при множені: {result}");
        }

        [HttpGet("divide")]
        public IActionResult Divide(int oneNum, int twoNum)
        {
            try
            {
                var result = service.Divide(oneNum, twoNum);
                return Ok($"Введені числа {oneNum} та {twoNum}отримуємо результат при ділені: {result}");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}
