using System.ComponentModel.DataAnnotations;

namespace daraz.Datamodel
{
    public class Block
    {
        [Key]
        public int Block_ID { get; set; }
        public string? Block_Name { get; set; }
        public string? Block_Address { get; set; }
        public string? Block_Number { get; set; }
       public string? Feedback { get; set; }
        public string? Suggestions { get; set; }
       
    }
}
