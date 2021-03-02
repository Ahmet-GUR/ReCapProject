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
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var resualt = _userService.GetAll();
            if (resualt.Success)
            {
                return Ok(resualt.Data);
            }
            return BadRequest(resualt.Data);
        }

        [HttpGet("getbyuserid")]
        public IActionResult GetByUserId(int userId)
        {
            var resualt = _userService.GetByUserId(userId);
            if (resualt.Success)
            {
                return Ok(resualt.Data);
            }
            return BadRequest(resualt.Data);
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var resualt = _userService.Add(user);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            var resualt = _userService.Delete(user);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            var resualt = _userService.Update(user);
            if (resualt.Success)
            {
                return Ok(resualt.Message);
            }
            return BadRequest(resualt.Message);
        }
    }
}
