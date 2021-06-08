using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using SGC_GRUPO4.Properties;
using System.Configuration;

namespace SGC_GRUPO4
{
    class conexioncs
    {
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlDataAdapter adaptador1;
        SqlCommand comando1;
        //SqlDataReader reader;
        SqlCommand comando;
        DataTable tabla;

        public static string ObtenerString() // Método para obtener la cadena de conexión de manera automática.
        {
            return Settings.Default.SisEvaConnectionString;
        }
        public conexioncs()
        {
            try
            {
                conexion = new SqlConnection(ObtenerString()); // Establecimiento de la conexión con la Base de Datos.
                conexion.Open();

                //"Server=LRAYFIL; database=SisEvaluacion; Integrated Security=true"
                //MessageBox.Show("Conexión Correcta.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error en la conexión.");
            }

            // Query para tabla Evaluación.
             comando = new SqlCommand("Select i.Id_Item, i.Descripcion, i.Activo, i.Fecha_Creado, i.Fecha_Expiración, " +
            "e.Proveedor, e.ISO_9001, e.ISO_14000, e.No_Expirado from ItemEvaluacion i join " +
            "Evaluacion e on i.Id_Item = e.Id_Item", conexion);
             adaptador = new SqlDataAdapter();
             adaptador.SelectCommand = comando;

            //Query para tabla ItemEvaluacion.
            comando1 = new SqlCommand("Select * from ItemEvaluacion", conexion);
             adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = comando1;


        }
        public void cargarEva(DataGridView dgv) // Método cargar datos al DataGridView de Form Evaluación desde base de datos.
        {
            tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv.DataSource = tabla;
        }
        public void cargarItems(DataGridView dgv1)// Método cargar datos al DataGridView de Form Items desde base de datos.
        {
            DataTable tabla = new DataTable();
            adaptador1.Fill(tabla);
            dgv1.DataSource = tabla;
        }
        public string Actualizar(int id, Boolean ISO14, Boolean ISO90, Boolean nVencido) // Método para actualizar los datos de la base de datos.
        
        {
            string salida = "Se ha actualizado el registro.";
            try
            {
                comando = new SqlCommand("Update Evaluacion set ISO_14000='" + Convert.ToString(ISO14) + "', ISO_9001='" + Convert.ToString(ISO90) + "', No_Expirado='" + Convert.ToString(nVencido) + "' where Id_Item='" + id + "'", conexion);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "Ha ocurrido un error" + ex.ToString();
            }
            return salida;
        }
    }
}

