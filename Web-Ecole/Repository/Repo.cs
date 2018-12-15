using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace Web_Ecole.Repository
{
    public class Repo
    {
       private List<ecole> GetEcoleMockData()
        {
            using (Entities db = new Entities())
            {
                return db.ecoles.ToList();
            }
        }

        public List<ecole> GetAllEcole()
        {
            using (Entities db = new Entities())
            {
                return db.ecoles.ToList();
            }
        }


        public List<classe> GetClasse()
        {
            using (Entities db = new Entities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.classes.ToList();
            }
        }

        public List<etudiant> GetEtudiant()
        {
            using (Entities db = new Entities())
            {
                return db.etudiants.ToList();
            }
        }

      
        public ecole GetEcole(int ecoleId)
            {
            var EcoleList = GetEcoleMockData();

                return (from p in EcoleList
                        where (p.id_ecole == ecoleId)
                        select p).FirstOrDefault();
            }


        }
}