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
            this.ExitButton = new System.Windows.Forms.Button();
            this.ControlBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlBarPanel
            // 
            this.ControlBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ControlBarPanel.Controls.Add(this.ExitButton);
            this.ControlBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlBarPanel.Name = "ControlBarPanel";
            this.ControlBarPanel.Size = new System.Drawing.Size(400, 40);
            this.ControlBarPanel.TabIndex = 0;
            this.ControlBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlBarPanel_MouseDown);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ExitButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Location = new System.Drawing.Point(359, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(38, 34);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(400, 700);
            this.ControlBox = false;
            this.Controls.Add(this.ControlBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ControlBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ControlBarPanel;
        private Button ExitButton;
    }
}