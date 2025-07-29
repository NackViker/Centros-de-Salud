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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " Menu Principal " + DateTime.Now.Date.ToShortDateString(); 
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrud form = new FormCrud();
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrud form = new FormCrud();
            form.oSubMenu = "Turnos";
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void consultorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
