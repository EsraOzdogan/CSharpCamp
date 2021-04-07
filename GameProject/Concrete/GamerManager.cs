using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
namespace GameProject.Concrete
{
    //MicroService //Edevlet gibi bilgilerin doğrulanması için dışarıdan başka bir servis (IUserValitadionService) kullanıcak microservice
    class GamerManager : BaseGamerManager //IGamerService interfaceini GamerManager implemente ediyo
    {
        //kullanıcı kayı oluren doğrulama servisi kullanmak istiyoruz
        //GamerManager içinde UservalidaitonManager kullanıcaz
        //Eğer bir manager sınıfın içerisinde başka bir manager sınıfını kullanıcaksan newleme


        private IUserValidationService _userValidationService; //constructor

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public override void Add(Gamer gamer)
        {
            //Console.Write("Gamer added");
            if (_userValidationService.Validate(gamer))
            {
                //Console.WriteLine("Registered");
                base.Add(gamer);

            }
            else
            {
                //Console.WriteLine("Validation failed. Registration failed");
                throw new Exception("Not a valid person" + gamer.FirstName);

            }

        }

        public override void Delete(Gamer gamer)
        {
            Console.Write("Gamer deleted");
        }

        public override void Update(Gamer gamer )
        {
            Console.Write("Gamer updated");
        }
    }
}
