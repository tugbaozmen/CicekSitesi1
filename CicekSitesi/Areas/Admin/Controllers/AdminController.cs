using CicekSitesi.BLL;
using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CicekSitesi.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        PersonBLL _personBLL;
        public AdminController()
        {
            _personBLL = new PersonBLL();
        }
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                Session["AdminID"] = id;
            }
            return View();
        }
        public ActionResult AdminUpdate()
        {
            int id = (int)Session["memberId"];
            Person admin = _personBLL.GetById(id);
            return View(admin);
        }

        [HttpPost]
        public ActionResult AdminUpdate(Person model)
        {
            try
            {
                Person admin = _personBLL.GetById(model.PersonId);
                model.Name = admin.Name;
                model.Surname = admin.Surname;
                model.Mail = admin.Mail;
                model.Password = admin.Password;
                model.PersonRoles = admin.PersonRoles;
                _personBLL.Update(admin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return View();
        }
    }
}