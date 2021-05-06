
namespace BlackJack
{
    partial class form_apresentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_apresentacao));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.btn_2jogadores = new System.Windows.Forms.Button();
            this.btn_louco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Properties.Resources._0;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 757);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(200, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vinte um";
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Location = new System.Drawing.Point(13, 660);
            this.btn_Iniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(157, 37);
            this.btn_Iniciar.TabIndex = 2;
            this.btn_Iniciar.Text = "Jogar 1";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_1Jogador_Click);
            // 
            // btn_2jogadores
            // 
            this.btn_2jogadores.Location = new System.Drawing.Point(321, 660);
            this.btn_2jogadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_2jogadores.Name = "btn_2jogadores";
            this.btn_2jogadores.Size = new System.Drawing.Size(157, 37);
            this.btn_2jogadores.TabIndex = 3;
            this.btn_2jogadores.Text = "Jogar 2";
            this.btn_2jogadores.UseVisualStyleBackColor = true;
            this.btn_2jogadores.Click += new System.EventHandler(this.btn_2jogadores_Click);
            // 
            // btn_louco
            // 
            this.btn_louco.Location = new System.Drawing.Point(167, 707);
            this.btn_louco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_louco.Name = "btn_louco";
            this.btn_louco.Size = new System.Drawing.Size(157, 37);
            this.btn_louco.TabIndex = 4;
            this.btn_louco.Text = "Modo louco";
            this.btn_louco.UseVisualStyleBackColor = true;
            this.btn_louco.Click += new System.EventHandler(this.btn_louco_Click);
            // 
            // form_apresentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 750);
            this.ControlBox = false;
            this.Controls.Add(this.btn_louco);
            this.Controls.Add(this.btn_2jogadores);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_apresentacao";
            this.Text = "BlackJack (Duplas)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Button btn_2jogadores;
        private System.Windows.Forms.Button btn_louco;
    }
}