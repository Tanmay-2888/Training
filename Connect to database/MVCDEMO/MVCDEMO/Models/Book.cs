using System;
using System.ComponentModel.DataAnnotations;

namespace MVCDEMO.Models
{
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]

        public int Id { get; set; }

        [Display(Name="Book Name")]
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }


        [Display(Name="AuthorName")]
        [Required(ErrorMessage ="AuthorName is Required")]
        public string AuthorName { get; set; }

        [Display(Name="PublisherName")]
        [Required(ErrorMessage ="PublisherName is required")]
        public string PublisherName { get; set; }

        [Required(ErrorMessage ="Date is Required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage ="Price is Required")]
        [Range(minimum:100,maximum:1000,ErrorMessage ="Price Between 100-1000")]
        public int Price { get; set; }
    }
}
