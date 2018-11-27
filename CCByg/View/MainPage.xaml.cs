using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using CCByg.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CCByg.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NavigationView_OnItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.InvokedItem is TextBlock itemContent)
            {
                switch (itemContent.Tag)
                {
                    case "Nav_Home":
                        Main.MainPageVMContext.MainPage.ContentFrame.Navigate(typeof(FrontPage));
                        break;
                    case "Nav_Inventory":
                        Main.MainPageVMContext.MainPage.ContentFrame.Navigate(typeof(InventoryPage));
                        break;
                    case "Nav_Project":
                        Main.MainPageVMContext.MainPage.ContentFrame.Navigate(typeof(ProjectPage));
                        break;
                    case "Nav_Staff":
                        Main.MainPageVMContext.MainPage.ContentFrame.Navigate(typeof(StaffPage));
                        break;
                }
            }
        }

        private void MainMenu_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MainMenu_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {

        }

        private void MainMenu_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {

        }
    }
}
