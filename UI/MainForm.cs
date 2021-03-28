using Tarea_6_Rehacer_el_mismo_detalle_desde_cero.UI;
using Tarea_6_Rehacer_el_mismo_detalle_desde_cero.UI.Consultas;
using System;
using System.Windows.Forms;

namespace Tarea_6_Rehacer_el_mismo_detalle_desde_cero
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.RolesToolStripMenuItem.Click += new EventHandler(this.RolesToolStripMenuItem_ItemClicked);


            this.ConsultaRolesToolStripMenuItem.Click += new EventHandler(this.ConsultaRolesToolStripMenuItem_ItemClicked);
        }

        private void RolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Roles = new RegistroRoles();
            Roles.Show();
        }

        private void ConsultaRolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Roles = new cRoles();
            Roles.Show();
        }

    }
}
