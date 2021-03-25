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
    public class AuthorController : ControllerBase
    {
        IRepository<Author> authorRepo;

        public AuthorController(IRepository<Author> authorRepo)
        {
            this.authorRepo = authorRepo;
        }

        // GET: api/Author
        [HttpGet]
        public IEnumerable<Author> GetAuthors()
        {
            return authorRepo.GetAll();
        }

        // GET: api/Author/5
        [HttpGet("{id}")]
        public Author GetAuthor(int id)
        {
            var author = authorRepo.GetById(id);

            return author;
        }

        //// PUT: api/Author/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAuthor(int id, Author author)
        //{
        //    if (id != author.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(author).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AuthorExists(id))
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

        //// POST: api/Author
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Author>> PostAuthor(Author author)
        //{
        //    _context.Authors.Add(author);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAuthor", new { id = author.Id }, author);
        //}

        //// DELETE: api/Author/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Author>> DeleteAuthor(int id)
        //{
        //    var author = await _context.Authors.FindAsync(id);
        //    if (author == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Authors.Remove(author);
        //    await _context.SaveChangesAsync();

        //    return author;
        //}

        //private bool AuthorExists(int id)
        //{
        //    return _context.Authors.Any(e => e.Id == id);
        //}
    }
}
