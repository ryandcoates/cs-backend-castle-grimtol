using System;
using System.Collections.Generic;
using System.Text;

namespace libgrimtol
{
    internal class Item
    {
        string Name { get; set; }
        string Description { get; set; }

        internal Item()
        {
            Random rand = new Random();
            int r = rand.Next(0, 7);

            List<Item> MockItems = new List<Item>();
            MockItems.Add(new Item() { Name = "Sword of Truth", Description = "Sword that does not lie" });
            MockItems.Add(new Item() { Name = "Axe of Rinji", Description = "Looks tiny on a Gnome" });
            MockItems.Add(new Item() { Name = "Cloak of Invisibility", Description = "Sorry, I didn't see you there" });
            MockItems.Add(new Item() { Name = "Boots of Icarus", Description = "I Beleive I can Flyyyyy" });
            MockItems.Add(new Item() { Name = "A bronze key", Description = "looks a little worn" });
            MockItems.Add(new Item() { Name = "A jade key", Description = "Cloaked in 80s mystery" });
            MockItems.Add(new Item() { Name = "Extra Life", Description = "I'll be back" });

            Name = MockItems[r].Name;
            Description = MockItems[r].Description;

        }
        internal Item(string n, string d)
        {
            Name = n;
            Description = d;
        }

        internal string GetName()
        {
            return Name;
        }
    }
}
