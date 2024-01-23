using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Detay
    {
        [Key]
        public int DetayID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]

        [Display(Name = "Ürün Adı")]
        public string UrunAd {  get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(2000)]

        [Display(Name = "Ürün Bilgisi")]
        public string UrunBilgi { get; set; }
    }
}