using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoldTeamProject7.Models
{
    public class TransactionViewModel
    {
        public ApplicationUser CurrentUser { get; set; }
        public Product Product { get; set; }
    }
}