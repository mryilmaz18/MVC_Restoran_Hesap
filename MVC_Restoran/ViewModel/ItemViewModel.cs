using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Restoran.ViewModel
{
    public class ItemViewModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal ItemUcret { get; set; }
    }
}