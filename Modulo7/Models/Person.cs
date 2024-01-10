using Modulo7.Atributos;
using System.ComponentModel.DataAnnotations;

namespace Modulo7.Models
{
    public class Person
    {
     


        [Display(Name = "MyName")]
        [Required(ErrorMessage = "Please enter a name.")]
        [AllLettersValidationAttribute(ErrorMessage = "Onlylettersallowed.")]
        public string Name { get; set; }

        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime Birthdate{ get; set; }
       
        [Display(Name = "Email Address")]
        [Required]
     
        
        public string EmailAddress { get; set; }
    
        [DataType(DataType.MultilineText)]
        [StringLength(20)]

        public string Description { get; set; }

        [Range(0, 150)]
        public int Age { get; set; }


        public bool ContactMe { get; set; }

}
}
