using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {


            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            Gamer gamer = new Gamer { Id = 1, FirstName = "Esra", LastName = "Özdoğan", BirthYear = new DateTime(1998, 09, 15), IdentityNumber = 12345687890};

            gamerManager.Add(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);

            GameManager gameManager = new GameManager();
            Game game = new Game { Id = 1, Name = "Game Name123", UnitPrice = 120 };

            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Delete(game);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign {CampaignId  = 1, CampaignName = "Discount on game", CapmpaignDiscount = 25 };

            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer, game);

            saleManager.CampaignSale(gamer, game, campaign);


            /*GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1984,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345
            });

            //Yeni bir e devlet sistemi yapısna geçilirse NewEStateUserValidationManager
            GamerManager gamerManager1 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1984,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345

            });*/
            Console.WriteLine("Hello World!");
        }
    }
}
