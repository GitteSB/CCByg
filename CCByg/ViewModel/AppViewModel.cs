using CCByg.View;
using Commands.Implementation;
using Extensions.ViewModel.Implementation;

namespace CCByg.ViewModel
{
        public class AppViewModel : AppViewModelMenu
        {
            public override void AddCommands()
            {
                NavigationCommands.Add("OpenHomeView", new NavigationCommand(AppFrame, typeof(FrontView)));
                NavigationCommands.Add("OpenInventoryView", new NavigationCommand(AppFrame, typeof(InventoryView)));
                NavigationCommands.Add("OpenProjectView", new NavigationCommand(AppFrame, typeof(ProjectView)));
                NavigationCommands.Add("OpenEmployeeView", new NavigationCommand(AppFrame, typeof(EmployeeView)));
            }
        }
}
