namespace DataGrid1
{
    partial class Form1
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.coluna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluna1,
            this.coluna2});
            this.dgvLista.Location = new System.Drawing.Point(12, 87);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(403, 194);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellClick);
            // 
            // coluna1
            // 
            this.coluna1.HeaderText = "Column1";
            this.coluna1.MinimumWidth = 6;
            this.coluna1.Name = "coluna1";
            this.coluna1.Width = 125;
            // 
            // coluna2
            // 
            this.coluna2.HeaderText = "Column1";
            this.coluna2.MinimumWidth = 6;
            this.coluna2.Name = "coluna2";
            this.coluna2.Width = 125;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(12, 42);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(192, 22);
            this.txtValor1.TabIndex = 1;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(223, 42);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(192, 22);
            this.txtValor2.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(454, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResult1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResult1.Location = new System.Drawing.Point(454, 87);
            this.lblResult1.MinimumSize = new System.Drawing.Size(100, 50);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(100, 50);
            this.lblResult1.TabIndex = 4;
            this.lblResult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResult2.Location = new System.Drawing.Point(454, 160);
            this.lblResult2.MinimumSize = new System.Drawing.Size(100, 50);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(100, 50);
            this.lblResult2.TabIndex = 4;
            this.lblResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 322);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.dgvLista);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult2;
    }
}

