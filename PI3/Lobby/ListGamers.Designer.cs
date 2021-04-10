
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
            this.dgvListGamers = new System.Windows.Forms.DataGridView();
            this.btnStartMatch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreateGamer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGamers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListGamers
            // 
            this.dgvListGamers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListGamers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListGamers.Location = new System.Drawing.Point(27, 56);
            this.dgvListGamers.MultiSelect = false;
            this.dgvListGamers.Name = "dgvListGamers";
            this.dgvListGamers.RowHeadersVisible = false;
            this.dgvListGamers.RowHeadersWidth = 62;
            this.dgvListGamers.RowTemplate.Height = 28;
            this.dgvListGamers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListGamers.Size = new System.Drawing.Size(546, 165);
            this.dgvListGamers.TabIndex = 10;
            // 
            // btnStartMatch
            // 
            this.btnStartMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(193)))), ((int)(((byte)(125)))));
            this.btnStartMatch.FlatAppearance.BorderSize = 0;
            this.btnStartMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMatch.ForeColor = System.Drawing.Color.White;
            this.btnStartMatch.Location = new System.Drawing.Point(157, 260);
            this.btnStartMatch.Name = "btnStartMatch";
            this.btnStartMatch.Size = new System.Drawing.Size(307, 85);
            this.btnStartMatch.TabIndex = 11;
            this.btnStartMatch.Text = "INICIAR PARTIDA";
            this.btnStartMatch.UseVisualStyleBackColor = false;
            this.btnStartMatch.Click += new System.EventHandler(this.btnStartMatch_Click);
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
            this.btnCreateGamer.Click += new System.EventHandler(this.btnCreateGamer_Click);
            // 
            // ListGamers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(621, 604);
            this.Controls.Add(this.btnCreateGamer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStartMatch);
            this.Controls.Add(this.dgvListGamers);
            this.Name = "ListGamers";
            this.Text = "Listar Jogadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListGamers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListGamers;
        private System.Windows.Forms.Button btnStartMatch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreateGamer;
    }
}