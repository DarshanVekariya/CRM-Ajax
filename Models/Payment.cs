using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Payment
    {
        [Key]
        public int paymentId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string ServiceName { get; set; }
        [Required]
        public decimal amount { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        [ForeignKey("customerId")]
        public virtual int fkCustomerId { get; set; }
        [Required]
        [ForeignKey("serviceId")]
        public virtual int fkServiceId { get; set; }

    }
}
