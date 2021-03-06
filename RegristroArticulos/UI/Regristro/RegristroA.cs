﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegristroArticulos.Entidades;
using RegristroArticulos.BLL;


namespace RegristroArticulos.UI.Regristro
{
    public partial class RegristroA : Form
    {
        public RegristroA()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegristroA_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private ArticulosProducto LlenaClase()
        {
            ArticulosProducto articulosProducto = new ArticulosProducto();

            articulosProducto.IdArticulos = Convert.ToInt32(IdnumericUpDown.Value);
            articulosProducto.FechaVencimiento = FechaVencimientodateTimePicker.Value;
            articulosProducto.Descripcion = DescripciontextBox.Text;
            articulosProducto.Precio = Convert.ToInt32(PreciotextBox.Text);
            articulosProducto.Existencia = Convert.ToInt32(ExistenciatextBox.Text);
            articulosProducto.CantidadCotizada = Convert.ToInt32(CantidadCotizadatextBox.Text);
            return articulosProducto;
        }

        
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            ArticulosProducto articulosProducto = new ArticulosProducto();
            bool paso = false;

            if (IdnumericUpDown.Value == 0)

                paso = BLL.ArticulosProductoBLL.Guardar(articulosProducto);
            else
                paso = BLL.ArticulosProductoBLL.Modificar(LlenaClase());

            if (paso)
                MessageBox.Show("Guardado", "Con Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo Guardar", "Error!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdnumericUpDown.Value = 0;
            FechaVencimientodateTimePicker.Value = DateTime.Now;
            DescripciontextBox.Clear();
            PreciotextBox.Clear();
            ExistenciatextBox.Clear();
            CantidadCotizadatextBox.Clear();

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);

            if (BLL.ArticulosProductoBLL.Eliminar(id))
                MessageBox.Show("Eliminado!", "Con Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo Eliminar", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            ArticulosProducto articulosProducto = BLL.ArticulosProductoBLL.Buscar(id);
            if(articulosProducto !=null)
            {
                DescripciontextBox.Text = articulosProducto.Descripcion;
                PreciotextBox.Text = articulosProducto.Precio.ToString();
                FechaVencimientodateTimePicker.Value = articulosProducto.FechaVencimiento;
                ExistenciatextBox.Text=articulosProducto.Existencia.ToString();
                CantidadCotizadatextBox.Text= articulosProducto.CantidadCotizada.ToString();

            }

            

        }
       public bool Validar()
        {
            bool HayErrores = false;
                if(IdnumericUpDown.Value==0)
            {
                ArticulosIderrorProvider.SetError(IdnumericUpDown, "Id:");
                HayErrores = true;
            }
            if(String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                DescripcionerrorProvider.SetError(DescripciontextBox, "Descripcion Vacio");
                HayErrores = true;
            }
            if (PreciotextBox.Text==String.Empty) 
            {
                PrecioerrorProvider.SetError(PreciotextBox, "Precio Vacio");
                HayErrores = true;
            }
            if(ExistenciatextBox.Text==String.Empty)
            {
                ExistenciaerrorProvider.SetError(ExistenciatextBox, "Existencia Vacia");
                HayErrores = true;
            }
            if(CantidadCotizadatextBox.Text==String.Empty)
            {
                CantidadCotizadaerrorProvider.SetError(CantidadCotizadatextBox, "Cantidad Cotizada Vacia");
                HayErrores = true;
            }
            return HayErrores;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CantidadCotizadatextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
