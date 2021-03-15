
namespace PI3
{
    partial class LobbyForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LobbyForm));
            this.btnCreateMatch = new System.Windows.Forms.Button();
            this.btnStartMatch = new System.Windows.Forms.Button();
            this.dgvListMatches = new System.Windows.Forms.DataGridView();
            this.btnListGamers = new System.Windows.Forms.Button();
            this.dgvListGamers = new System.Windows.Forms.DataGridView();
            this.lblMatchesList = new System.Windows.Forms.Label();
            this.helpLobby = new System.Windows.Forms.HelpProvider();
            this.filterMatches = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.lblGamersList = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnListMatches = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGamers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateMatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateMatch.Location = new System.Drawing.Point(13, 36);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(190, 39);
            this.btnCreateMatch.TabIndex = 0;
            this.btnCreateMatch.Text = "CRIAR PARTIDA";
            this.btnCreateMatch.UseVisualStyleBackColor = false;
            this.btnCreateMatch.Click += new System.EventHandler(this.btnCreateMatch_Click);
            // 
            // btnStartMatch
            // 
            this.btnStartMatch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStartMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStartMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartMatch.Location = new System.Drawing.Point(12, 169);
            this.btnStartMatch.Name = "btnStartMatch";
            this.btnStartMatch.Size = new System.Drawing.Size(190, 39);
            this.btnStartMatch.TabIndex = 6;
            this.btnStartMatch.Text = "INICIAR PARTIDA";
            this.btnStartMatch.UseVisualStyleBackColor = false;
            this.btnStartMatch.Visible = false;
            this.btnStartMatch.Click += new System.EventHandler(this.btnStartMatch_Click);
            // 
            // dgvListMatches
            // 
            this.dgvListMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMatches.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListMatches.Location = new System.Drawing.Point(246, 68);
            this.dgvListMatches.MultiSelect = false;
            this.dgvListMatches.Name = "dgvListMatches";
            this.dgvListMatches.RowHeadersWidth = 62;
            this.dgvListMatches.RowTemplate.Height = 28;
            this.dgvListMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListMatches.Size = new System.Drawing.Size(723, 392);
            this.dgvListMatches.TabIndex = 5;
            this.dgvListMatches.Visible = false;
            // 
            // btnListGamers
            // 
            this.btnListGamers.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnListGamers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnListGamers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListGamers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListGamers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnListGamers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListGamers.Location = new System.Drawing.Point(13, 124);
            this.btnListGamers.Name = "btnListGamers";
            this.btnListGamers.Size = new System.Drawing.Size(190, 39);
            this.btnListGamers.TabIndex = 8;
            this.btnListGamers.Text = "LISTAR JOGADORES";
            this.btnListGamers.UseVisualStyleBackColor = false;
            this.btnListGamers.Visible = false;
            this.btnListGamers.Click += new System.EventHandler(this.btnListGamers_Click);
            // 
            // dgvListGamers
            // 
            this.dgvListGamers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListGamers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListGamers.Location = new System.Drawing.Point(246, 68);
            this.dgvListGamers.MultiSelect = false;
            this.dgvListGamers.Name = "dgvListGamers";
            this.dgvListGamers.RowHeadersWidth = 62;
            this.dgvListGamers.RowTemplate.Height = 28;
            this.dgvListGamers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListGamers.Size = new System.Drawing.Size(546, 165);
            this.dgvListGamers.TabIndex = 9;
            this.dgvListGamers.Visible = false;
            // 
            // lblMatchesList
            // 
            this.lblMatchesList.AutoSize = true;
            this.lblMatchesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchesList.Location = new System.Drawing.Point(244, 28);
            this.lblMatchesList.Name = "lblMatchesList";
            this.lblMatchesList.Size = new System.Drawing.Size(208, 29);
            this.lblMatchesList.TabIndex = 10;
            this.lblMatchesList.Text = "Lista de Partidas";
            this.lblMatchesList.Visible = false;
            // 
            // filterMatches
            // 
            this.filterMatches.FormattingEnabled = true;
            this.filterMatches.Items.AddRange(new object[] {
            "Abertas",
            "Todos",
            "Jogango",
            "Excluídas"});
            this.filterMatches.Location = new System.Drawing.Point(848, 28);
            this.filterMatches.Name = "filterMatches";
            this.filterMatches.Size = new System.Drawing.Size(121, 28);
            this.filterMatches.TabIndex = 12;
            this.filterMatches.Visible = false;
            this.filterMatches.SelectedIndexChanged += new System.EventHandler(this.filterMatches_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(13, 59);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(190, 26);
            this.txtboxName.TabIndex = 13;
            this.txtboxName.Visible = false;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(13, 124);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(189, 26);
            this.txtboxPassword.TabIndex = 14;
            this.txtboxPassword.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Nome";
            this.lblName.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 101);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 20);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Senha";
            this.lblPassword.Visible = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::PI3.Properties.Resources.background;
            this.pbBackground.Location = new System.Drawing.Point(246, 34);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(423, 426);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 17;
            this.pbBackground.TabStop = false;
            // 
            // lblGamersList
            // 
            this.lblGamersList.AutoSize = true;
            this.lblGamersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamersList.Location = new System.Drawing.Point(244, 28);
            this.lblGamersList.Name = "lblGamersList";
            this.lblGamersList.Size = new System.Drawing.Size(236, 29);
            this.lblGamersList.TabIndex = 18;
            this.lblGamersList.Text = "Lista de Jogadores";
            this.lblGamersList.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(12, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 39);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirm.Location = new System.Drawing.Point(13, 169);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(190, 39);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "CRIAR";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnListMatches
            // 
            this.btnListMatches.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnListMatches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListMatches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListMatches.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListMatches.Location = new System.Drawing.Point(12, 82);
            this.btnListMatches.Name = "btnListMatches";
            this.helpLobby.SetShowHelp(this.btnListMatches, false);
            this.btnListMatches.Size = new System.Drawing.Size(190, 39);
            this.btnListMatches.TabIndex = 4;
            this.btnListMatches.Text = "LISTAR PARTIDAS";
            this.btnListMatches.UseVisualStyleBackColor = false;
            this.btnListMatches.Click += new System.EventHandler(this.btnListMatches_Click);
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 470);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblGamersList);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.filterMatches);
            this.Controls.Add(this.lblMatchesList);
            this.Controls.Add(this.dgvListGamers);
            this.Controls.Add(this.btnListGamers);
            this.Controls.Add(this.dgvListMatches);
            this.Controls.Add(this.btnListMatches);
            this.Controls.Add(this.btnCreateMatch);
            this.Controls.Add(this.pbBackground);
            this.Controls.Add(this.btnStartMatch);
            this.Controls.Add(this.btnConfirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LobbyForm";
            this.Text = "Can\'t Stop Lobby";
            this.TransparencyKey = System.Drawing.Color.Snow;
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGamers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateMatch;
        private System.Windows.Forms.Button btnStartMatch;
        private System.Windows.Forms.DataGridView dgvListMatches;
        private System.Windows.Forms.Button btnListGamers;
        private System.Windows.Forms.DataGridView dgvListGamers;
        private System.Windows.Forms.Label lblMatchesList;
        private System.Windows.Forms.HelpProvider helpLobby;
        private System.Windows.Forms.ComboBox filterMatches;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Label lblGamersList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnListMatches;
    }
}

