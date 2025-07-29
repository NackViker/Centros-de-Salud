using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using Nini.Config;
using System.Configuration;
using System.Windows.Forms;
using Gestosoc.ConnexionDB;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestosoc
{
    public partial class AccessToApp : Form
    {
        //variable booleana para saber si las 
        //credenciales de ingreso son validas
        private bool existenUsPas = false;
        public AccessToApp()
        {
            InitializeComponent();
        }

        //
        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (this.TextBoxUser.Text == "" || this.TextBoxPassword.Text == "")
            {
                MessageBox.Show("Usuario y/o contraseña en Blanco, Ingrese los datos","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                TextBoxUser.Focus();
                return;
            }

            //checar que el usuario y la contraseña exista en la base de datos 
            existenUsPas = CargarDatosDB(TextBoxUser.Text.Trim(), TextBoxPassword.Text.Trim());
            if (!existenUsPas)
            {
                MessageBox.Show("Usuario y/o contraseñas invalidos");
                this.TextBoxUser.Text = "";
                this.TextBoxPassword.Text = "";
                TextBoxUser.Focus();
            }
            else
            {
                //enviar el usuario y la password a la tabla de configuracion del formulario hijo 
                //para mostrar las opciones disponibles para dicho user, de acuerdo al rol asignado
                //en las reglas de negocio del sistema "GESTOSOC" 
                //this.Visible.Equals(false);
                Hide();
                TurnosCDS.FormMenu frm = new TurnosCDS.FormMenu();
                frm.ShowDialog();
                this.Visible = true;
            }
        }

        private bool CargarDatosDB(string user, string password)
        {
            ConnexionDB.AccesoDatos connexionDB = new AccesoDatos();
            try
            {
                string tabla = "Usuarios";
                bool HayDBase = false;
                HayDBase = connexionDB.ConectarBd();

                if (HayDBase)
                {
                    //bool uspasValid = false;
                    string TablaCons = "Select * from Usuarios where usuario=" + "'" + user + "'" + " and password=" + "'" + password + "'";
                    //AccesoDatos accesoDatos = new AccesoDatos();

                    string[] columns = { user, password };
                    //foreach(var i in columns)
                    //{
                    //    columns
                    //}
                    connexionDB.consultaSql += TablaCons;
                    //connexionDB.consultaSql += " where" + TablaCons + "";
                    bool valid = connexionDB.ConfigCommand();
                    if (valid)
                    {
                        return valid;
                    }
                    else
                    {

                        return valid;
                    }

                }
                else
                {
                    MessageBox.Show("No se encuentra la Base de datos o la tabla {0}" + tabla);
                    return false;
                }

            }
            catch (Exception e)
            {
                string mensaje = e.Message;
                MessageBox.Show("Error de acceso a base de datos " + mensaje, "Atención");
                return false;
            }
            finally { connexionDB.DesconectarBD(); }
        }

        //private void ButtonCancelar_Click(object sender, EventArgs e) => Formclosing(sender, e);

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                    SendKeys.Send("{TAB}");
            }
        }

        private void AccessToApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (MessageBox.Show("¿Desea cerrar el Formulario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No);
        }

        private void AccessToApp_Load(object sender, EventArgs e)
        {
            this.Text += Application.ProductName + " " + DateTime.Now.Date.ToShortDateString();
        }

        private void AccessToApp_Activated(object sender, EventArgs e)
        {
            this.TextBoxUser.Focus();
            this.TextBoxUser.Text = "";this.TextBoxPassword.Text = "";
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
