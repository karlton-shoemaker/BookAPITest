using BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Repositories
{
    public class AuthorRepository : Repository<Author>, IRepository<Author>
    {
        public AuthorRepository(BookContext db) : base(db)
        {

        }
    }
}
