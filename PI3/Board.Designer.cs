
namespace PI3
{
    partial class Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.Tabuleiro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tabuleiro)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabuleiro
            // 
            this.Tabuleiro.Image = ((System.Drawing.Image)(resources.GetObject("Tabuleiro.Image")));
            this.Tabuleiro.InitialImage = null;
            this.Tabuleiro.Location = new System.Drawing.Point(182, 4);
            this.Tabuleiro.Name = "Tabuleiro";
            this.Tabuleiro.Size = new System.Drawing.Size(435, 442);
            this.Tabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tabuleiro.TabIndex = 41;
            this.Tabuleiro.TabStop = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tabuleiro);
            this.Name = "Board";
            this.Text = "Can\'t Stop";
            ((System.ComponentModel.ISupportInitialize)(this.Tabuleiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Tabuleiro;
    }
}