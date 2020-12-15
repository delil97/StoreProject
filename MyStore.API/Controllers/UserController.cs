using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.API.Resources;
using MyStore.Core.Models;
using MyStore.Core.Services;

namespace MyStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService musicService, IMapper mapper)
        {
            this._userService = musicService;
            this._mapper = mapper;
        }

        //GET api
        [HttpGet("")]
        public async Task<ActionResult<UserResources>> AuthenticateUser(string username, string password)
        {
            var userGet = await _userService.GetUserWithAdress(username, password);

            if(userGet is null)
            {
                return NotFound("User not found");
            }

            var automappedUser = _mapper.Map<User, UserResources>(userGet); // Vad gör den här???

            return Ok(automappedUser);
        }

        // POST api 

        [HttpPost]
        public async Task<ActionResult<UserResources>> PostUser(User user)
        {
            try
            {
                var userPost = await _userService.CreateUser(user);

                return Ok(userPost);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        // PUT api
        [HttpPut("{id}")]
        public async Task<ActionResult<UserResources>> PutUser(int id, [FromBody] User user)
        {

            // return value

        }

        // DELETE: api
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


    }
}
