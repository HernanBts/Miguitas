namespace Miguitas.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Miguitas.Web.Helpers;
    using Miguitas.Web.Models;
    using System;
    using System.Diagnostics;

    public class HomeController : Controller
    {
        private readonly IMailHelper mailHelper;

        public HomeController(IMailHelper mailHelper)
        {
            this.mailHelper = mailHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel contactViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    this.mailHelper.SendMail("miguitaswebapp@hotmail.com", contactViewModel.Subject,
                         contactViewModel.Message + " Fue enviado por: " + contactViewModel.Name + " Correo: " + contactViewModel.Email + " Telefono: " + contactViewModel.Phone);
                    this.ViewBag.Message = "El mensaje fue enviado correctamente.";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Oops! We have a problem here {ex.Message}";
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("error/404")]
        public IActionResult Error404()
        {
            return View();
        }

    }
}
