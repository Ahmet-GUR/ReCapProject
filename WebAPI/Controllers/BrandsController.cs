using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult GetAll()
        {
            var resualt = _brandService.GetAll();
            if (resualt.Success)
            {
                return Ok(resualt.Data);
            }
            return BadRequest(resualt.Message);
        }

        [HttpGet("getbybrandid")]
        public IActionResult GetByBrandId(int brandId)
        {
            var resualt = _brandService.GetByBrandId(brandId);
            if (resualt.Success)
            {
                return Ok(resualt.Data);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var resualt = _brandService.Add(brand);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Brand brand)
        {
            var resualt = _brandService.Delete(brand);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Brand brand)
        {
            var resualt = _brandService.Update(brand);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }
    }
}
