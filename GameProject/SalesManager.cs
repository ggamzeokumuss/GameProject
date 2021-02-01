using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        ICampaignService _campaignService;
        public SalesManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }
 
        public void Sale(Campaign campaign , Gamer gamer)
        {
            Console.WriteLine(gamer.Id+ "Numaralı Müşteri" + campaign.CampaignName+ "Kampanyayı uyguladı");
        }

        internal void Add(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName +" "+ "Adlı Oyuncu"+" "+ campaign.CampaignName+ " " + "Uyguladı");
        }
    }
}
