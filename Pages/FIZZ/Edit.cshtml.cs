using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FIZZBUZZ.Data;
using FIZZBUZZ.Pages.Forms;

namespace FIZZBUZZ.Pages.FIZZ
{
    public class EditModel : PageModel
    {
        private readonly FIZZBUZZ.Data.FizzContext _context;

        public EditModel(FIZZBUZZ.Data.FizzContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Dane).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DaneExists(Dane.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DaneExists(int id)
        {
            return _context.Dane.Any(e => e.Id == id);
        }
    }
}
