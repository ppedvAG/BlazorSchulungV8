using System.ComponentModel.DataAnnotations;

namespace BlazorSchulungV8.Components.Pages.Modul5
{
    public class Person
    {
        [Required(ErrorMessage ="Da muss was rein")]
        [StringLength(10,ErrorMessage ="max 10")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Da muss was rein")]
        [Range(150,190,ErrorMessage ="zwischen {0} und {1}")]
        public int  Gross { get; set; }

        [Required(ErrorMessage = "Da muss was rein")]
        public DateTime GebDat { get; set; }
    }
}
