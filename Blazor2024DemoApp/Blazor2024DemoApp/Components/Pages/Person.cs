using System.ComponentModel.DataAnnotations;

namespace Blazor2024DemoApp.Components.Pages
{
    public class Person
    {
        [NameValidator]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public DateTime Birthday { get; set;}
        public int City { get; set;}
        public string Gender { get; set;}
    }
}
