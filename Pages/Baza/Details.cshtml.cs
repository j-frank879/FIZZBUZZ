using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FIZZBUZZ.Data;
using FIZZBUZZ.Pages.Forms;

namespace FIZZBUZZ.Pages.Baza
{
    public class DetailsModel : PageModel
    {
        private readonly FIZZBUZZ.Data.FizzContext _context;

        public DetailsModel(FIZZBUZZ.Data.FizzContext context)
        {
            _context = context;
        }

        public Dane Dane { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dane = await _context.Dane.FirstOrDefaultAsync(m => m.Id == id);

            if (Dane == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
