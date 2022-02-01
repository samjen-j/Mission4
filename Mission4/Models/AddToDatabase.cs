using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class AddToDatabase
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        
        [Required(ErrorMessage ="Put in the title")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Put in the year")]
        public ushort Year { get; set; }
        
        [Required(ErrorMessage = "Put in the director")]
        public string Director { get; set; }
        
        [Required(ErrorMessage = "Put in the rating")]
        public string Rating { get; set; }
        
        public bool Edited { get; set; }
        
        public string Lent { get; set; }
        
        [StringLength(25)]
        public string Notes { get; set; }

        //Build foreign key
        [Required(ErrorMessage = "Put in the category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
