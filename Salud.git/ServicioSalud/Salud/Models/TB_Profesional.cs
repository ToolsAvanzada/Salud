//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Salud.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Profesional
    {
        public TB_Profesional()
        {
            this.TB_Atencion = new HashSet<TB_Atencion>();
            this.TB_Atencion1 = new HashSet<TB_Atencion>();
            this.TB_DatosMedicos = new HashSet<TB_DatosMedicos>();
        }
    
        public int codigo { get; set; }
        public Nullable<int> rut { get; set; }
        public string codusuario { get; set; }
        public string digitover { get; set; }
        public string apellpat { get; set; }
        public string apellmat { get; set; }
        public string nombres { get; set; }
        public string nombre2 { get; set; }
        public int tipo { get; set; }
        public string direccion { get; set; }
        public Nullable<int> comuna { get; set; }
        public string fono { get; set; }
        public short estado { get; set; }
        public System.DateTime fecha { get; set; }
        public Nullable<int> observacion { get; set; }
    
        public virtual ICollection<TB_Atencion> TB_Atencion { get; set; }
        public virtual ICollection<TB_Atencion> TB_Atencion1 { get; set; }
        public virtual ICollection<TB_DatosMedicos> TB_DatosMedicos { get; set; }
        public virtual TB_Tipo TB_Tipo { get; set; }
    }
}
