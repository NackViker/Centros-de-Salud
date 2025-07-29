using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Data;
using System.Drawing;
using System.CodeDom;
using System.Data.Common;

namespace Gestosoc.ConnexionDB
{
    public class AccesoDatos
    //clase utilizada por todos los formularios para realizar operaciones con datos

    {
        //Atributos

        //la cadena almacenada en app.config p/conectarse a sql server
        public static string cadenaConexion; 

        private SqlConnection conexion;
        //la tabla o vista a mostrar en el datagridview que luego usara el form crud
        public string consultaSql = null; 
        
        public bool validarConn;
        
        public bool esFrmView =false;

        //metodos

        //obtengo la cadena de conexion a la bd guardada en app.config
        public static string ObtenerCadenaConexion()
        {
            string con;// =string.Empty;
            con = ConfigurationManager.ConnectionStrings["myConn"].ConnectionString;
            con = con.Trim();

            return con;
        }

        //metodo para saber si la cadena de conexion de la bd se encuentra guardada en el archivo de config de la app
        public bool IsConnStr()
        //Si existe la cadena de conexion en app.config => retorna true
        //sino false
        {
            if (cadenaConexion == null)
            {
                return false;
            }
            return true;
        }


        public bool ConectarBd()
        {
            bool positivo = false;
            try
            {
                cadenaConexion = ObtenerCadenaConexion();
                validarConn = IsConnStr();
                if (validarConn) 
                {
                    conexion = new SqlConnection
                    {
                        ConnectionString = cadenaConexion
                    };
                    if (conexion.State == ConnectionState.Closed)
                    { 
                        conexion.Open();
                        positivo = true;
                    }
                }
                else
                {
                    MessageBox.Show("No se encuentra cadena de conexion a la Base de Datos", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(
                    "Hubo un error al intentar conectarse a la Base de Datos ",
                    e.ErrorCode.ToString(),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            //finally
            //{
            //    //MessageBox.Show("Conexion exitosa a la base de datos");

            //}
            return positivo;
        }

        public void DesconectarBD()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
            else
            {
                MessageBox.Show("Base de datos no se puede cerrar");
            }
        }
        public bool ConfigCommand()
        {
            bool EsConfigcmdok = false;
            var command = new SqlCommand(consultaSql, conexion);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consultaSql, command.Connection);
            da.Fill(dt);

            if (dt.Rows.Count >= 1) 
            {
                EsConfigcmdok=true;
                if (!esFrmView)
                {
                    dt.Dispose();
                    da.Dispose();
                }
                //else {
                //frmViewData frm = new frmViewData();
                //frm.vistas = "";
                
            }

            return EsConfigcmdok;
            
            //this.dataGridView1.DataSource = dt;
            //dataGridView1.BeginEdit(false);
        }

        private void ConfigTypeCommand(SqlCommand _cmd)
        {

        }

        private void AbrirTablaConfigOpcMnu(SqlCommand cmd)
        {

        }
    }
}