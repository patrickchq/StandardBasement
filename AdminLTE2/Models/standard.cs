using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminLTE2.Models
{
    public class standard
    {
        public int standardId{get;set;}
        public string standardPrefix { get; set; }
        public string standardIdenttity { get; set; }
        public string standardTitle { get; set; }
        
     }
    public class ULStandard:standard
    {
       public DateTime standardIssuedate { get; set; }
       public int standardEdition { get; set; }
       public DateTime revisionDate { get; set; }
       
    }
    public class IECStandard:standard
    {

    }
}