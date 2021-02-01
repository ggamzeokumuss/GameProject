using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==2000 && gamer.FirstName=="Gamze"&& gamer.LastName=="Okumuş" && gamer.Id==1 && gamer.IdentityNumber==1511)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
