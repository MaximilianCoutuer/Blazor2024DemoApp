namespace Blazor2024DemoApp.Components.Exercise
{
    public class Person
    {
        public string Name { get; set; } = "";
        public string FirstName { get; set; } = "";
        public int Age { get; set; }
        public bool IsInetumEmployee { get; set; }

        public override string ToString()
        {
            return $"{Name} {FirstName}, age {Age}";
        }
    }
}
