using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace RegristroArticulos.Entidades
{   //Debe ser public para que sea visible en las demas capas
    public class ArticulosProducto
    {
        [Key]// Esta es la llave primaria 
        public int IdArticulos { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int Existencia { get; set; }
        public int CantidadCotizada { get; set; }


        public ArticulosProducto()
        {
            IdArticulos = 0;
            FechaVencimiento = DateTime.Now;
            Descripcion = string.Empty;
            Precio = 0;
            Existencia =0;
            CantidadCotizada =0;
        }
    }
}
