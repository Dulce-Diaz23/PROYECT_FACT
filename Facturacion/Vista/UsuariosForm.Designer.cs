namespace Vista
{
    partial class UsuariosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.EstaActiVoCheckBox = new System.Windows.Forms.CheckBox();
            this.AdjuntarFotoButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.UsuarioDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Location = new System.Drawing.Point(98, 15);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(201, 22);
            this.CodigoTextBox.TabIndex = 1;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Enabled = false;
            this.NombreTextBox.Location = new System.Drawing.Point(98, 46);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(201, 22);
            this.NombreTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // ContrasenaTextBox
            // 
            this.ContrasenaTextBox.Enabled = false;
            this.ContrasenaTextBox.Location = new System.Drawing.Point(98, 74);
            this.ContrasenaTextBox.Name = "ContrasenaTextBox";
            this.ContrasenaTextBox.Size = new System.Drawing.Size(201, 22);
            this.ContrasenaTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contrasena:";
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Enabled = false;
            this.CorreoTextBox.Location = new System.Drawing.Point(98, 102);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(201, 22);
            this.CorreoTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rol:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Esta Activo:";
            // 
            // RolComboBox
            // 
            this.RolComboBox.Enabled = false;
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.RolComboBox.Location = new System.Drawing.Point(98, 130);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(201, 24);
            this.RolComboBox.TabIndex = 12;
            // 
            // EstaActiVoCheckBox
            // 
            this.EstaActiVoCheckBox.AutoSize = true;
            this.EstaActiVoCheckBox.Enabled = false;
            this.EstaActiVoCheckBox.Location = new System.Drawing.Point(98, 179);
            this.EstaActiVoCheckBox.Name = "EstaActiVoCheckBox";
            this.EstaActiVoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActiVoCheckBox.TabIndex = 13;
            this.EstaActiVoCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdjuntarFotoButton
            // 
            this.AdjuntarFotoButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AdjuntarFotoButton.Enabled = false;
            this.AdjuntarFotoButton.Image = global::Vista.Properties.Resources.buscar;
            this.AdjuntarFotoButton.Location = new System.Drawing.Point(502, 111);
            this.AdjuntarFotoButton.Name = "AdjuntarFotoButton";
            this.AdjuntarFotoButton.Size = new System.Drawing.Size(34, 25);
            this.AdjuntarFotoButton.TabIndex = 15;
            this.AdjuntarFotoButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(357, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 118);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NuevoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NuevoButton.Location = new System.Drawing.Point(127, 238);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 16;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = false;
            // 
            // ModificarButton
            // 
            this.ModificarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModificarButton.Enabled = false;
            this.ModificarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModificarButton.Location = new System.Drawing.Point(208, 238);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 17;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GuardarButton.Enabled = false;
            this.GuardarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GuardarButton.Location = new System.Drawing.Point(289, 238);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 18;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = false;
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EliminarButton.Enabled = false;
            this.EliminarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EliminarButton.Location = new System.Drawing.Point(370, 238);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 19;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = false;
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelarButton.Enabled = false;
            this.CancelarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CancelarButton.Location = new System.Drawing.Point(451, 238);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 20;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = false;
            // 
            // UsuarioDataGridView
            // 
            this.UsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuarioDataGridView.Location = new System.Drawing.Point(1, 283);
            this.UsuarioDataGridView.Name = "UsuarioDataGridView";
            this.UsuarioDataGridView.Size = new System.Drawing.Size(631, 150);
            this.UsuarioDataGridView.TabIndex = 21;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 431);
            this.Controls.Add(this.UsuarioDataGridView);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.AdjuntarFotoButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EstaActiVoCheckBox);
            this.Controls.Add(this.RolComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CorreoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContrasenaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UsuariosForm";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContrasenaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CorreoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RolComboBox;
        private System.Windows.Forms.CheckBox EstaActiVoCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AdjuntarFotoButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.DataGridView UsuarioDataGridView;
    }
}