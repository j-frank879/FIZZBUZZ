using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace FIZZBUZZ.Pages.Forms
{
    
    public class Dane
    {[BindProperty]  
        
       [Range(1, 1000, ErrorMessage = "Podaj liczbe z zakresu od 1 do 1000"),
            Required(ErrorMessage ="Wpisz liczbe"),
       ]
        public int Liczba { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Komunikat { get; set; }
        
        public DateTime Date { get; set; }

        public void fizzbuzz()
        { Komunikat = "";
            if (Liczba % 3 == 0)
            {
                Komunikat += "FIZZ";
            }
            if(Liczba%5==0)
            {
                Komunikat += "BUZZ";

            }
            if(Komunikat.Equals(""))
            {
                Komunikat = "Liczba:"+Liczba+"  nie spełnia kryteriów Fizz / Buzz";

            }
        }
    }
}
