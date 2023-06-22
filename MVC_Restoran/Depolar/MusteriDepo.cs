using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Restoran.Models;

namespace MVC_Restoran.Depolar
{
    public class MusteriDepo
    {

        private RestoranDb1Entities objRestoranDb1Entities;
        public MusteriDepo()
        {
            objRestoranDb1Entities = new RestoranDb1Entities();
        }
        public IEnumerable<SelectListItem> GetAllMusteri()
        {
            var objSelectListItems = (from obj in objRestoranDb1Entities.Musteri
                                      select new SelectListItem()
                                      {
                                          Text = obj.MusteriAd,
                                          Value = obj.MusteriId.ToString(),
                                          Selected = true
                                      }).ToList();
            return objSelectListItems;
        }
    }
}