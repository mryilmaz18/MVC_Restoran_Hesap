using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Restoran.Depolar;
using MVC_Restoran.Models;

namespace MVC_Restoran.Controllers
{
    public class HomeController : Controller
    {
        private RestoranDb1Entities objRestoranDb1Entities;
        // GET: Home
        public HomeController()
        {
            objRestoranDb1Entities = new RestoranDb1Entities();
        }
        public ActionResult Index()
        {
            MusteriDepo objMusteriDepo = new MusteriDepo();
            ItemDepo objItemDepo = new ItemDepo();
            OdemeSekliDepo objOdemeSekliDepo = new OdemeSekliDepo();

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (objMusteriDepo.GetAllMusteri(), objItemDepo.GetAllItem(), objOdemeSekliDepo.GetAllOdemeSekli());
            return View(objMultipleModels);
        }
        [HttpGet]
        public JsonResult getItemBirimFiyat(int ItemId)
        {
            decimal BirimFiyat = objRestoranDb1Entities.Item.Single(model => model.ItemId == ItemId).ItemUcret;
            return Json(BirimFiyat, JsonRequestBehavior.AllowGet);
        }
    }
}