using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookProject;
using BookProject.Models;
using BookProject.Repositories;

namespace BookProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        IRepository<Book> bookRepo;

        public BookController(IRepository<Book> bookRepo)
        {
            this.bookRepo = bookRepo;
        }

        // GET: api/Book
        [HttpGet]
        public IEnumerable<Book> GetBooks()
        {
            return bookRepo.GetAll();
        }

        // GET: api/Book/5
        [HttpGet("{id}")]
        public Book GetBook(int id)
        {
            var book = bookRepo.GetById(id);

            return book;
        }

        //// PUT: api/Book/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutBook(int id, Book book)
        //{
        //    if (id != book.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(book).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!BookExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Book
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Book>> PostBook(Book book)
        //{
        //    _context.Books.Add(book);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetBook", new { id = book.Id }, book);
        //}

        //// DELETE: api/Book/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Book>> DeleteBook(int id)
        //{
        //    var book = await _context.Books.FindAsync(id);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Books.Remove(book);
        //    await _context.SaveChangesAsync();

        //    return book;
        //}

        //private bool BookExists(int id)
        //{
        //    return _context.Books.Any(e => e.Id == id);
        //}
    }
}
