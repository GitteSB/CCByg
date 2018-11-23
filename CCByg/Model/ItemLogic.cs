using System;
using System.Diagnostics;
using System.Linq;

namespace CCByg.Model
{
        public partial class Item
        {
            public Item(string name, int amountAvailable)
            {

            }

            public void AddItem(Model.Item item)
            {
                Main.DbContext.Items.Add(item);
                Main.DbContext.SaveChanges();
            }

            public void DeleteItem(Model.Item item)
            {
                Main.DbContext.Items.Remove(item);
                Main.DbContext.SaveChanges();
            }

            public void EditItem(Model.Item itemFromDatabase, Model.Item newItem)
            {
                var query = Main.DbContext.Items.Local.First(x => x.Equals(itemFromDatabase));
                query.Name = newItem.Name;
                query.AmountAvailable = newItem.AmountAvailable;
                query.AmountAllocated = newItem.AmountAllocated;
                Main.DbContext.SaveChanges();
            }
        }
}