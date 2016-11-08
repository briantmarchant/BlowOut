using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOutBrianMarchant.Models
{
    [Table("State")]
    public class State
    {
        
        [Key]
        [DisplayName("State")]
        public string StateID { get; set; }
        [DisplayName("State")]
        public string StateName { get; set; }
    }
}