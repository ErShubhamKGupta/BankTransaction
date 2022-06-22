using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransaction.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [Required]
        [MaxLength(12,ErrorMessage ="Account Number must be 12 digits only!")]
        [MinLength(12, ErrorMessage = "Account Number must be 12 digits only!")]
        [DisplayName("Account Number")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        [DisplayName("Beneficiary Name")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        [DisplayName("Bank Name")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Required]
        [MaxLength(8, ErrorMessage = "IFSC Code must be 8 characters only!")]
        [MinLength(8,ErrorMessage = "IFSC Code must be 8 characters only!")]
        [DisplayName("IFSC Code")]
        public string IFSCCode { get; set; }

        [Required]
        [DisplayName("Amount")]
        public int Ammount { get; set; }

        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        [DisplayName("Date")]
        public DateTime TransactionDate { get; set; }
    }
}
