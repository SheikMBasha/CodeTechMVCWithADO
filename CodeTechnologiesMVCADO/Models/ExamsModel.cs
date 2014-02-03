using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class ExamsModel
    {
        public int Id { get; set; }
        public string ExamNo { get; set; }
        public string ClientId { get; set; }
        public string Title { get; set; }
    
    }
}