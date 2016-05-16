namespace Michi
{
    partial class frm_Michi
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
            this.pnl_Michi = new System.Windows.Forms.Panel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_Jugador_Puntaje = new System.Windows.Forms.Label();
            this.lbl_Jugador_Nombre = new System.Windows.Forms.Label();
            this.lbl_Computador = new System.Windows.Forms.Label();
            this.lbl_Computador_Puntaje = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.pct11 = new System.Windows.Forms.PictureBox();
            this.pct33 = new System.Windows.Forms.PictureBox();
            this.pct32 = new System.Windows.Forms.PictureBox();
            this.pct31 = new System.Windows.Forms.PictureBox();
            this.pct23 = new System.Windows.Forms.PictureBox();
            this.pct22 = new System.Windows.Forms.PictureBox();
            this.pct21 = new System.Windows.Forms.PictureBox();
            this.pct13 = new System.Windows.Forms.PictureBox();
            this.pct12 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_Michi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct12)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Michi
            // 
            this.pnl_Michi.BackColor = System.Drawing.Color.Black;
            this.pnl_Michi.Controls.Add(this.pct11);
            this.pnl_Michi.Controls.Add(this.pct33);
            this.pnl_Michi.Controls.Add(this.pct32);
            this.pnl_Michi.Controls.Add(this.pct31);
            this.pnl_Michi.Controls.Add(this.pct23);
            this.pnl_Michi.Controls.Add(this.pct22);
            this.pnl_Michi.Controls.Add(this.pct21);
            this.pnl_Michi.Controls.Add(this.pct13);
            this.pnl_Michi.Controls.Add(this.pct12);
            this.pnl_Michi.Location = new System.Drawing.Point(12, 50);
            this.pnl_Michi.Name = "pnl_Michi";
            this.pnl_Michi.Size = new System.Drawing.Size(311, 311);
            this.pnl_Michi.TabIndex = 0;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(138, 402);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(80, 61);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Limpiar";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_Jugador_Puntaje
            // 
            this.lbl_Jugador_Puntaje.AutoSize = true;
            this.lbl_Jugador_Puntaje.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jugador_Puntaje.Location = new System.Drawing.Point(12, 384);
            this.lbl_Jugador_Puntaje.Name = "lbl_Jugador_Puntaje";
            this.lbl_Jugador_Puntaje.Size = new System.Drawing.Size(40, 42);
            this.lbl_Jugador_Puntaje.TabIndex = 2;
            this.lbl_Jugador_Puntaje.Text = "0";
            // 
            // lbl_Jugador_Nombre
            // 
            this.lbl_Jugador_Nombre.AutoSize = true;
            this.lbl_Jugador_Nombre.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jugador_Nombre.Location = new System.Drawing.Point(12, 365);
            this.lbl_Jugador_Nombre.Name = "lbl_Jugador_Nombre";
            this.lbl_Jugador_Nombre.Size = new System.Drawing.Size(80, 14);
            this.lbl_Jugador_Nombre.TabIndex = 5;
            this.lbl_Jugador_Nombre.Text = "[lbl_ombre]";
            this.lbl_Jugador_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Computador
            // 
            this.lbl_Computador.AutoSize = true;
            this.lbl_Computador.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Computador.Location = new System.Drawing.Point(12, 426);
            this.lbl_Computador.Name = "lbl_Computador";
            this.lbl_Computador.Size = new System.Drawing.Size(72, 14);
            this.lbl_Computador.TabIndex = 7;
            this.lbl_Computador.Text = "Cyberdyne";
            // 
            // lbl_Computador_Puntaje
            // 
            this.lbl_Computador_Puntaje.AutoSize = true;
            this.lbl_Computador_Puntaje.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Computador_Puntaje.Location = new System.Drawing.Point(12, 445);
            this.lbl_Computador_Puntaje.Name = "lbl_Computador_Puntaje";
            this.lbl_Computador_Puntaje.Size = new System.Drawing.Size(40, 42);
            this.lbl_Computador_Puntaje.TabIndex = 6;
            this.lbl_Computador_Puntaje.Text = "0";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(243, 402);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(80, 61);
            this.btn_Cerrar.TabIndex = 8;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // pct11
            // 
            this.pct11.BackColor = System.Drawing.Color.White;
            this.pct11.Location = new System.Drawing.Point(0, 0);
            this.pct11.Name = "pct11";
            this.pct11.Size = new System.Drawing.Size(100, 100);
            this.pct11.TabIndex = 0;
            this.pct11.TabStop = false;
            this.pct11.Click += new System.EventHandler(this.pct11_Click);
            this.pct11.MouseEnter += new System.EventHandler(this.pct11_MouseEnter);
            this.pct11.MouseLeave += new System.EventHandler(this.pct11_MouseLeave);
            // 
            // pct33
            // 
            this.pct33.BackColor = System.Drawing.Color.White;
            this.pct33.Location = new System.Drawing.Point(212, 212);
            this.pct33.Name = "pct33";
            this.pct33.Size = new System.Drawing.Size(100, 100);
            this.pct33.TabIndex = 8;
            this.pct33.TabStop = false;
            this.pct33.Click += new System.EventHandler(this.pct33_Click);
            this.pct33.MouseEnter += new System.EventHandler(this.pct33_MouseEnter);
            this.pct33.MouseLeave += new System.EventHandler(this.pct33_MouseLeave);
            // 
            // pct32
            // 
            this.pct32.BackColor = System.Drawing.Color.White;
            this.pct32.Location = new System.Drawing.Point(106, 212);
            this.pct32.Name = "pct32";
            this.pct32.Size = new System.Drawing.Size(100, 100);
            this.pct32.TabIndex = 7;
            this.pct32.TabStop = false;
            this.pct32.Click += new System.EventHandler(this.pct32_Click);
            this.pct32.MouseEnter += new System.EventHandler(this.pct32_MouseEnter);
            this.pct32.MouseLeave += new System.EventHandler(this.pct32_MouseLeave);
            // 
            // pct31
            // 
            this.pct31.BackColor = System.Drawing.Color.White;
            this.pct31.Location = new System.Drawing.Point(0, 212);
            this.pct31.Name = "pct31";
            this.pct31.Size = new System.Drawing.Size(100, 100);
            this.pct31.TabIndex = 6;
            this.pct31.TabStop = false;
            this.pct31.Click += new System.EventHandler(this.pct31_Click);
            this.pct31.MouseEnter += new System.EventHandler(this.pct31_MouseEnter);
            this.pct31.MouseLeave += new System.EventHandler(this.pct31_MouseLeave);
            // 
            // pct23
            // 
            this.pct23.BackColor = System.Drawing.Color.White;
            this.pct23.Location = new System.Drawing.Point(212, 106);
            this.pct23.Name = "pct23";
            this.pct23.Size = new System.Drawing.Size(100, 100);
            this.pct23.TabIndex = 5;
            this.pct23.TabStop = false;
            this.pct23.Click += new System.EventHandler(this.pct23_Click);
            this.pct23.MouseEnter += new System.EventHandler(this.pct23_MouseEnter);
            this.pct23.MouseLeave += new System.EventHandler(this.pct23_MouseLeave);
            // 
            // pct22
            // 
            this.pct22.BackColor = System.Drawing.Color.White;
            this.pct22.Location = new System.Drawing.Point(106, 106);
            this.pct22.Name = "pct22";
            this.pct22.Size = new System.Drawing.Size(100, 100);
            this.pct22.TabIndex = 4;
            this.pct22.TabStop = false;
            this.pct22.Click += new System.EventHandler(this.pct22_Click);
            this.pct22.MouseEnter += new System.EventHandler(this.pct22_MouseEnter);
            this.pct22.MouseLeave += new System.EventHandler(this.pct22_MouseLeave);
            // 
            // pct21
            // 
            this.pct21.BackColor = System.Drawing.Color.White;
            this.pct21.Location = new System.Drawing.Point(0, 106);
            this.pct21.Name = "pct21";
            this.pct21.Size = new System.Drawing.Size(100, 100);
            this.pct21.TabIndex = 3;
            this.pct21.TabStop = false;
            this.pct21.Click += new System.EventHandler(this.pct21_Click);
            this.pct21.MouseEnter += new System.EventHandler(this.pct21_MouseEnter);
            this.pct21.MouseLeave += new System.EventHandler(this.pct21_MouseLeave);
            // 
            // pct13
            // 
            this.pct13.BackColor = System.Drawing.Color.White;
            this.pct13.Location = new System.Drawing.Point(212, 0);
            this.pct13.Name = "pct13";
            this.pct13.Size = new System.Drawing.Size(100, 100);
            this.pct13.TabIndex = 2;
            this.pct13.TabStop = false;
            this.pct13.Click += new System.EventHandler(this.pct13_Click);
            this.pct13.MouseEnter += new System.EventHandler(this.pct13_MouseEnter);
            this.pct13.MouseLeave += new System.EventHandler(this.pct13_MouseLeave);
            // 
            // pct12
            // 
            this.pct12.BackColor = System.Drawing.Color.White;
            this.pct12.Location = new System.Drawing.Point(106, 0);
            this.pct12.Name = "pct12";
            this.pct12.Size = new System.Drawing.Size(100, 100);
            this.pct12.TabIndex = 1;
            this.pct12.TabStop = false;
            this.pct12.Click += new System.EventHandler(this.pct12_Click);
            this.pct12.MouseEnter += new System.EventHandler(this.pct12_MouseEnter);
            this.pct12.MouseLeave += new System.EventHandler(this.pct12_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 36);
            this.label6.TabIndex = 10;
            this.label6.Text = "MICHI";
            // 
            // frm_Michi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 501);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.lbl_Jugador_Puntaje);
            this.Controls.Add(this.lbl_Jugador_Nombre);
            this.Controls.Add(this.lbl_Computador);
            this.Controls.Add(this.lbl_Computador_Puntaje);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.pnl_Michi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Michi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MICHI";
            this.Load += new System.EventHandler(this.frm_Michi_Load);
            this.pnl_Michi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Michi;
        private System.Windows.Forms.PictureBox pct33;
        private System.Windows.Forms.PictureBox pct32;
        private System.Windows.Forms.PictureBox pct31;
        private System.Windows.Forms.PictureBox pct23;
        private System.Windows.Forms.PictureBox pct22;
        private System.Windows.Forms.PictureBox pct21;
        private System.Windows.Forms.PictureBox pct13;
        private System.Windows.Forms.PictureBox pct12;
        private System.Windows.Forms.PictureBox pct11;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_Jugador_Puntaje;
        private System.Windows.Forms.Label lbl_Jugador_Nombre;
        private System.Windows.Forms.Label lbl_Computador;
        private System.Windows.Forms.Label lbl_Computador_Puntaje;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label label6;
    }
}