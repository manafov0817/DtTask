using DtTask.Business.Abstract;
using DtTask.Business.Concrete;
using DtTask.Data.Concrete.EF;
using DtTask.Entity.Entities;
using System;
using System.Web.Mvc;
 
namespace DtTask.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IPersonService _personService { get; set; }
        public IPersonTypeService _personTypeService { get; set; }

        public HomeController()
        {
            _personService = new PersonManager(new EfPersonRepository());
            _personTypeService = new PersonTypeManager(new EfPersonTypeRepository());

        }

        public ActionResult Index()
        {

            return View();
        }

        public JsonResult GetUsers()
        {
            var users = _personService.GetAll();
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetUsersIncluded()
        {
            var users = _personService.GetPeopleIncluded();
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTypesByNumber(string word, int number)
        {
            var personTypes = _personTypeService.GetPersonTypesByNumber(word, number);

            return Json(personTypes, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddUser(Person person)
        {
            try
            {
                return Json(_personService.CreateWithPersonType(person), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }

        }

        public JsonResult IsUniquePerson(string name)
        {
            bool isUnique = _personService.IsUniqueUser(name);

            return Json(isUnique, JsonRequestBehavior.AllowGet);
        }
    }
}