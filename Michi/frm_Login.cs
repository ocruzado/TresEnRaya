using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Michi
{
    public partial class frm_Login : Form
    {
        public Jugador j;

        public frm_Login()
        {
            InitializeComponent();

            j = new Jugador();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            j.Usuario = txt_Usuario.Text;
            j.Clave = txt_Clave.Text;

            if (j.obtener())
            {
                IniciarMichi();
            }
            else
            {
                MessageBox.Show(this, "Usuario o Clave Incorrectos");
            }

        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            j.Nombre = txt_Reg_Nombre.Text;
            j.Usuario = txt_Reg_Usuario.Text;
            j.Clave = txt_Reg_Clave.Text;

            if (j.insertar())
            {
                MessageBox.Show(this, "Bienvenido");

                IniciarMichi();
            }
            else
            {
                MessageBox.Show(this, "Usuario Ingresado ya esta en Uso");
            }

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IniciarMichi()
        {
            frm_Michi michi = new frm_Michi();

            michi.j = this.j;

            michi.Show();

            this.Hide();
        }
    }
}
