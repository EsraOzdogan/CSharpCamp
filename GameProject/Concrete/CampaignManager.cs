using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "campaign added"); 
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "campaign deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "campaign updated");
        }
    }
}
