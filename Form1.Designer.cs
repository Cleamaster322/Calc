namespace Calc
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
            panel1 = new Panel();
            PanelTit = new Panel();
            buttonCvernut = new Button();
            BtnTitle = new Button();
            PanelHistory = new Panel();
            panel2 = new Panel();
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ButtonDelAll = new Button();
            ButtonDelChar = new Button();
            ButtonPercent = new Button();
            ButtonDelCur = new Button();
            ButtonReverse = new Button();
            ButtonX2 = new Button();
            ButtonDiv = new Button();
            ButtonSqrt = new Button();
            Button4 = new Button();
            Button5 = new Button();
            ButtonPlus = new Button();
            Button6 = new Button();
            Button7 = new Button();
            Button8 = new Button();
            ButtonMulti = new Button();
            Button9 = new Button();
            Button1 = new Button();
            Button2 = new Button();
            ButtonMinus = new Button();
            Button3 = new Button();
            ButtonPlusMinus = new Button();
            Button0 = new Button();
            ButtonEqual = new Button();
            ButtonDot = new Button();
            PanelTit.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 0);
            panel1.TabIndex = 0;
            // 
            // PanelTit
            // 
            PanelTit.Controls.Add(buttonCvernut);
            PanelTit.Controls.Add(BtnTitle);
            PanelTit.Dock = DockStyle.Top;
            PanelTit.Location = new Point(0, 0);
            PanelTit.Margin = new Padding(0);
            PanelTit.Name = "PanelTit";
            PanelTit.Size = new Size(320, 40);
            PanelTit.TabIndex = 3;
            // 
            // buttonCvernut
            // 
            buttonCvernut.Dock = DockStyle.Right;
            buttonCvernut.FlatAppearance.BorderSize = 0;
            buttonCvernut.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            buttonCvernut.FlatAppearance.MouseOverBackColor = Color.Red;
            buttonCvernut.FlatStyle = FlatStyle.Flat;
            buttonCvernut.Location = new Point(220, 0);
            buttonCvernut.Margin = new Padding(0);
            buttonCvernut.Name = "buttonCvernut";
            buttonCvernut.Size = new Size(50, 40);
            buttonCvernut.TabIndex = 2;
            buttonCvernut.Text = "---";
            buttonCvernut.UseVisualStyleBackColor = true;
            buttonCvernut.Click += ButtonCollapse;
            // 
            // BtnTitle
            // 
            BtnTitle.Dock = DockStyle.Right;
            BtnTitle.FlatAppearance.BorderSize = 0;
            BtnTitle.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            BtnTitle.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnTitle.FlatStyle = FlatStyle.Flat;
            BtnTitle.Location = new Point(270, 0);
            BtnTitle.Margin = new Padding(0);
            BtnTitle.Name = "BtnTitle";
            BtnTitle.Size = new Size(50, 40);
            BtnTitle.TabIndex = 0;
            BtnTitle.Text = "X";
            BtnTitle.UseVisualStyleBackColor = true;
            BtnTitle.Click += ButtonExit;
            // 
            // PanelHistory
            // 
            PanelHistory.Dock = DockStyle.Bottom;
            PanelHistory.Location = new Point(0, 526);
            PanelHistory.Margin = new Padding(0);
            PanelHistory.Name = "PanelHistory";
            PanelHistory.Size = new Size(320, 14);
            PanelHistory.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 40);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 40);
            panel2.TabIndex = 5;
            // 
            // TextBox1
            // 
            TextBox1.BackColor = SystemColors.Window;
            TextBox1.BorderStyle = BorderStyle.None;
            TextBox1.Dock = DockStyle.Top;
            TextBox1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox1.ForeColor = SystemColors.WindowFrame;
            TextBox1.Location = new Point(0, 80);
            TextBox1.Margin = new Padding(0);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(320, 20);
            TextBox1.TabIndex = 6;
            TextBox1.Text = "0";
            TextBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // TextBox2
            // 
            TextBox2.BackColor = SystemColors.Window;
            TextBox2.BorderStyle = BorderStyle.None;
            TextBox2.Dock = DockStyle.Top;
            TextBox2.Font = new Font("Times New Roman", 35F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox2.Location = new Point(0, 100);
            TextBox2.Margin = new Padding(0);
            TextBox2.Multiline = true;
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(320, 55);
            TextBox2.TabIndex = 7;
            TextBox2.Text = "0";
            TextBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // ButtonDelAll
            // 
            ButtonDelAll.BackColor = SystemColors.AppWorkspace;
            ButtonDelAll.FlatAppearance.BorderSize = 0;
            ButtonDelAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonDelAll.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonDelAll.FlatStyle = FlatStyle.Flat;
            ButtonDelAll.Location = new Point(167, 165);
            ButtonDelAll.Margin = new Padding(0);
            ButtonDelAll.Name = "ButtonDelAll";
            ButtonDelAll.Size = new Size(70, 50);
            ButtonDelAll.TabIndex = 8;
            ButtonDelAll.Text = "C";
            ButtonDelAll.UseVisualStyleBackColor = false;
            ButtonDelAll.Click += buttonDelAll_Click;
            // 
            // ButtonDelChar
            // 
            ButtonDelChar.BackColor = SystemColors.AppWorkspace;
            ButtonDelChar.FlatAppearance.BorderSize = 0;
            ButtonDelChar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonDelChar.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonDelChar.FlatStyle = FlatStyle.Flat;
            ButtonDelChar.Location = new Point(246, 165);
            ButtonDelChar.Margin = new Padding(0);
            ButtonDelChar.Name = "ButtonDelChar";
            ButtonDelChar.Size = new Size(70, 50);
            ButtonDelChar.TabIndex = 9;
            ButtonDelChar.Text = "DEL";
            ButtonDelChar.UseVisualStyleBackColor = false;
            ButtonDelChar.Click += buttonDelChar_Click;
            // 
            // ButtonPercent
            // 
            ButtonPercent.BackColor = SystemColors.AppWorkspace;
            ButtonPercent.FlatAppearance.BorderSize = 0;
            ButtonPercent.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonPercent.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonPercent.FlatStyle = FlatStyle.Flat;
            ButtonPercent.Location = new Point(9, 165);
            ButtonPercent.Margin = new Padding(0);
            ButtonPercent.Name = "ButtonPercent";
            ButtonPercent.Size = new Size(70, 50);
            ButtonPercent.TabIndex = 11;
            ButtonPercent.Text = "%";
            ButtonPercent.UseVisualStyleBackColor = false;
            ButtonPercent.Click += ButtonSelfOper;
            // 
            // ButtonDelCur
            // 
            ButtonDelCur.BackColor = SystemColors.AppWorkspace;
            ButtonDelCur.FlatAppearance.BorderSize = 0;
            ButtonDelCur.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonDelCur.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonDelCur.FlatStyle = FlatStyle.Flat;
            ButtonDelCur.Location = new Point(88, 165);
            ButtonDelCur.Margin = new Padding(0);
            ButtonDelCur.Name = "ButtonDelCur";
            ButtonDelCur.Size = new Size(70, 50);
            ButtonDelCur.TabIndex = 10;
            ButtonDelCur.Text = "CE";
            ButtonDelCur.UseVisualStyleBackColor = false;
            ButtonDelCur.Click += buttonDelLast_Click;
            // 
            // ButtonReverse
            // 
            ButtonReverse.BackColor = SystemColors.AppWorkspace;
            ButtonReverse.FlatAppearance.BorderSize = 0;
            ButtonReverse.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonReverse.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonReverse.FlatStyle = FlatStyle.Flat;
            ButtonReverse.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonReverse.Location = new Point(9, 225);
            ButtonReverse.Margin = new Padding(0);
            ButtonReverse.Name = "ButtonReverse";
            ButtonReverse.Size = new Size(70, 50);
            ButtonReverse.TabIndex = 15;
            ButtonReverse.Text = "⅟x";
            ButtonReverse.UseVisualStyleBackColor = false;
            ButtonReverse.Click += ButtonSelfOper;
            // 
            // ButtonX2
            // 
            ButtonX2.BackColor = SystemColors.AppWorkspace;
            ButtonX2.FlatAppearance.BorderSize = 0;
            ButtonX2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonX2.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonX2.FlatStyle = FlatStyle.Flat;
            ButtonX2.Location = new Point(88, 225);
            ButtonX2.Margin = new Padding(0);
            ButtonX2.Name = "ButtonX2";
            ButtonX2.Size = new Size(70, 50);
            ButtonX2.TabIndex = 14;
            ButtonX2.Text = "x^2";
            ButtonX2.UseVisualStyleBackColor = false;
            ButtonX2.Click += ButtonSelfOper;
            // 
            // ButtonDiv
            // 
            ButtonDiv.BackColor = SystemColors.AppWorkspace;
            ButtonDiv.FlatAppearance.BorderSize = 0;
            ButtonDiv.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonDiv.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonDiv.FlatStyle = FlatStyle.Flat;
            ButtonDiv.Location = new Point(246, 225);
            ButtonDiv.Margin = new Padding(0);
            ButtonDiv.Name = "ButtonDiv";
            ButtonDiv.Size = new Size(70, 50);
            ButtonDiv.TabIndex = 13;
            ButtonDiv.Text = "÷";
            ButtonDiv.UseVisualStyleBackColor = false;
            ButtonDiv.Click += ButtonMathOper;
            // 
            // ButtonSqrt
            // 
            ButtonSqrt.BackColor = SystemColors.AppWorkspace;
            ButtonSqrt.FlatAppearance.BorderSize = 0;
            ButtonSqrt.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonSqrt.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonSqrt.FlatStyle = FlatStyle.Flat;
            ButtonSqrt.Location = new Point(167, 225);
            ButtonSqrt.Margin = new Padding(0);
            ButtonSqrt.Name = "ButtonSqrt";
            ButtonSqrt.Size = new Size(70, 50);
            ButtonSqrt.TabIndex = 12;
            ButtonSqrt.Text = "√x";
            ButtonSqrt.UseVisualStyleBackColor = false;
            ButtonSqrt.Click += ButtonSelfOper;
            // 
            // Button4
            // 
            Button4.BackColor = SystemColors.AppWorkspace;
            Button4.FlatAppearance.BorderSize = 0;
            Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Button4.FlatAppearance.MouseOverBackColor = Color.Red;
            Button4.FlatStyle = FlatStyle.Flat;
            Button4.Location = new Point(9, 345);
            Button4.Margin = new Padding(0);
            Button4.Name = "Button4";
            Button4.Size = new Size(70, 50);
            Button4.TabIndex = 23;
            Button4.Text = "4";
            Button4.UseVisualStyleBackColor = false;
            Button4.Click += ButtonNumClick;
            // 
            // Button5
            // 
            Button5.BackColor = SystemColors.AppWorkspace;
            Button5.FlatAppearance.BorderSize = 0;
            Button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Button5.FlatAppearance.MouseOverBackColor = Color.Red;
            Button5.FlatStyle = FlatStyle.Flat;
            Button5.Location = new Point(88, 345);
            Button5.Margin = new Padding(0);
            Button5.Name = "Button5";
            Button5.Size = new Size(70, 50);
            Button5.TabIndex = 22;
            Button5.Text = "5";
            Button5.UseVisualStyleBackColor = false;
            Button5.Click += ButtonNumClick;
            // 
            // ButtonPlus
            // 
            ButtonPlus.BackColor = SystemColors.AppWorkspace;
            ButtonPlus.FlatAppearance.BorderSize = 0;
            ButtonPlus.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonPlus.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonPlus.FlatStyle = FlatStyle.Flat;
            ButtonPlus.Location = new Point(246, 345);
            ButtonPlus.Margin = new Padding(0);
            ButtonPlus.Name = "ButtonPlus";
            ButtonPlus.Size = new Size(70, 50);
            ButtonPlus.TabIndex = 21;
            ButtonPlus.Text = "+";
            ButtonPlus.UseVisualStyleBackColor = false;
            ButtonPlus.Click += ButtonMathOper;
            // 
            // Button6
            // 
            Button6.BackColor = SystemColors.AppWorkspace;
            Button6.FlatAppearance.BorderSize = 0;
            Button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Button6.FlatAppearance.MouseOverBackColor = Color.Red;
            Button6.FlatStyle = FlatStyle.Flat;
            Button6.Location = new Point(167, 345);
            Button6.Margin = new Padding(0);
            Button6.Name = "Button6";
            Button6.Size = new Size(70, 50);
            Button6.TabIndex = 20;
            Button6.Text = "6";
            Button6.UseVisualStyleBackColor = false;
            Button6.Click += ButtonNumClick;
            // 
            // Button7
            // 
            Button7.BackColor = SystemColors.AppWorkspace;
            Button7.FlatAppearance.BorderSize = 0;
            Button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Button7.FlatAppearance.MouseOverBackColor = Color.Red;
            Button7.FlatStyle = FlatStyle.Flat;
            Button7.Location = new Point(9, 285);
            Button7.Margin = new Padding(0);
            Button7.Name = "Button7";
            Button7.Size = new Size(70, 50);
            Button7.TabIndex = 19;
            Button7.Text = "7";
            Button7.UseVisualStyleBackColor = false;
            Button7.Click += ButtonNumClick;
            // 
            // Button8
            // 
            Button8.BackColor = SystemColors.AppWorkspace;
            Button8.FlatAppearance.BorderSize = 0;
            Button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Button8.FlatAppearance.MouseOverBackColor = Color.Red;
            Button8.FlatStyle = FlatStyle.Flat;
            Button8.Location = new Point(88, 285);
            Button8.Margin = new Padding(0);
            Button8.Name = "Button8";
            Button8.Size = new Size(70, 50);
            Button8.TabIndex = 18;
            Button8.Text = "8";
            Button8.UseVisualStyleBackColor = false;
            Button8.Click += ButtonNumClick;
            // 
            // ButtonMulti
            // 
            ButtonMulti.BackColor = SystemColors.AppWorkspace;
            ButtonMulti.FlatAppearance.BorderSize = 0;
            ButtonMulti.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonMulti.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonMulti.FlatStyle = FlatStyle.Flat;
            ButtonMulti.Location = new Point(246, 285);
            ButtonMulti.Margin = new Padding(0);
            ButtonMulti.Name = "ButtonMulti";
            ButtonMulti.Size = new Size(70, 50);
            ButtonMulti.TabIndex = 17;
            ButtonMulti.Text = "×";
            ButtonMulti.UseVisualStyleBackColor = false;
            ButtonMulti.Click += ButtonMathOper;
            // 
            // Button9
            // 
            Button9.BackColor = SystemColors.AppWorkspace;
            Button9.FlatAppearance.BorderSize = 0;
            Button9.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Button9.FlatAppearance.MouseOverBackColor = Color.Red;
            Button9.FlatStyle = FlatStyle.Flat;
            Button9.Location = new Point(167, 285);
            Button9.Margin = new Padding(0);
            Button9.Name = "Button9";
            Button9.Size = new Size(70, 50);
            Button9.TabIndex = 16;
            Button9.Text = "9";
            Button9.UseVisualStyleBackColor = false;
            Button9.Click += ButtonNumClick;
            // 
            // Button1
            // 
            Button1.BackColor = SystemColors.AppWorkspace;
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Button1.FlatAppearance.MouseOverBackColor = Color.Red;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(9, 405);
            Button1.Margin = new Padding(0);
            Button1.Name = "Button1";
            Button1.Size = new Size(70, 50);
            Button1.TabIndex = 27;
            Button1.Text = "1";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += ButtonNumClick;
            // 
            // Button2
            // 
            Button2.BackColor = SystemColors.AppWorkspace;
            Button2.FlatAppearance.BorderSize = 0;
            Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Button2.FlatAppearance.MouseOverBackColor = Color.Red;
            Button2.FlatStyle = FlatStyle.Flat;
            Button2.Location = new Point(88, 405);
            Button2.Margin = new Padding(0);
            Button2.Name = "Button2";
            Button2.Size = new Size(70, 50);
            Button2.TabIndex = 26;
            Button2.Text = "2";
            Button2.UseVisualStyleBackColor = false;
            Button2.Click += ButtonNumClick;
            // 
            // ButtonMinus
            // 
            ButtonMinus.BackColor = SystemColors.AppWorkspace;
            ButtonMinus.FlatAppearance.BorderSize = 0;
            ButtonMinus.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonMinus.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonMinus.FlatStyle = FlatStyle.Flat;
            ButtonMinus.Location = new Point(246, 405);
            ButtonMinus.Margin = new Padding(0);
            ButtonMinus.Name = "ButtonMinus";
            ButtonMinus.Size = new Size(70, 50);
            ButtonMinus.TabIndex = 25;
            ButtonMinus.Text = "−";
            ButtonMinus.UseVisualStyleBackColor = false;
            ButtonMinus.Click += ButtonMathOper;
            // 
            // Button3
            // 
            Button3.BackColor = SystemColors.AppWorkspace;
            Button3.FlatAppearance.BorderSize = 0;
            Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Button3.FlatAppearance.MouseOverBackColor = Color.Red;
            Button3.FlatStyle = FlatStyle.Flat;
            Button3.Location = new Point(167, 405);
            Button3.Margin = new Padding(0);
            Button3.Name = "Button3";
            Button3.Size = new Size(70, 50);
            Button3.TabIndex = 24;
            Button3.Text = "3";
            Button3.UseVisualStyleBackColor = false;
            Button3.Click += ButtonNumClick;
            // 
            // ButtonPlusMinus
            // 
            ButtonPlusMinus.BackColor = SystemColors.AppWorkspace;
            ButtonPlusMinus.FlatAppearance.BorderSize = 0;
            ButtonPlusMinus.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonPlusMinus.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonPlusMinus.FlatStyle = FlatStyle.Flat;
            ButtonPlusMinus.Location = new Point(9, 465);
            ButtonPlusMinus.Margin = new Padding(0);
            ButtonPlusMinus.Name = "ButtonPlusMinus";
            ButtonPlusMinus.Size = new Size(70, 50);
            ButtonPlusMinus.TabIndex = 31;
            ButtonPlusMinus.Text = "±";
            ButtonPlusMinus.UseVisualStyleBackColor = false;
            // 
            // Button0
            // 
            Button0.BackColor = SystemColors.AppWorkspace;
            Button0.FlatAppearance.BorderSize = 0;
            Button0.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Button0.FlatAppearance.MouseOverBackColor = Color.Red;
            Button0.FlatStyle = FlatStyle.Flat;
            Button0.Location = new Point(88, 465);
            Button0.Margin = new Padding(0);
            Button0.Name = "Button0";
            Button0.Size = new Size(70, 50);
            Button0.TabIndex = 30;
            Button0.Text = "0";
            Button0.UseVisualStyleBackColor = false;
            Button0.Click += ButtonNumClick;
            // 
            // ButtonEqual
            // 
            ButtonEqual.BackColor = Color.FromArgb(25, 106, 167);
            ButtonEqual.FlatAppearance.BorderSize = 0;
            ButtonEqual.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonEqual.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonEqual.FlatStyle = FlatStyle.Flat;
            ButtonEqual.ForeColor = Color.White;
            ButtonEqual.Location = new Point(246, 465);
            ButtonEqual.Margin = new Padding(0);
            ButtonEqual.Name = "ButtonEqual";
            ButtonEqual.Size = new Size(70, 50);
            ButtonEqual.TabIndex = 29;
            ButtonEqual.Text = "=";
            ButtonEqual.UseVisualStyleBackColor = false;
            ButtonEqual.Click += ButtonEqual_Click;
            // 
            // ButtonDot
            // 
            ButtonDot.BackColor = SystemColors.AppWorkspace;
            ButtonDot.FlatAppearance.BorderSize = 0;
            ButtonDot.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            ButtonDot.FlatAppearance.MouseOverBackColor = Color.Red;
            ButtonDot.FlatStyle = FlatStyle.Flat;
            ButtonDot.Location = new Point(167, 465);
            ButtonDot.Margin = new Padding(0);
            ButtonDot.Name = "ButtonDot";
            ButtonDot.Size = new Size(70, 50);
            ButtonDot.TabIndex = 28;
            ButtonDot.Text = ",";
            ButtonDot.UseVisualStyleBackColor = false;
            ButtonDot.Click += ButtonNumClick;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(320, 540);
            Controls.Add(ButtonPlusMinus);
            Controls.Add(Button0);
            Controls.Add(ButtonEqual);
            Controls.Add(ButtonDot);
            Controls.Add(ButtonPercent);
            Controls.Add(ButtonDelCur);
            Controls.Add(ButtonDelChar);
            Controls.Add(ButtonDelAll);
            Controls.Add(Button1);
            Controls.Add(Button2);
            Controls.Add(ButtonMinus);
            Controls.Add(Button3);
            Controls.Add(Button4);
            Controls.Add(Button5);
            Controls.Add(ButtonPlus);
            Controls.Add(Button6);
            Controls.Add(Button7);
            Controls.Add(Button8);
            Controls.Add(ButtonMulti);
            Controls.Add(Button9);
            Controls.Add(ButtonReverse);
            Controls.Add(ButtonX2);
            Controls.Add(ButtonDiv);
            Controls.Add(ButtonSqrt);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Controls.Add(panel2);
            Controls.Add(PanelHistory);
            Controls.Add(PanelTit);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PanelTit.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel PanelTit;
        private Button BtnTitle;
        private Panel PanelHistory;
        private Button buttonCvernut;
        private Panel panel2;
        private TextBox TextBox1;
        private TextBox TextBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button ButtonDelAll;
        private Button ButtonDelChar;
        private Button ButtonPercent;
        private Button ButtonDelCur;
        private Button ButtonReverse;
        private Button ButtonX2;
        private Button ButtonDiv;
        private Button ButtonSqrt;
        private Button Button4;
        private Button Button5;
        private Button ButtonPlus;
        private Button Button6;
        private Button Button7;
        private Button Button8;
        private Button ButtonMulti;
        private Button Button9;
        private Button Button1;
        private Button Button2;
        private Button ButtonMinus;
        private Button Button3;
        private Button ButtonPlusMinus;
        private Button Button0;
        private Button ButtonEqual;
        private Button ButtonDot;
    }
}