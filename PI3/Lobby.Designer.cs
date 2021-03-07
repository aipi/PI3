
namespace PI3
{
    partial class Lobby
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
            this.btnCreateMatch = new System.Windows.Forms.Button();
            this.btnListMatches = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvListMatches = new System.Windows.Forms.DataGridView();
            this.btnListGamers = new System.Windows.Forms.Button();
            this.dgvListGamers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGamers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateMatch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateMatch.Location = new System.Drawing.Point(12, 124);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(190, 39);
            this.btnCreateMatch.TabIndex = 0;
            this.btnCreateMatch.Text = "CRIAR PARTIDA";
            this.btnCreateMatch.UseVisualStyleBackColor = false;
            // 
            // btnListMatches
            // 
            this.btnListMatches.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnListMatches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnListMatches.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListMatches.Location = new System.Drawing.Point(12, 34);
            this.btnListMatches.Name = "btnListMatches";
            this.btnListMatches.Size = new System.Drawing.Size(190, 39);
            this.btnListMatches.TabIndex = 4;
            this.btnListMatches.Text = "LISTAR PARTIDAS";
            this.btnListMatches.UseVisualStyleBackColor = false;
            this.btnListMatches.Click += new System.EventHandler(this.btnListMatches_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "ENTRAR PARTIDA";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvListMatches
            // 
            this.dgvListMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMatches.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListMatches.Location = new System.Drawing.Point(246, 34);
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
            this.btnListGamers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.dgvListGamers.Location = new System.Drawing.Point(246, 244);
            this.dgvListGamers.MultiSelect = false;
            this.dgvListGamers.Name = "dgvListGamers";
            this.dgvListGamers.RowHeadersWidth = 62;
            this.dgvListGamers.RowTemplate.Height = 28;
            this.dgvListGamers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListGamers.Size = new System.Drawing.Size(696, 174);
            this.dgvListGamers.TabIndex = 9;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.dgvListGamers);
            this.Controls.Add(this.btnListGamers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvListMatches);
            this.Controls.Add(this.btnListMatches);
            this.Controls.Add(this.btnCreateMatch);
            this.Name = "Lobby";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGamers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateMatch;
        private System.Windows.Forms.Button btnListMatches;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvListMatches;
        private System.Windows.Forms.Button btnListGamers;
        private System.Windows.Forms.DataGridView dgvListGamers;
    }
}

