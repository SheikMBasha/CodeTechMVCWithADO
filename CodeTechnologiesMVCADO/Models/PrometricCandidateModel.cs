using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class PrometricCandidateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ExamNatureModel ExamNature { get; set; }
        public ExamsModel ExamId { get; set; }
        public VoucherModel VoucherId { get; set; }
        public string CandidateId { get; set; }
        public string ExamStatus { get; set; }
        public short Attempts { get; set; }
        public DateTime ExamDate { get; set; }
        public string EmailAddress { get; set; }
        public InstituteModel InstituteId { get; set; }
        public ClientModel ClientId { get; set; }
        public bool Abroad { get; set; }
    }
}