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
    
    public partial class fa_cuotas_x_doc
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public int secuencia { get; set; }
        public int num_cuota { get; set; }
        public System.DateTime fecha_vcto_cuota { get; set; }
        public double valor_a_cobrar { get; set; }
        public bool Estado { get; set; }
    
        public virtual fa_factura fa_factura { get; set; }
    }
}
