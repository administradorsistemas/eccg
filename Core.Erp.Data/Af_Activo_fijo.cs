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
    
    public partial class Af_Activo_fijo
    {
        public Af_Activo_fijo()
        {
            this.Af_Depreciacion_Det = new HashSet<Af_Depreciacion_Det>();
            this.Af_Mej_Baj_Activo = new HashSet<Af_Mej_Baj_Activo>();
            this.Af_Retiro_Activo = new HashSet<Af_Retiro_Activo>();
            this.Af_Venta_Activo = new HashSet<Af_Venta_Activo>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public string CodActivoFijo { get; set; }
        public string Af_Nombre { get; set; }
        public int IdActivoFijoTipo { get; set; }
        public int IdCategoriaAF { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdDepartamento { get; set; }
        public string IdCatalogo_Marca { get; set; }
        public string IdCatalogo_Modelo { get; set; }
        public string Af_NumSerie { get; set; }
        public string IdCatalogo_Color { get; set; }
        public string IdTipoCatalogo_Ubicacion { get; set; }
        public System.DateTime Af_fecha_compra { get; set; }
        public System.DateTime Af_fecha_ini_depre { get; set; }
        public System.DateTime Af_fecha_fin_depre { get; set; }
        public double Af_costo_compra { get; set; }
        public double Af_Depreciacion_acum { get; set; }
        public int Af_Vida_Util { get; set; }
        public int Af_Meses_depreciar { get; set; }
        public double Af_porcentaje_deprec { get; set; }
        public string Af_observacion { get; set; }
        public string Af_NumPlaca { get; set; }
        public string Estado { get; set; }
        public decimal IdEmpleadoEncargado { get; set; }
        public decimal IdEmpleadoCustodio { get; set; }
        public string Af_Codigo_Barra { get; set; }
        public string Estado_Proceso { get; set; }
        public double Af_ValorSalvamento { get; set; }
        public int Cantidad { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
    
        public virtual Af_Activo_fijo_Categoria Af_Activo_fijo_Categoria { get; set; }
        public virtual Af_Activo_fijo_tipo Af_Activo_fijo_tipo { get; set; }
        public virtual Af_Catalogo Af_Catalogo { get; set; }
        public virtual Af_Catalogo Af_Catalogo1 { get; set; }
        public virtual Af_Catalogo Af_Catalogo2 { get; set; }
        public virtual Af_Catalogo Af_Catalogo3 { get; set; }
        public virtual Af_Catalogo Af_Catalogo4 { get; set; }
        public virtual Af_Departamento Af_Departamento { get; set; }
        public virtual ICollection<Af_Depreciacion_Det> Af_Depreciacion_Det { get; set; }
        public virtual ICollection<Af_Mej_Baj_Activo> Af_Mej_Baj_Activo { get; set; }
        public virtual ICollection<Af_Retiro_Activo> Af_Retiro_Activo { get; set; }
        public virtual ICollection<Af_Venta_Activo> Af_Venta_Activo { get; set; }
    }
}
