namespace Michi
{
    partial class frm_Login
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
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Registro = new System.Windows.Forms.Button();
            this.txt_Reg_Clave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Reg_Usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Reg_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.Location = new System.Drawing.Point(9, 81);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(146, 26);
            this.btn_Inicio.TabIndex = 3;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.UseVisualStyleBackColor = true;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Inicio);
            this.groupBox1.Controls.Add(this.txt_Clave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Usuario);
            this.groupBox1.Location = new System.Drawing.Point(181, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 113);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(55, 29);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_Usuario.TabIndex = 1;
            // 
            // txt_Clave
            // 
            this.txt_Clave.Location = new System.Drawing.Point(55, 55);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(100, 20);
            this.txt_Clave.TabIndex = 2;
            this.txt_Clave.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Clave";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_Reg_Nombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_Registro);
            this.groupBox2.Controls.Add(this.txt_Reg_Clave);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Reg_Usuario);
            this.groupBox2.Location = new System.Drawing.Point(181, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Clave";
            // 
            // btn_Registro
            // 
            this.btn_Registro.Location = new System.Drawing.Point(9, 94);
            this.btn_Registro.Name = "btn_Registro";
            this.btn_Registro.Size = new System.Drawing.Size(146, 26);
            this.btn_Registro.TabIndex = 7;
            this.btn_Registro.Text = "Registrate";
            this.btn_Registro.UseVisualStyleBackColor = true;
            this.btn_Registro.Click += new System.EventHandler(this.btn_Registro_Click);
            // 
            // txt_Reg_Clave
            // 
            this.txt_Reg_Clave.Location = new System.Drawing.Point(55, 71);
            this.txt_Reg_Clave.Name = "txt_Reg_Clave";
            this.txt_Reg_Clave.Size = new System.Drawing.Size(100, 20);
            this.txt_Reg_Clave.TabIndex = 6;
            this.txt_Reg_Clave.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Usuario";
            // 
            // txt_Reg_Usuario
            // 
            this.txt_Reg_Usuario.Location = new System.Drawing.Point(55, 45);
            this.txt_Reg_Usuario.Name = "txt_Reg_Usuario";
            this.txt_Reg_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_Reg_Usuario.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "Nombre";
            // 
            // txt_Reg_Nombre
            // 
            this.txt_Reg_Nombre.Location = new System.Drawing.Point(55, 19);
            this.txt_Reg_Nombre.Name = "txt_Reg_Nombre";
            this.txt_Reg_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Reg_Nombre.TabIndex = 4;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(12, 226);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(163, 37);
            this.btn_Cerrar.TabIndex = 8;
            this.btn_Cerrar.Text = "CERRAR";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Michi.Properties.Resources.fondo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 169);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "MICHI";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 276);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Reg_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Registro;
        private System.Windows.Forms.TextBox txt_Reg_Clave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Reg_Usuario;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}