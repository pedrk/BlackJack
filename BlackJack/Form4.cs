using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            btn_reiniciar.Enabled = false;
            btn_jogar_2.Enabled = false;
            btn_parar_2.Enabled = false;
        }

        int pontos_A = 0;
        int pontos_B = 0;
        int isJogadaDupla;

        public void resultado()
        {

            if (pontos_A <= 21 && pontos_B <= 21)
            {
                if (pontos_A == pontos_B)
                {
                    lbl_Resultado.Text = "Empate";
                }
                if (pontos_A > pontos_B)
                {
                    lbl_Resultado.Text = "Jogador 1 GANHOU!";
                }
                else
                {
                    lbl_Resultado.Text = "Jogador 2 GANHOU!";
                }
            }

            if (pontos_A > 21 && pontos_B <= 21)
            {
                lbl_Resultado.Text = "Jogador 2 GANHOU!";
            }
            if (pontos_A <= 21 && pontos_B > 21)
            {
                lbl_Resultado.Text = "Jogador 1 GANHOU!";
            }
            if (pontos_A > 21 && pontos_B > 21)
            {
                lbl_Resultado.Text = "Derrota Dupla";
            }

        }

        public void Jogada(PictureBox A, int jogador)
        {
            int x, total_pontos = 0;
            Random sorteio = new Random();
            x = sorteio.Next(1, 15);

            switch (x)
            {
                case 1: A.Image = Properties.Resources.a; total_pontos += 1; break;
                case 2: A.Image = Properties.Resources._2; total_pontos += 2; break;
                case 3: A.Image = Properties.Resources._3; total_pontos += 3; break;
                case 4: A.Image = Properties.Resources._4; total_pontos += 4; break;
                case 5: A.Image = Properties.Resources._5; total_pontos += 5; break;
                case 6: A.Image = Properties.Resources._6; total_pontos += 6; break;
                case 7: A.Image = Properties.Resources._7; total_pontos += 7; break;
                case 8: A.Image = Properties.Resources._8; total_pontos += 8; break;
                case 9: A.Image = Properties.Resources._9; total_pontos += 9; break;
                case 10: A.Image = Properties.Resources._10; total_pontos += 10; break;
                case 11: A.Image = Properties.Resources.J; total_pontos += 11; break;
                case 12: A.Image = Properties.Resources.Q; total_pontos += 12; break;
                case 13: A.Image = Properties.Resources.K; total_pontos += 13; break;
                case 14: A.Image = Properties.Resources.perigo; isJogadaDupla = 1; break;
            }

            if (jogador == 1)
                pontos_A += total_pontos;
            else
                pontos_B += total_pontos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isJogadaDupla == 1)
            {
                Jogada(pictureBox1, 1);
                isJogadaDupla = 0;
            }
            Jogada(pictureBox1, 1);


            if (pontos_A <= 21)
            {   // JOGANDO
                lbl_Pontos_A.Text = Convert.ToString(pontos_A);
                if (pontos_A == 21)
                {
                    //lbl_Resultado.Text = "GANHOU!!!";
                    btn_jogar_1.Enabled = false;
                    btn_reiniciar.Enabled = true;
                }
            }
            else
            {   // PARTIDA PERDIDA
                lbl_Pontos_A.Text = Convert.ToString(pontos_A);
                //lbl_Resultado.Text = "PERDEU!!!! ";

                btn_jogar_1.Enabled = false;
                btn_parar_1.Enabled = false;

                btn_jogar_2.Enabled = true;
                btn_parar_2.Enabled = true;

                //btn_reiniciar.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pontos_A = 0;
            pontos_B = 0;
            btn_jogar_1.Enabled = true;
            btn_jogar_2.Enabled = false;
            btn_parar_1.Enabled = true;
            btn_parar_2.Enabled = false;

            btn_reiniciar.Enabled = false;
            lbl_Pontos_A.Text = "0";
            lbl_Pontos_B.Text = "0";
            lbl_Resultado.Text = "";

            pictureBox1.Image = Properties.Resources._0;
            pictureBox2.Image = Properties.Resources._0;

        }

        private void btn_jogar_2_Click(object sender, EventArgs e)
        {
            if (isJogadaDupla == 1)
            {
                Jogada(pictureBox2, 2);
                isJogadaDupla = 0;
            }
            //  ESCOLHER AS CARTAS
            Jogada(pictureBox2, 2);

            if (pontos_B <= 21)
            {   // JOGANDO
                lbl_Pontos_B.Text = Convert.ToString(pontos_B);
                if (pontos_B == 21)
                {
                    //lbl_Resultado.Text = "GANHOU!!!";
                    btn_jogar_2.Enabled = false;
                    btn_reiniciar.Enabled = true;
                    resultado();
                }
            }
            else
            {   // PARTIDA PERDIDA
                lbl_Pontos_B.Text = Convert.ToString(pontos_B);
                //lbl_Resultado.Text = "PERDEU!!!! ";

                btn_jogar_2.Enabled = false;
                btn_parar_2.Enabled = false;

                btn_jogar_2.Enabled = false;
                btn_parar_2.Enabled = false;

                resultado();
                btn_reiniciar.Enabled = true;
            }
        }

        private void btn_parar_1_Click(object sender, EventArgs e)
        {
            btn_jogar_1.Enabled = false;
            btn_parar_1.Enabled = false;
            btn_jogar_2.Enabled = true;
            btn_parar_2.Enabled = true;
        }

        private void btn_parar_2_Click(object sender, EventArgs e)
        {
            btn_jogar_2.Enabled = false;
            btn_parar_2.Enabled = false;
            btn_reiniciar.Enabled = true;
            resultado();
        }
    }
}
