using System.ComponentModel.DataAnnotations;

namespace MvcEF_CRUD.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }
    }
}