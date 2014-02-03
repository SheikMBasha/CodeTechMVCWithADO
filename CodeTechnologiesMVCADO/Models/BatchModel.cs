using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class BatchModel
    {
        public int BatchId { get; set; }
        public string BatchNo { get; set; }
        public ExamTypeModel Type { get; set; }
        public ExamNatureModel Nature { get; set; }
        public ClientModel ClientId { get; set; }
        public DateTime ReceivedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double Price { get; set; }
        public string Vendor { get; set; }
    }
}