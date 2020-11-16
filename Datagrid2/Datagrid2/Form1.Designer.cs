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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiagonal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPares = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblImpar = new System.Windows.Forms.Label();
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
            // btnCalc
            // 
            this.btnCalc.Enabled = false;
            this.btnCalc.Location = new System.Drawing.Point(49, 238);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(305, 46);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calcular Valores";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Diagonal Principal";
            // 
            // lblDiagonal
            // 
            this.lblDiagonal.AutoSize = true;
            this.lblDiagonal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDiagonal.Location = new System.Drawing.Point(254, 324);
            this.lblDiagonal.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblDiagonal.Name = "lblDiagonal";
            this.lblDiagonal.Size = new System.Drawing.Size(100, 17);
            this.lblDiagonal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Números pares";
            // 
            // lblPares
            // 
            this.lblPares.AutoSize = true;
            this.lblPares.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPares.Location = new System.Drawing.Point(254, 358);
            this.lblPares.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblPares.Name = "lblPares";
            this.lblPares.Size = new System.Drawing.Size(100, 17);
            this.lblPares.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Numeros Impares";
            // 
            // lblImpar
            // 
            this.lblImpar.AutoSize = true;
            this.lblImpar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblImpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImpar.Location = new System.Drawing.Point(254, 391);
            this.lblImpar.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblImpar.Name = "lblImpar";
            this.lblImpar.Size = new System.Drawing.Size(100, 17);
            this.lblImpar.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 445);
            this.Controls.Add(this.lblImpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDiagonal);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiagonal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPares;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblImpar;
    }
}

