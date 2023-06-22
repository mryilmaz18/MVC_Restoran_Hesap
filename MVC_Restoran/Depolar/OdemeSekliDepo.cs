using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Restoran.Models;

namespace MVC_Restoran.Depolar
{
    public class OdemeSekliDepo
    {
        private RestoranDb1Entities objRestoranDb1Entities;
        public OdemeSekliDepo()
        {
            objRestoranDb1Entities = new RestoranDb1Entities();
        }
        public IEnumerable<SelectListItem> GetAllOdemeSekli()
        {
            var objSelectListItems = (from obj in objRestoranDb1Entities.OdemeSekli
                                      select new SelectListItem()
                                      {
                                          Text = obj.OdemeSekliAd,
                                          Value = obj.OdemeSekliId.ToString(),
                                          Selected = true
                                      }).ToList();
            return objSelectListItems;
        }


    }
}