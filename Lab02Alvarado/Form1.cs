using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02Alvarado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Desconectado d = new Desconectado();
        private void Form1_Load(object sender, EventArgs e)
        {

           
            d.ListaEmpleados(cboEmpleados);
        }

        private void cboEmpleados_SelectionChangeCommitted(object sender, EventArgs e)
        {
 
            DGPedidos.DataSource = d.ListaPedidosxEmpleado(Convert.ToInt32(cboEmpleados.SelectedValue));
        }
    }
}
