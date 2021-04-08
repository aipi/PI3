
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
            this.btnRollDice = new System.Windows.Forms.Button();
            this.pB002 = new System.Windows.Forms.PictureBox();
            this.pB001 = new System.Windows.Forms.PictureBox();
            this.pB003 = new System.Windows.Forms.PictureBox();
            this.pB004 = new System.Windows.Forms.PictureBox();
            this.pB006 = new System.Windows.Forms.PictureBox();
            this.pB005 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB002)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB001)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB003)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB004)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB006)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB005)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(12, 404);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(164, 34);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "ROLAR DADOS";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // pB002
            // 
            this.pB002.Image = global::PI3.Properties.Resources.dice2;
            this.pB002.Location = new System.Drawing.Point(126, 69);
            this.pB002.Name = "pB002";
            this.pB002.Size = new System.Drawing.Size(50, 50);
            this.pB002.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB002.TabIndex = 2;
            this.pB002.TabStop = false;
            // 
            // pB001
            // 
            this.pB001.Image = global::PI3.Properties.Resources.dice1;
            this.pB001.Location = new System.Drawing.Point(55, 69);
            this.pB001.Name = "pB001";
            this.pB001.Size = new System.Drawing.Size(50, 50);
            this.pB001.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB001.TabIndex = 1;
            this.pB001.TabStop = false;
            this.pB001.Visible = false;
            // 
            // pB003
            // 
            this.pB003.Image = global::PI3.Properties.Resources.dice3;
            this.pB003.Location = new System.Drawing.Point(198, 69);
            this.pB003.Name = "pB003";
            this.pB003.Size = new System.Drawing.Size(50, 50);
            this.pB003.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB003.TabIndex = 3;
            this.pB003.TabStop = false;
            // 
            // pB004
            // 
            this.pB004.Image = global::PI3.Properties.Resources.dice4;
            this.pB004.Location = new System.Drawing.Point(274, 69);
            this.pB004.Name = "pB004";
            this.pB004.Size = new System.Drawing.Size(50, 50);
            this.pB004.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB004.TabIndex = 4;
            this.pB004.TabStop = false;
            // 
            // pB006
            // 
            this.pB006.Image = global::PI3.Properties.Resources.dice6;
            this.pB006.Location = new System.Drawing.Point(421, 69);
            this.pB006.Name = "pB006";
            this.pB006.Size = new System.Drawing.Size(50, 50);
            this.pB006.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB006.TabIndex = 5;
            this.pB006.TabStop = false;
            // 
            // pB005
            // 
            this.pB005.Image = global::PI3.Properties.Resources.dice5;
            this.pB005.Location = new System.Drawing.Point(348, 69);
            this.pB005.Name = "pB005";
            this.pB005.Size = new System.Drawing.Size(50, 50);
            this.pB005.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB005.TabIndex = 6;
            this.pB005.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pB005);
            this.Controls.Add(this.pB006);
            this.Controls.Add(this.pB004);
            this.Controls.Add(this.pB003);
            this.Controls.Add(this.pB002);
            this.Controls.Add(this.pB001);
            this.Controls.Add(this.btnRollDice);
            this.Name = "Game";
            this.Text = "Can\'t Stop";
            ((System.ComponentModel.ISupportInitialize)(this.pB002)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB001)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB003)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB004)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB006)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB005)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.PictureBox pB001;
        private System.Windows.Forms.PictureBox pB002;
        private System.Windows.Forms.PictureBox pB003;
        private System.Windows.Forms.PictureBox pB004;
        private System.Windows.Forms.PictureBox pB006;
        private System.Windows.Forms.PictureBox pB005;
    }
}