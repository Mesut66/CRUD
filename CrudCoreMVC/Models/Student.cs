using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCoreMVC.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Tam adınızı girin!")]
        [StringLength (25, ErrorMessage = "Bu isim çok uzun.")]
        [Display(Name = "Tam Adı")]
        public string FullName { get; set; }

        [Display(Name = "Adı")]
        public string MiddleName { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "Mail Adresi")]
        public string EmailAddress { get; set; }

        [Range(15,25, ErrorMessage = "Yaş aralığınız 15-25 arası olmalıdır")]
        public int Age { get; set; }

        public DateTime Birthday { get; set; }

        [Range(0,4.0, ErrorMessage = "Geçerli bir not ortalaması girin")]
        public double GPA { get; set; }

        //Relations
        public virtual Teacher Teacher { get; set; }
        [Display(Name = "Öğretmen Adı")]
        public int TeacherId { get; set; }

    }
}
