using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using RegristroArticulos.Entidades;


namespace RegristroArticulos.DAL
{   // Agregamos public para que la clase pueda ser encontrada en cualquier codigo del proyecto
    //y heredamos de DbContext para que EntityFramework pueda funcionar
    public class Contexto : DbContext
    {
        public DbSet<ArticulosProducto> ArticuloP { get; set; }
        //base(conStr) para pasar la conexion a la clase base de EntityFramework
        public Contexto() : base("ConStr")
        { }

    }
}
