//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2022
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rodzaj_parametr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rodzaj_parametr()
        {
            this.Parametr_czesc = new HashSet<Parametr_czesc>();
            this.Parametr_maszyna = new HashSet<Parametr_maszyna>();
            this.Parametr_material = new HashSet<Parametr_material>();
            this.Parametr_narzedzie = new HashSet<Parametr_narzedzie>();
        }
    
        public int ID_rodzaj_parametr { get; set; }
        public string Nazwa { get; set; }
        public int ID_jednostka { get; set; }
    
        public virtual Jednostka Jednostka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parametr_czesc> Parametr_czesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parametr_maszyna> Parametr_maszyna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parametr_material> Parametr_material { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parametr_narzedzie> Parametr_narzedzie { get; set; }
    }
}
