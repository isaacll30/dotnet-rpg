using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _serivce;

        public CharacterController(ICharacterService serivce)
        {
            _serivce = serivce;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(_serivce.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(_serivce.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            return Ok(_serivce.AddCharacter(newCharacter));
        }
    }
}