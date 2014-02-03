using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class PrometricPromotionModel
    {
        public int id { get; set; }
        public int SiteId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int MarginGain { get; set; }
        public int MarginMiss { get; set; }
    }
}