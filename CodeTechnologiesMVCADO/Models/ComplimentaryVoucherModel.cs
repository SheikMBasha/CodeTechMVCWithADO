using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class ComplimentaryVoucherModel
    {
        public int Id { get; set; }
        public int BatchId { get; set; }
        public string VoucherNo { get; set; }
        public BatchModel batch { get; set; }
    }
}