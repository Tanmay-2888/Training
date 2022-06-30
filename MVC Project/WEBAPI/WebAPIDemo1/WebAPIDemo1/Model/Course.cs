using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDemo1.Model
{
    
    
        [Table("Course")]
        public class Course
        {
            [Key]
            public int Id { get; set; }
            public string CourseName { get; set; }
            public decimal Fee { get; set; }
        }

    

}

