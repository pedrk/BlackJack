
namespace BlackJack
{
    partial class Form3
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
            this.pt_box1 = new System.Windows.Forms.PictureBox();
            this.txt_placar = new System.Windows.Forms.Label();
            this.btn_Jogar = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pt_box1)).BeginInit();
            this.SuspendLayout();
            // 
            // pt_box1
            // 
            this.pt_box1.Image = global::BlackJack.Properties.Resources._0;
            this.pt_box1.Location = new System.Drawing.Point(44, 12);
            this.pt_box1.Name = "pt_box1";
            this.pt_box1.Size = new System.Drawing.Size(358, 428);
            this.pt_box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt_box1.TabIndex = 0;
            this.pt_box1.TabStop = false;
            // 
            // txt_placar
            // 
            this.txt_placar.AutoSize = true;
            this.txt_placar.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_placar.Location = new System.Drawing.Point(44, 554);
            this.txt_placar.Name = "txt_placar";
            this.txt_placar.Size = new System.Drawing.Size(211, 70);
            this.txt_placar.TabIndex = 1;
            this.txt_placar.Text = "Pontos: ";
            // 
            // btn_Jogar
            // 
            this.btn_Jogar.Location = new System.Drawing.Point(44, 473);
            this.btn_Jogar.Name = "btn_Jogar";
            this.btn_Jogar.Size = new System.Drawing.Size(141, 45);
            this.btn_Jogar.TabIndex = 2;
            this.btn_Jogar.Text = "Jogar";
            this.btn_Jogar.UseVisualStyleBackColor = true;
            this.btn_Jogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Location = new System.Drawing.Point(262, 474);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(141, 45);
            this.btn_parar.TabIndex = 3;
            this.btn_parar.Text = "Recomeçar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 633);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_Jogar);
            this.Controls.Add(this.txt_placar);
            this.Controls.Add(this.pt_box1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pt_box1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pt_box1;
        private System.Windows.Forms.Label txt_placar;
        private System.Windows.Forms.Button btn_Jogar;
        private System.Windows.Forms.Button btn_parar;
    }
}