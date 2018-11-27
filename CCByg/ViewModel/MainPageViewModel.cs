using System.Windows.Input;
using CCByg.View;

namespace CCByg.ViewModel
{
    public class MainPageViewModel
    {
        public ICommand NavigateCommand { get; set; }

        private MainPage _mainPage = new MainPage();

        public MainPage MainPage { get; set; }

        
        public MainPageViewModel()
        {
        }
    }
}