﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServicesAJAX
{
    public class Menu
    {
        public int Id { get; set; }
        public string MenuText { get; set; }
        public int? ParentId { get; set; }
        public bool Active { get; set; }
        public List<Menu> List { get; set; }

    }
}