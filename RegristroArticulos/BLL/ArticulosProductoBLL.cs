using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegristroArticulos.Entidades;
using RegristroArticulos.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace RegristroArticulos.BLL
{
    public class ArticulosProductoBLL
    {
        //Permite Guardar Una Entidad En La Base De Dato
        public static bool Guardar(ArticulosProducto articulosProducto)
        {
            bool paso = false;
            //Creamos Una Instancia de Del contexto Para conectarla con la Base de Dato
            Contexto contexto = new Contexto();

            try
            {
                if(contexto.ArticuloP.Add(articulosProducto)!=null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
            }catch(Exception)
            {
                throw;
            }
            return paso;
            
        }
        //Permite Modificar Una Entidad en la Base de Dato
        public static bool Modificar(ArticulosProducto articulosProducto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(articulosProducto).State = EntityState.Modified;
                if (contexto.SaveChanges()>0)
                {
                    
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }
        //Permirte Eliminar Una Entidad De la Base De Dato
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                ArticulosProducto articulosProducto = new ArticulosProducto();
                contexto.ArticuloP.Remove(articulosProducto);

                if (contexto.SaveChanges()>0)
                {
                    
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }
        //Permite Buscar Una Entidad en la Base de Dato
        public static ArticulosProducto Buscar(int id)
        {
            
            Contexto contexto = new Contexto();
            ArticulosProducto articulosProducto = new ArticulosProducto();

            try
            {
                articulosProducto = contexto.ArticuloP.Find(id);
                contexto.Dispose();
               

               
            }
            catch (Exception)
            {
                throw;
            }
            return articulosProducto;

        }
        //Permite Extraer Una Lista De Personas de la Base de Dato
        public static List<ArticulosProducto> GetList(Expression<Func<ArticulosProducto, bool>> expression)
        {
            List<ArticulosProducto> articulosProductos = new List<ArticulosProducto>();
            Contexto contexto = new Contexto();
            try
            {
                articulosProductos = contexto.ArticuloP.Where(expression).ToList();
            }catch
            {
                throw;
            }
            return articulosProductos;
        }


    }
}
