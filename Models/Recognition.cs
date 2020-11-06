using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Team6_MIS4200.Models
{
    public class Recognition
    {
       
        [Key]
        public int surveyID { get; set; }

        public Guid EmployeeID { get; set; }
     
        public string coreValue { get; set; }

        public string reasoning { get; set; }
        [ForeignKey("EmployeeID")] 
        public virtual Employees Employees { get; set; }
}
}