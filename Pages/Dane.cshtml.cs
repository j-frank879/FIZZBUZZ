using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FIZZBUZZ.Pages.Forms;


namespace FIZZBUZZ.Pages
{
    public class DaneModel : PageModel
    {
        
        public Dane Dane;
        public void OnGet()
        {
            
            
                var Sesja =HttpContext.Session.GetString("Sesja");
            if (Sesja != null)
            {
                Dane =JsonConvert.DeserializeObject<Dane>(Sesja);
                
            }


        }

    }
    
}
