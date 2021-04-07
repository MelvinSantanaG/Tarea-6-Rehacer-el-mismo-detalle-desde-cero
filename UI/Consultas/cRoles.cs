using Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.BLL;
using Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.UI.Consultas
{
    public partial class cRoles : Form
    {
        public cRoles()
        {
            InitializeComponent();
        }

        private void cRoles_Load(object sender, EventArgs e)
        {

        }

        private void BuscarRolButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Roles>();

            if (FiltroActivoCheckBox.Checked)
            {
                if (TodosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioRolTextBox.Text))
                    {
                        switch (FiltroRolComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioRolTextBox.Text));
                                break;

                            case 1:
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioRolTextBox.Text));
                                break;

                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => true);
                }
                else if (ActivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioRolTextBox.Text))
                    {
                        switch (FiltroRolComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioRolTextBox.Text) && r.EsActivo);
                                break;
                            case 1:
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioRolTextBox.Text.ToUpper()) && r.EsActivo || r.Descripcion.Contains(CriterioRolTextBox.Text.ToLower()) && r.EsActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => r.EsActivo);
                }
                else if (InactivosRadioButton.Checked)
                {
                    if (!String.IsNullOrWhiteSpace(CriterioRolTextBox.Text))
                    {
                        switch (FiltroRolComboBox.SelectedIndex)
                        {
                            case 0:
                                lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioRolTextBox.Text) && !r.EsActivo);
                                break;
                            case 1:
                                lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioRolTextBox.Text.ToUpper()) && !r.EsActivo || r.Descripcion.Contains(CriterioRolTextBox.Text.ToLower()) && !r.EsActivo);
                                break;
                            default:
                                break;
                        }
                    }
                    else
                        lista = RolesBLL.GetList(r => !r.EsActivo);
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(CriterioRolTextBox.Text))
                {
                    switch (FiltroRolComboBox.SelectedIndex)
                    {
                        case 0:
                            lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioRolTextBox.Text));
                            break;
                        case 1:
                            lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioRolTextBox.Text));
                            break;
                        default:
                            break;
                    }
                }
                else
                    lista = RolesBLL.GetList(r => true);
            }

            if (FiltroFechaRolCheckBox.Checked)
            {
                lista = RolesBLL.GetList(l => l.FechaCreacion >= DesdeDateTimePicker.Value && l.FechaCreacion <= HastaDateTimePicker.Value);
            }

            DetalleRolesDataGridView.DataSource = null;
            DetalleRolesDataGridView.DataSource = lista;
        }

        private void FiltroActivoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FiltroActivoCheckBox.Checked) { 
           
                EsActivoGroupBox.Enabled = true;
            }
            else
            {
                EsActivoGroupBox.Enabled = false;
            }
        }
    }
}
