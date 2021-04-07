using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);//Genel user da alınabilir //doğru yanlış döndürcek bool
    }
}
