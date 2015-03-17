namespace MathKeyBoard
{
    partial class SetTheory
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
            this.Hide();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
           // base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetTheory));
            this.SetTheoryPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogicLink = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetTheoryPanel
            // 
            this.SetTheoryPanel.Location = new System.Drawing.Point(16, 24);
            this.SetTheoryPanel.Name = "SetTheoryPanel";
            this.SetTheoryPanel.Size = new System.Drawing.Size(205, 378);
            this.SetTheoryPanel.TabIndex = 0;
            this.SetTheoryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LogicLink);
            this.panel2.Location = new System.Drawing.Point(27, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 58);
            this.panel2.TabIndex = 11;
            // 
            // LogicLink
            // 
            this.LogicLink.Image = ((System.Drawing.Image)(resources.GetObject("LogicLink.Image")));
            this.LogicLink.Location = new System.Drawing.Point(3, 3);
            this.LogicLink.Name = "LogicLink";
            this.LogicLink.Size = new System.Drawing.Size(50, 50);
            this.LogicLink.TabIndex = 10;
            this.LogicLink.UseVisualStyleBackColor = true;
            this.LogicLink.Click += new System.EventHandler(this.LogicLink_Click);
            // 
            // SetTheory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(256, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SetTheoryPanel);
            this.Name = "SetTheory";
            this.Text = "SetTheory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetTheory_FormClosing);
            this.Load += new System.EventHandler(this.SetTheory_Load);
            this.Leave += new System.EventHandler(this.SetTheory_Leave);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SetTheoryPanel;


        private void InitializeCompponent()
        {

            this.TopMost = true;
            this.Hide();
        }

        private System.Windows.Forms.Button LogicLink;
        private System.Windows.Forms.Panel panel2;
        
    }
}