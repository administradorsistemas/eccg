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
    
    public partial class VWROL_019
    {
        public int IdEmpresa { get; set; }
        public decimal IdPrestamo { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdRubro { get; set; }
        public int NumCuota { get; set; }
        public double SaldoInicial { get; set; }
        public double TotalCuota { get; set; }
        public double Saldo { get; set; }
        public System.DateTime FechaPago { get; set; }
        public string EstadoPago { get; set; }
        public bool Estado { get; set; }
        public string Observacion_det { get; set; }
        public int IdNominaTipoLiqui { get; set; }
        public string em_codigo { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string pe_cedulaRuc { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IdNomina { get; set; }
        public string Nomina { get; set; }
        public Nullable<int> IdArea { get; set; }
        public Nullable<int> IdDivision { get; set; }
        public string ru_descripcion { get; set; }
    }
}