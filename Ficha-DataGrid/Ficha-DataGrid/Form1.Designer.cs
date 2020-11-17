namespace Ficha_DataGrid
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
            this.tblNumeros = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // tblNumeros
            // 
            this.tblNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblNumeros.ColumnHeadersVisible = false;
            this.tblNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.tblNumeros.Location = new System.Drawing.Point(179, 41);
            this.tblNumeros.Name = "tblNumeros";
            this.tblNumeros.RowHeadersVisible = false;
            this.tblNumeros.RowHeadersWidth = 51;
            this.tblNumeros.RowTemplate.Height = 24;
            this.tblNumeros.Size = new System.Drawing.Size(400, 400);
            this.tblNumeros.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 41);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(143, 400);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Gerar Numeros";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 93);
            this.label1.MinimumSize = new System.Drawing.Size(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Média";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(725, 93);
            this.label2.MinimumSize = new System.Drawing.Size(50, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 50);
            this.label2.TabIndex = 3;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 252);
            this.label3.MinimumSize = new System.Drawing.Size(50, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "Máximo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.OrangeRed;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.White;
            this.lblMax.Location = new System.Drawing.Point(725, 179);
            this.lblMax.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(50, 50);
            this.lblMax.TabIndex = 5;
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(614, 179);
            this.label5.MinimumSize = new System.Drawing.Size(50, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 50);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mínimo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.OrangeRed;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(725, 252);
            this.lblMin.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(50, 50);
            this.lblMin.TabIndex = 7;
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 323);
            this.label7.MinimumSize = new System.Drawing.Size(50, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 50);
            this.label7.TabIndex = 6;
            this.label7.Text = "Moda";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.BackColor = System.Drawing.Color.OrangeRed;
            this.lblModa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModa.ForeColor = System.Drawing.Color.White;
            this.lblModa.Location = new System.Drawing.Point(725, 323);
            this.lblModa.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(50, 50);
            this.lblModa.TabIndex = 7;
            this.lblModa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(616, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "(Número inteiro)";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 481);
            this.Controls.Add(this.lblModa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tblNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tblNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblNumeros;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

