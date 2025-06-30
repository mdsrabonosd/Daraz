using System.ComponentModel.DataAnnotations;

namespace daraz.Datamodel2
{
    public class Library
    {
        [Key]
        public string? Name { get; set; }
        public int id { get; set; }
        public string? Email { get; set; }
        public string? Book { get; set; }
        

    }
}
