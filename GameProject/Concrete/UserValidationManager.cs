using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        /* public bool Validate(Gamer gamer)
         {
             if (gamer.BirthYear == 1998 && gamer.FirstName == "Esra" && gamer.LastName == "Özdoğan" && gamer.IdentityNumber == 12345)
             {
                 return true;
             }
             else
             {
                 return false;
             }

         }*/
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
