namespace ComboBox
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBlue = new System.Windows.Forms.RadioButton();
            this.btnRed = new System.Windows.Forms.RadioButton();
            this.btnGreen = new System.Windows.Forms.RadioButton();
            this.btnOp1 = new System.Windows.Forms.RadioButton();
            this.btnOp2 = new System.Windows.Forms.RadioButton();
            this.btnOp3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btnForm
            // 
            this.btnForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm.Location = new System.Drawing.Point(35, 79);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(111, 88);
            this.btnForm.TabIndex = 1;
            this.btnForm.Text = "Novo Form";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Combo Box";
            // 
            // cmbList
            // 
            this.cmbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbList.FormattingEnabled = true;
            this.cmbList.Items.AddRange(new object[] {
            "Lisboa",
            "Porto",
            "Barreiro",
            "Coimbra",
            "Braga",
            "Palmela"});
            this.cmbList.Location = new System.Drawing.Point(180, 130);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(170, 37);
            this.cmbList.TabIndex = 3;
            this.cmbList.SelectedIndexChanged += new System.EventHandler(this.cmbList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGreen);
            this.groupBox1.Controls.Add(this.btnRed);
            this.groupBox1.Controls.Add(this.btnBlue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mudar cor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOp3);
            this.groupBox2.Controls.Add(this.btnOp2);
            this.groupBox2.Controls.Add(this.btnOp1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(222, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fazer nada";
            // 
            // btnBlue
            // 
            this.btnBlue.AutoSize = true;
            this.btnBlue.Location = new System.Drawing.Point(7, 22);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(61, 24);
            this.btnBlue.TabIndex = 0;
            this.btnBlue.TabStop = true;
            this.btnBlue.Text = "azul";
            this.btnBlue.UseVisualStyleBackColor = true;
            // 
            // btnRed
            // 
            this.btnRed.AutoSize = true;
            this.btnRed.Location = new System.Drawing.Point(7, 50);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(98, 24);
            this.btnRed.TabIndex = 1;
            this.btnRed.TabStop = true;
            this.btnRed.Text = "vermelho";
            this.btnRed.UseVisualStyleBackColor = true;
            // 
            // btnGreen
            // 
            this.btnGreen.AutoSize = true;
            this.btnGreen.Location = new System.Drawing.Point(7, 78);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(71, 24);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.TabStop = true;
            this.btnGreen.Text = "verde";
            this.btnGreen.UseVisualStyleBackColor = true;
            // 
            // btnOp1
            // 
            this.btnOp1.AutoSize = true;
            this.btnOp1.Location = new System.Drawing.Point(7, 22);
            this.btnOp1.Name = "btnOp1";
            this.btnOp1.Size = new System.Drawing.Size(89, 24);
            this.btnOp1.TabIndex = 0;
            this.btnOp1.TabStop = true;
            this.btnOp1.Text = "opção 1";
            this.btnOp1.UseVisualStyleBackColor = true;
            // 
            // btnOp2
            // 
            this.btnOp2.AutoSize = true;
            this.btnOp2.Location = new System.Drawing.Point(7, 50);
            this.btnOp2.Name = "btnOp2";
            this.btnOp2.Size = new System.Drawing.Size(89, 24);
            this.btnOp2.TabIndex = 1;
            this.btnOp2.TabStop = true;
            this.btnOp2.Text = "opção 2";
            this.btnOp2.UseVisualStyleBackColor = true;
            // 
            // btnOp3
            // 
            this.btnOp3.AutoSize = true;
            this.btnOp3.Location = new System.Drawing.Point(7, 78);
            this.btnOp3.Name = "btnOp3";
            this.btnOp3.Size = new System.Drawing.Size(89, 24);
            this.btnOp3.TabIndex = 2;
            this.btnOp3.TabStop = true;
            this.btnOp3.Text = "opção 3";
            this.btnOp3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vè isto:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(150, 399);
            this.lblCity.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(200, 33);
            this.lblCity.TabIndex = 5;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(29, 499);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(321, 21);
            this.hScrollBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 544);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnGreen;
        private System.Windows.Forms.RadioButton btnRed;
        private System.Windows.Forms.RadioButton btnBlue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btnOp3;
        private System.Windows.Forms.RadioButton btnOp2;
        private System.Windows.Forms.RadioButton btnOp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

