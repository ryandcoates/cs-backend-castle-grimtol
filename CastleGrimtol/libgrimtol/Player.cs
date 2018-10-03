using System;
using System.Collections.Generic;
using System.Text;

namespace libgrimtol
{
    internal class Player
    {

        internal string PlayerName { get; private set; }
        List<Item> Inventory { get; set; }


        Player(string name)
        {
            PlayerName = name;
            Inventory = new List<Item>();
        }

        internal List<Item> GetInventory()
        {
            return Inventory;
        }
    }
}
