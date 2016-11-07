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
        [StringLength(30, MinimumLength = 1, ErrorMessage="Cannot exceed 30 characters")]
        public string ClientFirstName { get; set; }
        [Required(ErrorMessage = "Please enter a last name")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Cannot exceed 30 characters")]
        public string ClientLastName { get; set; }
        [Required(ErrorMessage = "Please enter an address")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Cannot exceed 50 characters")]
        public string ClientAddress { get; set; }
        [Required(ErrorMessage = "Please enter a city")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Cannot exceed 30 characters")]
        public string ClientCity { get; set; }
        [Required(ErrorMessage = "Please enter a state")]
        [StringLength(14, MinimumLength = 2, ErrorMessage = "Cannot exceed 30 characters")]
        public string ClientState { get; set; }
        [Required(ErrorMessage = "Please enter a zip code")]
        [StringLength(5, MinimumLength=5, ErrorMessage="You must enter a 5 digit number")]
        public string ClientZip { get; set; }
        [Required(ErrorMessage = "Please enter an email address")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Cannot exceed 50 characters")]
        public string ClientEmail { get; set; }
        [Required(ErrorMessage = "Please enter a phone number")]
        public string ClientPhone { get; set; }
    }
}