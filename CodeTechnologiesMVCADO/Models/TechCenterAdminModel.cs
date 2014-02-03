using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class TechCenterAdminModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecurityQuestion1 { get; set; }
        public string AnswerQuestion1 { get; set; }
        public string SecurityQuestion2 { get; set; }
        public string AnswerQuestion2 { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}