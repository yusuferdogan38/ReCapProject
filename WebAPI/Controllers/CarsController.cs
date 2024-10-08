using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);


        }

        [HttpGet("getbyid")]
        IActionResult GetById(int carId) {
        
            var result = _carService.GetByCarId(carId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete]
        IActionResult Delete(int carId) {
            var result = _carService.Delete(carId);
            if (result.Success)
            {
                return Ok(result.Success);

            }
            return BadRequest(result.Message);
        }



    }
}
