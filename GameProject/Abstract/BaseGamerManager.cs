using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine(" " + gamer.FirstName + " user added.");
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine(" " + gamer.FirstName + " user deleted.");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine(" " + gamer.FirstName + " user updated.");
        }
    }
}
