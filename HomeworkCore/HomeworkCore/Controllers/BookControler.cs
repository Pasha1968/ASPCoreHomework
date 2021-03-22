using HomeworkCore.Data;
using HomeworkCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeworkCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookControler : ControllerBase
    {
        // GET: api/<BookControler>
        [HttpGet]
        public IActionResult Get()
        {
            List<Book> bookList;
            using (AppDB db = new AppDB())
            {
                bookList = db.Books.ToList();//.Select(x => new Book(x)).ToList();
            }
            return Ok(bookList);
        }

        // GET api/<BookControler>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookControler>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookControler>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookControler>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
