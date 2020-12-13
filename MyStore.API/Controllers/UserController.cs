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

        [HttpGet("")]
        public async Task<ActionResult<UserResources>> AuthenticateUser(string username, string password)
        {
            var user = await _userService.GetUserWithAdress(username, password);

            if(user is null)
            {
                return NotFound("User not found");
            }

            var automappedUser = _mapper.Map<User, UserResources>(user);

            return Ok(automappedUser);
        }

        [HttpPost]
        public async Task<ActionResult<UserResources>> PostUser(User user)
        {
            //Todo. Ändra resultatet som kommer in. Kontrollera att inget av det som användaren skickar in inte är null. 

            try
            {
                return Ok(user);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
