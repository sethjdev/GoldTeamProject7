using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoldTeamProject7.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public int MessageID { get; set; }
        public DateTime? Created { get; set; }
        public int BuyerID { get; set; }
        public int ProductID { get; set; }

    }
}