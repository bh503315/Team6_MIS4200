using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team6_MIS4200.Models
{
    public class Recognition
    {
       
        public Guid ID { get; set; }
        public int surveyID { get; set; }

        public string coreValue { get; set; }

        public string reasoning { get; set; }

        public virtual Employees Employees { get; set; }
}
}