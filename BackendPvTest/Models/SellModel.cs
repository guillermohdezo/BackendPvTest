using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendPvTest.Models
{
    public class SellModel
    {
        public int UserId { get; set; }
        public List<SubSellModel> SubSellList { get; set; }
    }
}