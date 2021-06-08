using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVC5.Models
{
    public class Myshop
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public bool IsAvailable { get; set; }
    }
}