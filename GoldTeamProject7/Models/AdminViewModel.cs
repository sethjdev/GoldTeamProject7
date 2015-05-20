using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoldTeamProject7.Models
{
    public class AdminViewModel
    {
        public IEnumerable<Product> productList { get; set; }
        public IEnumerable<ApplicationUser> userList { get; set; }
        public IEnumerable<Messages> messageList { get; set; }
    }
}
