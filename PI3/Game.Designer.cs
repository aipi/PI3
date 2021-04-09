
namespace PI3
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pB5 = new System.Windows.Forms.PictureBox();
            this.pB6 = new System.Windows.Forms.PictureBox();
            this.pB4 = new System.Windows.Forms.PictureBox();
            this.pB3 = new System.Windows.Forms.PictureBox();
            this.pB2 = new System.Windows.Forms.PictureBox();
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.Tabuleiro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabuleiro)).BeginInit();
            this.SuspendLayout();
            // 
            // pB5
            // 
            this.pB5.Image = global::PI3.Properties.Resources.dice5;
            this.pB5.Location = new System.Drawing.Point(53, 214);
            this.pB5.Name = "pB5";
            this.pB5.Size = new System.Drawing.Size(50, 50);
            this.pB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB5.TabIndex = 39;
            this.pB5.TabStop = false;
            this.pB5.Visible = false;
            // 
            // pB6
            // 
            this.pB6.Image = global::PI3.Properties.Resources.dice6;
            this.pB6.Location = new System.Drawing.Point(121, 214);
            this.pB6.Name = "pB6";
            this.pB6.Size = new System.Drawing.Size(50, 50);
            this.pB6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB6.TabIndex = 38;
            this.pB6.TabStop = false;
            this.pB6.Visible = false;
            // 
            // pB4
            // 
            this.pB4.Image = global::PI3.Properties.Resources.dice4;
            this.pB4.Location = new System.Drawing.Point(121, 158);
            this.pB4.Name = "pB4";
            this.pB4.Size = new System.Drawing.Size(50, 50);
            this.pB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB4.TabIndex = 37;
            this.pB4.TabStop = false;
            this.pB4.Visible = false;
            // 
            // pB3
            // 
            this.pB3.Image = global::PI3.Properties.Resources.dice3;
            this.pB3.Location = new System.Drawing.Point(53, 158);
            this.pB3.Name = "pB3";
            this.pB3.Size = new System.Drawing.Size(50, 50);
            this.pB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB3.TabIndex = 36;
            this.pB3.TabStop = false;
            this.pB3.Visible = false;
            // 
            // pB2
            // 
            this.pB2.Image = global::PI3.Properties.Resources.dice2;
            this.pB2.Location = new System.Drawing.Point(121, 102);
            this.pB2.Name = "pB2";
            this.pB2.Size = new System.Drawing.Size(50, 50);
            this.pB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB2.TabIndex = 35;
            this.pB2.TabStop = false;
            this.pB2.Visible = false;
            this.pB2.Click += new System.EventHandler(this.pB2_Click);
            // 
            // pB1
            // 
            this.pB1.Image = global::PI3.Properties.Resources.dice1;
            this.pB1.Location = new System.Drawing.Point(53, 102);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(50, 50);
            this.pB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB1.TabIndex = 34;
            this.pB1.TabStop = false;
            this.pB1.Visible = false;
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(40, 326);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(164, 34);
            this.btnRollDice.TabIndex = 33;
            this.btnRollDice.Text = "ROLAR DADOS";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // Tabuleiro
            // 
            this.Tabuleiro.Image = ((System.Drawing.Image)(resources.GetObject("Tabuleiro.Image")));
            this.Tabuleiro.InitialImage = null;
            this.Tabuleiro.Location = new System.Drawing.Point(362, 1);
            this.Tabuleiro.Name = "Tabuleiro";
            this.Tabuleiro.Size = new System.Drawing.Size(435, 442);
            this.Tabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tabuleiro.TabIndex = 40;
            this.Tabuleiro.TabStop = false;
            this.Tabuleiro.Click += new System.EventHandler(this.Tabuleiro_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tabuleiro);
            this.Controls.Add(this.pB5);
            this.Controls.Add(this.pB6);
            this.Controls.Add(this.pB4);
            this.Controls.Add(this.pB3);
            this.Controls.Add(this.pB2);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.btnRollDice);
            this.Name = "Game";
            this.Text = "Can\'t Stop";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabuleiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pB5;
        private System.Windows.Forms.PictureBox pB6;
        private System.Windows.Forms.PictureBox pB4;
        private System.Windows.Forms.PictureBox pB3;
        private System.Windows.Forms.PictureBox pB2;
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.PictureBox Tabuleiro;
    }
}