//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeManageWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tasks
    {
        public int TasksID { get; set; }
        public double TasksStartDate { get; set; }
        public System.DateTime TasksEndDate { get; set; }
        public double TasksHours { get; set; }
        public byte TasksStatus { get; set; }
        public System.DateTime TasksStartDateActual { get; set; }
        public System.DateTime TasksEndDateActual { get; set; }
        public double TasksHoursActual { get; set; }
        public double TasksHoursCoding { get; set; }
        public double TasksHoursTesting { get; set; }
        public double TasksHoursOthers { get; set; }
        public double TasksSV { get; set; }
        public double TasksEV { get; set; }
        public byte TasksIsMilestone { get; set; }
        public int TasksProjectID { get; set; }
    }
}
