using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class ExamCodeModel
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string ExamType { get; set; }
        public string ExamCode1 { get; set; }
    }
}