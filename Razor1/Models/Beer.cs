using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Razor1.Models
{
    public class Beer 
    {   
        [Key]
        [Display(Name="Beer Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name="Beer Name")]
        [StringLength(25, ErrorMessage ="Name field is required and can be no more than 25 chars")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Country")]
        [StringLength(50,ErrorMessage ="Country can be no more than 50 chars")]                     
        public string Country { get; set; }
    }
}
