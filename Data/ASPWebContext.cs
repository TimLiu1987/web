using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPWeb.Models;

namespace ASPWeb.Data
{
    public class ASPWebContext : DbContext
    {
        public ASPWebContext (DbContextOptions<ASPWebContext> options)
            : base(options)
        {
        }

        public DbSet<ASPWeb.Models.Movie> Movie { get; set; } = default!;
    }
}
