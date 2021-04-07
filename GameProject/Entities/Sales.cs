using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Sales:IEntity
    {
        public int OrderId { get; set; }
        public int GameId { get; set; }
        public int GamerId { get; set; }
        public int CampaignId { get; set; }
        public DateTime OrderDate
        {
            get; set;
        }
        public double indirim { get; set; }
    }
}
