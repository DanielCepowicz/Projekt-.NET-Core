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
    public class IndexModel : PageModel
    {
        private readonly Projekt_.NET_Core.Data.Projekt_NET_CoreContext _context;

        public IndexModel(Projekt_.NET_Core.Data.Projekt_NET_CoreContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }
    }
}
