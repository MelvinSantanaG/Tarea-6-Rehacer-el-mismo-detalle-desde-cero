using Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.UI;
using Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.UI.Consultas;
using System;
using System.Windows.Forms;

namespace Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero
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
            var Roles = new rRoles();
            Roles.Show();
        }

        private void ConsultaRolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Roles = new cRoles();
            Roles.Show();
        }

    }
}
