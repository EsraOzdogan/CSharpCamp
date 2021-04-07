using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SaleManager : ISaleService
    {
        public void CampaignSale(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("'" + gamer.FirstName + " " + gamer.LastName + "'" + " purchased the game named " + "'" + game.Name + "' with " + campaign.CapmpaignDiscount + " % discount");
        }
        public void Sale(Gamer gamer , Game game)
        {
            Console.WriteLine("'" + gamer.FirstName + " " + gamer.LastName + "'" + " purchased the game named " + "'" + game.Name + "'");
        }
    }
}
