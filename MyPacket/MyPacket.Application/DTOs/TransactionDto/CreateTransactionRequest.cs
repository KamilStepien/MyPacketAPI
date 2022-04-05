using System.ComponentModel.DataAnnotations;

namespace MyPacket.Application.DTOs.TransactionDto
{
    public class CreateTransactionRequest
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public bool IsExpense { get; set; }
    }
}
