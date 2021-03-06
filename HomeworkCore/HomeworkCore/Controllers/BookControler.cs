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
    public class BookControler : ControllerBase
    {
        // GET: api/<BookControler>
        [HttpGet]
        public IActionResult Get()
        {
            List<Book> bookList;
            using (AppDB db = new AppDB())
            {
                bookList = db.Books
                    //.Include(u => u.Genre)
                    .ToList();
            }
            return Ok(bookList);
        }

        // GET api/<BookControler>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Book res;
            using (AppDB db = new AppDB()) {
                res = db.Books.Find(id);
            }
            return Ok(res);
        }

        // POST api/<BookControler>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            using (AppDB db = new AppDB())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
        }

        // PUT api/<BookControler>/5
        [HttpPut]
        public IActionResult Put( [FromBody] Book book)
        {
            using (AppDB db = new AppDB())
            {
                db.Entry(book).State = EntityState.Modified;
                db.Update(book);
                db.SaveChanges();
            }
            return Ok(book);
        }

        // DELETE api/<BookControler>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Book res;
            using (AppDB db = new AppDB())
            {
                res = db.Books.Find(id);
                db.Remove(res);
                db.SaveChanges();
            }
            return Ok(res);
        }
    }
}
