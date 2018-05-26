using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegristroArticulos.BLL;
using RegristroArticulos.Entidades;
using System.Linq.Expressions;
using RegristroArticulos.UI.Consulta;

namespace RegristroArticulos.UI.Consulta
{
    public partial class ConsultaA : Form
    {
        public ConsultaA()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            //Inicializando el filtro en true

            Expression<Func<ArticulosProducto, bool>> Filtro = a => true;

            int id;
            switch(FiltrarcomboBox.SelectedIndex)
            {
                case 0:
                    id= Convert.ToInt32(CriteriotextBox.Text);
                    Filtro = a => a.IdArticulos == id;
                    break;
                case 1:
                    Filtro = a => a.FechaVencimiento.Equals(CriteriotextBox.Text);
                    break;
                case 2:
                    Filtro = a => a.Descripcion.Equals(CriteriotextBox.Text);
                    break;
                case 3:
                    Filtro = a => a.Precio.Equals(CriteriotextBox.Text);
                    break;
                case 4:
                    Filtro = a => a.Existencia.Equals(CriteriotextBox.Text);
                    break;
                case 5:
                    Filtro = a => a.CantidadCotizada.Equals(CriteriotextBox.Text);
                    break;
            }
            ConsultadataGridView.DataSource = BLL.ArticulosProductoBLL.GetList(Filtro);
            
        }

        private void ConsultaA_Load(object sender, EventArgs e)
        {

        }

        private void ConsultadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
