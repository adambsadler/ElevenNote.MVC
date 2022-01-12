using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        [MinLength(2, ErrorMessage = "The category name must contain at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "The category name cannot contain more than 50 characters.")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [MaxLength(500)]
        public string Description { get; set; }

        public virtual ICollection<Note> Notes { get; set; } = new List<Note>();
    }
}
