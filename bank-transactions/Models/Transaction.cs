﻿using System.ComponentModel;
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
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only.")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]
        public string SWIFTCode { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
