namespace Assignment_4._1._2
{
    partial class Form1
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
            Num1 = new TextBox();
            Num2 = new TextBox();
            AddBtn = new Button();
            SubtractBtn = new Button();
            TimesBtn = new Button();
            DivideBtn = new Button();
            Num1Lbl = new Label();
            Num2Lbl = new Label();
            ResultLbl = new Label();
            ClearBtn = new Button();
            ExitBtn = new Button();
            label1 = new Label();
            ResultDisplay = new TextBox();
            SuspendLayout();
            // 
            // Num1
            // 
            Num1.Location = new Point(156, 64);
            Num1.Name = "Num1";
            Num1.Size = new Size(200, 23);
            Num1.TabIndex = 0;
            Num1.Leave += Num_Leave;
            // 
            // Num2
            // 
            Num2.Location = new Point(156, 128);
            Num2.Name = "Num2";
            Num2.Size = new Size(200, 23);
            Num2.TabIndex = 1;
            Num2.Leave += Num_Leave;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.ActiveCaption;
            AddBtn.Font = new Font("Segoe UI", 14F);
            AddBtn.Location = new Point(139, 200);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(116, 34);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "+";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // SubtractBtn
            // 
            SubtractBtn.BackColor = SystemColors.ActiveCaption;
            SubtractBtn.Font = new Font("Segoe UI", 14F);
            SubtractBtn.Location = new Point(273, 200);
            SubtractBtn.Name = "SubtractBtn";
            SubtractBtn.Size = new Size(116, 34);
            SubtractBtn.TabIndex = 3;
            SubtractBtn.Text = "-";
            SubtractBtn.UseVisualStyleBackColor = false;
            SubtractBtn.Click += SubtractBtn_Click;
            // 
            // TimesBtn
            // 
            TimesBtn.BackColor = SystemColors.ActiveCaption;
            TimesBtn.Font = new Font("Segoe UI", 18F);
            TimesBtn.Location = new Point(139, 254);
            TimesBtn.Name = "TimesBtn";
            TimesBtn.Size = new Size(116, 34);
            TimesBtn.TabIndex = 4;
            TimesBtn.Text = "*";
            TimesBtn.UseVisualStyleBackColor = false;
            TimesBtn.Click += TimesBtn_Click;
            // 
            // DivideBtn
            // 
            DivideBtn.BackColor = SystemColors.ActiveCaption;
            DivideBtn.Font = new Font("Segoe UI", 14F);
            DivideBtn.Location = new Point(273, 254);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(116, 34);
            DivideBtn.TabIndex = 5;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = false;
            DivideBtn.Click += DivideBtn_Click;
            // 
            // Num1Lbl
            // 
            Num1Lbl.AutoSize = true;
            Num1Lbl.Font = new Font("Segoe UI", 12F);
            Num1Lbl.Location = new Point(200, 40);
            Num1Lbl.Name = "Num1Lbl";
            Num1Lbl.Size = new Size(105, 21);
            Num1Lbl.TabIndex = 6;
            Num1Lbl.Text = "First Number:";
            // 
            // Num2Lbl
            // 
            Num2Lbl.AutoSize = true;
            Num2Lbl.Font = new Font("Segoe UI", 12F);
            Num2Lbl.Location = new Point(200, 104);
            Num2Lbl.Name = "Num2Lbl";
            Num2Lbl.Size = new Size(126, 21);
            Num2Lbl.TabIndex = 7;
            Num2Lbl.Text = "Second Number:";
            // 
            // ResultLbl
            // 
            ResultLbl.AutoSize = true;
            ResultLbl.BackColor = SystemColors.ActiveBorder;
            ResultLbl.BorderStyle = BorderStyle.FixedSingle;
            ResultLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ResultLbl.Location = new Point(231, 310);
            ResultLbl.Name = "ResultLbl";
            ResultLbl.Size = new Size(63, 23);
            ResultLbl.TabIndex = 8;
            ResultLbl.Text = "Result:";
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = SystemColors.ScrollBar;
            ClearBtn.Location = new Point(35, 382);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(93, 24);
            ClearBtn.TabIndex = 10;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = SystemColors.ScrollBar;
            ExitBtn.Location = new Point(395, 382);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(93, 24);
            ExitBtn.TabIndex = 11;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(200, 169);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 12;
            label1.Text = "Select Operator:";
            // 
            // ResultDisplay
            // 
            ResultDisplay.BackColor = SystemColors.ButtonFace;
            ResultDisplay.BorderStyle = BorderStyle.FixedSingle;
            ResultDisplay.Font = new Font("Segoe UI", 9F);
            ResultDisplay.Location = new Point(175, 336);
            ResultDisplay.Name = "ResultDisplay";
            ResultDisplay.ReadOnly = true;
            ResultDisplay.Size = new Size(170, 23);
            ResultDisplay.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 458);
            Controls.Add(label1);
            Controls.Add(ExitBtn);
            Controls.Add(ClearBtn);
            Controls.Add(ResultDisplay);
            Controls.Add(ResultLbl);
            Controls.Add(Num2Lbl);
            Controls.Add(Num1Lbl);
            Controls.Add(DivideBtn);
            Controls.Add(TimesBtn);
            Controls.Add(SubtractBtn);
            Controls.Add(AddBtn);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Name = "Form1";
            Text = "Calculator App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Num1;
        private TextBox Num2;
        private Button AddBtn;
        private Button SubtractBtn;
        private Button TimesBtn;
        private Button DivideBtn;
        private Label Num1Lbl;
        private Label Num2Lbl;
        private Label ResultLbl;
        private Button ClearBtn;
        private Button ExitBtn;
        private Label label1;
        private TextBox ResultDisplay;
    }
}
