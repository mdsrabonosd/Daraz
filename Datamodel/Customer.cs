using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security.Cryptography;

namespace daraz.Datamodel
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName{ get; set; }     
        public string? Address{ get; set; }
        public string? StreetAddress{ get; set; }        
        public string? StreetAddressLine { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? AboutUs { get; set; }
        public string? Feedback { get; set; }
         public string? Suggestions { get; set; }
         public string? recommend { get; set; }
         

    }
}
