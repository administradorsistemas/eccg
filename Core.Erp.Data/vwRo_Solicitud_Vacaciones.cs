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
    
    public partial class vwRo_Solicitud_Vacaciones
    {
        public int IdEmpresa { get; set; }
        public int IdSolicitud { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal IdEmpleado { get; set; }
        public int AnioServicio { get; set; }
        public int Dias_q_Corresponde { get; set; }
        public int Dias_a_disfrutar { get; set; }
        public int Dias_pendiente { get; set; }
        public System.DateTime Anio_Desde { get; set; }
        public System.DateTime Anio_Hasta { get; set; }
        public System.DateTime Fecha_Desde { get; set; }
        public System.DateTime Fecha_Hasta { get; set; }
        public System.DateTime Fecha_Retorno { get; set; }
        public string Observacion { get; set; }
        public string IdUsuario_Anu { get; set; }
        public string Estado { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public decimal IdEmpleado_aprue { get; set; }
        public Nullable<decimal> IdEmpleado_remp { get; set; }
        public bool Gozadas_Pgadas { get; set; }
        public bool Canceladas { get; set; }
        public int IdVacacion { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string em_codigo { get; set; }
        public Nullable<int> IdLiquidacion { get; set; }
        public string Estado_liquidacion { get; set; }
    }
}
