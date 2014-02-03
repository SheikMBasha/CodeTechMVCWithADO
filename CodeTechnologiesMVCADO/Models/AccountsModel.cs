using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class AccountsModel
    {
        public int Id { get; set; }
        public InstituteModel InstituteId { get; set; }
        public PrometricModel SiteId { get; set; }
        public DateTime DateOfDeposit { get; set; }
        public int AmountDebited { get; set; }
        public int AmountCredited { get; set; }
        public VoucherModel VoucherId { get; set; }
        public string CandidateId { get; set; }
    }
}