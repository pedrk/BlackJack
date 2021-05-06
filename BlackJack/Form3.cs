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
    public partial class Form3 : Form
    {
        int pontos;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jogada();


            if (pontos <= 21)
            {   
                txt_placar.Text = $"Pontos: {pontos}";
                if (pontos == 21)
                {
                    txt_placar.Text = "Vitória";
                }
            }
            else
            {   // PARTIDA PERDIDA
                txt_placar.Text = "Derrota";
            }
        }

        private void jogada()
        {
            int x, total_pontos = 0;
            Random sorteio = new Random();
            x = sorteio.Next(1, 14);


            switch (x)
            {
                case 1: pt_box1.Image = Properties.Resources.a; total_pontos += 1; break;
                case 2: pt_box1.Image = Properties.Resources._2; total_pontos += 2; break;
                case 3: pt_box1.Image = Properties.Resources._3; total_pontos += 3; break;
                case 4: pt_box1.Image = Properties.Resources._4; total_pontos += 4; break;
                case 5: pt_box1.Image = Properties.Resources._5; total_pontos += 5; break;
                case 6: pt_box1.Image = Properties.Resources._6; total_pontos += 6; break;
                case 7: pt_box1.Image = Properties.Resources._7; total_pontos += 7; break;
                case 8: pt_box1.Image = Properties.Resources._8; total_pontos += 8; break;
                case 9: pt_box1.Image = Properties.Resources._9; total_pontos += 9; break;
                case 10: pt_box1.Image = Properties.Resources._10; total_pontos += 10; break;
                case 11: pt_box1.Image = Properties.Resources.J; total_pontos += 11; break;
                case 12: pt_box1.Image = Properties.Resources.Q; total_pontos += 12; break;
                case 13: pt_box1.Image = Properties.Resources.K; total_pontos += 13; break;
            }
            pontos += total_pontos;
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            Form apresentacao = new form_apresentacao();
            apresentacao.Show();
            this.Visible = false;
        }
    }
}
