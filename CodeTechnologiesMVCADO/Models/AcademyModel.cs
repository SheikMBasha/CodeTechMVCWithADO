using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class AcademyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string POCName { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}