using System;
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
        private bool Negar(int Negar)
        {
            bool paso = false;
            if (Negar == 1 && IdnumericUpDown.Value == 0)
            {
                ArticulosIderrorProvider1.SetError(IdnumericUpDown, "Digite Id del Articulo:");
                paso = true;
            }
            if(Negar==2 && DescripciontextBox.Text == String.Empty)
            {
                DescripcionerrorProvider2.SetError(DescripciontextBox, "Ingrese una Descripcion:");
                paso = true;
            }
            if(Negar==2 && PreciotextBox.Text==string.Empty)
            {
                PrecioerrorProvider3.SetError(PreciotextBox, "Ingrese el Precio");
                paso = true;
            }
            if(Negar==2 && ExistenciatextBox.Text==string.Empty)
            {
                ExistenciaerrorProvider5.SetError(ExistenciatextBox, "Digite Cantidad de Existencia");
                paso = true;

            }
            if(Negar==2 && CantidadCotizadatextBox.Text==string.Empty)
            {
                CantidadCotizadaerrorProvider4.SetError(CantidadCotizadatextBox, "Digite Cantidad Contizada");
                paso = true;
            }
            return paso;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
