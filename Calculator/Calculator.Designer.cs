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
            this.EqualsButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PositiveNegativeButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CloseParenthesis = new System.Windows.Forms.Button();
            this.OpenParenthesis = new System.Windows.Forms.Button();
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
            this.NumberOutputTextBox.Text = "";
            // 
            // EqualsButton
            // 
            this.EqualsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.EqualsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.EqualsButton.FlatAppearance.BorderSize = 0;
            this.EqualsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.EqualsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualsButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EqualsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EqualsButton.Location = new System.Drawing.Point(298, 598);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(90, 90);
            this.EqualsButton.TabIndex = 3;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = false;
            // 
            // DecimalButton
            // 
            this.DecimalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DecimalButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DecimalButton.FlatAppearance.BorderSize = 0;
            this.DecimalButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.DecimalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecimalButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecimalButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DecimalButton.Location = new System.Drawing.Point(202, 598);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(90, 90);
            this.DecimalButton.TabIndex = 4;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ZeroButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ZeroButton.FlatAppearance.BorderSize = 0;
            this.ZeroButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.ZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZeroButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ZeroButton.Location = new System.Drawing.Point(106, 598);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(90, 90);
            this.ZeroButton.TabIndex = 5;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // PositiveNegativeButton
            // 
            this.PositiveNegativeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PositiveNegativeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PositiveNegativeButton.FlatAppearance.BorderSize = 0;
            this.PositiveNegativeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.PositiveNegativeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PositiveNegativeButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PositiveNegativeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PositiveNegativeButton.Location = new System.Drawing.Point(10, 598);
            this.PositiveNegativeButton.Name = "PositiveNegativeButton";
            this.PositiveNegativeButton.Size = new System.Drawing.Size(90, 90);
            this.PositiveNegativeButton.TabIndex = 6;
            this.PositiveNegativeButton.Text = "+/-";
            this.PositiveNegativeButton.UseVisualStyleBackColor = false;
            // 
            // AdditionButton
            // 
            this.AdditionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AdditionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AdditionButton.FlatAppearance.BorderSize = 0;
            this.AdditionButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.AdditionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdditionButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdditionButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AdditionButton.Location = new System.Drawing.Point(298, 502);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(90, 90);
            this.AdditionButton.TabIndex = 7;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = false;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MultiplyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MultiplyButton.FlatAppearance.BorderSize = 0;
            this.MultiplyButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.MultiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplyButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultiplyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MultiplyButton.Location = new System.Drawing.Point(298, 406);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(90, 90);
            this.MultiplyButton.TabIndex = 8;
            this.MultiplyButton.Text = "X";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            // 
            // DivideButton
            // 
            this.DivideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DivideButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DivideButton.FlatAppearance.BorderSize = 0;
            this.DivideButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.DivideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivideButton.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DivideButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DivideButton.Location = new System.Drawing.Point(298, 310);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(90, 90);
            this.DivideButton.TabIndex = 9;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = false;
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BackspaceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BackspaceButton.FlatAppearance.BorderSize = 0;
            this.BackspaceButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackspaceButton.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackspaceButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackspaceButton.Location = new System.Drawing.Point(298, 214);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(90, 90);
            this.BackspaceButton.TabIndex = 10;
            this.BackspaceButton.Text = "←";
            this.BackspaceButton.UseVisualStyleBackColor = false;
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ThreeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ThreeButton.FlatAppearance.BorderSize = 0;
            this.ThreeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.ThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThreeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ThreeButton.Location = new System.Drawing.Point(202, 502);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(90, 90);
            this.ThreeButton.TabIndex = 11;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TwoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TwoButton.FlatAppearance.BorderSize = 0;
            this.TwoButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.TwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TwoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.TwoButton.Location = new System.Drawing.Point(106, 502);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(90, 90);
            this.TwoButton.TabIndex = 12;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.OneButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.OneButton.FlatAppearance.BorderSize = 0;
            this.OneButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.OneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OneButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OneButton.Location = new System.Drawing.Point(10, 502);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(90, 90);
            this.OneButton.TabIndex = 13;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SixButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SixButton.FlatAppearance.BorderSize = 0;
            this.SixButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.SixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SixButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SixButton.Location = new System.Drawing.Point(202, 406);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(90, 90);
            this.SixButton.TabIndex = 14;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FiveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FiveButton.FlatAppearance.BorderSize = 0;
            this.FiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.FiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FiveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FiveButton.Location = new System.Drawing.Point(106, 406);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(90, 90);
            this.FiveButton.TabIndex = 15;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FourButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FourButton.FlatAppearance.BorderSize = 0;
            this.FourButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.FourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FourButton.ForeColor = System.Drawing.SystemColors.Control;
            this.FourButton.Location = new System.Drawing.Point(10, 406);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(90, 90);
            this.FourButton.TabIndex = 16;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.NineButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.NineButton.FlatAppearance.BorderSize = 0;
            this.NineButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.NineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NineButton.ForeColor = System.Drawing.SystemColors.Control;
            this.NineButton.Location = new System.Drawing.Point(202, 310);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(90, 90);
            this.NineButton.TabIndex = 17;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.EightButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.EightButton.FlatAppearance.BorderSize = 0;
            this.EightButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.EightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EightButton.ForeColor = System.Drawing.SystemColors.Control;
            this.EightButton.Location = new System.Drawing.Point(106, 310);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(90, 90);
            this.EightButton.TabIndex = 18;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SevenButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SevenButton.FlatAppearance.BorderSize = 0;
            this.SevenButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.SevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SevenButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SevenButton.Location = new System.Drawing.Point(10, 310);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(90, 90);
            this.SevenButton.TabIndex = 19;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearButton.Location = new System.Drawing.Point(202, 214);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(90, 90);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // CloseParenthesis
            // 
            this.CloseParenthesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CloseParenthesis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CloseParenthesis.FlatAppearance.BorderSize = 0;
            this.CloseParenthesis.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.CloseParenthesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseParenthesis.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseParenthesis.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseParenthesis.Location = new System.Drawing.Point(106, 214);
            this.CloseParenthesis.Name = "CloseParenthesis";
            this.CloseParenthesis.Size = new System.Drawing.Size(90, 90);
            this.CloseParenthesis.TabIndex = 21;
            this.CloseParenthesis.Text = ")";
            this.CloseParenthesis.UseVisualStyleBackColor = false;
            // 
            // OpenParenthesis
            // 
            this.OpenParenthesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.OpenParenthesis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.OpenParenthesis.FlatAppearance.BorderSize = 0;
            this.OpenParenthesis.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.OpenParenthesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenParenthesis.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenParenthesis.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenParenthesis.Location = new System.Drawing.Point(10, 214);
            this.OpenParenthesis.Name = "OpenParenthesis";
            this.OpenParenthesis.Size = new System.Drawing.Size(90, 90);
            this.OpenParenthesis.TabIndex = 22;
            this.OpenParenthesis.Text = "(";
            this.OpenParenthesis.UseVisualStyleBackColor = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(400, 700);
            this.ControlBox = false;
            this.Controls.Add(this.OpenParenthesis);
            this.Controls.Add(this.CloseParenthesis);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.BackspaceButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.PositiveNegativeButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.EqualsButton);
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
        private Button EqualsButton;
        private Button DecimalButton;
        private Button ZeroButton;
        private Button PositiveNegativeButton;
        private Button AdditionButton;
        private Button MultiplyButton;
        private Button DivideButton;
        private Button BackspaceButton;
        private Button ThreeButton;
        private Button TwoButton;
        private Button OneButton;
        private Button SixButton;
        private Button FiveButton;
        private Button FourButton;
        private Button NineButton;
        private Button EightButton;
        private Button SevenButton;
        private Button ClearButton;
        private Button CloseParenthesis;
        private Button OpenParenthesis;
    }
}