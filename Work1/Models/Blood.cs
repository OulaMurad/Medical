using System;
using System.Collections.Generic;

namespace Work.Models
{
    public partial class Blood
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? ExamDate { get; set; }
        public DateTime? ResultsDate { get; set; }
        public string Description { get; set; }
        public decimal? Hemoglobin { get; set; }
        public decimal? Hematocrit { get; set; }
        public decimal? WhiteBloodCellCount { get; set; }
        public decimal? RedBloodCellCount { get; set; }
    }
}
