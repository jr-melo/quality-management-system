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
    public partial class ItemsForm : Form
    {
        conexioncs conexItem = new conexioncs(); //Instancia de la clase conexioncs.cs en este formulario.

        private EvaluateForm evaForm; //Objeto del formulario evaluacion. 

        public ItemsForm()
        {
            InitializeComponent();
        }

        private void ItemsForm_Load(object sender, EventArgs e) // Carga del form.
        {

            conexItem.cargarItems(DGV_Items); //Carga los datos en la tabla de artículos, proveniente de un método en la clase conexioncs.

            label2.Text = DateTime.Now.ToLongDateString();
            label3.BringToFront();
        }

        private void btnCalc_Click(object sender, EventArgs e) // Botón para generar formulario de Evaluacion.
        {
            if (evaForm == null) // Si formulario de evaluación es null, crea una instancia del mismo. La muestra y esconde el actual formulario.
            {
                evaForm = new EvaluateForm();
                //Items_F.MdiParent = this;
                evaForm.FormClosed += new FormClosedEventHandler(CerrarEva);
                evaForm.propLabel2.Text = this.propLabel1.Text;
                this.Hide();
                evaForm.ShowDialog();
                this.Show();
            }
            else // Si el formulario no es null, lo activa.
            {
                evaForm.Activate();
            }
        }
        void CerrarEva(object sender, FormClosedEventArgs e) // Al cerrar form de evaluación, asigna valor null.
        {
            evaForm = null;
        }
    }
}
