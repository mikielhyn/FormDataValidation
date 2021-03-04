using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormDataValidation.Models
{
    public class PersonModel
    {

        [Required]
        [StringLength(8)]
        public string StdID { get; set; }

        [Required]
        public string Fname { get; set; }

        [Required]
        public string Lname { get; set; }
        
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Campus { get; set; }

        [Required]
        [StringLength(50)]
        public string Course { get; set; }

        [Required]
        [Range(1, 4)]
        public int Yrlvl { get; set; }

    
   
    
    }

}
