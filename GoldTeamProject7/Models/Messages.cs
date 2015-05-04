using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoldTeamProject7.Models
{
    public class Messages
    {
        public int ID { get; set; }        
        public string Message { get; set; }
        public DateTime? DateSent { get; set; }
        public int TransactionID { get; set; }
        public virtual Transaction Transaction { get; set; }

    }
}