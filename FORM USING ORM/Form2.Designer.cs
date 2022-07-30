namespace FORM_ORM_1
{
    partial class Form2
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
            this.mAINMENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dISPLAYDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSERTDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAINMENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mAINMENUToolStripMenuItem
            // 
            this.mAINMENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dISPLAYDATAToolStripMenuItem,
            this.iNSERTDATAToolStripMenuItem,
            this.uPDATEDATAToolStripMenuItem,
            this.dELETEDATAToolStripMenuItem});
            this.mAINMENUToolStripMenuItem.Name = "mAINMENUToolStripMenuItem";
            this.mAINMENUToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.mAINMENUToolStripMenuItem.Text = "MAIN MENU";
            // 
            // dISPLAYDATAToolStripMenuItem
            // 
            this.dISPLAYDATAToolStripMenuItem.Name = "dISPLAYDATAToolStripMenuItem";
            this.dISPLAYDATAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dISPLAYDATAToolStripMenuItem.Text = "DISPLAY DATA";
            this.dISPLAYDATAToolStripMenuItem.Click += new System.EventHandler(this.dISPLAYDATAToolStripMenuItem_Click);
            // 
            // iNSERTDATAToolStripMenuItem
            // 
            this.iNSERTDATAToolStripMenuItem.Name = "iNSERTDATAToolStripMenuItem";
            this.iNSERTDATAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iNSERTDATAToolStripMenuItem.Text = "INSERT DATA";
            this.iNSERTDATAToolStripMenuItem.Click += new System.EventHandler(this.iNSERTDATAToolStripMenuItem_Click);
            // 
            // uPDATEDATAToolStripMenuItem
            // 
            this.uPDATEDATAToolStripMenuItem.Name = "uPDATEDATAToolStripMenuItem";
            this.uPDATEDATAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uPDATEDATAToolStripMenuItem.Text = "UPDATE DATA";
            this.uPDATEDATAToolStripMenuItem.Click += new System.EventHandler(this.uPDATEDATAToolStripMenuItem_Click);
            // 
            // dELETEDATAToolStripMenuItem
            // 
            this.dELETEDATAToolStripMenuItem.Name = "dELETEDATAToolStripMenuItem";
            this.dELETEDATAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dELETEDATAToolStripMenuItem.Text = "DELETE DATA";
            this.dELETEDATAToolStripMenuItem.Click += new System.EventHandler(this.dELETEDATAToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(257, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO BOM";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mAINMENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dISPLAYDATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSERTDATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATEDATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEDATAToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}