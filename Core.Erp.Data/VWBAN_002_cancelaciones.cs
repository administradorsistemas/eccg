//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class VWBAN_002_cancelaciones
    {
        public int mba_IdEmpresa { get; set; }
        public decimal mba_IdCbteCble { get; set; }
        public int mba_IdTipocbte { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<int> IdBodega_Cbte { get; set; }
        public Nullable<decimal> IdCbte_vta_nota { get; set; }
        public string dc_TipoDocumento { get; set; }
        public string Referencia { get; set; }
        public string Observacion { get; set; }
        public Nullable<double> monto { get; set; }
    }
}