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
    
    public partial class vwro_marcaciones_x_planificacion_horario
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdHorario { get; set; }
        public int IdCalendadrio { get; set; }
        public Nullable<double> Sueldo { get; set; }
        public Nullable<int> IdNomina { get; set; }
        public string pe_nombre { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string em_codigo { get; set; }
        public System.TimeSpan time_entrada1 { get; set; }
        public System.TimeSpan time_salida1 { get; set; }
        public System.DateTime es_fechaRegistro { get; set; }
        public System.TimeSpan HoraIni { get; set; }
        public System.TimeSpan HoraFin { get; set; }
    }
}
