using Site.Domain.Services.Interfaces;
using Site.Models.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Web.Controllers
{
    public class FormController : Controller
    {
        private readonly IFormService _formService;

        public FormController(IFormService formService)
        {
            _formService = formService;
        }

        [HttpPost]
        public ActionResult ContactUs(ContactUsFormModel form)
        {
            _formService.ContactUs(form);

            return View();
        }

    }
}
