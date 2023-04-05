using Arion.Theme.Test.Models;
using Arion.Theme.Test.ViewModel.Base;

namespace Arion.Theme.Test.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public Person Person { get; set; }

        public MainViewModel()
        {
            Person = new Person()
            {
                Surname = "Малахов",
                Age = 15
            };
        }
    }
}