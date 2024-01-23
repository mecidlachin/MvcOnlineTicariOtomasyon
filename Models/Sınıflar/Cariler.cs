using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Cariler
    {
        [Key]
        public int CariID { get; set; }

        [Display(Name = "Cari Adı")]
        [Column(TypeName = "Varchar")]
        [Required(ErrorMessage = "Bu Alanı Boş Geçemezsiniz...")]
        [StringLength(30, ErrorMessage = "En Fazla 30 Karakter Yazabilirsiniz...")]
        public string CariAd { get; set; }

        [Display(Name = "Cari Soyadı")]
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En Fazla 30 Karakter Yazabilirsiniz...")]
        [Required(ErrorMessage = "Bu Alanı Boş Geçemezsiniz...")]
        public string CariSoyad { get; set; }

        [Display(Name = "Cari Şehiri")]
        [Column(TypeName = "Varchar")]
        [Required(ErrorMessage = "Bu Alanı Boş Geçemezsiniz...")]
        [StringLength(13, ErrorMessage = "En Fazla 13 Karakter Yazabilirsiniz...")]
        public string CariSehir { get; set; }

        [Display(Name = "Mail Hesabı")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Required(ErrorMessage = "Bu Alanı Boş Geçemezsiniz...")]
        public string CariMail { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        [Required(ErrorMessage = "Bu Alanı Boş Geçemezsiniz...")]
        public string CariSifre { get; set; }

        public bool Durum { get; set; }

        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}