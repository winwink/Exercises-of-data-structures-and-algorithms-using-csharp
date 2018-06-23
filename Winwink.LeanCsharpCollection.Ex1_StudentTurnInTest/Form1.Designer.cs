namespace Winwink.LeanCsharpCollection.Ex1_StudentTurnInTest
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnTrunIn = new System.Windows.Forms.Button();
            this.BtnLookTest = new System.Windows.Forms.Button();
            this.BtnReturnTest = new System.Windows.Forms.Button();
            this.BtnExitTest = new System.Windows.Forms.Button();
            this.listBoxSubmitted = new System.Windows.Forms.ListBox();
            this.listBoxOutForChecking = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(108, 37);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 25);
            this.TxtName.TabIndex = 1;
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(316, 37);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(100, 25);
            this.TxtNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "No.";
            // 
            // BtnTrunIn
            // 
            this.BtnTrunIn.Location = new System.Drawing.Point(47, 84);
            this.BtnTrunIn.Name = "BtnTrunIn";
            this.BtnTrunIn.Size = new System.Drawing.Size(161, 23);
            this.BtnTrunIn.TabIndex = 4;
            this.BtnTrunIn.Text = "Turn in a test";
            this.BtnTrunIn.UseVisualStyleBackColor = true;
            this.BtnTrunIn.Click += new System.EventHandler(this.BtnTrunIn_Click);
            // 
            // BtnLookTest
            // 
            this.BtnLookTest.Location = new System.Drawing.Point(47, 113);
            this.BtnLookTest.Name = "BtnLookTest";
            this.BtnLookTest.Size = new System.Drawing.Size(161, 23);
            this.BtnLookTest.TabIndex = 5;
            this.BtnLookTest.Text = "Let student look at test";
            this.BtnLookTest.UseVisualStyleBackColor = true;
            this.BtnLookTest.Click += new System.EventHandler(this.BtnLookTest_Click);
            // 
            // BtnReturnTest
            // 
            this.BtnReturnTest.Location = new System.Drawing.Point(47, 142);
            this.BtnReturnTest.Name = "BtnReturnTest";
            this.BtnReturnTest.Size = new System.Drawing.Size(161, 23);
            this.BtnReturnTest.TabIndex = 6;
            this.BtnReturnTest.Text = "Return a test";
            this.BtnReturnTest.UseVisualStyleBackColor = true;
            this.BtnReturnTest.Click += new System.EventHandler(this.BtnReturnTest_Click);
            // 
            // BtnExitTest
            // 
            this.BtnExitTest.Location = new System.Drawing.Point(47, 171);
            this.BtnExitTest.Name = "BtnExitTest";
            this.BtnExitTest.Size = new System.Drawing.Size(161, 23);
            this.BtnExitTest.TabIndex = 7;
            this.BtnExitTest.Text = "Exit";
            this.BtnExitTest.UseVisualStyleBackColor = true;
            this.BtnExitTest.Click += new System.EventHandler(this.BtnExitTest_Click);
            // 
            // listBoxSubmitted
            // 
            this.listBoxSubmitted.FormattingEnabled = true;
            this.listBoxSubmitted.ItemHeight = 15;
            this.listBoxSubmitted.Location = new System.Drawing.Point(47, 217);
            this.listBoxSubmitted.Name = "listBoxSubmitted";
            this.listBoxSubmitted.Size = new System.Drawing.Size(192, 94);
            this.listBoxSubmitted.TabIndex = 8;
            // 
            // listBoxOutForChecking
            // 
            this.listBoxOutForChecking.FormattingEnabled = true;
            this.listBoxOutForChecking.ItemHeight = 15;
            this.listBoxOutForChecking.Location = new System.Drawing.Point(342, 217);
            this.listBoxOutForChecking.Name = "listBoxOutForChecking";
            this.listBoxOutForChecking.Size = new System.Drawing.Size(204, 94);
            this.listBoxOutForChecking.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxOutForChecking);
            this.Controls.Add(this.listBoxSubmitted);
            this.Controls.Add(this.BtnExitTest);
            this.Controls.Add(this.BtnReturnTest);
            this.Controls.Add(this.BtnLookTest);
            this.Controls.Add(this.BtnTrunIn);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnTrunIn;
        private System.Windows.Forms.Button BtnLookTest;
        private System.Windows.Forms.Button BtnReturnTest;
        private System.Windows.Forms.Button BtnExitTest;
        private System.Windows.Forms.ListBox listBoxSubmitted;
        private System.Windows.Forms.ListBox listBoxOutForChecking;
    }
}

