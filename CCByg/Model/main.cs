
using System.Diagnostics;
using System.Linq;
using CCByg.ViewModel;

namespace CCByg.Model
{
    public static class Main
    {
        static Main()
        {
        }
        public static DBContext DbContext { get; }
        public static MainPageViewModel MainPageVMContext { get; }
        public static InventoryPageViewModel InventoryPageVMContext { get; }
        public static ProjectPageViewModel ProjectPageVMContext { get; }
        public static StaffPageViewModel StaffPageVMContext { get; }
        public static CatalogBase catalogBase { get; }

    }
}