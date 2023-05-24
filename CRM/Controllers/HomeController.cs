using Access.Interfaces;
using CRM.Models;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Diagnostics;

namespace CRM.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _db;
        public HomeController(IUnitOfWork db)
        {
           _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllCuatomer()
        {
            return Json(_db.customer.GetAll());
        }

        public JsonResult Add(CustomerTbl c)
        {
            _db.customer.Add(c);
            return Json(_db.Complate());
        }
        public JsonResult Update(CustomerTbl c)
        {
            _db.customer.Update(c);
            return Json(_db.Complate());
        }
        public JsonResult Delete(CustomerTbl c)
        {
            _db.customer.Delete(c);
            return Json(_db.Complate());
        }
    }
}