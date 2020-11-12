namespace Datagrid2
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
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDesc2 = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblDesc1 = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.tblNumeros = new System.Windows.Forms.DataGridView();
            this.btnCalc = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(49, 73);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(205, 22);
            this.txtValue.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(279, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDesc2
            // 
            this.lblDesc2.AutoSize = true;
            this.lblDesc2.Location = new System.Drawing.Point(397, 171);
            this.lblDesc2.Name = "lblDesc2";
            this.lblDesc2.Size = new System.Drawing.Size(43, 17);
            this.lblDesc2.TabIndex = 2;
            this.lblDesc2.Text = "Linha";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRows.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRows.Location = new System.Drawing.Point(390, 188);
            this.lblRows.MinimumSize = new System.Drawing.Size(50, 10);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(50, 17);
            this.lblRows.TabIndex = 3;
            // 
            // lblDesc1
            // 
            this.lblDesc1.AutoSize = true;
            this.lblDesc1.Location = new System.Drawing.Point(390, 127);
            this.lblDesc1.Name = "lblDesc1";
            this.lblDesc1.Size = new System.Drawing.Size(52, 17);
            this.lblDesc1.TabIndex = 4;
            this.lblDesc1.Text = "Coluna";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblColumns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColumns.Location = new System.Drawing.Point(390, 144);
            this.lblColumns.MinimumSize = new System.Drawing.Size(50, 10);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(50, 17);
            this.lblColumns.TabIndex = 5;
            // 
            // tblNumeros
            // 
            this.tblNumeros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblNumeros.ColumnHeadersVisible = false;
            this.tblNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.tblNumeros.Location = new System.Drawing.Point(49, 123);
            this.tblNumeros.Name = "tblNumeros";
            this.tblNumeros.RowHeadersVisible = false;
            this.tblNumeros.RowHeadersWidth = 51;
            this.tblNumeros.RowTemplate.Height = 24;
            this.tblNumeros.Size = new System.Drawing.Size(305, 91);
            this.tblNumeros.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(49, 238);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(305, 46);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calcular Valores";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 689);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tblNumeros);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.lblDesc1);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblDesc2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtValue);
            this.Name = "Form1";
            this.Text = "Datagrid2";
            ((System.ComponentModel.ISupportInitialize)(this.tblNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDesc2;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblDesc1;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.DataGridView tblNumeros;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

