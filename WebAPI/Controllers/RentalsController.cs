using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;
        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result=_rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result.Success);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById( int rentalId)
        {
            var result = _rentalService.GetById(rentalId);
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result.Success);

        }


        [HttpGet("getbycarid")]
        public IActionResult GetByCarId(int carId)
        {
            var result = _rentalService.GetRentalByCarId(carId);
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result.Success);

        }


        [HttpGet("getbyuserid")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _rentalService.GetRentalByUserId(userId);
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result.Success);

        }




        [HttpGet("getbydetails")]
        public IActionResult GetByDetails()
        {
            var result = _rentalService.GetRentalDetails();
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result.Success);

        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }



        [HttpPost("update")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }


        [HttpDelete("delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }




    }
}
