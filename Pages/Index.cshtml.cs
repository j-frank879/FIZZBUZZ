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

namespace FIZZBUZZ.Pages
{
    public class IndexModel : PageModel
    {
        
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Dane Dane { get; set; }
    


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            
                if (ModelState.IsValid)
                {Dane.Date= DateTime.Now;
                Dane.fizzbuzz();
                HttpContext.Session.SetString("Sesja",JsonConvert.SerializeObject(Dane));

                return RedirectToPage("./Dane");

            }

            return Page();



           
        }
       

        }
}





