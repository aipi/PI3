﻿
namespace PI3.Lobby
{
    partial class ListMatches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMatches));
            this.dgvListMatches = new System.Windows.Forms.DataGridView();
            this.btnListMatches = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.filterMatches = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListMatches
            // 
            this.dgvListMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMatches.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListMatches.Location = new System.Drawing.Point(12, 80);
            this.dgvListMatches.MultiSelect = false;
            this.dgvListMatches.Name = "dgvListMatches";
            this.dgvListMatches.RowHeadersVisible = false;
            this.dgvListMatches.RowHeadersWidth = 62;
            this.dgvListMatches.RowTemplate.Height = 28;
            this.dgvListMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListMatches.Size = new System.Drawing.Size(597, 254);
            this.dgvListMatches.TabIndex = 6;
            // 
            // btnListMatches
            // 
            this.btnListMatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(193)))), ((int)(((byte)(125)))));
            this.btnListMatches.FlatAppearance.BorderSize = 0;
            this.btnListMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListMatches.ForeColor = System.Drawing.Color.White;
            this.btnListMatches.Location = new System.Drawing.Point(150, 378);
            this.btnListMatches.Name = "btnListMatches";
            this.btnListMatches.Size = new System.Drawing.Size(307, 85);
            this.btnListMatches.TabIndex = 7;
            this.btnListMatches.Text = "LISTAR JOGADORES";
            this.btnListMatches.UseVisualStyleBackColor = false;
            this.btnListMatches.Click += new System.EventHandler(this.btnListMatches_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(102)))), ((int)(((byte)(132)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(150, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(307, 85);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "VOLTAR";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // filterMatches
            // 
            this.filterMatches.FormattingEnabled = true;
            this.filterMatches.Items.AddRange(new object[] {
            "Abertas",
            "Todos",
            "Jogango",
            "Excluídas"});
            this.filterMatches.Location = new System.Drawing.Point(488, 46);
            this.filterMatches.Name = "filterMatches";
            this.filterMatches.Size = new System.Drawing.Size(121, 28);
            this.filterMatches.TabIndex = 18;
            this.filterMatches.SelectedIndexChanged += new System.EventHandler(this.filterMatches_SelectedIndexChanged);
            // 
            // ListMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(621, 604);
            this.Controls.Add(this.filterMatches);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnListMatches);
            this.Controls.Add(this.dgvListMatches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListMatches";
            this.Text = "Listar Partidas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListMatches;
        private System.Windows.Forms.Button btnListMatches;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox filterMatches;
    }
}