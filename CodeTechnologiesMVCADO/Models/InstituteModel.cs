using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class InstituteModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string POCName { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int CreditAllowed { get; set; }
        public int CreditRemaining { get; set; }
    
    }
}