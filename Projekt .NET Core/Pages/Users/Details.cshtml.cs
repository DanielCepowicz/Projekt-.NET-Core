using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_.NET_Core.Data;
using Projekt_.NET_Core.Models;

namespace Projekt_.NET_Core.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly Projekt_.NET_Core.Data.Projekt_NET_CoreContext _context;

        public DetailsModel(Projekt_.NET_Core.Data.Projekt_NET_CoreContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.Users.FirstOrDefaultAsync(m => m.ID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
