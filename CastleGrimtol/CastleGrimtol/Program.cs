using System;
using System.Collections.Generic;

namespace CastleGrimtol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Castle Grimtol");
            Console.WriteLine("You can check out, but you can never leave");
            Room rm = new Room("large", 1);
            Console.WriteLine(rm.id);
            Console.Read();
        }


    }
    class Room
    {
        public Guid id { get; set; }
        public List<Tile> floor { get; set; }
        Dictionary<Tile, Guid> intersections { get; set; }
        public Room(string size, int exits)
        {
            var maxHeight = 0;
            var maxWidth = 0;

            if (size == "large")
            {
                maxHeight = 12;
                maxWidth = 12;
            }
            else if (size == "small")
            {
                maxHeight = 6;
                maxWidth = 6;
            }

            Guid id =  Guid.NewGuid();
            List<Tile> floor = new List<Tile>();
            for (int i = 0; i < maxHeight; i++)
                for (int j = 0; j < maxWidth; j++)
                    floor.Add(new Tile { X = i, Y = j });


        }
    }
    internal class Tile
    {
        internal int X { get; set; }
        internal int Y { get; set; }
        bool isWall { get; set; }
        Guid isDoorTo { get; set; }
    }
}
