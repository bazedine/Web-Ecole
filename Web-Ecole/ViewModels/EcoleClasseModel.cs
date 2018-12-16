using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Web_Ecole.ViewModels
{
    public class EcoleClasseModel
    {
        public int id_classe { get; set; }
        public int id_ecole { get; set; }
        public int id_etudiant { get; set; }
        public string nom_classe { get; set; }
        public int SelectValue { get; set; }

        //public string effectif_classe { get; set; }
        //public Nullable<int> id_ecole { get; set; }

        public virtual ecole ecole { get; set; }
        
        [DisplayName("Class Ecole")]
        public virtual ICollection<ecole> ecoles { get; set; }

        /////////////////
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public ecole()
        //{
        //    this.classes = new HashSet<classe>();
        //}

        //public int id_ecole { get; set; }
        //public string nom_ecole { get; set; }
        //public string ville_ecole { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<classe> classes { get; set; }



    }
}