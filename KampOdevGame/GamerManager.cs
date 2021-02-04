using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdevGame
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt oluşturuldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt SİLİNDİ");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt SİLME başarısız");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt GÜNCELLENDİ");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt GÜNCELLEME başarısız");
            }
        }
    }
}