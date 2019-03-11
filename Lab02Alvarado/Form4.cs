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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Desconectado d = new Desconectado();
        private void Form4_Load(object sender, EventArgs e)
        {
            d.ListarYear(cboYear);
        }

        private void cboYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            d.ListarMeses(cboMes, Convert.ToInt32(cboYear.SelectedValue));
       
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int year = Convert.ToInt32(cboYear.SelectedValue);
            int mes = Convert.ToInt32(cboMes.SelectedValue);

            DGPedidosFecha.DataSource = d.ListarxFecha(year, mes);
            
        }
    }
}
