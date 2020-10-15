using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCoreMVC.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen adınızı girin.")]
        [DataType(DataType.Text)]
        [Display(Name = "Tam adı")]
        public string FullName { get; set; }
        [Range(25,70, ErrorMessage = "Lütfen 25-70 arasında bir yaş girin")]
        [Display(Name = "Yaş")]
        public int Age { get; set; }
        [Required]
        [Display(Name = "Kaç yıl Deneyimli")]
        public double YearsOfExperience { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Lütfen geçerli bir telefon numarası girin")]
        [Phone(ErrorMessage = "Geçerli bir telefon numarası değil")]
        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Alan")]
        public string Subject { get; set; }


        // Relations
        public virtual School School { get; set; }
        [Display(Name = "Okul Adı")]
        public int SchoolId { get; set; }

        public List<Student> Students { get; set; }

    }
}


