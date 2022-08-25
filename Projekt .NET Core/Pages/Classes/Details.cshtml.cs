using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_.NET_Core.Data;
using Projekt_.NET_Core.Models;

namespace Projekt_.NET_Core.Pages.Classes
{
    public class DetailsModel : PageModel
    {
        private readonly Projekt_.NET_Core.Data.Projekt_NET_CoreContext _context;

        public DetailsModel(Projekt_.NET_Core.Data.Projekt_NET_CoreContext context)
        {
            _context = context;
        }

        public Class Class { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Class = await _context.Classes.FirstOrDefaultAsync(m => m.ID == id);

            if (Class == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
