using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public record UslugaBody(string nazwa, string wykonawca, string rodzaj, int rok);
    //public class UslugaBody
    //{
    //    [Required(ErrorMessage = "Nazwa jest wymagana.")]
    //    [MaxLength(100, ErrorMessage = "Nazwaa.")]
    //    public string nazwa { get; set; }

    //    [Required(ErrorMessage = "Rodzaj jest wymagany.")]
    //    [RegularExpression("^(budowlana|projektowa|edukacyjna)$",
    //        ErrorMessage = "Rodzaj")]
    //    public string rodzaj { get; set; }

    //    [Range(0, 2025, ErrorMessage = "Rok")]
    //    public int rok { get; set; }

    //    public string wykonawca;


    //    UslugaBody(string nazwa, string wykonawca, string rodzaj, int rok)
    //    {
    //        this.nazwa = nazwa;
    //        this.rodzaj = rodzaj;
    //        this.rok = rok;
    //        this.wykonawca = wykonawca;

    //    }


    //}
}
