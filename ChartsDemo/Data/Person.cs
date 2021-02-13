using System.ComponentModel.DataAnnotations;

namespace Common.Web
{
    public class Person
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }


        public int Age { get; set; }
    }
}
