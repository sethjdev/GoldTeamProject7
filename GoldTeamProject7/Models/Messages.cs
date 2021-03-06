﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldTeamProject7.Models
{
    public class Messages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }        
        
        public string Message { get; set; }
        
        public DateTime? DateSent { get; set; }
        
        public int ProductID { get; set; }

        public int TransactionID { get; set; }
        
        public string ApplicationUserID { get; set; }

    }
}