using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab02Alvarado
{
    public class Desconectado
    {
        Conexion cnn = new Conexion();
        #region "consulta 1"
        public void ListaEmpleados(ComboBox cbo)
        {
            SqlDataAdapter df = new SqlDataAdapter("Usp_ListaEmpleados", cnn.cadena());
            df.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            df.Fill(dt);
            //mostrar los datos en un combobox
            cbo.DataSource = dt;
            //visualizar la data en el combo
            cbo.DisplayMember = "Nombre";
            //comparar el campo con uno xterno
            cbo.ValueMember = "IdEmpleado";
        }
        public DataTable ListaPedidosxEmpleado(int x)
        {
            using (SqlDataAdapter df = new SqlDataAdapter("Usp_BuscaPedidosxEmpleado", cnn.cadena()))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                df.SelectCommand.Parameters.AddWithValue("@idemp", x);
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable ListarPedidos()
        {
   
            using (SqlDataAdapter df = new SqlDataAdapter("Usp_ListarPedidos", cnn.cadena()))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
   
          public DataTable ListarDetalles(int id)
        {
            using (SqlDataAdapter df = new SqlDataAdapter("Usp_ListarDetalles", cnn.cadena()))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                df.SelectCommand.Parameters.AddWithValue("@idped", id);
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
            public void ListarYear(ComboBox cbo)
        {
            SqlDataAdapter df = new SqlDataAdapter("Usp_ListarAno", cnn.cadena());
            df.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            df.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = "Anno";
            cbo.ValueMember = "Anno";
         

        }
        public void ListarMeses(ComboBox cbo, int year)
        {
            SqlDataAdapter df = new SqlDataAdapter("Usp_ListarMes ", cnn.cadena());
            df.SelectCommand.CommandType = CommandType.StoredProcedure;
            df.SelectCommand.Parameters.AddWithValue("@idyear", year);
            DataTable dt = new DataTable();
            df.Fill(dt);
         
            cbo.DataSource = dt;
            cbo.DisplayMember = "Meses";
            cbo.ValueMember = "orden";
            
 
        }
        public DataTable ListarxFecha(int year, int mes)
        {
            using (SqlDataAdapter df = new SqlDataAdapter("Usp_ListarxFecha", cnn.cadena()))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                df.SelectCommand.Parameters.AddWithValue("@idyear", year);
                df.SelectCommand.Parameters.AddWithValue("@idmes", mes);
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }


        }
        #endregion
    }
}
