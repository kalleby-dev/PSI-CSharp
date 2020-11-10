namespace Tabuada
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
            this.lblTag = new System.Windows.Forms.Label();
            this.cmbNumero = new System.Windows.Forms.ComboBox();
            this.listResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.Location = new System.Drawing.Point(68, 46);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(87, 25);
            this.lblTag.TabIndex = 0;
            this.lblTag.Text = "Número:";
            // 
            // cmbNumero
            // 
            this.cmbNumero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumero.FormattingEnabled = true;
            this.cmbNumero.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNumero.Location = new System.Drawing.Point(176, 43);
            this.cmbNumero.Name = "cmbNumero";
            this.cmbNumero.Size = new System.Drawing.Size(121, 33);
            this.cmbNumero.TabIndex = 1;
            this.cmbNumero.SelectedIndexChanged += new System.EventHandler(this.cmbNumero_SelectedIndexChanged);
            // 
            // listResult
            // 
            this.listResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listResult.FormattingEnabled = true;
            this.listResult.ItemHeight = 25;
            this.listResult.Location = new System.Drawing.Point(71, 118);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(226, 325);
            this.listResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(359, 481);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.cmbNumero);
            this.Controls.Add(this.lblTag);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.ComboBox cmbNumero;
        private System.Windows.Forms.ListBox listResult;
    }
}

