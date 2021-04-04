using FIZZBUZZ.Pages.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FIZZBUZZ.Data;

namespace FIZZBUZZ.Pages
{
    public class IndexModel : PageModel
    {

        private readonly FIZZBUZZ.Data.FizzContext _context;
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Dane Dane { get; set; }


        

        public IndexModel(ILogger<IndexModel> logger, FizzContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync()
        {
            
                if (ModelState.IsValid)
                {Dane.Date= DateTime.Now;
                Dane.fizzbuzz();
                HttpContext.Session.SetString("Sesja",JsonConvert.SerializeObject(Dane));
                
                _context.Dane.Add(Dane);
                 await _context.SaveChangesAsync();

                return RedirectToPage("./Dane");

            }

            return Page();



           
        }
       

        }
}





