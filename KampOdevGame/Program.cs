using System;

namespace KampOdevGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1991,
                FirstName = "MÜYESSER",
                LastName = "CANÇELİK",
                IdentityNumber = 12345
            });

            Console.WriteLine("--------------------------------------");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add2(new Campaign
            {
                Id = 1,
                Name = "Bir Alana Bir Bedava",
                Detail="Sadece zekâ oyunlarında geçerli olacak, bir alana bir bedava kampanyası. Son tarih 20 Şubat"
            });

            Console.WriteLine("--------------------------------------");

            OrderManager orderManager = new OrderManager();
            orderManager.SatisYap(new Products
            { 
                ProductId=1,
                ProductName="Counter Strike",
                UnitPrice=25,
                Stock=1000
            
            });


        }
    }

}
