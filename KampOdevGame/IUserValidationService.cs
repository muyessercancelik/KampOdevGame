using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdevGame
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}