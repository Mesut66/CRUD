using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCoreMVC.Models
{
    public class School
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Lütfen isim girin!")]
        [StringLength(20, ErrorMessage = "Bu isim çok uzun.")]
        [Display(Name = "Adı")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Lütfen Adres girin!")]
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Kuruluş yılı")]
        public DateTime FoundingYear { get; set; }
        [Display(Name = "Öğrenci numarası")]
        public int NumberOfStudents { get; set; }

        //Relations
        public List<Teacher> Teachers { get; set; }

    }
}
