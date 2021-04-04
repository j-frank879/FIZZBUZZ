using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FIZZBUZZ.Data;
using FIZZBUZZ.Pages.Forms;

namespace FIZZBUZZ.Pages.FIZZ
{
    public class IndexModel : PageModel
    {
        private readonly FIZZBUZZ.Data.FizzContext _context;

        public IndexModel(FIZZBUZZ.Data.FizzContext context)
        {
            _context = context;
        }

        public IList<Dane> Dane { get;set; }

        public async Task OnGetAsync()
        {
            

            
            IQueryable<Dane> daneIQ = from s in _context.Dane
                                      select s;
            daneIQ = daneIQ.OrderByDescending(s => s.Date);
            Dane =await daneIQ.AsNoTracking().ToListAsync();
        }
    }
}
