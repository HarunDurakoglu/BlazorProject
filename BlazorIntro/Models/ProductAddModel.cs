using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorIntro.Models
{
    public class ProductAddModel
    {
        
        [Required(ErrorMessage = "Ürün adı zorunludur")]
        [StringLength(20,ErrorMessage = "Ürün ismi karakter sayısı aşıldı(Max 20)")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Ürün açıklaması zorunludur")]
        [StringLength(40, ErrorMessage = "Ürün açıklaması karakter sayısı aşıldı(Max 40)")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Ürün kategorisi zorunludur")]
        public string CategoryId { get; set; }

    }
}
