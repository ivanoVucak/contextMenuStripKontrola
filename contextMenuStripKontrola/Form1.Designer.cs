namespace contextMenuStripKontrola
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
            this.components = new System.ComponentModel.Container();
            this.lijevoTb = new System.Windows.Forms.TextBox();
            this.desnoTb = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoNaDesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoNaLijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lijevoTb
            // 
            this.lijevoTb.ContextMenuStrip = this.contextMenuStrip1;
            this.lijevoTb.Location = new System.Drawing.Point(21, 37);
            this.lijevoTb.Name = "lijevoTb";
            this.lijevoTb.Size = new System.Drawing.Size(162, 20);
            this.lijevoTb.TabIndex = 1;
            // 
            // desnoTb
            // 
            this.desnoTb.ContextMenuStrip = this.contextMenuStrip1;
            this.desnoTb.Location = new System.Drawing.Point(228, 37);
            this.desnoTb.Name = "desnoTb";
            this.desnoTb.Size = new System.Drawing.Size(171, 20);
            this.desnoTb.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoNaDesnoToolStripMenuItem,
            this.desnoNaLijevoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 48);
            // 
            // lijevoNaDesnoToolStripMenuItem
            // 
            this.lijevoNaDesnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlDToolStripMenuItem});
            this.lijevoNaDesnoToolStripMenuItem.Name = "lijevoNaDesnoToolStripMenuItem";
            this.lijevoNaDesnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lijevoNaDesnoToolStripMenuItem.Text = "Lijevo na desno";
            this.lijevoNaDesnoToolStripMenuItem.Click += new System.EventHandler(this.lijevoNaDesnoToolStripMenuItem_Click);
            // 
            // desnoNaLijevoToolStripMenuItem
            // 
            this.desnoNaLijevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlLToolStripMenuItem});
            this.desnoNaLijevoToolStripMenuItem.Name = "desnoNaLijevoToolStripMenuItem";
            this.desnoNaLijevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desnoNaLijevoToolStripMenuItem.Text = "Desno na lijevo";
            this.desnoNaLijevoToolStripMenuItem.Click += new System.EventHandler(this.desnoNaLijevoToolStripMenuItem_Click);
            // 
            // ctrlLToolStripMenuItem
            // 
            this.ctrlLToolStripMenuItem.Name = "ctrlLToolStripMenuItem";
            this.ctrlLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ctrlLToolStripMenuItem.Text = "Ctrl+ L";
            // 
            // ctrlDToolStripMenuItem
            // 
            this.ctrlDToolStripMenuItem.Name = "ctrlDToolStripMenuItem";
            this.ctrlDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ctrlDToolStripMenuItem.Text = "Ctrl+ D";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 104);
            this.Controls.Add(this.desnoTb);
            this.Controls.Add(this.lijevoTb);
            this.Name = "Form1";
            this.Text = "Upotreba ContexMenuStrip kontrole";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lijevoTb;
        private System.Windows.Forms.TextBox desnoTb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lijevoNaDesnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoNaLijevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlLToolStripMenuItem;
    }
}

