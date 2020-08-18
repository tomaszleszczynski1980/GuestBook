using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuestBook.Data;
using Microsoft.EntityFrameworkCore;

namespace GuestBook.Controllers
{
    public class GuestBookController : Controller
    {
        private readonly GuestBookContext _context;
        
        public GuestBookController(GuestBookContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.GuestBook.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Index([Bind("Id,Message,Name")] Models.GuestBook guestBook)
        {
            _context.Add(guestBook);
            await _context.SaveChangesAsync();
            return View(await _context.GuestBook.ToListAsync());
        }
    }
}