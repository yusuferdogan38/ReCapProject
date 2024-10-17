﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }



        [HttpGet("getall")]
        IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result.Success);
            }
            return BadRequest(result.Message);
        }



        [HttpGet("getbyid")]
        IActionResult GetByBrandId(int brandId)
        {
            var result = _brandService.GetByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result.Success);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        IActionResult Add(Brand brand)
        {
            var result = _brandService.BrandAdd(brand);
            if (result.Success)
            {
                return Ok(result.Success);
            }
            return BadRequest(result.Message);
        }

          [HttpPost("update")]
        IActionResult Update(Brand brand)
        {
            var result = _brandService.BrandUpdate(brand);
            if (result.Success)
            {
                return Ok(result.Success);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("delete")]
        IActionResult Delete(Brand brand)
        {
            var result = _brandService.BrandDelete(brand);
            if (result.Success)
            {
                return Ok(result.Success);
            }
            return BadRequest(result.Message);
        }






    }
}