using System.ComponentModel.DataAnnotations;

namespace BookManagement.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(15)]
        public string Name { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }

    }
}
