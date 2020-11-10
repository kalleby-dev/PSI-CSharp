namespace Vetores
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
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnValor1 = new System.Windows.Forms.Button();
            this.btnValor2 = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.listValor1 = new System.Windows.Forms.ListBox();
            this.listValor2 = new System.Windows.Forms.ListBox();
            this.listSum = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValor1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValor1.Location = new System.Drawing.Point(9, 34);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(46, 17);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "label1";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValor2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValor2.Location = new System.Drawing.Point(14, 33);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(46, 17);
            this.lblValor2.TabIndex = 1;
            this.lblValor2.Text = "label2";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(12, 54);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 22);
            this.txtValor1.TabIndex = 2;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(17, 53);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 22);
            this.txtValor2.TabIndex = 3;
            // 
            // btnValor1
            // 
            this.btnValor1.Location = new System.Drawing.Point(118, 33);
            this.btnValor1.Name = "btnValor1";
            this.btnValor1.Size = new System.Drawing.Size(75, 43);
            this.btnValor1.TabIndex = 4;
            this.btnValor1.Text = "Inserir";
            this.btnValor1.UseVisualStyleBackColor = true;
            // 
            // btnValor2
            // 
            this.btnValor2.Location = new System.Drawing.Point(123, 34);
            this.btnValor2.Name = "btnValor2";
            this.btnValor2.Size = new System.Drawing.Size(75, 42);
            this.btnValor2.TabIndex = 5;
            this.btnValor2.Text = "Inserir";
            this.btnValor2.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(46, 164);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(206, 41);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Apresentar valores";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(266, 164);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(198, 41);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "Somar";
            this.btnSum.UseVisualStyleBackColor = true;
            // 
            // listValor1
            // 
            this.listValor1.FormattingEnabled = true;
            this.listValor1.ItemHeight = 16;
            this.listValor1.Location = new System.Drawing.Point(46, 211);
            this.listValor1.Name = "listValor1";
            this.listValor1.Size = new System.Drawing.Size(100, 180);
            this.listValor1.TabIndex = 8;
            // 
            // listValor2
            // 
            this.listValor2.FormattingEnabled = true;
            this.listValor2.ItemHeight = 16;
            this.listValor2.Location = new System.Drawing.Point(152, 211);
            this.listValor2.Name = "listValor2";
            this.listValor2.Size = new System.Drawing.Size(100, 180);
            this.listValor2.TabIndex = 9;
            // 
            // listSum
            // 
            this.listSum.FormattingEnabled = true;
            this.listSum.ItemHeight = 16;
            this.listSum.Location = new System.Drawing.Point(266, 211);
            this.listSum.Name = "listSum";
            this.listSum.Size = new System.Drawing.Size(198, 180);
            this.listSum.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValor1);
            this.groupBox1.Controls.Add(this.lblValor1);
            this.groupBox1.Controls.Add(this.btnValor1);
            this.groupBox1.Location = new System.Drawing.Point(48, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtValor2);
            this.groupBox2.Controls.Add(this.lblValor2);
            this.groupBox2.Controls.Add(this.btnValor2);
            this.groupBox2.Location = new System.Drawing.Point(266, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listSum);
            this.Controls.Add(this.listValor2);
            this.Controls.Add(this.listValor1);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnValor1;
        private System.Windows.Forms.Button btnValor2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.ListBox listValor1;
        private System.Windows.Forms.ListBox listValor2;
        private System.Windows.Forms.ListBox listSum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

