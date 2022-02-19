using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationExam.Models
{
    public class NewClass
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Decimal Rate { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
    }
}