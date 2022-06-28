using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDemo.Model
{
   
    
        [Table("Product")]
        public class Product
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

    

}

