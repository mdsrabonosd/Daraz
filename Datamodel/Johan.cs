using System.ComponentModel.DataAnnotations;

namespace daraz.Datamodel
{
    public class Johan
    {
        [Key]
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? Description { get; set; }
            
        public string? Author { get; set; }
         
    }
}
