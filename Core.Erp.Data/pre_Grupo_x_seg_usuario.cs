//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class pre_Grupo_x_seg_usuario
    {
        public int IdEmpresa { get; set; }
        public int IdGrupo { get; set; }
        public int Secuencia { get; set; }
        public string IdUsuario { get; set; }
        public bool AsignaCuentas { get; set; }
    
        public virtual pre_Grupo pre_Grupo { get; set; }
    }
}
