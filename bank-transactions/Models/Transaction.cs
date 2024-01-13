using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bank_transactions.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Beneficiary Name")]
        [Required]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Bank Name")]
        [Required]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("SWIFT Code")]
        [Required]
        public string SWIFTCode { get; set; }
        [Required]
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
