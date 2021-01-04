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

            //Todo make it similar to the put method user (try and catch). Throw exception if user wrote wrong username and password in service layer.
            if (userGet is null)
            {
                return NotFound("User not found");
            }

            var automappedUser = _mapper.Map<User, UserResources>(userGet); 

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
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

     
        [HttpPut("{id}")]
        public async Task<ActionResult<UserUpdateResources>> PutUser(int id, UserUpdateResources userUpdate)
        {
            try
            {
                var user = await _userService.GetUserById(id);

                var autoMappedUser = _mapper.Map<UserUpdateResources, User>(userUpdate);

                await _userService.UpdateUser(user, autoMappedUser);

                var updatedUser = await _userService.GetUserById(id);

                var autoMappedupdatedUser = _mapper.Map<User, UserUpdateResources>(updatedUser);

                return Ok(autoMappedupdatedUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
