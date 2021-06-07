
namespace PI3.Lobby
{
    partial class ListGamers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListGamers));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreateGamer = new System.Windows.Forms.Button();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.pbBlue = new System.Windows.Forms.PictureBox();
            this.pbYellow = new System.Windows.Forms.PictureBox();
            this.pbRed = new System.Windows.Forms.PictureBox();
            this.pbGreen = new System.Windows.Forms.PictureBox();
            this.lblActiveYellow = new System.Windows.Forms.Label();
            this.lblActiveBlue = new System.Windows.Forms.Label();
            this.lblActiveGreen = new System.Windows.Forms.Label();
            this.lblInactivateRed = new System.Windows.Forms.Label();
            this.lblInactivateYellow = new System.Windows.Forms.Label();
            this.lblInactivateBlue = new System.Windows.Forms.Label();
            this.lblInactivateGreen = new System.Windows.Forms.Label();
            this.lblActiveRed = new System.Windows.Forms.Label();
            this.btnShowMatch = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(102)))), ((int)(((byte)(132)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(157, 465);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(307, 85);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "VOLTAR";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreateGamer
            // 
            this.btnCreateGamer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(193)))), ((int)(((byte)(125)))));
            this.btnCreateGamer.FlatAppearance.BorderSize = 0;
            this.btnCreateGamer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGamer.ForeColor = System.Drawing.Color.White;
            this.btnCreateGamer.Location = new System.Drawing.Point(157, 364);
            this.btnCreateGamer.Name = "btnCreateGamer";
            this.btnCreateGamer.Size = new System.Drawing.Size(307, 85);
            this.btnCreateGamer.TabIndex = 16;
            this.btnCreateGamer.Text = "CRIAR JOGADOR";
            this.btnCreateGamer.UseVisualStyleBackColor = false;
            this.btnCreateGamer.Visible = false;
            this.btnCreateGamer.Click += new System.EventHandler(this.btnCreateGamer_Click);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblRed.Location = new System.Drawing.Point(47, 130);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(85, 20);
            this.lblRed.TabIndex = 21;
            this.lblRed.Text = "Vermelho";
            // 
            // lblYellow
            // 
            this.lblYellow.AutoSize = true;
            this.lblYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYellow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(202)))), ((int)(((byte)(18)))));
            this.lblYellow.Location = new System.Drawing.Point(200, 130);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(75, 20);
            this.lblYellow.TabIndex = 22;
            this.lblYellow.Text = "Amarelo";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(103)))), ((int)(((byte)(179)))));
            this.lblBlue.Location = new System.Drawing.Point(353, 130);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(44, 20);
            this.lblBlue.TabIndex = 23;
            this.lblBlue.Text = "Azul";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(179)))), ((int)(((byte)(86)))));
            this.lblGreen.Location = new System.Drawing.Point(492, 130);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(57, 20);
            this.lblGreen.TabIndex = 24;
            this.lblGreen.Text = "Verde";
            // 
            // pbBlue
            // 
            this.pbBlue.Image = global::PI3.Properties.Resources.azul1;
            this.pbBlue.Location = new System.Drawing.Point(329, 153);
            this.pbBlue.Name = "pbBlue";
            this.pbBlue.Size = new System.Drawing.Size(100, 101);
            this.pbBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBlue.TabIndex = 20;
            this.pbBlue.TabStop = false;
            // 
            // pbYellow
            // 
            this.pbYellow.Image = global::PI3.Properties.Resources.amarelo1;
            this.pbYellow.Location = new System.Drawing.Point(188, 153);
            this.pbYellow.Name = "pbYellow";
            this.pbYellow.Size = new System.Drawing.Size(100, 101);
            this.pbYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbYellow.TabIndex = 19;
            this.pbYellow.TabStop = false;
            // 
            // pbRed
            // 
            this.pbRed.Image = global::PI3.Properties.Resources.vermelho1;
            this.pbRed.Location = new System.Drawing.Point(40, 153);
            this.pbRed.Name = "pbRed";
            this.pbRed.Size = new System.Drawing.Size(100, 101);
            this.pbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRed.TabIndex = 18;
            this.pbRed.TabStop = false;
            // 
            // pbGreen
            // 
            this.pbGreen.Image = global::PI3.Properties.Resources.verde1;
            this.pbGreen.Location = new System.Drawing.Point(473, 153);
            this.pbGreen.Name = "pbGreen";
            this.pbGreen.Size = new System.Drawing.Size(100, 101);
            this.pbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGreen.TabIndex = 17;
            this.pbGreen.TabStop = false;
            // 
            // lblActiveYellow
            // 
            this.lblActiveYellow.AutoSize = true;
            this.lblActiveYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveYellow.ForeColor = System.Drawing.Color.Black;
            this.lblActiveYellow.Location = new System.Drawing.Point(214, 257);
            this.lblActiveYellow.Name = "lblActiveYellow";
            this.lblActiveYellow.Size = new System.Drawing.Size(49, 20);
            this.lblActiveYellow.TabIndex = 26;
            this.lblActiveYellow.Text = "Ativo";
            this.lblActiveYellow.Visible = false;
            // 
            // lblActiveBlue
            // 
            this.lblActiveBlue.AutoSize = true;
            this.lblActiveBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveBlue.ForeColor = System.Drawing.Color.Black;
            this.lblActiveBlue.Location = new System.Drawing.Point(353, 257);
            this.lblActiveBlue.Name = "lblActiveBlue";
            this.lblActiveBlue.Size = new System.Drawing.Size(49, 20);
            this.lblActiveBlue.TabIndex = 27;
            this.lblActiveBlue.Text = "Ativo";
            this.lblActiveBlue.Visible = false;
            // 
            // lblActiveGreen
            // 
            this.lblActiveGreen.AutoSize = true;
            this.lblActiveGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveGreen.ForeColor = System.Drawing.Color.Black;
            this.lblActiveGreen.Location = new System.Drawing.Point(500, 257);
            this.lblActiveGreen.Name = "lblActiveGreen";
            this.lblActiveGreen.Size = new System.Drawing.Size(49, 20);
            this.lblActiveGreen.TabIndex = 28;
            this.lblActiveGreen.Text = "Ativo";
            this.lblActiveGreen.Visible = false;
            // 
            // lblInactivateRed
            // 
            this.lblInactivateRed.AutoSize = true;
            this.lblInactivateRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactivateRed.ForeColor = System.Drawing.Color.Black;
            this.lblInactivateRed.Location = new System.Drawing.Point(57, 257);
            this.lblInactivateRed.Name = "lblInactivateRed";
            this.lblInactivateRed.Size = new System.Drawing.Size(63, 20);
            this.lblInactivateRed.TabIndex = 29;
            this.lblInactivateRed.Text = "Inativo";
            // 
            // lblInactivateYellow
            // 
            this.lblInactivateYellow.AutoSize = true;
            this.lblInactivateYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactivateYellow.ForeColor = System.Drawing.Color.Black;
            this.lblInactivateYellow.Location = new System.Drawing.Point(206, 257);
            this.lblInactivateYellow.Name = "lblInactivateYellow";
            this.lblInactivateYellow.Size = new System.Drawing.Size(63, 20);
            this.lblInactivateYellow.TabIndex = 30;
            this.lblInactivateYellow.Text = "Inativo";
            // 
            // lblInactivateBlue
            // 
            this.lblInactivateBlue.AutoSize = true;
            this.lblInactivateBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactivateBlue.ForeColor = System.Drawing.Color.Black;
            this.lblInactivateBlue.Location = new System.Drawing.Point(348, 257);
            this.lblInactivateBlue.Name = "lblInactivateBlue";
            this.lblInactivateBlue.Size = new System.Drawing.Size(63, 20);
            this.lblInactivateBlue.TabIndex = 31;
            this.lblInactivateBlue.Text = "Inativo";
            // 
            // lblInactivateGreen
            // 
            this.lblInactivateGreen.AutoSize = true;
            this.lblInactivateGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactivateGreen.ForeColor = System.Drawing.Color.Black;
            this.lblInactivateGreen.Location = new System.Drawing.Point(490, 257);
            this.lblInactivateGreen.Name = "lblInactivateGreen";
            this.lblInactivateGreen.Size = new System.Drawing.Size(63, 20);
            this.lblInactivateGreen.TabIndex = 32;
            this.lblInactivateGreen.Text = "Inativo";
            // 
            // lblActiveRed
            // 
            this.lblActiveRed.AutoSize = true;
            this.lblActiveRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveRed.ForeColor = System.Drawing.Color.Black;
            this.lblActiveRed.Location = new System.Drawing.Point(57, 257);
            this.lblActiveRed.Name = "lblActiveRed";
            this.lblActiveRed.Size = new System.Drawing.Size(49, 20);
            this.lblActiveRed.TabIndex = 25;
            this.lblActiveRed.Text = "Ativo";
            this.lblActiveRed.Visible = false;
            // 
            // btnShowMatch
            // 
            this.btnShowMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(193)))), ((int)(((byte)(125)))));
            this.btnShowMatch.FlatAppearance.BorderSize = 0;
            this.btnShowMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMatch.ForeColor = System.Drawing.Color.White;
            this.btnShowMatch.Location = new System.Drawing.Point(157, 364);
            this.btnShowMatch.Name = "btnShowMatch";
            this.btnShowMatch.Size = new System.Drawing.Size(307, 85);
            this.btnShowMatch.TabIndex = 33;
            this.btnShowMatch.Text = "EXIBIR PARTIDA";
            this.btnShowMatch.UseVisualStyleBackColor = false;
            this.btnShowMatch.Visible = false;
            this.btnShowMatch.Click += new System.EventHandler(this.btnShowMatch_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(248, 325);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 20);
            this.lblStatus.TabIndex = 34;
            this.lblStatus.Text = "Status: ";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PI3.Properties.Resources.tipo;
            this.pictureBox1.Location = new System.Drawing.Point(239, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(533, 584);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 15);
            this.lblVersion.TabIndex = 36;
            this.lblVersion.Text = "Versão:";
            // 
            // ListGamers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(621, 604);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnShowMatch);
            this.Controls.Add(this.lblInactivateGreen);
            this.Controls.Add(this.lblInactivateBlue);
            this.Controls.Add(this.lblInactivateYellow);
            this.Controls.Add(this.lblInactivateRed);
            this.Controls.Add(this.lblActiveGreen);
            this.Controls.Add(this.lblActiveBlue);
            this.Controls.Add(this.lblActiveYellow);
            this.Controls.Add(this.lblActiveRed);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblYellow);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.pbBlue);
            this.Controls.Add(this.pbYellow);
            this.Controls.Add(this.pbRed);
            this.Controls.Add(this.pbGreen);
            this.Controls.Add(this.btnCreateGamer);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListGamers";
            this.Text = "Listar Jogadores";
            this.Load += new System.EventHandler(this.ListGamers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreateGamer;
        private System.Windows.Forms.PictureBox pbGreen;
        private System.Windows.Forms.PictureBox pbRed;
        private System.Windows.Forms.PictureBox pbYellow;
        private System.Windows.Forms.PictureBox pbBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblActiveYellow;
        private System.Windows.Forms.Label lblActiveBlue;
        private System.Windows.Forms.Label lblActiveGreen;
        private System.Windows.Forms.Label lblInactivateRed;
        private System.Windows.Forms.Label lblInactivateYellow;
        private System.Windows.Forms.Label lblInactivateBlue;
        private System.Windows.Forms.Label lblInactivateGreen;
        private System.Windows.Forms.Label lblActiveRed;
        private System.Windows.Forms.Button btnShowMatch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersion;
    }
}