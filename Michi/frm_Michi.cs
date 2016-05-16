using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Michi
{
    public partial class frm_Michi : Form
    {
        private int[,] michi = new int[3, 3];

        private int Score_Jugador = 0;
        private int Score_Computador = 0;

        private Bitmap Ico_Jugador = Properties.Resources.circulo;
        private Bitmap Ico_Computador = Properties.Resources.equis;

        public Jugador j;

        public frm_Michi()
        {
            InitializeComponent();
        }

        private void frm_Michi_Load(object sender, EventArgs e)
        {
            lbl_Jugador_Nombre.Text = j.Nombre;

            Score_Computador = 0;
            Score_Jugador = 0;

            lbl_Computador_Puntaje.Text = "0";
            lbl_Jugador_Puntaje.Text = "0";
        }

        #region Evento Click
        private void pct11_Click(object sender, EventArgs e)
        {
            if (michi[0, 0] == 0)
            {
                pct11.Image = Ico_Jugador;
                michi[0, 0] = 1;
            }

            Computador();
        }

        private void pct12_Click(object sender, EventArgs e)
        {
            if (michi[0, 1] == 0)
            {
                pct12.Image = Ico_Jugador;
                michi[0, 1] = 1;
            }

            Computador();
        }

        private void pct13_Click(object sender, EventArgs e)
        {
            if (michi[0, 2] == 0)
            {
                pct13.Image = Ico_Jugador;
                michi[0, 2] = 1;
            }

            Computador();
        }

        private void pct21_Click(object sender, EventArgs e)
        {
            if (michi[1, 0] == 0)
            {
                pct21.Image = Ico_Jugador;
                michi[1, 0] = 1;
            }

            Computador();
        }

        private void pct22_Click(object sender, EventArgs e)
        {
            if (michi[1, 1] == 0)
            {
                pct22.Image = Ico_Jugador;
                michi[1, 1] = 1;
            }

            Computador();
        }

        private void pct23_Click(object sender, EventArgs e)
        {
            if (michi[1, 2] == 0)
            {
                pct23.Image = Ico_Jugador;
                michi[1, 2] = 1;
            }

            Computador();
        }

        private void pct31_Click(object sender, EventArgs e)
        {
            if (michi[2, 0] == 0)
            {
                pct31.Image = Ico_Jugador;
                michi[2, 0] = 1;
            }

            Computador();
        }

        private void pct32_Click(object sender, EventArgs e)
        {
            if (michi[2, 1] == 0)
            {
                pct32.Image = Ico_Jugador;
                michi[2, 1] = 1;
            }

            Computador();
        }

        private void pct33_Click(object sender, EventArgs e)
        {
            if (michi[2, 2] == 0)
            {
                pct33.Image = Ico_Jugador;
                michi[2, 2] = 1;
            }

            Computador();
        }
        #endregion

        #region Evento MouseEnter
        private void pct11_MouseEnter(object sender, EventArgs e)
        {
            if (michi[0, 0] == 0)
            {
                pct11.Image = Ico_Jugador;
            }
        }

        private void pct12_MouseEnter(object sender, EventArgs e)
        {
            if (michi[0, 1] == 0)
            {
                pct12.Image = Ico_Jugador;
            }
        }

        private void pct13_MouseEnter(object sender, EventArgs e)
        {
            if (michi[0, 2] == 0)
            {
                pct13.Image = Ico_Jugador;
            }
        }

        private void pct21_MouseEnter(object sender, EventArgs e)
        {
            if (michi[1, 0] == 0)
            {
                pct21.Image = Ico_Jugador;
            }
        }

        private void pct22_MouseEnter(object sender, EventArgs e)
        {
            if (michi[1, 1] == 0)
            {
                pct22.Image = Ico_Jugador;
            }
        }

        private void pct23_MouseEnter(object sender, EventArgs e)
        {
            if (michi[1, 2] == 0)
            {
                pct23.Image = Ico_Jugador;
            }
        }

        private void pct31_MouseEnter(object sender, EventArgs e)
        {
            if (michi[2, 0] == 0)
            {
                pct31.Image = Ico_Jugador;
            }
        }

        private void pct32_MouseEnter(object sender, EventArgs e)
        {
            if (michi[2, 1] == 0)
            {
                pct32.Image = Ico_Jugador;
            }
        }

        private void pct33_MouseEnter(object sender, EventArgs e)
        {
            if (michi[2, 2] == 0)
            {
                pct33.Image = Ico_Jugador;
            }
        }
        #endregion

        #region Evento MouseLeave
        private void pct11_MouseLeave(object sender, EventArgs e)
        {
            if (michi[0, 0] == 0)
            {
                pct11.Image = null;
            }
        }

        private void pct12_MouseLeave(object sender, EventArgs e)
        {
            if (michi[0, 1] == 0)
            {
                pct12.Image = null;
            }
        }

        private void pct13_MouseLeave(object sender, EventArgs e)
        {
            if (michi[0, 2] == 0)
            {
                pct13.Image = null;
            }
        }

        private void pct21_MouseLeave(object sender, EventArgs e)
        {
            if (michi[1, 0] == 0)
            {
                pct21.Image = null;
            }
        }

        private void pct22_MouseLeave(object sender, EventArgs e)
        {
            if (michi[1, 1] == 0)
            {
                pct22.Image = null;
            }
        }

        private void pct23_MouseLeave(object sender, EventArgs e)
        {
            if (michi[1, 2] == 0)
            {
                pct23.Image = null;
            }
        }

        private void pct31_MouseLeave(object sender, EventArgs e)
        {
            if (michi[2, 0] == 0)
            {
                pct31.Image = null;
            }
        }

        private void pct32_MouseLeave(object sender, EventArgs e)
        {
            if (michi[2, 1] == 0)
            {
                pct32.Image = null;
            }
        }

        private void pct33_MouseLeave(object sender, EventArgs e)
        {
            if (michi[2, 2] == 0)
            {
                pct33.Image = null;
            }
        }
        #endregion

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            michi = new int[3, 3];

            pct11.Image = null;
            pct12.Image = null;
            pct13.Image = null;

            pct21.Image = null;
            pct22.Image = null;
            pct23.Image = null;

            pct31.Image = null;
            pct32.Image = null;
            pct33.Image = null;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ganador(int Id_Jugador)
        {
            bool ganador = false;

            #region Fila
            // Fila 1.*
            if (michi[0, 0] == Id_Jugador & michi[0, 1] == Id_Jugador & michi[0, 2] == Id_Jugador)
            {
                ganador = true;
            }
            // Fila 2.*
            if (michi[1, 0] == Id_Jugador & michi[1, 1] == Id_Jugador & michi[1, 2] == Id_Jugador)
            {
                ganador = true;
            }
            // Fila 3.*
            if (michi[2, 0] == Id_Jugador & michi[2, 1] == Id_Jugador & michi[2, 2] == Id_Jugador)
            {
                ganador = true;
            }
            #endregion


            #region Columna
            // Columna *.1
            if (michi[0, 0] == Id_Jugador & michi[1, 0] == Id_Jugador & michi[2, 0] == Id_Jugador)
            {
                ganador = true;
            }
            
            // Columna *.2
            if (michi[0, 1] == Id_Jugador & michi[1, 1] == Id_Jugador & michi[2, 1] == Id_Jugador)
            {
                ganador = true;
            }
            // Columna *.3
            if (michi[0, 2] == Id_Jugador & michi[1, 2] == Id_Jugador & michi[2, 2] == Id_Jugador)
            {
                ganador = true;
            }
            #endregion

            #region Diagonal
            // Diagonal 1
            if (michi[0, 0] == Id_Jugador & michi[1, 1] == Id_Jugador & michi[2, 2] == Id_Jugador)
            {
                ganador = true;
            }
            // Diagonal 2
            if (michi[2, 0] == Id_Jugador & michi[1, 1] == Id_Jugador & michi[0, 2] == Id_Jugador)
            {
                ganador = true;
            }
            #endregion

            if (ganador)
            {
                if (Id_Jugador == 1)
                {
                    MessageBox.Show("¡Felicidades, Has Ganado!");

                    Score_Jugador++;

                    lbl_Jugador_Puntaje.Text = Score_Jugador.ToString();

                    btn_Reset_Click(null, null);
                }
                else
                {
                    MessageBox.Show("¡Haz Perdido!");

                    Score_Computador++;

                    lbl_Computador_Puntaje.Text = Score_Computador.ToString();

                    btn_Reset_Click(null, null);

                }
            }
        }

        // Leyenda 
        // * 1 = Jugador
        // * 2 = Computador
        // * X = Jugada Computador
        // * 0 = libre
        private void Computador()
        {

            #region Jugador Centro
            /*
            X   0   0
            0   1   0
            0   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            #endregion

            #region Inicio 22 (7)
            /*
            2   1   0
            0   1   0
            0   X   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            2   0   1
            0   1   0
            X   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            2   0   0
            X   1   1
            0   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            2   0   X
            0   1   0
            0   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            2   X   0
            0   1   0
            0   1   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
            2   0   X
            0   1   0
            1   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            2   0   0
            1   1   X
            0   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            #endregion

            #region Inicio 22 - 12 (5)
            /*
            2   1   1
            0   1   0
            X   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            2   1   0
            X   1   1
            0   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            2   1   0
            X   1   0
            0   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            2   1   X
            0   1   0
            1   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            2   1   0
            1   1   X
            0   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            #endregion

            #region Inicio 22 - 13 (5)
            /*
            2   0   1
            X   1   1
            2   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            /*
            2   0   1
            X   1   0
            2   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            /*
            2   0   1
            X   1   0
            2   1   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            /*
            2   0   1
            1   1   X
            2   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            2   1   1
            X   1   0
            2   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            #endregion

            #region Inicio 22 - 23 (5)
            /*
            2   0   0
            2   1   1
            X   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            /*
            2   0   0
            2   1   1
            X   1   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            /*
            2   0   X
            2   1   1
            1   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            /*
            2   1   0
            2   1   1
            X   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 1] = 2;
            }
            /*
            2   0   1
            2   1   1
            X   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 1] = 2;
            }
            #endregion

            #region Inicio 22 - 33 (5)
            /*
            2   X   2
            0   1   0
            0   1   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
            2   X   2
            0   1   0
            1   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
            2   X   2
            1   1   0
            0   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
            2   1   2
            0   1   0
            0   X   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            2   X   2
            0   1   1
            0   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            #endregion

            #region Inicio 22 - 32 (5)
            /*
            2   2   X
            0   1   0
            1   1   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 2 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            /*
            2   2   X
            1   1   0
            0   1   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 2 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            /*
            2   2   1
            0   1   0
            X   1   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            /*
            2   2   X
            0   1   1
            0   1   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 2 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            /*
            2   2   X
            0   1   0
            0   1   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 2 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion

            #region Inicio 22 - 31 (5)
            /*
            2   X   2
            1   1   0
            1   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            /*
            2   1   2
            0   1   0
            1   X   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }
            /*
            2   X   2
            0   1   1
            1   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            /*
            2   X   2
            0   1   0
            1   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            /*
            2   X   2
            0   1   0
            1   1   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            #endregion

            #region Inicio 22 - 21 (5)
            /*
            2   1   0
            1   1   2
            0   X   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }
            /*
            2   0   1
            1   1   2
            X   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            /*
            2   0   X
            1   1   2
            0   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            /*
            2   X   0
            1   1   2
            0   1   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            /*
            2   0   X
            1   1   2
            1   0   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 2 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion


            #region 22 - 12 - 13 (3)
            /*
            2   1   1
            X   1   1
            2   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            2   1   1
            X   1   0
            2   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            2   1   1
            1   1   X
            2   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            #endregion

            #region 22 - 12 - 23 (3)
            /*
            2   1   1
            2   1   1
            X   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            /*
            2   1   0
            2   1   1
            X   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            /*
            2   1   X
            2   1   1
            1   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion

            #region 22 - 12 - 33 (3)
            /*
            2   1   1
            2   1   0
            X   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            /*
            2   1   0
            2   1   1
            X   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            /*
            2   1   X
            2   1   0
            1   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion

            #region 22 - 12 - 31 (3)
            /*
            2   1   2
            X   1   1
            1   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            /*
            2   1   2
            X   1   0
            1   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            /*
            2   1   2
            1   1   X
            1   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            #endregion

            #region 22 - 12 - 21 (3)
            /*
            2   1   1
            1   1   2
            X   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            /*
            2   1   0
            1   1   2
            X   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            /*
            2   1   X
            1   1   2
            1   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 2 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion


            #region 22 - 13 - 21 (3)
            /*
            2   1   1
            1   1   2
            2   X   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 2 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }
            /*
            2   X   1
            1   1   2
            2   1   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 2 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            /*
            2   X   1
            1   1   2
            2   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 2 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            #endregion

            #region 22 - 23 - 31 (3)
            /*
            2   X   2
            2   1   1
            1   1   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            /*
            2   X   2
            2   1   1
            1   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            /*
            2   1   2
            2   1   1
            1   X   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 2 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }
            #endregion

            #region 22 - 33 - 12 (3)
            /*
            2   1   2
            X   1   1
            0   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            /*
            2   1   2
            X   1   0
            1   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            /*
            2   1   2
            1   1   X
            0   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            #endregion

            #region 22 - 32 - 13 (3)
            /*
            2   2   1
            X   1   1
            2   1   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            /*
            2   2   1
            X   1   0
            2   1   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            /*
            2   2   1
            1   1   X
            2   1   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            #endregion

            #region 22 - 31 - 12 (3)
            /*
            2   1   2
            X   1   1
            1   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            /*
            2   1   2
            0   1   X
            1   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            /*
            2   1   2
            1   1   X
            1   2   0
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 1 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            #endregion

            /*---------------------------------------*/
            #region Computador Centro

            #region Computadaor Centro (8)
            /*
            1   0   0
            0   X   0
            0   0   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 0 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct22.Image = Ico_Computador;
                michi[1, 1] = 2;
            }

            /*
            0   1   0
            0   X   0
            0   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 0 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct22.Image = Ico_Computador;
                michi[1, 1] = 2;
            }

            /*
            0   0   1
            0   X   0
            0   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 0 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct22.Image = Ico_Computador;
                michi[1, 1] = 2;
            }

            /*
            0   0   0
            0   X   1
            0   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 0 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct22.Image = Ico_Computador;
                michi[1, 1] = 2;
            }

            /*
            0   0   0
            0   X   0
            0   0   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 0 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct22.Image = Ico_Computador;
                michi[1, 1] = 2;
            }

            /*
            0   0   0
            0   X   0
            0   1   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 0 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct22.Image = Ico_Computador;
                michi[1, 1] = 2;
            }

            /*
            0   0   0
            0   X   0
            1   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 0 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct22.Image = Ico_Computador;
                michi[1, 1] = 2;
            }

            /*
            0   0   0
            1   X   0
            0   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 0 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct22.Image = Ico_Computador;
                michi[1, 1] = 2;
            }


            /*------------------------------------------------------------*/
            /*------------------------------------------------------------*/

            #endregion


            #region Inicio 11 (6)
            //si se tiene el centro
            /*
            1   1   X
            0   2   0
            0   0   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            1   X   1
            0   2   0
            0   0   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
            1   0   X
            0   2   1
            0   0   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            1   0   0
            X   2   0
            0   0   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            1   0   0
            0   2   0
            X   1   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            1   0   0
            X   2   0
            1   0   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            1   0   0
            1   2   0
            X   0   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            #endregion

            #region Inicio 12 (6)
            /*
            X   1   1
            0   2   0
            0   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            0   1   X
            0   2   1
            0   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            0   1   X
            0   2   0
            0   0   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            0   1   0
            X   2   0
            0   1   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            X   1   0
            0   2   0
            1   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            X   1   0
            1   2   0
            0   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            #endregion

            #region Inicio 13 (5)
            /*
            0   0   1
            0   2   1
            0   0   X
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            0   0   1
            0   2   X
            0   0   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            0   0   1
            0   2   0
            0   1   X
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            0   0   1
            X   2   0
            1   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            X   0   1
            1   2   0
            0   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            #endregion

            #region Inicio 23 (4)
            /*
            0   0   X
            0   2   1
            0   0   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            /*
            0   0   0
            0   2   1
            0   1   X
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }
            /*
            0   0   0
            0   2   1
            1   0   X
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }
            /*
            0   0   X
            1   2   1
            0   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion

            #region Inicio 33 (3)
            /*
            0   0   0
            0   2   0
            X   1   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            /*
            0   0   0
            0   2   0
            1   X   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }
            /*
            0   0   0
            1   2   0
            X   0   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            #endregion

            #region Inicio 32 (2)
            /*
            0   0   0
            0   2   0
            1   1   X
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }
            /*
            0   0   0
            1   2   0
            X   1   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            #endregion

            #region Inicio 31 (1)
            /*
            X   0   0
            1   2   0
            1   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            #endregion



            #region Inicio 11 - 12 (5)
            /*
            1   1   2
            0   2   1
            X   0   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            1   1   2
            0   2   0
            X   0   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            1   1   2
            0   2   0
            X   1   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            1   1   2
            X   2   0
            1   0   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            1   1   2
            1   2   0
            X   0   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            #endregion

            #region Inicio 11 - 13 (5)
            /*
             1   2   1
             0   2   1
             0   X   0
              */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            1   2   1
            0   2   0
            0   X   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            1   2   1
            X   2   0
            0   1   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            1   2   1
            0   2   0
            1   X   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            1   2   1
            1   2   0
            0   X   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }
            #endregion

            #region Inicio 11 - 23 (4)
            /*
             1   0   2
             0   2   1
             X   0   1
              */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            1   0   2
            0   2   1
            X   1   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            1   0   2
            X   2   1
            1   0   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            1   0   2
            1   2   1
            X   0   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            #endregion

            #region Inicio 11 - 33 (5)
            /*
             1   0   0
             2   2   X
             0   1   1
              */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            1   0   0
            2   2   X
            1   0   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            1   1   0
            2   2   X
            0   0   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            1   0   1
            2   2   X
            0   0   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            1   0   X
            2   2   1
            0   0   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion

            #region Inicio 11 - 32 (5)
            /*
             1   0   X
             1   2   0
             2   1   0
              */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            1   1   X
            0   2   0
            2   1   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
           1   X   1
           0   2   0
           2   1   0
            */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
            1   0   X
            0   2   1
            2   1   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            1   0   X
            0   2   0
            2   1   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            #endregion

            #region Inicio 11 - 31 (4)
            /*
             1   1   0
             2   2   X
             1   0   0
              */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            1   0   1
            2   2   X
            1   0   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            1   X   0
            2   2   1
            1   0   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
            1   0   0
            2   2   X
            1   0   1
             */
            // //Jugada Repedida

            /*
            1   0   0
            2   2   X
            1   1   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            #endregion

            #region Inicio 11 - 21 (5)
            /*
             1   1   X
             1   2   0
             2   0   0
              */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
             1   X   1
             1   2   0
             2   0   0
              */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
             1   0   X
             1   2   1
             2   0   0
              */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
             1   0   X
             1   2   0
             2   0   1
              */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
             1   0   X
             1   2   0
             2   1   0
              */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }


            #endregion



            #region Inicio 12 - 13 (5)
            /*
             2   1   1
             0   2   1
             0   0   X
              */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            2   1   1
            0   2   X
            0   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            2   1   1
            0   2   0
            0   1   X
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            2   1   1
            0   2   0
            1   0   X
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            2   1   1
            1   2   0
            0   0   X
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }
            #endregion

            #region Inicio 12 - 23 (4)
            /*
             0   1   2
             0   2   1
             X   0   1
              */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            /*
            0   1   2
            0   2   1
            X   1   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            0   1   2
            0   2   1
            1   0   X
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            0   1   2
            1   2   1
            X   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            1   1   2
            0   2   1
            X   0   0
             */
            // //Jugada Repedida
            #endregion

            #region Inicio 12 - 33 (3)
            /*
             0   1   2
             0   2   0
             X   1   1
              */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            0   1   2
            0   2   0
            1   X   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            0   1   2
            1   2   0
            X   0   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            1   1   2
            0   2   0
            X   0   1
             */
            // //Jugada Repedida

            #endregion

            #region Inicio 12 - 32 (5)
            /*
             0   1   0
             2   2   X
             1   1   0
              */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            1   1   0
            2   2   X
            0   1   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            0   1   1
            2   2   X
            0   1   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            0   1   0
            2   2   1
            X   1   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            0   1   0
            2   2   X
            0   1   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            #endregion

            #region Inicio 12 - 31 (4)
            /*
             2   1   0
             1   2   0
             1   0   X
              */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            2   1   1
            0   2   0
            1   0   X
             */
            // //Jugada Repedida

            /*
            2   1   0
            0   2   1
            1   0   X
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            2   1   0
            0   2   0
            1   X   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            2   1   0
            0   2   0
            1   1   X
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            #endregion

            #region Inicio 12 - 21 (3)
            /*
            2   1   0
            1   2   1
            0   0   X
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            2   1   0
            1   2   0
            X   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            2   1   0
            1   2   0
            0   1   X
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }
            #endregion



            #region Inicio 13 - 23 (5)
            /*
             X   0   1
             0   2   1
             0   1   2
              */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            X   0   1
            0   2   1
            1   0   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            X   0   1
            1   2   1
            0   0   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            1   X   1
            0   2   1
            0   0   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
            X   1   1
            0   2   1
            0   0   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            #endregion

            #region Inicio 13 - 33 (5)
            /*
             0   0   1
             X   2   2
             0   1   1
              */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            0   0   1
            X   2   2
            1   0   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            0   0   1
            1   2   2
            0   X   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            1   0   1
            X   2   2
            0   0   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            0   1   1
            X   2   2
            0   0   1
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 1 &
            michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 2 &
            michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            #endregion

            #region Inicio 13 - 32 (4)
            /*
             X   0   1
             0   2   0
             1   1   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            /*
            X   0   1
            1   2   0
            0   1   2
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            /*
            1   X   1
            0   2   0
            0   1   2
            */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            /*
            X   1   1
            0   2   0
            0   1   2
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            #endregion

            #region Inicio 13 - 31 (4)
            /*
            1   0   1
            2   2   X
            1   0   0
            */
            // //Jugada Repedida

            /*
            0   1   1
            2   2   X
            1   0   0
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            0   0   1
            2   2   1
            1   0   X
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            0   0   1
            2   2   X
            1   0   1
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            0   0   1
            2   2   X
            1   1   0
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            #endregion

            #region Inicio 13 - 21 (1)
            /*
            2   1   1
            1   2   0
            0   0   X
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
           2   0   1
           1   2   1
           0   0   X
            */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
           2   0   1
           1   2   X
           0   0   1
            */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            #endregion



            #region Inicio 23 - 33 (3)
            /*
             0   0   2
             0   2   1
             X   1   1
              */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            0   0   2
            0   2   1
            1   X   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            0   0   2
            1   2   1
            X   0   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            1   0   2
            0   2   1
            X   0   1
             */
            // //Jugada Repedida
            #endregion

            #region Inicio 23 - 32 (4)
            /*
             X   0   0
             0   2   1
             1   1   2
              */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            X   0   0
            1   2   1
            0   1   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            1   0   0
            0   2   1
            X   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            X   1   0
            0   2   1
            0   1   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            #endregion

            #region Inicio 23 - 31 (3)
            /*
             X   0   0
             1   2   1
             1   0   2
              */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            1   0   0
            X   2   1
            1   0   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            X   1   0
            0   2   1
            1   0   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            #endregion

            #region Inicio 23 - 21 (2)
            /*
            0   0   2
            1   2   1
            X   1   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            X   0   2
            1   2   1
            1   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            #endregion



            #region Inicio 33 - 32 (4)
            /*
             0   0   X
             1   2   0
             2   1   1
              */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            1   0   X
            0   2   0
            2   1   1
             */
            //Jugada Repedida

            /*
            0   1   X
            0   2   0
            2   1   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            0   0   1
            0   2   X
            2   1   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            0   0   X
            0   2   1
            2   1   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion

            #region Inicio 33 - 31 (5)
            /*
             0   X   0
             1   2   0
             1   2   1
              */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
            1   X   0
            0   2   0
            1   2   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
            X   1   0
            0   2   0
            1   2   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            0   X   1
            0   2   0
            1   2   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
            0   X   0
            0   2   1
            1   2   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            #endregion

            #region Inicio 33 - 21 (3)
            /*
            0   1   X
            1   2   0
            2   0   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
           0   0   1
           1   2   X
           2   0   1
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
           0   0   X
           1   2   1
           2   0   1
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion


            #region Inicio 32 - 31 (5)
            /*
            X   0   0
            1   2   0
            1   1   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            /*
            1   0   0
            X   2   0
            1   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            /*
            X   1   0
            0   2   0
            1   1   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            /*
            X   0   1
            0   2   0
            1   1   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            /*
            X   0   0
            0   2   1
            1   1   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }
            #endregion

            #region Inicio 32 - 21 (1)
            /*
            0   1   X
            1   2   0
            2   1   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
           0   0   1
           1   2   0
           2   1   X
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
           0   0   X
           1   2   1
           2   1   0
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion


            #region Inicio 31 - 21 (4)
            /*
            2   1   0
            1   2   0
            1   0   X
             */
            // // Jugada Repedita

            /*
            2   0   1
            1   2   0
            1   0   X
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            2   0   0
            1   2   1
            1   0   X
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            2   0   0
            1   2   0
            1   X   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            2   0   0
            1   2   0
            1   1   X
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }
            #endregion


            #region Inicio 11 - 12 - 31 (3)
            /*
            1   1   2
            2   2   1
            1   X   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }
            /*
            1   1   2
            2   2   X
            1   0   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            /*
            1   1   2
            2   2   X
            1   1   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            #endregion

            #region Inicio 11 - 13 - 32 (3)
            /*
            1   2   1
            2   2   1
            0   1   X
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }
            /*
            1   2   1
            2   2   X
            0   1   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            /*
            1   2   1
            2   2   X
            1   1   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            #endregion

            #region Inicio 11 - 23 - 31 (2)
            /*
            1   1   2
            2   2   1
            1   X   0
             */
            // //Jugada Repedida

            /*
            1   0   2
            2   2   1
            1   X   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            1   0   2
            2   2   1
            1   1   X
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }
            #endregion

            #region Inicio 11 - 33 - 23 (2)
            /*
            1   1   2
            2   2   1
            X   0   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            1   0   2
            2   2   1
            X   1   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            #endregion

            #region Inicio 11 - 32 - 13 (3)
            /*
            1   2   1
            0   2   1
            2   1   X
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            1   2   1
            1   2   X
            2   1   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            1   2   1
            0   2   X
            2   1   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            #endregion

            #region Inicio 11 - 31 - 23 (3)
            /*
            1   2   1
            2   2   1
            1   X   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            1   2   0
            2   2   1
            1   X   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            1   2   0
            2   2   1
            1   1   X
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }
            #endregion

            #region Inicio 11 - 21 - 13 (3)
            /*
            1   2   1
            1   2   1
            2   X   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            1   2   1
            1   2   0
            2   X   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            1   2   1
            1   2   0
            2   1   X
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }
            #endregion


            #region Inicio 12 - 13 - 33 (3)
            /*
            2   1   1
            X   2   2
            0   1   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            2   1   1
            X   2   2
            1   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            2   1   1
            1   2   2
            0   X   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }
            #endregion

            #region Inicio 12 - 23 - 31 (3)
            /*
            X   1   2
            0   2   1
            1   1   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            X   1   2
            1   2   1
            1   0   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            1   1   2
            X   2   1
            1   0   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            #endregion

            #region Inicio 12 - 33 - 31 (3)
            /*
            X   1   2
            0   2   1
            1   2   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            /*
            X   1   2
            1   2   0
            1   2   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            /*
            1   1   2
            X   2   0
            1   2   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            #region Inicio 31 (1)
            /*
            X   0   0
            1   2   0
            1   0   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            #endregion
            #endregion

            #region Inicio 12 - 32 - 23 (3)
            /*
            1   1   X
            2   2   1
            2   1   0
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            X   1   1
            2   2   1
            2   1   0
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            X   1   0
            2   2   1
            2   1   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            #endregion

            #region Inicio 12 - 31 - 33 (3)
            /*
            2   1   1
            0   2   X
            1   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            2   1   X
            0   2   1
            1   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            2   1   X
            1   2   0
            1   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion

            #region Inicio 12 - 21 - 33 (3)
            /*
            2   1   1
            1   2   X
            2   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            2   1   X
            1   2   1
            2   0   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            2   1   0
            1   2   0
            2   1   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion


            #region Inicio 13 - 23 - 11 (3)
            /*
            1   2   1
            0   2   1
            X   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            /*
            1   2   1
            0   2   1
            1   X   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }
            /*
            1   2   1
            1   2   1
            0   X   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }
            #endregion

            #region Inicio 13 - 33 - 21 (3)
            /*
            X   1   1
            1   2   2
            0   2   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
           0   X   1
           1   2   2
           1   2   1
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
           1   X   1
           1   2   2
           0   2   1
            */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            #endregion

            #region Inicio 13 - 32 - 11 (3)
            /*
            1   2   1
            X   2   1
            0   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            /*
            1   2   1
            X   2   0
            1   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }
            /*
            1   2   1
            1   2   0
            X   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 2 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }
            #endregion

            #region Inicio 13 - 31 - 23 (3)
            /*
            X   1   1
            2   2   1
            1   0   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            /*
            X   0   1
            2   2   1
            1   1   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            /*
            1   X   1
            2   2   1
            1   0   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            #endregion

            #region Inicio 13 - 21 -33 (3)
            /*
            2   1   1
            1   2   2
            0   X   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            2   0   1
            1   2   2
            X   1   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 0 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct31.Image = Ico_Computador;
                michi[2, 0] = 2;
            }

            /*
            2   0   1
            1   2   2
            1   X   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }
            #endregion


            #region Inicio 23 - 33 - 31 (3)
            /*
            X   1   2
            0   2   1
            1   2   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }
            /*
            0   X   2
            1   2   1
            1   2   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            /*
            1   0   2
            0   2   1
            1   2   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            #endregion

            #region Inicio 23 - 32 - 11 (3)
            /*
            1   1   X
            0   2   1
            2   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
            1   X   1
            0   2   1
            2   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
            1   0   X
            1   2   1
            2   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion

            #region Inicio 23 - 31 - 11 (3)
            /*
            1   1   X
            2   2   1
            1   0   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            /*
            1   X   0
            2   2   1
            1   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            /*
            1   X   1
            2   2   1
            1   0   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 2)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            #endregion

            #region Inicio 23 - 21 - 31 (3)
            /*
            2   1   2
            1   2   1
            1   0   X
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            /*
            2   0   2
            1   2   1
            1   X   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct32.Image = Ico_Computador;
                michi[2, 1] = 2;
            }

            /*
            2   0   2
            1   2   1
            1   1   X
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 2 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 0)
            {
                pct33.Image = Ico_Computador;
                michi[2, 2] = 2;
            }

            #endregion


            #region Inicio 33 - 32 - 13 (3)
            /*
            0   1   1
            X   2   2
            2   1   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            1   0   1
            X   2   2
            2   1   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct21.Image = Ico_Computador;
                michi[1, 0] = 2;
            }

            /*
            0   X   1
            1   2   2
            2   1   1
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            #endregion

            #region Inicio 33 - 31 - 12 (1)
            /*
            2   1   1
            0   2   X
            1   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }
            /*
            2   1   X
            0   2   1
            1   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 0 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            /*
            2   1   X
            1   2   0
            1   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }
            #endregion

            #region Inicio 33 - 21 - 13 (3)
            /*
            1   X   1
            1   2   2
            2   0   1
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
           X   1   1
           1   2   2
           2   0   1
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 2 & michi[2, 1] == 0 & michi[2, 2] == 1)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
           0   X   1
           1   2   2
           2   1   1
            */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 2 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            #endregion


            #region Inicio 32 - 31 - 11 (3)
            /*
            1   1   0
            2   2   X
            1   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            1   0   1
            2   2   X
            1   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct23.Image = Ico_Computador;
                michi[1, 2] = 2;
            }

            /*
            1   X   0
            2   2   1
            1   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 2 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            #endregion

            #region Inicio 32 - 21 - 13 (1)
            /*
            X   1   1
            1   2   0
            2   1   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 1 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            X   0   1
            1   2   1
            2   1   2
             */
            if (michi[0, 0] == 0 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct11.Image = Ico_Computador;
                michi[0, 0] = 2;
            }

            /*
            1   X   1
            1   2   0
            2   1   2
             */
            if (michi[0, 0] == 1 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 2 & michi[2, 1] == 1 & michi[2, 2] == 2)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            #endregion


            #region Inicio 31 - 21 - 33 (3)
            /*
            2   1   X
            1   2   0
            1   2   1
             */
            if (michi[0, 0] == 2 & michi[0, 1] == 1 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct13.Image = Ico_Computador;
                michi[0, 2] = 2;
            }

            /*
           2   X   1
           1   2   0
           1   2   1
            */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 1 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 0 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }

            /*
           2   X   0
           1   2   1
           1   2   1
            */
            if (michi[0, 0] == 2 & michi[0, 1] == 0 & michi[0, 2] == 0 &
                michi[1, 0] == 1 & michi[1, 1] == 2 & michi[1, 2] == 1 &
                michi[2, 0] == 1 & michi[2, 1] == 2 & michi[2, 2] == 1)
            {
                pct12.Image = Ico_Computador;
                michi[0, 1] = 2;
            }
            #endregion
            #endregion

            Ganador(1);
            Ganador(2);
        }




    }
}
