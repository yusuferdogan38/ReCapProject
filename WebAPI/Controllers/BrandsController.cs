using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public  BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }




        [HttpGet("getall")]
       public  IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpGet("getbyıd")]
       public IActionResult GetById(int brandId)
        {
            var result = _brandService.GetByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
      public   IActionResult Add(Brand brand)
        {
            var result = _brandService.BrandAdd(brand);
            if (result.Success) {
                return Ok(result);
            
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.BrandAdd(brand);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result.Message);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.BrandDelete(brand);
            if (result.Success) { 
            return Ok(result);
            }
            return BadRequest(result.Message);
        }



    }

}

