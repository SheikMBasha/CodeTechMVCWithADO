using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class SellingPricingModel
    {
        public int id { get; set; }
        public List<InstituteModel> InstituteId { get; set; }
        public List<ClientModel> ClientId { get; set; }
        public List<VoucherModel> VoucherType { get; set; }
        public List<ExamNatureModel> VoucherNature { get; set; }
        public double PriceWithVoucher { get; set; }
        public double PriceWithoutVoucher { get; set; }
        public DateTime PriceDate { get; set; }
        public double PriceWithTraining { get; set; }
    }
}