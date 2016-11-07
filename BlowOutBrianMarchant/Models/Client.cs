using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName ("First Name")]
        [StringLength(30, MinimumLength = 1, ErrorMessage="Cannot exceed 30 characters")]
        public string ClientFirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        [DisplayName("Last Name")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Cannot exceed 30 characters")]
        public string ClientLastName { get; set; }

        [Required(ErrorMessage = "Please enter an address")]
        [DisplayName("Address")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Cannot exceed 50 characters")]
        public string ClientAddress { get; set; }

        [Required(ErrorMessage = "Please enter a city")]
        [DisplayName("City")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Cannot exceed 30 characters")]
        public string ClientCity { get; set; }

        [Required(ErrorMessage = "Please enter a state")]
        [DisplayName("State")]
        [StringLength(14, MinimumLength = 2, ErrorMessage = "Must be between 2 and 30 characters")]
        public string ClientState { get; set; }

        [Required(ErrorMessage = "Please enter a zip code")]
        [DisplayName("Zip Code")]
        [StringLength(5, MinimumLength=5, ErrorMessage="You must enter a 5 digit number")]
        public string ClientZip { get; set; }

        [Required(ErrorMessage = "Please enter an email address")]
        [DisplayName("Email")]
        [EmailAddress]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Cannot exceed 50 characters")]
        public string ClientEmail { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        [DisplayName("Phone Number")]
        [RegularExpression ("((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}")]
        public string ClientPhone { get; set; }
    }
}