using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Ecole.Repository;

namespace Web_Ecole.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            Repo repository = new Repo();
            var ListeEcole = repository.GetAllEcole();
            ViewBag.ListeEcole = new SelectList(ListeEcole, "id_ecole", "nom_ecole");
            //List<ecole> EcoleList = 
            return View();
        }

        public JsonResult GetstatList(int id_ecole)
        {
           
            Repo repository = new Repo();
            var ListeClasse = repository.GetClasse();
            List<classe> Startelist = ListeClasse.Where(x => x.id_ecole == id_ecole).ToList();

            return Json(Startelist, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetstatListEtudiant(int id_classe)
        {

            Repo repository = new Repo();
            var ListeClasse = repository.GetEtudiant();
            List<etudiant> Startelist = ListeClasse.Where(x => x.id_classe == id_classe).ToList();

            return Json(Startelist, JsonRequestBehavior.AllowGet);
        }
    }
}