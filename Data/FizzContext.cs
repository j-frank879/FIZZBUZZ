using FIZZBUZZ.Pages.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIZZBUZZ.Data
{
    public class FizzContext:DbContext
    {
        public FizzContext(DbContextOptions options) : base(options) { }
        public DbSet<Dane> Dane { get; set; }

    }
}
