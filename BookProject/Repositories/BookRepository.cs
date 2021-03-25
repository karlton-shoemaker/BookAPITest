using BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Repositories
{
    public class BookRepository : Repository<Book>, IRepository<Book>
    {
        public BookRepository(BookContext db) : base(db)
        {

        }
    }
}
