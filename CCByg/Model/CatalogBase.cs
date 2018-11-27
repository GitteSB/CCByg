using CCByg.View;
using Microsoft.Extensions.Logging;

namespace CCByg.Model
{
    public class CatalogBase
    {
        public void Create(string table, string name, int amountAvailable)
        {
            switch (table)
            {
                case "item":
                    Main.DbContext.Items.Add(new Item(name, amountAvailable));
                    Create("logger", name, amountAvailable);
                    break;
                case "logger":
                    Main.DbContext.Logbooks.Add(new Logbook(name, table, "Create"));
                    Main.DbContext.SaveChanges();
                    break;
                case "project":
                    Main.DbContext.Projects.Add(new Project(name));
                    Create("logger", name, amountAvailable);
                    break;
                case "staff":
                    Main.DbContext.Staffs.Add(new Staff(name));
                    Create("logger", name, amountAvailable);
                    break;
            }
        }
    }
}