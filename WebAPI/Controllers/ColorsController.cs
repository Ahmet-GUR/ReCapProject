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
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var resualt = _colorService.GetAll();
            if (resualt.Success)
            {
                return Ok(resualt.Data);
            }
            return BadRequest(resualt.Message);
        }

        [HttpGet("getbycolorid")]
        public IActionResult GetByColorId(int colorId)
        {
            var resualt = _colorService.GetByColorId(colorId);
            if (resualt.Success)
            {
                return Ok(resualt.Data);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Color color)
        {
            var resualt = _colorService.Add(color);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Color color)
        {
            var resualt = _colorService.Update(color);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Color color)
        {
            var resualt = _colorService.Delete(color);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }
    }
}
