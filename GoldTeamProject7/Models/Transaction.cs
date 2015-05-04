using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoldTeamProject7.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Created { get; set; }
        public int BuyerID { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}