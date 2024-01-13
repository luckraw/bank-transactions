using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bank_transactions.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        public string SWIFTCode { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
