using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Web_FIA35_Validierungstest_MVC.Models
{
    public class InsertViewModel
    {
        [Required(ErrorMessage ="Nötig")]
        [RegularExpression("[a-zA-Z]+")]
        [StringLength(25, ErrorMessage = "Nachname wird benötigt")]
        public string Name { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z]+")]
        [StringLength(25,ErrorMessage ="Vorname wird benötigt")]
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
