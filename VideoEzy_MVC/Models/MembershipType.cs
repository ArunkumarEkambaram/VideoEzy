using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoEzy_MVC.Models
{
    public class MembershipType
    {
        public short Id { get; set; }
        public short SignUpFee { get; set; }
        public short DurationInMonths { get; set; }
        public short DiscountRate { get; set; }
        public string Description { get; set; }
    }
}