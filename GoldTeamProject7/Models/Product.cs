using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoldTeamProject7.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public virtual byte[] MainPhoto { get; set; }
        public string Description { get; set; }
        public bool Availability { get; set; }
        public string Category { get; set; }
        public DateTime UploadDate { get; set; }

        public string ApplicationUserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}