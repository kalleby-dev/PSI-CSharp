namespace EX7_SmilesCartas
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
            this.smilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHappy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSad = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.espadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smilesToolStripMenuItem,
            this.cartasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smilesToolStripMenuItem
            // 
            this.smilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escolherToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.smilesToolStripMenuItem.Name = "smilesToolStripMenuItem";
            this.smilesToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.smilesToolStripMenuItem.Text = "Smiles";
            // 
            // escolherToolStripMenuItem
            // 
            this.escolherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHappy,
            this.btnSad});
            this.escolherToolStripMenuItem.Name = "escolherToolStripMenuItem";
            this.escolherToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.escolherToolStripMenuItem.Text = "Escolher";
            // 
            // btnHappy
            // 
            this.btnHappy.Name = "btnHappy";
            this.btnHappy.Size = new System.Drawing.Size(127, 26);
            this.btnHappy.Text = "Feliz";
            this.btnHappy.Click += new System.EventHandler(this.btnHappy_Click);
            // 
            // btnSad
            // 
            this.btnSad.Name = "btnSad";
            this.btnSad.Size = new System.Drawing.Size(127, 26);
            this.btnSad.Text = "Triste";
            this.btnSad.Click += new System.EventHandler(this.btnSad_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cartasToolStripMenuItem
            // 
            this.cartasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escolherToolStripMenuItem1,
            this.sairToolStripMenuItem1});
            this.cartasToolStripMenuItem.Name = "cartasToolStripMenuItem";
            this.cartasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.cartasToolStripMenuItem.Text = "Cartas";
            // 
            // escolherToolStripMenuItem1
            // 
            this.escolherToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.espadasToolStripMenuItem,
            this.copasToolStripMenuItem,
            this.ouroToolStripMenuItem,
            this.pausToolStripMenuItem});
            this.escolherToolStripMenuItem1.Name = "escolherToolStripMenuItem1";
            this.escolherToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.escolherToolStripMenuItem1.Text = "Escolher";
            // 
            // espadasToolStripMenuItem
            // 
            this.espadasToolStripMenuItem.Name = "espadasToolStripMenuItem";
            this.espadasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.espadasToolStripMenuItem.Text = "espadas";
            this.espadasToolStripMenuItem.Click += new System.EventHandler(this.espadasToolStripMenuItem_Click);
            // 
            // copasToolStripMenuItem
            // 
            this.copasToolStripMenuItem.Name = "copasToolStripMenuItem";
            this.copasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.copasToolStripMenuItem.Text = "copas";
            this.copasToolStripMenuItem.Click += new System.EventHandler(this.copasToolStripMenuItem_Click);
            // 
            // ouroToolStripMenuItem
            // 
            this.ouroToolStripMenuItem.Name = "ouroToolStripMenuItem";
            this.ouroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ouroToolStripMenuItem.Text = "ouro";
            this.ouroToolStripMenuItem.Click += new System.EventHandler(this.ouroToolStripMenuItem_Click);
            // 
            // pausToolStripMenuItem
            // 
            this.pausToolStripMenuItem.Name = "pausToolStripMenuItem";
            this.pausToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pausToolStripMenuItem.Text = "paus";
            this.pausToolStripMenuItem.Click += new System.EventHandler(this.pausToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(164, 56);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(400, 401);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox.TabIndex = 1;
            this.imgBox.TabStop = false;
            this.imgBox.Click += new System.EventHandler(this.imgBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 512);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnHappy;
        private System.Windows.Forms.ToolStripMenuItem btnSad;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem espadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.PictureBox imgBox;
    }
}

