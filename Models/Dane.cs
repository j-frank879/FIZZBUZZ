using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FIZZBUZZ.Pages.Forms
{
    public class Dane
    {
        public int Id { get; set; }
        [BindProperty]
        [Range(1, 1000, ErrorMessage = "Podaj liczbe z zakresu od 1 do 1000"),
            Required(ErrorMessage = "Wpisz liczbe"),
       ]
        public int Liczba { get; set; }
        [BindProperty(SupportsGet = true)]
        [MaxLength(35)]
        public string Komunikat { get; set; }
        [Column(TypeName = "datetime")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Date { get; set; }
        [BindProperty]
        public string Name_User { get; set; }

        public void fizzbuzz()
        {
            Komunikat = "";
            if (Liczba % 3 == 0)
            {
                Komunikat += "FIZZ";
            }
            if (Liczba % 5 == 0)
            {
                Komunikat += "BUZZ";

            }
            if (Komunikat.Equals(""))
            {
                Komunikat = "Liczba:" + Liczba + " nie spełnia kryteriów ";

            }

        }
    }
}
