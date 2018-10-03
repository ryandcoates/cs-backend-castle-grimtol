using System;
using System.Collections.Generic;
using System.Text;

namespace libgrimtol
{
    public class Base
    {
        internal Dictionary<string, Game> Games { get; set; } = new Dictionary<string, Game>();
        internal string GameId { get; private set; } = "";

        public string GetGameId()
        {
            return GameId;
        }
        public void StartGame()
        {
            throw new NotImplementedException();
        }

        public void ProcessCommand(string com)
        {
            //throw new NotImplementedException();
        }

        public void GetGameState()
        {
            throw new NotImplementedException();
        }
    }
}
