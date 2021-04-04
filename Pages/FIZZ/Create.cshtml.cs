using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FIZZBUZZ.Data;
using FIZZBUZZ.Pages.Forms;

namespace FIZZBUZZ.Pages.FIZZ
{
    public class CreateModel : PageModel
    {
        private readonly FIZZBUZZ.Data.FizzContext _context;

        public CreateModel(FIZZBUZZ.Data.FizzContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Dane Dane { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dane.Add(Dane);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
