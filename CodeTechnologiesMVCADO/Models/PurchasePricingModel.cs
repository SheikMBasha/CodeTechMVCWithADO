using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class PurchasePricingModel
    {
        public int Id { get; set; }
        public string VendorId { get; set; }
        public string ClientId { get; set; }
        public string VoucherType { get; set; }
        public string VoucherNature { get; set; }
        public int Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int BatchNo { get; set; }
    }
}