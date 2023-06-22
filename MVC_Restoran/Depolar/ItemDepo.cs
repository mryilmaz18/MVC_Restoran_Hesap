using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Restoran.Models;

namespace MVC_Restoran.Depolar
{
    public class ItemDepo
    {
        private RestoranDb1Entities objRestoranDb1Entities;
        public ItemDepo()
        {
            objRestoranDb1Entities = new RestoranDb1Entities();
        }
        public IEnumerable<SelectListItem> GetAllItem()
        {
            var objSelectListItems = (from obj in objRestoranDb1Entities.Item
                                      select new SelectListItem()
                                      {
                                          Text = obj.ItemName,
                                          Value = obj.ItemId.ToString(),
                                          Selected = false
                                      }).ToList();
            return objSelectListItems;
        }

    }
}