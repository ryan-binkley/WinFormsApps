namespace Calculator
{
    partial class Calculator
    {
        
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ControlBarPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ControlBarPanel
            // 
            this.ControlBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlBarPanel.Name = "ControlBarPanel";
            this.ControlBarPanel.Size = new System.Drawing.Size(400, 40);
            this.ControlBarPanel.TabIndex = 0;
            this.ControlBarPanel.BackColor = Color.FromArgb(51, 51, 51);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.ControlBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.BackColor = Color.FromArgb(153, 153, 153);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ControlBarPanel;
    }
}