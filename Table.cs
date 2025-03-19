using System.ComponentModel.DataAnnotations;

namespace Table4U
{
    public class Table
    {
        public Table()
        {
            
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public int Slot { get; set; }
    }
}
