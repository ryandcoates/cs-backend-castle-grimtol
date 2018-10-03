using System;
using System.Collections.Generic;
using System.Text;

namespace libgrimtol
{
    internal class CastleFactory
    {
        int roomCount;
        int richness;


        internal CastleFactory(int rooms, int riches)
        {
            Dictionary<string, Room> Castle = new Dictionary<string, Room>();
            string[] roomArray = { "GateHouse", "Kitchen", "Armory", "Vault", "GreatHall", "ThroneRoom" };

            for (int i = 0; i < rooms; i++)
            {
                
            }
        }
    }
}
