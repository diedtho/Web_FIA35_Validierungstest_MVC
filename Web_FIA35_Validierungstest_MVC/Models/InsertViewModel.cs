using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Web_FIA35_Validierungstest_MVC.Models
{
    public class InsertViewModel
    {
        [Required(ErrorMessage = "Nachname wird benötigt")]
        [RegularExpression("[a-zA-Z]+")]
        [StringLength(25, ErrorMessage = "Nachname darf nur 25 Zeichen lang sein")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vorname wird benötigt")]
        [RegularExpression("[a-zA-Z]+")]
        [StringLength(25,ErrorMessage ="Vorname darf nur 25 Zeichen lang sein")]
        public string Vorname { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Geburtsdatum { get; set; }

        [Required]
        [Range(22,54,ErrorMessage ="Zwischen 22 und 54")]
        [Display(Name="Schuhgröße")]
        public int Schuhgroesse { get; set; }

        [Required]
        [Range(0, 9999999, ErrorMessage = "Zwischen 0 und 9999999 €")]
        public double Wunschgehalt { get; set; }
    }
}