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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Desconectado d = new Desconectado();
        private void DGPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DGPedidos.DataSource = d.ListarPedidos();
        }

        private void DGDetallesP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // var item = DGPedidos.Rows[e.RowIndex].Cells[0].Value;
        }

        private void DGDetallesP_DoubleClick(object sender, EventArgs e)
        {
          //
         
        }

        private void DGDetallesP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void DGDetallesP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void DGPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 ID = Convert.ToInt32(DGPedidos.Rows[e.RowIndex].Cells["IdPedido"].Value);

            DGDetallesP.DataSource = d.ListarDetalles(ID);
        }
    }
}
