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
    
    public partial class com_Motivo_Orden_Compra
    {
        public com_Motivo_Orden_Compra()
        {
            this.com_ordencompra_local = new HashSet<com_ordencompra_local>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdMotivo { get; set; }
        public string Cod_Motivo { get; set; }
        public string Descripcion { get; set; }
        public string estado { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
    
        public virtual ICollection<com_ordencompra_local> com_ordencompra_local { get; set; }
    }
}