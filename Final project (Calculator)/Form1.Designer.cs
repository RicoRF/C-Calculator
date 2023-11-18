namespace Final_project__Calculator_
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
            txtOutputResult = new TextBox();
            txtOutputM = new TextBox();
            btnBack = new Button();
            btnClear = new Button();
            btnMC = new Button();
            btnMR = new Button();
            btnMS = new Button();
            btnMPlus = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnSlash = new Button();
            btnSqrt = new Button();
            btnOneSlashX = new Button();
            btnMultiply = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnEqual = new Button();
            btnMinus = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnPlus = new Button();
            btnDot = new Button();
            btnPlusSlashMinus = new Button();
            btnZero = new Button();
            SuspendLayout();
            // 
            // txtOutputResult
            // 
            txtOutputResult.BorderStyle = BorderStyle.FixedSingle;
            txtOutputResult.Location = new Point(33, 34);
            txtOutputResult.Name = "txtOutputResult";
            txtOutputResult.ReadOnly = true;
            txtOutputResult.Size = new Size(414, 39);
            txtOutputResult.TabIndex = 0;
            txtOutputResult.TabStop = false;
            // 
            // txtOutputM
            // 
            txtOutputM.BorderStyle = BorderStyle.FixedSingle;
            txtOutputM.Location = new Point(33, 90);
            txtOutputM.Name = "txtOutputM";
            txtOutputM.ReadOnly = true;
            txtOutputM.Size = new Size(64, 39);
            txtOutputM.TabIndex = 1;
            txtOutputM.TabStop = false;
            txtOutputM.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(100, 90);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(137, 39);
            btnBack.TabIndex = 26;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(243, 90);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(204, 39);
            btnClear.TabIndex = 3;
            btnClear.TabStop = false;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnMC
            // 
            btnMC.Location = new Point(33, 135);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(64, 55);
            btnMC.TabIndex = 4;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = true;
            btnMC.Click += btnMC_Click;
            // 
            // btnMR
            // 
            btnMR.Location = new Point(33, 196);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(64, 55);
            btnMR.TabIndex = 10;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = true;
            btnMR.Click += btnMR_Click;
            // 
            // btnMS
            // 
            btnMS.Location = new Point(33, 257);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(64, 55);
            btnMS.TabIndex = 16;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = true;
            btnMS.Click += btnMS_Click;
            // 
            // btnMPlus
            // 
            btnMPlus.Location = new Point(33, 318);
            btnMPlus.Name = "btnMPlus";
            btnMPlus.Size = new Size(64, 55);
            btnMPlus.TabIndex = 21;
            btnMPlus.Text = "M+";
            btnMPlus.UseVisualStyleBackColor = true;
            btnMPlus.Click += btnMPlus_Click;
            // 
            // btnSeven
            // 
            btnSeven.Location = new Point(103, 135);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(64, 55);
            btnSeven.TabIndex = 5;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += UpdateCurrentValue_Click;
            // 
            // btnEight
            // 
            btnEight.Location = new Point(173, 135);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(64, 55);
            btnEight.TabIndex = 6;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += UpdateCurrentValue_Click;
            // 
            // btnNine
            // 
            btnNine.Location = new Point(243, 135);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(64, 55);
            btnNine.TabIndex = 7;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += UpdateCurrentValue_Click;
            // 
            // btnSlash
            // 
            btnSlash.Location = new Point(313, 135);
            btnSlash.Name = "btnSlash";
            btnSlash.Size = new Size(64, 55);
            btnSlash.TabIndex = 8;
            btnSlash.Text = "/";
            btnSlash.UseVisualStyleBackColor = true;
            btnSlash.Click += UpdateCurrentOperator_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Location = new Point(383, 135);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(64, 55);
            btnSqrt.TabIndex = 9;
            btnSqrt.Text = "sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnOneSlashX
            // 
            btnOneSlashX.Location = new Point(383, 196);
            btnOneSlashX.Name = "btnOneSlashX";
            btnOneSlashX.Size = new Size(64, 55);
            btnOneSlashX.TabIndex = 15;
            btnOneSlashX.Text = "1/X";
            btnOneSlashX.UseVisualStyleBackColor = true;
            btnOneSlashX.Click += btnOneSlashX_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(313, 196);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(64, 55);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += UpdateCurrentOperator_Click;
            // 
            // btnSix
            // 
            btnSix.Location = new Point(243, 196);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(64, 55);
            btnSix.TabIndex = 13;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += UpdateCurrentValue_Click;
            // 
            // btnFive
            // 
            btnFive.Location = new Point(173, 196);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(64, 55);
            btnFive.TabIndex = 12;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += UpdateCurrentValue_Click;
            // 
            // btnFour
            // 
            btnFour.Location = new Point(103, 196);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(64, 55);
            btnFour.TabIndex = 11;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += UpdateCurrentValue_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(383, 257);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(64, 116);
            btnEqual.TabIndex = 2;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            btnEqual.Leave += btnEqual_Leave;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(313, 257);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(64, 55);
            btnMinus.TabIndex = 20;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += UpdateCurrentOperator_Click;
            // 
            // btnThree
            // 
            btnThree.Location = new Point(243, 257);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(64, 55);
            btnThree.TabIndex = 19;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += UpdateCurrentValue_Click;
            // 
            // btnTwo
            // 
            btnTwo.Location = new Point(173, 257);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(64, 55);
            btnTwo.TabIndex = 18;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += UpdateCurrentValue_Click;
            // 
            // btnOne
            // 
            btnOne.Location = new Point(103, 257);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(64, 55);
            btnOne.TabIndex = 17;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += UpdateCurrentValue_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(313, 318);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(64, 55);
            btnPlus.TabIndex = 25;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += UpdateCurrentOperator_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(243, 318);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(64, 55);
            btnDot.TabIndex = 24;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btnPlusSlashMinus
            // 
            btnPlusSlashMinus.Location = new Point(173, 318);
            btnPlusSlashMinus.Name = "btnPlusSlashMinus";
            btnPlusSlashMinus.Size = new Size(64, 55);
            btnPlusSlashMinus.TabIndex = 23;
            btnPlusSlashMinus.Text = "+/-";
            btnPlusSlashMinus.UseVisualStyleBackColor = true;
            btnPlusSlashMinus.Click += btnPlusSlashMinus_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(103, 318);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(64, 55);
            btnZero.TabIndex = 22;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += UpdateCurrentValue_Click;
            btnZero.KeyPress += Form1_KeyPress;
            // 
            // Form1
            // 
            AcceptButton = btnEqual;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 406);
            Controls.Add(btnPlus);
            Controls.Add(btnDot);
            Controls.Add(btnPlusSlashMinus);
            Controls.Add(btnZero);
            Controls.Add(btnEqual);
            Controls.Add(btnMinus);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnOneSlashX);
            Controls.Add(btnMultiply);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnSqrt);
            Controls.Add(btnSlash);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnMPlus);
            Controls.Add(btnMS);
            Controls.Add(btnMR);
            Controls.Add(btnMC);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(txtOutputM);
            Controls.Add(txtOutputResult);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOutputResult;
        private TextBox txtOutputM;
        private Button btnBack;
        private Button btnClear;
        private Button btnMC;
        private Button btnMR;
        private Button btnMS;
        private Button btnMPlus;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnSlash;
        private Button btnSqrt;
        private Button btnOneSlashX;
        private Button btnMultiply;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnEqual;
        private Button btnMinus;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnPlus;
        private Button btnDot;
        private Button btnPlusSlashMinus;
        private Button btnZero;
    }
}