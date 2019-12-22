using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly Interfaces.IUserRepository _userRepository;

        public UsersController(Interfaces.IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<Models.User> users = _userRepository.List();
            return new JsonResult(users);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Models.User user = _userRepository.Get(id);
            return new JsonResult(user);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.User user)
        {
            _userRepository.Insert(user);
            return new JsonResult(user);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Models.User user)
        {
            _userRepository.Update(user);
            return new JsonResult(user);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userRepository.Delete(id);
            return Ok();
        }
    }
}