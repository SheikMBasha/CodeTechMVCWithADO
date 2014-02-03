using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTechnologiesMVC.Models
{
    public class ExamsTrainingModel
    {
        public int Id { get; set; }
        public ExamsModel ExamId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TrainingCost { get; set; }
        public int TotalAmountReceived { get; set; }
        public TrainerModel TrainerID { get; set; }
    }
}