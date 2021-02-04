using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdevGame
{
    class UserValidationManager
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "MÜYESSER"
                && gamer.LastName == "CANÇELİK" && gamer.IdentityNumber == 12345)
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
