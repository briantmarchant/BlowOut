using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOutBrianMarchant.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Required(ErrorMessage="Please enter a first name")]
        public string ClientFirstName { get; set; }
        [Required(ErrorMessage = "Please enter a last name")]
        public string ClientLastName { get; set; }
        [Required(ErrorMessage = "Please enter an address")]
        public string ClientAddress { get; set; }
        [Required(ErrorMessage = "Please enter a city")]
        public string ClientCity { get; set; }
        [Required(ErrorMessage = "Please enter a state")]
        public string ClientState { get; set; }
        [Required(ErrorMessage = "Please enter a zip code")]
        [StringLength(5, MinimumLength=5, ErrorMessage="You must enter a 5 digit number")]
        public string ClientZip { get; set; }
        [Required(ErrorMessage = "Please enter an email address")]
        public string ClientEmail { get; set; }
        [Required(ErrorMessage = "Please enter a phone number")]
        public string ClientPhone { get; set; }
    }
}