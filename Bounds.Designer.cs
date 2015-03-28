namespace MathKeyBoard
{
    partial class Bounds
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
            this.UpperBound_txt = new System.Windows.Forms.TextBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.None = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.BoundsPanel = new System.Windows.Forms.Panel();
            this.LowerBound = new System.Windows.Forms.Label();
            this.LowerBound_txt = new System.Windows.Forms.TextBox();
            this.UpperBound = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.BoundsPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpperBound_txt
            // 
            this.UpperBound_txt.Location = new System.Drawing.Point(119, 37);
            this.UpperBound_txt.Name = "UpperBound_txt";
            this.UpperBound_txt.Size = new System.Drawing.Size(100, 20);
            this.UpperBound_txt.TabIndex = 0;
            // 
            // None
            // 
            this.None.Location = new System.Drawing.Point(17, 13);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(108, 33);
            this.None.TabIndex = 1;
            this.None.Text = "NONE";
            this.None.UseVisualStyleBackColor = true;
            this.None.Click += new System.EventHandler(this.None_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(131, 13);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(108, 33);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // BoundsPanel
            // 
            this.BoundsPanel.Controls.Add(this.LowerBound);
            this.BoundsPanel.Controls.Add(this.LowerBound_txt);
            this.BoundsPanel.Controls.Add(this.UpperBound);
            this.BoundsPanel.Controls.Add(this.UpperBound_txt);
            this.BoundsPanel.Location = new System.Drawing.Point(21, 38);
            this.BoundsPanel.Name = "BoundsPanel";
            this.BoundsPanel.Size = new System.Drawing.Size(226, 136);
            this.BoundsPanel.TabIndex = 3;
            // 
            // LowerBound
            // 
            this.LowerBound.Location = new System.Drawing.Point(13, 83);
            this.LowerBound.MaximumSize = new System.Drawing.Size(100, 13);
            this.LowerBound.Name = "LowerBound";
            this.LowerBound.Size = new System.Drawing.Size(100, 13);
            this.LowerBound.TabIndex = 3;
            this.LowerBound.Text = "Lower:";
            this.LowerBound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LowerBound_txt
            // 
            this.LowerBound_txt.Location = new System.Drawing.Point(119, 80);
            this.LowerBound_txt.Name = "LowerBound_txt";
            this.LowerBound_txt.Size = new System.Drawing.Size(100, 20);
            this.LowerBound_txt.TabIndex = 2;
            // 
            // UpperBound
            // 
            this.UpperBound.Location = new System.Drawing.Point(13, 40);
            this.UpperBound.MaximumSize = new System.Drawing.Size(100, 13);
            this.UpperBound.Name = "UpperBound";
            this.UpperBound.Size = new System.Drawing.Size(100, 13);
            this.UpperBound.TabIndex = 1;
            this.UpperBound.Text = "Upper:";
            this.UpperBound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.OK);
            this.ButtonsPanel.Controls.Add(this.None);
            this.ButtonsPanel.Location = new System.Drawing.Point(9, 190);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(254, 59);
            this.ButtonsPanel.TabIndex = 4;
            // 
            // Bounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.BoundsPanel);
            this.Name = "Bounds";
            this.Text = "Bounds";
            this.Load += new System.EventHandler(this.Bounds_Load);
            this.BoundsPanel.ResumeLayout(false);
            this.BoundsPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox UpperBound_txt;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button None;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Panel BoundsPanel;
        private System.Windows.Forms.Label LowerBound;
        public  System.Windows.Forms.TextBox LowerBound_txt;
        private System.Windows.Forms.Label UpperBound;
        private System.Windows.Forms.Panel ButtonsPanel;
        Helpers help1 = new Helpers();
    }
}