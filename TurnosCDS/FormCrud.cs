using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnosCDS
{
    public partial class FormCrud : Form
    {
        public string oMenu, oSubMenu;
        public string[] confForm = { "Turnos", "Consultorios", "Profesionales", "Clientes" }; 
        public FormCrud()
        {
            InitializeComponent();
            //oMenu = string.Empty;
            //oSubMenu = string.Empty;
        }

        
        private void FormCrud_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cdsDataSet2.Room' Puede moverla o quitarla según sea necesario.
            this.roomTableAdapter.Fill(this.cdsDataSet2.Room);
            // TODO: esta línea de código carga datos en la tabla 'cdsDataSet1.Profesional' Puede moverla o quitarla según sea necesario.
            this.profesionalTableAdapter.Fill(this.cdsDataSet1.Profesional);
            // TODO: esta línea de código carga datos en la tabla 'cdsDataSet.Practica' Puede moverla o quitarla según sea necesario.
            this.practicaTableAdapter.Fill(this.cdsDataSet.Practica);
            this.Text = oSubMenu + " " + Application.ProductName + " " + DateTime.Now.Date.ToShortDateString();
            if (oSubMenu == "Turnos")
            {
                dateTimePicker2.Format = DateTimePickerFormat.Time;
                dateTimePicker2.ShowUpDown = true;
            }

        }
    }
}
