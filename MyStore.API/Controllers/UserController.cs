﻿using System;
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
            if (userGet is null)
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
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

     
        [HttpPut("{id}")]
        public async Task<ActionResult<UserUpdateResources>> PutUser(int id, UserUpdateResources userUpdate)
        {
            var user = await _userService.GetUserById(id); //hämtar en användare
            var autoMappedUser = _mapper.Map<UserUpdateResources, User>(userUpdate); // mappar över från 

            await _userService.UpdateUser(user, autoMappedUser);
              
            //TODO:
            // hämta användare återigen efter update
            // när du gör en getuserby id, blanda inte ihop gör en var NewUser t.ex lägg i return..

                return Ok( );
       

        }
 

        //// DELETE: api
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{


        //}
    }
}
