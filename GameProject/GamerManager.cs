using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Bilgiler Doğrulandı , Oyuncu Kaydedildi ");
            }
            else
            {
                Console.WriteLine("Bilgiler Eksik veya Yanlış , Oyuncu Kaydedilemedi");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi");
        }
    }
}
