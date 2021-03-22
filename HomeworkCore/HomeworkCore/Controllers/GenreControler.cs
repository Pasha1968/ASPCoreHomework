using HomeworkCore.Data;
using HomeworkCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeworkCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreControler : ControllerBase
    {
        // GET: api/<GenreControler>
        [HttpGet]
        public IActionResult Get()
        {
            List<Genre> GenreList;
            using (AppDB db = new AppDB())
            {
                GenreList = db.Genres.Include(u => u.Books).ToList();
            }
            return Ok(GenreList);
        }

        // GET api/<GenreControler>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GenreControler>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GenreControler>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GenreControler>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
