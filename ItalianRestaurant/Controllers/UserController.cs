using AutoMapper;
using Italian.API.Models;
using Italian.Core.DTOs;
using Italian.Core.Models;
using Italian.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Italyano.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;


        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<List<Uzer>> Get()
        {
            return _userService.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var user = _userService.GetById(id);
            var userDto = _mapper.Map<List<UserDto>>(list);
            return userDto;
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserPostModel user)
        {
            var result = Task.Run(() => _manager.Calculate(1, 2));
            var add = _userService.Add(value);

            await Task.WhenAll(result, add);

            return Ok(add);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}