using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Ecole.Repository;
using Web_Ecole.ViewModels;

namespace Web_Ecole.Controllers
{
    public class EcoleController : Controller
    {
        // GET: Ecole

        [HttpGet]
        public ActionResult Index()
        {
            var classeRrpository = new Repo();

            var classecole = classeRrpository.GetAllEcole();

            var classViewmodel = new EcoleClasseModel();

            // assigne values for viewmodel

            classViewmodel.ecoles = classecole;

            return View("index", classViewmodel);
        }
        [HttpPost]
        public ActionResult Index(EcoleClasseModel classViewModel)
        {
            var classeRrpository = new Repo();

            var classecole = classeRrpository.GetEcole(classViewModel.SelectValue);

            classViewModel.ecole = classecole;

            var classeObj = new classe
                {
                nom_classe = classViewModel.nom_classe,
                ecole = classecole,
                };

            if (ModelState.IsValid) //check for any validation errors
            {
                //code to save valid data into database

                return RedirectToAction("Index");
            }
            else
            {
                //when validation failed return viewmodel back to UI (View) 
                return View(classViewModel);
            }
        }
    }
}