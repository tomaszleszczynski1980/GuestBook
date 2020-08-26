using GuestBook.Models;
using System.Collections.Generic;

namespace GuestBook.Controllers
{
    public class GuestBookRepository
    {   
        private readonly GuestBookContext _context;

        public GuestBookRepository (GuestBookContext context)
	    {
            _context = context;
	    }

        public List<GuestBook> GetAllEntries() {
            _context.GuestBook.ToListAsync();
        }
    }
}