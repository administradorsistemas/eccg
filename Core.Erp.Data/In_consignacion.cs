//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class in_Consignacion
    {
        public in_Consignacion()
        {
            this.in_ConsignacionDet = new HashSet<in_ConsignacionDet>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdConsignacion { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal IdProveedor { get; set; }
        public string Observacion { get; set; }
        public bool Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
    
        public virtual ICollection<in_ConsignacionDet> in_ConsignacionDet { get; set; }
        public virtual in_Ing_Egr_Inven in_Ing_Egr_Inven { get; set; }
    }
}