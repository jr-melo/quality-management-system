using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SGC_GRUPO4
{
    public partial class EvaluateForm : Form
    {

        conexioncs conexEva = new conexioncs();  // Instancia de la conexión proveniente de la clase conexioncs.
        //SqlConnection conexion;
        //SqlCommand comando;

        public EvaluateForm()
        {
            InitializeComponent();
        }

        private void EvaluateForm_Load(object sender, EventArgs e) // Carga del formulario evaluación.
        {

            // TODO: esta línea de código carga datos en la tabla 'sisEvaluacionDataSet2.ItemEvaluacion' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'sisEvaluacionDataSet2.Evaluacion' Puede moverla o quitarla según sea necesario.

            conexEva.cargarEva(DGV_Evaluacion);  //Carga los datos en la tabla de evaluación, proveniente de un método en la clase conexioncs.

            labeltime.Text = DateTime.Now.ToLongDateString();
            titlelbl.BringToFront();
            evaLabel.BringToFront();

            foreach (DataGridViewRow dgvcolor in DGV_Evaluacion.Rows) // Bucle recorre columnas. Al encontrar las 3 columnas de "Check" en true, cambia el color de la fila.
            {
                int color = dgvcolor.Index;

                if(DGV_Evaluacion.Rows[color].Cells["ISO_14000"].Value.ToString().Equals("True") && DGV_Evaluacion.Rows[color].Cells["ISO_9001"].Value.ToString().Equals("True") && DGV_Evaluacion.Rows[color].Cells["No_Expirado"].Value.ToString().Equals("True"))
                {
                    DGV_Evaluacion.Rows[color].DefaultCellStyle.BackColor = Color.PowderBlue;
                }
                else
                {
                    DGV_Evaluacion.Rows[color].DefaultCellStyle.BackColor = Color.White;
                }
            }

            int count = 0; 
            double res;

            for (int i = 0; i < DGV_Evaluacion.Rows.Count; i++)  // Bucle for. Recorre las columnas y cuenta la cantidad de columnas "Check" marcadas como true. Si encuentra, incrementa variable count.
            {                                                    // Actualiza al cargar el form.
                if (DGV_Evaluacion.Rows[i].Cells["ISO_14000"].Value.ToString().Equals("True") && DGV_Evaluacion.Rows[i].Cells["ISO_9001"].Value.ToString().Equals("True") && DGV_Evaluacion.Rows[i].Cells["No_Expirado"].Value.ToString().Equals("True"))
                {
                    count++;
                }
            }
            res = count * (100) / DGV_Evaluacion.Rows.Count;
            evaLabel.Text = Convert.ToString(res + "%"); // Calculo de porcentaje e impresión en label para el "Cálculo Indicador de Calidad".
                                                         // Actualiza al cargar el form.
        }

        // Líneas de códigos representan objetos definidos para capturar los valores de las columnas de la base de datos.

        public static string ID;
        public static string Descripcion;
        public static string Proveedor;
        public static string Fecha;         
        public static string ISO14;
        public static string ISO90;
        public static string nExpirado;

        private void DGV_Evaluacion_CellClick(object sender, DataGridViewCellEventArgs e) // Evento que indica el click en una fila del DataGridView.
        {
            try
            {
                //Líneas de códigos para captura de los valores de las columnas del DataGridView. Almacenados en objetos previamente definidos.

                ID = DGV_Evaluacion.Rows[e.RowIndex].Cells["Id_Item"].Value.ToString();
                Descripcion = DGV_Evaluacion.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                Proveedor = DGV_Evaluacion.Rows[e.RowIndex].Cells["Proveedor"].Value.ToString();
                ISO14 = DGV_Evaluacion.Rows[e.RowIndex].Cells["ISO_14000"].Value.ToString();
                ISO90 = DGV_Evaluacion.Rows[e.RowIndex].Cells["ISO_9001"].Value.ToString();
                nExpirado = DGV_Evaluacion.Rows[e.RowIndex].Cells["No_Expirado"].Value.ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) //Botón editar.
        {
            try
            {
                if (ID == "")
                {
                    MessageBox.Show("Seleccione una fila a editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Este bloque de código muestra los datos visualizados en el DataGridView en los textbox y checkbox al presionar el botón editar.
                    idtxt.Text = ID;
                    descriptxt.Text = Descripcion;
                    provtxt.Text = Proveedor;

                    if (ISO14.Equals("True"))
                    {
                        ISO14Check.Checked = true;
                    }
                    else
                    {
                        ISO14Check.Checked = false;
                    }
                    if (ISO90.Equals("True"))
                    {
                        ISO90Check.Checked = true;
                    }
                    else
                    {
                        ISO90Check.Checked = false;
                    }
                    if (nExpirado.Equals("True"))
                    {
                        nExpCheck.Checked = true;
                    }
                    else
                    {
                        nExpCheck.Checked = false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila a editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void pictureBox2_Click(object sender, EventArgs e) //Botón Guardar.
        {
            try
            {
                //Bloque de cógido toma los valores actuales de los textbox y checkbox y los actualiza/guarda en la base de datos.
                //Posteriormente, actualiza el DataGridView en pantalla.
                MessageBox.Show(conexEva.Actualizar(Convert.ToInt16(idtxt.Text), ISO14Check.Checked, ISO90Check.Checked, nExpCheck.Checked));
                conexEva.cargarEva(DGV_Evaluacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe seleccionar un registro a editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (DataGridViewRow col in DGV_Evaluacion.Rows) // Bucle recorre columnas. Al encontrar las 3 columnas de "Check" en true, cambia el color de la fila.
                                                                 // Actualiza al presionar botón.
            {
                int colors = col.Index;

                if (DGV_Evaluacion.Rows[colors].Cells["ISO_14000"].Value.ToString().Equals("True") && DGV_Evaluacion.Rows[colors].Cells["ISO_9001"].Value.ToString().Equals("True") && DGV_Evaluacion.Rows[colors].Cells["No_Expirado"].Value.ToString().Equals("True"))
                {
                    DGV_Evaluacion.Rows[colors].DefaultCellStyle.BackColor = Color.PowderBlue;
                }
                else
                {
                    DGV_Evaluacion.Rows[colors].DefaultCellStyle.BackColor = Color.White;
                }
            }

            int count = 0;
            double res;

            for (int i = 0; i < DGV_Evaluacion.Rows.Count; i++) // Calculo de porcentaje e impresión en label para el "Cálculo Indicador de Calidad".
                                                                // Actualiza al presionar botón.
            {
                if (DGV_Evaluacion.Rows[i].Cells["ISO_14000"].Value.ToString().Equals("True") && DGV_Evaluacion.Rows[i].Cells["ISO_9001"].Value.ToString().Equals("True") && DGV_Evaluacion.Rows[i].Cells["No_Expirado"].Value.ToString().Equals("True"))
                {
                    count++;
                }
            }
            res = count * (100) / DGV_Evaluacion.Rows.Count;
            evaLabel.Text = Convert.ToString(res + "%");
        }
    }
}
