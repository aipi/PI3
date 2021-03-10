
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
            this.btnListMatches = new System.Windows.Forms.Button();
            this.btnStartMatch = new System.Windows.Forms.Button();
            this.dgvListMatches = new System.Windows.Forms.DataGridView();
            this.btnListGamers = new System.Windows.Forms.Button();
            this.dgvListGamers = new System.Windows.Forms.DataGridView();
            this.lblMatchesList = new System.Windows.Forms.Label();
            this.lblGamersList = new System.Windows.Forms.Label();
            this.helpLobby = new System.Windows.Forms.HelpProvider();
            this.filterMatches = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGamers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateMatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateMatch.Location = new System.Drawing.Point(12, 124);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(190, 39);
            this.btnCreateMatch.TabIndex = 0;
            this.btnCreateMatch.Text = "CRIAR PARTIDA";
            this.btnCreateMatch.UseVisualStyleBackColor = false;
            this.btnCreateMatch.Click += new System.EventHandler(this.btnCreateMatch_Click);
            // 
            // btnListMatches
            // 
            this.btnListMatches.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnListMatches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListMatches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListMatches.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListMatches.Location = new System.Drawing.Point(12, 34);
            this.btnListMatches.Name = "btnListMatches";
            this.btnListMatches.Size = new System.Drawing.Size(190, 39);
            this.btnListMatches.TabIndex = 4;
            this.btnListMatches.Text = "LISTAR PARTIDAS";
            this.btnListMatches.UseVisualStyleBackColor = false;
            this.btnListMatches.Click += new System.EventHandler(this.btnListMatches_Click);
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
            this.dgvListMatches.Size = new System.Drawing.Size(696, 174);
            this.dgvListMatches.TabIndex = 5;
            // 
            // btnListGamers
            // 
            this.btnListGamers.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnListGamers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnListGamers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListGamers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListGamers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnListGamers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListGamers.Location = new System.Drawing.Point(12, 79);
            this.btnListGamers.Name = "btnListGamers";
            this.btnListGamers.Size = new System.Drawing.Size(190, 39);
            this.btnListGamers.TabIndex = 8;
            this.btnListGamers.Text = "LISTAR JOGADORES";
            this.btnListGamers.UseVisualStyleBackColor = false;
            this.btnListGamers.Click += new System.EventHandler(this.btnListGamers_Click);
            // 
            // dgvListGamers
            // 
            this.dgvListGamers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListGamers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListGamers.Location = new System.Drawing.Point(246, 301);
            this.dgvListGamers.MultiSelect = false;
            this.dgvListGamers.Name = "dgvListGamers";
            this.dgvListGamers.RowHeadersWidth = 62;
            this.dgvListGamers.RowTemplate.Height = 28;
            this.dgvListGamers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListGamers.Size = new System.Drawing.Size(696, 174);
            this.dgvListGamers.TabIndex = 9;
            // 
            // lblMatchesList
            // 
            this.lblMatchesList.AutoSize = true;
            this.lblMatchesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchesList.Location = new System.Drawing.Point(249, 28);
            this.lblMatchesList.Name = "lblMatchesList";
            this.lblMatchesList.Size = new System.Drawing.Size(273, 37);
            this.lblMatchesList.TabIndex = 10;
            this.lblMatchesList.Text = "Lista de Partidas";
            // 
            // lblGamersList
            // 
            this.lblGamersList.AutoSize = true;
            this.lblGamersList.Location = new System.Drawing.Point(252, 278);
            this.lblGamersList.Name = "lblGamersList";
            this.lblGamersList.Size = new System.Drawing.Size(144, 20);
            this.lblGamersList.TabIndex = 11;
            this.lblGamersList.Text = "Lista de Jogadores";
            // 
            // filterMatches
            // 
            this.filterMatches.FormattingEnabled = true;
            this.filterMatches.Items.AddRange(new object[] {
            "Abertas",
            "Todos",
            "Jogango",
            "Excluídas"});
            this.filterMatches.Location = new System.Drawing.Point(821, 34);
            this.filterMatches.Name = "filterMatches";
            this.filterMatches.Size = new System.Drawing.Size(121, 28);
            this.filterMatches.TabIndex = 12;
            this.filterMatches.Visible = false;
            this.filterMatches.SelectedIndexChanged += new System.EventHandler(this.filterMatches_SelectedIndexChanged);
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(956, 499);
            this.Controls.Add(this.filterMatches);
            this.Controls.Add(this.lblGamersList);
            this.Controls.Add(this.lblMatchesList);
            this.Controls.Add(this.dgvListGamers);
            this.Controls.Add(this.btnListGamers);
            this.Controls.Add(this.btnStartMatch);
            this.Controls.Add(this.dgvListMatches);
            this.Controls.Add(this.btnListMatches);
            this.Controls.Add(this.btnCreateMatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LobbyForm";
            this.Text = "Lobby";
            this.TransparencyKey = System.Drawing.Color.Snow;
            this.Load += new System.EventHandler(this.LobbyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGamers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateMatch;
        private System.Windows.Forms.Button btnListMatches;
        private System.Windows.Forms.Button btnStartMatch;
        private System.Windows.Forms.DataGridView dgvListMatches;
        private System.Windows.Forms.Button btnListGamers;
        private System.Windows.Forms.DataGridView dgvListGamers;
        private System.Windows.Forms.Label lblMatchesList;
        private System.Windows.Forms.Label lblGamersList;
        private System.Windows.Forms.HelpProvider helpLobby;
        private System.Windows.Forms.ComboBox filterMatches;
    }
}

