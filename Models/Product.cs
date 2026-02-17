using System.ComponentModel.DataAnnotations;

namespace FormApp.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Lütfen urun adi girin")]
        [Display(Name = "Urun Adi")]
 
        public string Name { get; set; } = null!;

        [Required]
        [Range(1,100000 ,ErrorMessage="Lütfen 1, 100.000 arasi bir deger girin")]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

        [Display(Name = "Resim")]
        
        public string? Image { get; set; } = string.Empty;
        
        public bool IsActive { get; set; }


        [Required]
        [Display(Name = "Category")]

       
        public int? CategoryId { get; set; }
    }
}