using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CozyHotels.ViewModels;
using CozyHotels.Services;
using Microsoft.Extensions.Configuration;

namespace CozyHotels.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailServices _mailservice;
        private IConfigurationRoot _config;

        public AppController(IMailServices mailservice, IConfigurationRoot config)
        {
            _mailservice = mailservice;
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Support()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Support(SupportViewModel model)
        {
            if (model.Email.Contains("aol.com"))
                ModelState.AddModelError("Email","We don't support aol addresses");

            if (ModelState.IsValid)
            {
                _mailservice.SendMail(_config["MailSettings:ToAddress"], model.Email, model.Name + " | " + model.Phone, model.Message);
                ModelState.Clear();
                ViewBag.UserMessage = "We got your message! We will contact you back.";
            }
            return View();
        }
    }
}
