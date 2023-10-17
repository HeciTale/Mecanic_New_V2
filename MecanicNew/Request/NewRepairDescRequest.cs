using System.ComponentModel.DataAnnotations;

namespace MecanicNew.Request
{
    public class NewRepairDescRequest
    {
        [Required(ErrorMessage = "Remont Adı boş qala bilməz.")]
        [MinLength(3, ErrorMessage = "Remont Adı minimum 3 hərfli olmalıdır.")]
        [MaxLength(30, ErrorMessage = "Remont Adı maksimum 30 hərfli olmalıdır.")]
        public string RepairText { get; set; }

        [Required(ErrorMessage = "Nece eded oldugu boş qala bilməz.")]

        public int RepairCount { get; set; }


        [Required(ErrorMessage = "Qiymet boş qala bilməz.")]

        public int RepairPrice { get; set; }
    }
}
