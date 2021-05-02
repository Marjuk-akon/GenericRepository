using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenericRepository.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
      //  public string City { get; set; }


    }
}