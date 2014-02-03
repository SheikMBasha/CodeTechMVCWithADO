using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class PrometricModel
    {
        public int SiteId { get; set; }
        public string Name { get; set; }
        public string POCName { get; set; }
        public int POCPhone { get; set; }
        public string POCEmail { get; set; }
        public string SiteAddress { get; set; }
        public bool IsHired { get; set; }
        public string PerExamProfit { get; set; }
        public int TCAAdminId { get; set; }
        public string SiteOwnerName { get; set; }
    }
}