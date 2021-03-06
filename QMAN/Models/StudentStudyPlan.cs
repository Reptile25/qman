﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QMAN.Models
{
    [Table("Student_StudyPlan")]
    public class StudentStudyPlan
    {
        [Key]
        public string StudentID { get; set; }
        [Key]
        public string QualCode { get; set; }
        public int TermCodeStart { get; set; }
        public int TermYearStart { get; set; }
        public string EnrolmentType { get; set; }
    }
}