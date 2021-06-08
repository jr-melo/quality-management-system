using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_GRUPO4
{
    public partial class Menu : Form
    {
        Validacion_Letras v = new Validacion_Letras();  // Instancia de la clase para validaciones en los textbox del login.
        private ItemsForm Items_F;
        private MainMenu Menu_F;

        public Menu()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e) //Botón "Limpiar".
        {
            proptxt.Clear();
            passtxt.Clear();
        }
        private void btnEx_Click(object sender, EventArgs e) //Botón Salir. Cierra el Form del Login.
        {
            Application.Exit();
        }
        
        void CerrarItems(object sender, FormClosedEventArgs e) // Declaración de formulario de items como Null.
        {
            Items_F = null;
        }
        private void btnEva_Click(object sender, EventArgs e) // Botón Ingresar al siguiente form.
        {
            try
            {           
                if (proptxt.Text == "" || passtxt.Text == "")       // Validaciones para los textbox.
                {
                    MessageBox.Show("Debe completar todos los campos.");

                    if (proptxt.Text=="")
                    {
                        proptxt.Focus();
                    }
                    else if (passtxt.Text=="")
                    {
                        passtxt.Focus();
                    }
                }
                else if (passtxt.Text.Equals("123456"))  // Validación de contraseña correcta. Por defecto= 123456.
                {

                    if (Items_F == null) // Valida si Form Items está null, de ser así, crea la isntancia. De lo contrario, es porque ya está abierto.
                    {
                        Items_F = new ItemsForm();
                        //Items_F.MdiParent = this;
                        Items_F.FormClosed += new FormClosedEventHandler(CerrarItems);
                        Items_F.propLabel1.Text = this.proptxt.Text;
                        this.Hide();
                        Items_F.ShowDialog();
                        this.Show();
                        proptxt.Clear();
                        passtxt.Clear();  
                    }
                    else
                    {
                        Items_F.Activate();  // Si no está null, activa dicho form.
                    }
                }
                else // Validador de contraseña incorrecta.
                {
                    MessageBox.Show("La contraseña ingresada es incorrecta.");
                    passtxt.Clear();
                    passtxt.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, favor limpiar y reintentar.");
            }
        }

        private void proptxt_KeyPress(object sender, KeyPressEventArgs e) //Ejecuta las validaciones en el textbox proptxt, provenientes de la clase Validacion_Letras.cs
        {
            v.soloLetras(e);
        }

        private void proptxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
