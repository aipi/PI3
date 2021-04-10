
namespace PI3.Lobby
{
    partial class StartGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreateMatch = new System.Windows.Forms.Button();
            this.btnListMatches = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI3.Properties.Resources.Logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(193)))), ((int)(((byte)(125)))));
            this.btnCreateMatch.FlatAppearance.BorderSize = 0;
            this.btnCreateMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMatch.ForeColor = System.Drawing.Color.White;
            this.btnCreateMatch.Location = new System.Drawing.Point(148, 384);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(307, 85);
            this.btnCreateMatch.TabIndex = 2;
            this.btnCreateMatch.Text = "CRIAR PARTIDA";
            this.btnCreateMatch.UseVisualStyleBackColor = false;
            this.btnCreateMatch.Click += new System.EventHandler(this.btnCreateMatch_Click);
            // 
            // btnListMatches
            // 
            this.btnListMatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(122)))), ((int)(((byte)(74)))));
            this.btnListMatches.FlatAppearance.BorderSize = 0;
            this.btnListMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListMatches.ForeColor = System.Drawing.Color.White;
            this.btnListMatches.Location = new System.Drawing.Point(148, 485);
            this.btnListMatches.Name = "btnListMatches";
            this.btnListMatches.Size = new System.Drawing.Size(307, 85);
            this.btnListMatches.TabIndex = 3;
            this.btnListMatches.Text = "LISTAR PARTIDAS";
            this.btnListMatches.UseVisualStyleBackColor = false;
            this.btnListMatches.Click += new System.EventHandler(this.btnListMatches_Click);
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(621, 604);
            this.Controls.Add(this.btnListMatches);
            this.Controls.Add(this.btnCreateMatch);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartGame";
            this.Text = "Can\'t Stop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreateMatch;
        private System.Windows.Forms.Button btnListMatches;
    }
}