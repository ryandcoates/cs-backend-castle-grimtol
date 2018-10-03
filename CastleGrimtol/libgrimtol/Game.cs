using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libgrimtol
{
    internal class Game
    {
        Room CurrentRoom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Player CurrentPlayer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void GetUserInput()
        {
            throw new NotImplementedException();
        }

        void Go(string direction)
        {
            throw new NotImplementedException();
        }

        void Help()
        {
            throw new NotImplementedException();
        }

        internal List<Item> Inventory()
        {
            return CurrentPlayer.GetInventory();
        }

        internal string Look()
        {
            return CurrentRoom.Description;
        }

        void Quit()
        {
            throw new NotImplementedException();
        }

        void Reset()
        {
            throw new NotImplementedException();
        }

        void GenerateCastle()
        {

        }

        void Setup()
        {
            var Game = new Base();
            
        }

        int StartGame()
        {
            var gameId = 1;
            return gameId;
        }

        void TakeItem(string itemName)
        {
            List<Item> items = CurrentPlayer.GetInventory();
            List<Item> roomItems = CurrentRoom.GetItem();
            HashSet<Item> transfer = new HashSet<Item>(
                items.Where( x => x.GetName() == itemName ));
            items.AddRange(transfer);
            roomItems.RemoveAll(transfer.Contains);
                
        }

        void UseItem(string itemName)
        {
            throw new NotImplementedException();
        }
    }
}
