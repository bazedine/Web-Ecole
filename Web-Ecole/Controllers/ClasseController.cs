using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using Web_Ecole.Repository;

namespace Web_Ecole.Controllers
{
    public class ClasseController : ApiController
    {
        //classe[] classes = new classe[]
        //    {
        //    new classe { id_ecole = 1, nom_classe = "AAA", effectif_classe = "10" },
           
        //    };

        //public IEnumerable<Repo> GetAllProducts()
        //{
        //    var servicebranche = new Repo();
        //    var listeClasParEcole = new List<>
        //    return classes;
        //}


//        var servicebranche = new repository();
//        var resourceData = new List<ScheduleResource>();
//        List<tbbranche> Branches = servicebranche.GetBranche();
//        List<tbSalle> Salles = servicebranche.GetSalle();
//           // List<tbpatient> Patients = servicebranche.GetPatients();
//            foreach (var branc in Branches)
//            {
//                var res = new ScheduleResource();
//        res.id = branc.BranchID.ToString();
//                res.title = branc.BranchNom;
//                foreach (var salle in Salles)
//                {
//                    if (res.id == salle.BranchID.ToString())
//                    {
//                        var salleRes = new ScheduleResource();
//        salleRes.id = salle.SalleID.ToString();
//                        salleRes.title = salle.SalleNom;
//                        res.children.Add(salleRes);
//                    }
//}
//resourceData.Add(res);

//                Debug.WriteLine(branc.BranchNom);
//            }

//            return Json(resourceData, JsonRequestBehavior.AllowGet);


        //IHttpActionResult Get()
        //{

        //    return Ok(new[]
        //    {
        //        new ecole { id_ecole=1,nom_ecole="AAA",ville_ecole="colombes"}
        //    }
        //    );
        //}
    }
}
