using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projekt_.NET_Core.Models;

namespace Projekt_.NET_Core.Data
{
    public class Projekt_NET_CoreContext : DbContext
    {
        public Projekt_NET_CoreContext (DbContextOptions<Projekt_NET_CoreContext> options)
            : base(options)
        {
        }

        public DbSet<Projekt_.NET_Core.Models.Class> Classes { get; set; }

        public DbSet<Projekt_.NET_Core.Models.User> Users { get; set; }
    }
}
