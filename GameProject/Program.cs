using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {Id=1,FirstName="Gamze",LastName="Okumuş", BirthYear=2000, IdentityNumber=1511 });

            CampaignManager campaignManager = new CampaignManager();
            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager.Add(new Campaign()
                {

                CampaignName = "%10 İndirimli Öğrenci Kampanyası"


            }); 
            campaignManager1.Update(new Campaign()
            {
                CampaignName="%20 İndirim Kampanyası"
            });
            campaignManager1.Delete(new Campaign()
            {
                CampaignName="%50 İNDİRİMLİ BÜYÜK YIL SONU KAMPANYASI"
            });

            SalesManager salesManager = new SalesManager(new CampaignManager());
            salesManager.Add(new Gamer { FirstName="Gamze "}, new Campaign { CampaignName = "%20 İndirim Kampanyasını" });
                
        }
    }
}
