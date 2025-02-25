using System.ComponentModel.DataAnnotations;

namespace Table4U
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public TimeOnly Time { get; set; }
        [Required]
        public int PeopleCount { get; set; }
        [Required]
        public int TableId { get; set; }
        public Table Table { get; set; }
    }
}
