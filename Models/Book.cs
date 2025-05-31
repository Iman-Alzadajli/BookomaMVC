using System.ComponentModel.DataAnnotations;

namespace BookomaMVC.Models
{
    public class Book
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Book name is required")]
        public string Name { get; set; }

        [Display(Name = "Is Hidden")]
        public bool IsHidden { get; set; } = false;


    }
}
