
namespace Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.UI
{
    partial class rRoles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rRoles));
            this.PermisoIdComboBox = new System.Windows.Forms.ComboBox();
            this.PermisoIdLabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.IdRolNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.IdRolLabel = new System.Windows.Forms.Label();
            this.EsAsignadoCheckBox = new System.Windows.Forms.CheckBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoRolButton = new System.Windows.Forms.Button();
            this.GuardarRolButton = new System.Windows.Forms.Button();
            this.EliminarRolButton = new System.Windows.Forms.Button();
            this.AgregarRolButton = new System.Windows.Forms.Button();
            this.RemoverRolButton = new System.Windows.Forms.Button();
            this.RolesDataGridView = new System.Windows.Forms.DataGridView();
            this.RolesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.IdRolNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PermisoIdComboBox
            // 
            this.PermisoIdComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PermisoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PermisoIdComboBox.FormattingEnabled = true;
            this.PermisoIdComboBox.Location = new System.Drawing.Point(105, 90);
            this.PermisoIdComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PermisoIdComboBox.Name = "PermisoIdComboBox";
            this.PermisoIdComboBox.Size = new System.Drawing.Size(170, 23);
            this.PermisoIdComboBox.TabIndex = 38;
            // 
            // PermisoIdLabel
            // 
            this.PermisoIdLabel.AutoSize = true;
            this.PermisoIdLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PermisoIdLabel.Location = new System.Drawing.Point(12, 98);
            this.PermisoIdLabel.Name = "PermisoIdLabel";
            this.PermisoIdLabel.Size = new System.Drawing.Size(68, 15);
            this.PermisoIdLabel.TabIndex = 37;
            this.PermisoIdLabel.Text = "Permiso ID";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(105, 50);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(323, 23);
            this.DescripcionTextBox.TabIndex = 36;
            // 
            // IdRolNumericUpDown
            // 
            this.IdRolNumericUpDown.Location = new System.Drawing.Point(105, 10);
            this.IdRolNumericUpDown.Name = "IdRolNumericUpDown";
            this.IdRolNumericUpDown.Size = new System.Drawing.Size(139, 23);
            this.IdRolNumericUpDown.TabIndex = 34;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescripcionLabel.Location = new System.Drawing.Point(12, 58);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(72, 15);
            this.DescripcionLabel.TabIndex = 33;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // IdRolLabel
            // 
            this.IdRolLabel.AutoSize = true;
            this.IdRolLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IdRolLabel.Location = new System.Drawing.Point(12, 17);
            this.IdRolLabel.Name = "IdRolLabel";
            this.IdRolLabel.Size = new System.Drawing.Size(39, 15);
            this.IdRolLabel.TabIndex = 31;
            this.IdRolLabel.Text = "Id Rol";
            // 
            // EsAsignadoCheckBox
            // 
            this.EsAsignadoCheckBox.AutoSize = true;
            this.EsAsignadoCheckBox.Location = new System.Drawing.Point(338, 94);
            this.EsAsignadoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EsAsignadoCheckBox.Name = "EsAsignadoCheckBox";
            this.EsAsignadoCheckBox.Size = new System.Drawing.Size(90, 19);
            this.EsAsignadoCheckBox.TabIndex = 39;
            this.EsAsignadoCheckBox.Text = "Es Asignado";
            this.EsAsignadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.Properties.Resources.search;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(250, 10);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(67, 24);
            this.BuscarButton.TabIndex = 40;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoRolButton
            // 
            this.NuevoRolButton.Image = global::Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.Properties.Resources.nuevo;
            this.NuevoRolButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoRolButton.Location = new System.Drawing.Point(12, 354);
            this.NuevoRolButton.Name = "NuevoRolButton";
            this.NuevoRolButton.Size = new System.Drawing.Size(75, 60);
            this.NuevoRolButton.TabIndex = 41;
            this.NuevoRolButton.Text = "Nuevo";
            this.NuevoRolButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoRolButton.UseVisualStyleBackColor = true;
            this.NuevoRolButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarRolButton
            // 
            this.GuardarRolButton.Image = global::Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.Properties.Resources.guardar;
            this.GuardarRolButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarRolButton.Location = new System.Drawing.Point(180, 354);
            this.GuardarRolButton.Name = "GuardarRolButton";
            this.GuardarRolButton.Size = new System.Drawing.Size(75, 60);
            this.GuardarRolButton.TabIndex = 42;
            this.GuardarRolButton.Text = "Guardar";
            this.GuardarRolButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarRolButton.UseVisualStyleBackColor = true;
            this.GuardarRolButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarRolButton
            // 
            this.EliminarRolButton.Image = global::Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.Properties.Resources.eliminar;
            this.EliminarRolButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarRolButton.Location = new System.Drawing.Point(354, 354);
            this.EliminarRolButton.Name = "EliminarRolButton";
            this.EliminarRolButton.Size = new System.Drawing.Size(75, 60);
            this.EliminarRolButton.TabIndex = 43;
            this.EliminarRolButton.Text = "Eliminar";
            this.EliminarRolButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarRolButton.UseVisualStyleBackColor = true;
            this.EliminarRolButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // AgregarRolButton
            // 
            this.AgregarRolButton.Image = global::Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.Properties.Resources.anadir;
            this.AgregarRolButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarRolButton.Location = new System.Drawing.Point(91, 319);
            this.AgregarRolButton.Name = "AgregarRolButton";
            this.AgregarRolButton.Size = new System.Drawing.Size(75, 30);
            this.AgregarRolButton.TabIndex = 44;
            this.AgregarRolButton.Text = "Agregar";
            this.AgregarRolButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarRolButton.UseVisualStyleBackColor = true;
            this.AgregarRolButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // RemoverRolButton
            // 
            this.RemoverRolButton.Image = global::Tarea_6_Rehacer_El_Mismo_Detalle_Desde_Cero.Properties.Resources.botonx;
            this.RemoverRolButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverRolButton.Location = new System.Drawing.Point(264, 319);
            this.RemoverRolButton.Name = "RemoverRolButton";
            this.RemoverRolButton.Size = new System.Drawing.Size(82, 30);
            this.RemoverRolButton.TabIndex = 45;
            this.RemoverRolButton.Text = "Remover";
            this.RemoverRolButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverRolButton.UseVisualStyleBackColor = true;
            this.RemoverRolButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // RolesDataGridView
            // 
            this.RolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesDataGridView.Location = new System.Drawing.Point(12, 130);
            this.RolesDataGridView.Name = "RolesDataGridView";
            this.RolesDataGridView.RowTemplate.Height = 25;
            this.RolesDataGridView.Size = new System.Drawing.Size(417, 170);
            this.RolesDataGridView.TabIndex = 46;
            // 
            // RolesErrorProvider
            // 
            this.RolesErrorProvider.ContainerControl = this;
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Checked = true;
            this.ActivoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActivoCheckBox.Location = new System.Drawing.Point(366, 11);
            this.ActivoCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(62, 19);
            this.ActivoCheckBox.TabIndex = 47;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegistroRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 421);
            this.Controls.Add(this.ActivoCheckBox);
            this.Controls.Add(this.RolesDataGridView);
            this.Controls.Add(this.RemoverRolButton);
            this.Controls.Add(this.AgregarRolButton);
            this.Controls.Add(this.EliminarRolButton);
            this.Controls.Add(this.GuardarRolButton);
            this.Controls.Add(this.NuevoRolButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EsAsignadoCheckBox);
            this.Controls.Add(this.PermisoIdComboBox);
            this.Controls.Add(this.PermisoIdLabel);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.IdRolNumericUpDown);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.IdRolLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroRoles";
            this.Text = "Registro Roles";
            this.Load += new System.EventHandler(this.RegistroRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdRolNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PermisoIdComboBox;
        private System.Windows.Forms.Label PermisoIdLabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown IdRolNumericUpDown;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label IdRolLabel;
        private System.Windows.Forms.CheckBox EsAsignadoCheckBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoRolButton;
        private System.Windows.Forms.Button GuardarRolButton;
        private System.Windows.Forms.Button EliminarRolButton;
        private System.Windows.Forms.Button AgregarRolButton;
        private System.Windows.Forms.Button RemoverRolButton;
        private System.Windows.Forms.DataGridView RolesDataGridView;
        private System.Windows.Forms.ErrorProvider RolesErrorProvider;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
    }
}