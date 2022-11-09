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
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.NumberOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.ControlBarPanel.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlBarPanel
            // 
            this.ControlBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ControlBarPanel.Controls.Add(this.MinimizeButton);
            this.ControlBarPanel.Controls.Add(this.ExitButton);
            this.ControlBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlBarPanel.Name = "ControlBarPanel";
            this.ControlBarPanel.Size = new System.Drawing.Size(400, 40);
            this.ControlBarPanel.TabIndex = 0;
            this.ControlBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlBarPanel_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimizeButton.Location = new System.Drawing.Point(315, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(38, 34);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Location = new System.Drawing.Point(359, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(38, 34);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.InputPanel.Controls.Add(this.NumberOutputTextBox);
            this.InputPanel.Location = new System.Drawing.Point(0, 39);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(400, 150);
            this.InputPanel.TabIndex = 1;
            // 
            // NumberOutputTextBox
            // 
            this.NumberOutputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.NumberOutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberOutputTextBox.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberOutputTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.NumberOutputTextBox.Location = new System.Drawing.Point(60, 40);
            this.NumberOutputTextBox.Name = "NumberOutputTextBox";
            this.NumberOutputTextBox.ReadOnly = true;
            this.NumberOutputTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NumberOutputTextBox.Size = new System.Drawing.Size(328, 62);
            this.NumberOutputTextBox.TabIndex = 0;
            this.NumberOutputTextBox.Text = "012345";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(400, 700);
            this.ControlBox = false;
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.ControlBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ControlBarPanel.ResumeLayout(false);
            this.InputPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ControlBarPanel;
        private Button ExitButton;
        private Button MinimizeButton;
        private Panel InputPanel;
        private RichTextBox NumberOutputTextBox;
    }
}