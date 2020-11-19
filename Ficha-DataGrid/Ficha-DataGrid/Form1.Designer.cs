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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnMinimo = new System.Windows.Forms.Button();
            this.btnMaximo = new System.Windows.Forms.Button();
            this.btnModa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblNumeros)).BeginInit();
            this.SuspendLayout();
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
            this.Column3,
            this.Column4,
            this.Column5});
            this.tblNumeros.Location = new System.Drawing.Point(189, 237);
            this.tblNumeros.Name = "tblNumeros";
            this.tblNumeros.RowHeadersVisible = false;
            this.tblNumeros.RowHeadersWidth = 51;
            this.tblNumeros.RowTemplate.Height = 24;
            this.tblNumeros.Size = new System.Drawing.Size(438, 300);
            this.tblNumeros.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 65;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 65;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 65;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 65;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 237);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(160, 301);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Gerar Numeros";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.BackColor = System.Drawing.Color.OrangeRed;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.ForeColor = System.Drawing.Color.White;
            this.lblMedia.Location = new System.Drawing.Point(770, 249);
            this.lblMedia.MinimumSize = new System.Drawing.Size(75, 50);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(75, 50);
            this.lblMedia.TabIndex = 3;
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.OrangeRed;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.White;
            this.lblMax.Location = new System.Drawing.Point(770, 396);
            this.lblMax.MinimumSize = new System.Drawing.Size(75, 50);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(75, 50);
            this.lblMax.TabIndex = 5;
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.OrangeRed;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(770, 323);
            this.lblMin.MinimumSize = new System.Drawing.Size(75, 50);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(75, 50);
            this.lblMin.TabIndex = 7;
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.BackColor = System.Drawing.Color.OrangeRed;
            this.lblModa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModa.ForeColor = System.Drawing.Color.White;
            this.lblModa.Location = new System.Drawing.Point(770, 467);
            this.lblModa.MinimumSize = new System.Drawing.Size(75, 50);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(75, 50);
            this.lblModa.TabIndex = 7;
            this.lblModa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "(Número inteiro)";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 90);
            this.lblTitle.MinimumSize = new System.Drawing.Size(0, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(799, 100);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "ESTATÍSTICA AVANÇADA 3.0";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMedia
            // 
            this.btnMedia.Enabled = false;
            this.btnMedia.Location = new System.Drawing.Point(658, 249);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(76, 50);
            this.btnMedia.TabIndex = 9;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnMinimo
            // 
            this.btnMinimo.Enabled = false;
            this.btnMinimo.Location = new System.Drawing.Point(659, 323);
            this.btnMinimo.Name = "btnMinimo";
            this.btnMinimo.Size = new System.Drawing.Size(75, 50);
            this.btnMinimo.TabIndex = 10;
            this.btnMinimo.Text = "Minimo";
            this.btnMinimo.UseVisualStyleBackColor = true;
            this.btnMinimo.Click += new System.EventHandler(this.btnMinimo_Click);
            // 
            // btnMaximo
            // 
            this.btnMaximo.Enabled = false;
            this.btnMaximo.Location = new System.Drawing.Point(659, 396);
            this.btnMaximo.Name = "btnMaximo";
            this.btnMaximo.Size = new System.Drawing.Size(75, 50);
            this.btnMaximo.TabIndex = 11;
            this.btnMaximo.Text = "Maximo";
            this.btnMaximo.UseVisualStyleBackColor = true;
            this.btnMaximo.Click += new System.EventHandler(this.btnMaximo_Click);
            // 
            // btnModa
            // 
            this.btnModa.Enabled = false;
            this.btnModa.Location = new System.Drawing.Point(658, 467);
            this.btnModa.Name = "btnModa";
            this.btnModa.Size = new System.Drawing.Size(75, 50);
            this.btnModa.TabIndex = 12;
            this.btnModa.Text = "Moda";
            this.btnModa.UseVisualStyleBackColor = true;
            this.btnModa.Click += new System.EventHandler(this.btnModa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 560);
            this.Controls.Add(this.btnModa);
            this.Controls.Add(this.btnMaximo);
            this.Controls.Add(this.btnMinimo);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblModa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMedia);
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
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnMinimo;
        private System.Windows.Forms.Button btnMaximo;
        private System.Windows.Forms.Button btnModa;
    }
}

