using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class ExpensesModel
    {
        public int Id { get; set; }
        public string ExpenseType { get; set; }
        public int AmountPaid { get; set; }
        public DateTime Date { get; set; }
        public string PaymentChannel { get; set; }
        public PrometricModel SiteId { get; set; }
    }
}