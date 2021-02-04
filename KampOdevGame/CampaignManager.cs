using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdevGame
{
    class CampaignManager : ICampaignService
    {
        public void Add2(Campaign campaign)
        {
            Console.WriteLine("Kampanya sisteme eklendi.");
            Console.WriteLine(campaign.Id);
            Console.WriteLine(campaign.Name);
            Console.WriteLine(campaign.Detail);
        }

        public void Delete2(Campaign campaign)
        {
            Console.WriteLine("Kampanya sistemden silindi.");
        }

        public void Update2(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
