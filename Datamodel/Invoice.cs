using System.ComponentModel.DataAnnotations;

namespace daraz.Datamodel
{
    public class Invoice
    {
        [Key]
        public int Product_Id { get; set; }
        public string? Product_Name { get; set; }
        public string? Product_No { get; set; }
        public string?  Quantity{ get; set; }
        
    }
}
