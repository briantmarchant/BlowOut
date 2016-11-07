using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOutBrianMarchant.Models
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        public int InstrumentID { get; set; }
        public string InstrumentDescription { get; set; }
        public string InstrumentCondition { get; set; }
        public double InstrumentPrice { get; set; }
        public int ClientID { get; set; }
    }
}