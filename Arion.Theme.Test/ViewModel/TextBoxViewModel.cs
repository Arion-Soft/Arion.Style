using Arion.Theme.Test.Models;

namespace Arion.Theme.Test.ViewModel
{
    public class TextBoxViewModel
    {
        public Person Person { get; set; }

        public TextBoxViewModel()
        {
            Person = new Person
            {
                Surname = "Малахов",
                Age = 20
            };
        }
    }
}