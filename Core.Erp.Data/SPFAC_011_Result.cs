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
    
    public partial class SPFAC_011_Result
    {
        public int IdEmpresa { get; set; }
        public decimal IdCliente { get; set; }
        public string pe_nombreCompleto { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }
        public string Referencia { get; set; }
        public string Observacion { get; set; }
        public double Debitos { get; set; }
        public Nullable<double> Creditos { get; set; }
        public Nullable<double> Saldo { get; set; }
        public Nullable<double> SaldoModulo { get; set; }
        public Nullable<int> Secuencia { get; set; }
    }
}
