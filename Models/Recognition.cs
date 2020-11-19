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
        [Display(Name ="Core value recognized")]

        public CoreValue award { get; set; }

        [Display(Name = "ID of Person giving the recognition")]
        public Guid recognizor { get; set; }

        [Display(Name = "ID of Person receiving the recognition")]
        
     
        public Guid Nominee { get; set; }
        [Display(Name = "Date recognition given")]

        public DateTime recognizationDate { get; set; }
        public enum CoreValue
        {
            Excellence = 1,
            Integrity = 2,
            Stewardship = 3,
            Culture = 4,
            Passion =5,
            Innovate = 6,
            Balanced = 7
        }


        public virtual Employees Employees { get; set; }
        
        


}
}