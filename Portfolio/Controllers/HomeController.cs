using Core.entities;
using Core.interfaces;
using Microsoft.AspNetCore.Mvc;
using Portfolio.ViewModels;
using System.Diagnostics;

namespace Controllers
{
    public class HomeController : Controller
    {

        private readonly IUnitOfWork<Project> project;
        public HomeController(IUnitOfWork<Project> project)
        {
            this.project = project;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Certifications()
        {
            return View();
        }

        public IActionResult Projects()
        {
            HomeViewModel model = new HomeViewModel()
            {
                Projects = this.project.Repository.GetAll().ToList()
            };

            return View(model);
        }

        public IActionResult WorkExperience()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
