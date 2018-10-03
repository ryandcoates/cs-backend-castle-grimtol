using System;
using System.Collections.Generic;
using System.Text;

namespace libgrimtol
{
    internal class Room
    {
        internal string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        internal string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<Item> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Dictionary<string, Room> Exits { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        Room(string name, string desc, int r)
        {
            Name = name;
            Description = desc;
            Items = new List<Item>();
            for (int i = 0; i < r; i++)
            {
                
                var j = new Item();
                Items.Add(j);
            }
           
        }

        internal List<Item> GetItem()
        {
            return Items;
        }
    }


}
