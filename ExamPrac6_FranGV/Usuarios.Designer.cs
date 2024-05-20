namespace ExamPrac6_FranGV
{
    partial class Usuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasenia = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasenia = new System.Windows.Forms.Label();
            this.buttonAcceder = new System.Windows.Forms.Button();
            this.buttonCargarUsuarios = new System.Windows.Forms.Button();
            this.comboBoxListaUsuarios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(113, 44);
            this.textBoxUsuario.MaxLength = 1000;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(144, 20);
            this.textBoxUsuario.TabIndex = 0;
            // 
            // textBoxContrasenia
            // 
            this.textBoxContrasenia.Location = new System.Drawing.Point(113, 86);
            this.textBoxContrasenia.MaxLength = 8;
            this.textBoxContrasenia.Name = "textBoxContrasenia";
            this.textBoxContrasenia.Size = new System.Drawing.Size(144, 20);
            this.textBoxContrasenia.TabIndex = 1;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(43, 47);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelContrasenia
            // 
            this.labelContrasenia.AutoSize = true;
            this.labelContrasenia.Location = new System.Drawing.Point(43, 89);
            this.labelContrasenia.Name = "labelContrasenia";
            this.labelContrasenia.Size = new System.Drawing.Size(64, 13);
            this.labelContrasenia.TabIndex = 3;
            this.labelContrasenia.Text = "Contraseña:";
            // 
            // buttonAcceder
            // 
            this.buttonAcceder.Location = new System.Drawing.Point(46, 124);
            this.buttonAcceder.Name = "buttonAcceder";
            this.buttonAcceder.Size = new System.Drawing.Size(211, 23);
            this.buttonAcceder.TabIndex = 4;
            this.buttonAcceder.Text = "Acceder";
            this.buttonAcceder.UseVisualStyleBackColor = true;
            this.buttonAcceder.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // buttonCargarUsuarios
            // 
            this.buttonCargarUsuarios.Location = new System.Drawing.Point(46, 172);
            this.buttonCargarUsuarios.Name = "buttonCargarUsuarios";
            this.buttonCargarUsuarios.Size = new System.Drawing.Size(211, 23);
            this.buttonCargarUsuarios.TabIndex = 5;
            this.buttonCargarUsuarios.Text = "Cargar Usuarios Registrados";
            this.buttonCargarUsuarios.UseVisualStyleBackColor = true;
            this.buttonCargarUsuarios.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // comboBoxListaUsuarios
            // 
            this.comboBoxListaUsuarios.FormattingEnabled = true;
            this.comboBoxListaUsuarios.Location = new System.Drawing.Point(46, 217);
            this.comboBoxListaUsuarios.Name = "comboBoxListaUsuarios";
            this.comboBoxListaUsuarios.Size = new System.Drawing.Size(211, 21);
            this.comboBoxListaUsuarios.TabIndex = 6;
            this.comboBoxListaUsuarios.SelectedIndexChanged += new System.EventHandler(this.comboBoxListaUsuarios_SelectedIndexChanged);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 261);
            this.Controls.Add(this.comboBoxListaUsuarios);
            this.Controls.Add(this.buttonCargarUsuarios);
            this.Controls.Add(this.buttonAcceder);
            this.Controls.Add(this.labelContrasenia);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxContrasenia);
            this.Controls.Add(this.textBoxUsuario);
            this.Name = "Usuarios";
            this.Text = "Examen Práctico";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasenia;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasenia;
        private System.Windows.Forms.Button buttonAcceder;
        private System.Windows.Forms.Button buttonCargarUsuarios;
        private System.Windows.Forms.ComboBox comboBoxListaUsuarios;
    }
}

