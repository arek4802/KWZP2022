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
    
    public partial class Szczegoly_sprzedaz
    {
        public int ID_szczegoly_sprzedaz { get; set; }
        public int ID_sprzedaz { get; set; }
        public decimal Kwota_sprzedazy { get; set; }
        public int ID_podatek { get; set; }
    
        public virtual Podatek Podatek { get; set; }
        public virtual Sprzedaz Sprzedaz { get; set; }
    }
}
