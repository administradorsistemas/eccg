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
    
    public partial class ATS_retenciones
    {
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public int Secuencia { get; set; }
        public string co_serie { get; set; }
        public string co_factura { get; set; }
        public string Cedula_ruc { get; set; }
        public Nullable<decimal> valRetBien10 { get; set; }
        public Nullable<decimal> valRetServ20 { get; set; }
        public Nullable<decimal> valorRetBienes { get; set; }
        public Nullable<decimal> valRetServ50 { get; set; }
        public Nullable<decimal> valorRetServicios { get; set; }
        public Nullable<decimal> valRetServ100 { get; set; }
        public string codRetAir { get; set; }
        public Nullable<decimal> baseImpAir { get; set; }
        public string porcentajeAir { get; set; }
        public Nullable<decimal> valRetAir { get; set; }
        public string estabRetencion1 { get; set; }
        public string ptoEmiRetencion1 { get; set; }
        public string secRetencion1 { get; set; }
        public string autRetencion1 { get; set; }
        public Nullable<System.DateTime> fechaEmiRet1 { get; set; }
        public string docModificado { get; set; }
        public string estabModificado { get; set; }
        public string ptoEmiModificado { get; set; }
        public string secModificado { get; set; }
        public string autModificado { get; set; }
        public string re_tipo_Ret { get; set; }
        public string denopr { get; set; }
        public Nullable<int> IdSucursal { get; set; }
    }
}