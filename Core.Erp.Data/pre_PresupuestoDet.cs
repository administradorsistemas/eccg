//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class pre_PresupuestoDet
    {
        public int IdEmpresa { get; set; }
        public decimal IdPresupuesto { get; set; }
        public int Secuencia { get; set; }
        public int IdRubro { get; set; }
        public string IdCtaCble { get; set; }
        public double Monto { get; set; }
    
        public virtual pre_Presupuesto pre_Presupuesto { get; set; }
        public virtual pre_Rubro pre_Rubro { get; set; }
    }
}
