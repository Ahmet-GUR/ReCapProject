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
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var resualt = _customerService.GetAll();
            if (resualt.Success)
            {
                return Ok(resualt.Data);
            }
            return BadRequest(resualt.Message);
        }

        [HttpGet("getbycustomerid")]
        public IActionResult GetByCustomerId(int customerId)
        {
            var resualt = _customerService.GetByCustomerId(customerId);
            if (resualt.Success)
            {
                return Ok(resualt.Data);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var resualt = _customerService.Add(customer);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            var resualt = _customerService.Update(customer);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            var resualt = _customerService.Delete(customer);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }
    }
}
