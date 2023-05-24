using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CustomerTbl
    {
        [Key]
        public int customerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        public decimal CustomerPhone { get; set; }
        [Required]
        public string CustomerAddress { get; set; }

        public virtual List<Payment> Payments { get; set; }
     }
}
