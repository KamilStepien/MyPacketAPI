using System.ComponentModel.DataAnnotations;

namespace MyPacket.Domain
{
    public class Transaction : BaseEntity
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(128)]
        public string Name { get; set; } = string.Empty;
        
        [MaxLength(512)]
        public string Description { get; set; } = string.Empty;
        
        [Required]
        public double Amount  { get; set; }

        [Required]
        public bool IsExpense { get; set; } = false;
    }
}
