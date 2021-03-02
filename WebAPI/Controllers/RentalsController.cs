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
            var resualt = _rentalService.GetAll();
            if (resualt.Success)
            {
                return Ok(resualt.Data);
            }
            return BadRequest(resualt.Message);
        }

        [HttpGet("getbyrental")]
        public IActionResult GetByRentalDetail()
        {
            var resualt = _rentalService.GetByRentalDetail();
            if (resualt.Success)
            {
                return Ok(resualt.Data);
            }
            return BadRequest(resualt.Message);
        }

        [HttpGet("getbyrentalid")]
        public IActionResult GetByRentalId(int rentalId)
        {
            var resualt = _rentalService.GetByRentalId(rentalId);
            if (resualt.Success)
            {
                return Ok(resualt.Data);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("Add")]
        public IActionResult Add(Rental rental)
        {
            var resualt = _rentalService.Add(rental);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Rental rental)
        {
            var resualt = _rentalService.Update(rental);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Rental rental)
        {
            var resualt = _rentalService.Delete(rental);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }
    }
}
