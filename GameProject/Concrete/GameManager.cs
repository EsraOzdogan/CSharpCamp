using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("'" + game.Name + "'" + " game added.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("'" + game.Name + "'" + " game deleted.");
        }

        public void Update(Game game)
        {
            Console.WriteLine("'" + game.Name + "'" + " game updated.");
        }

    }
}
