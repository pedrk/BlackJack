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
    public partial class form_apresentacao : Form
    {
        public form_apresentacao()
        {
            InitializeComponent();
        }

        private void btn_1Jogador_Click(object sender, EventArgs e)
        {
            Form jogo = new Form_jogo();
            jogo.Show();
            this.Visible = false;
        }

        private void btn_2jogadores_Click(object sender, EventArgs e)
        {
            Form jogoSolo = new Form3();
            jogoSolo.Show();
            this.Visible = false;
        }

        private void btn_louco_Click(object sender, EventArgs e)
        {
            Form jogoLouco = new Form4();
            jogoLouco.Show();
            this.Visible = false;
        }
    }
}
