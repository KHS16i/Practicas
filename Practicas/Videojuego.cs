//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practicas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Videojuego
    {
        public int IdVideojuego { get; set; }
        public string Nombre { get; set; }
        public int IdGenero { get; set; }
        public int IdDistribuidor { get; set; }
        public int IdDesarrollador { get; set; }
        public Nullable<int> Rating { get; set; }
        public Nullable<bool> Mulitjugador { get; set; }
    
        public virtual Desarrolladora Desarrolladora { get; set; }
        public virtual Distribuidora Distribuidora { get; set; }
        public virtual Genero Genero { get; set; }
    }
}