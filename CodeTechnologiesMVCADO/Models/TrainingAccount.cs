using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class TrainingAccount
    {
        public int Id { get; set; }
        public int TrainingId { get; set; }
        public int TrainingAmountReceived { get; set; }
        public int TrainingCostIncurred { get; set; }
    }
}