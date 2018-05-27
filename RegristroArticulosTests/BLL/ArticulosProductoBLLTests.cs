using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegristroArticulos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegristroArticulos.Entidades;

namespace RegristroArticulos.BLL.Tests
{
    [TestClass()]
    public class ArticulosProductoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            ArticulosProducto articulosProducto = new ArticulosProducto();
            articulosProducto.IdArticulos = 0;
            articulosProducto.Descripcion = "Prueba";
            paso = ArticulosProductoBLL.Guardar(articulosProducto);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
 

           
        }

        [TestMethod()]
        public void EliminarTest()
        {
           
        }

        [TestMethod()]
        public void BuscarTest()
        {
            
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModificarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest1()
        {
            Assert.Fail();
        }
    }
}