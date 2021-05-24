
namespace cardgameform
{
    partial class formrestart
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
            this.labelstart = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.follow1 = new System.Windows.Forms.Button();
            this.follow2 = new System.Windows.Forms.Button();
            this.fold1 = new System.Windows.Forms.Button();
            this.fold2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.winnerButton = new System.Windows.Forms.Button();
            this.cardtype2 = new System.Windows.Forms.TextBox();
            this.cardtype1 = new System.Windows.Forms.TextBox();
            this.WinnerTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelstart
            // 
            this.labelstart.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelstart.Location = new System.Drawing.Point(259, 20);
            this.labelstart.Name = "labelstart";
            this.labelstart.Size = new System.Drawing.Size(191, 50);
            this.labelstart.TabIndex = 0;
            this.labelstart.Text = "開始玩撲克吧";
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(286, 91);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(112, 34);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "開始";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startButton_click1);
            // 
            // follow1
            // 
            this.follow1.Location = new System.Drawing.Point(100, 180);
            this.follow1.Name = "follow1";
            this.follow1.Size = new System.Drawing.Size(112, 34);
            this.follow1.TabIndex = 1;
            this.follow1.Text = "跟牌";
            this.follow1.UseVisualStyleBackColor = true;
            this.follow1.Click += new System.EventHandler(this.follow1_Click);
            // 
            // follow2
            // 
            this.follow2.Location = new System.Drawing.Point(476, 180);
            this.follow2.Name = "follow2";
            this.follow2.Size = new System.Drawing.Size(112, 34);
            this.follow2.TabIndex = 1;
            this.follow2.Text = "跟牌";
            this.follow2.UseVisualStyleBackColor = true;
            this.follow2.Click += new System.EventHandler(this.follow2_Click);
            // 
            // fold1
            // 
            this.fold1.Location = new System.Drawing.Point(100, 233);
            this.fold1.Name = "fold1";
            this.fold1.Size = new System.Drawing.Size(112, 34);
            this.fold1.TabIndex = 1;
            this.fold1.Text = "棄牌";
            this.fold1.UseVisualStyleBackColor = true;
            this.fold1.Click += new System.EventHandler(this.fold1_Click);
            // 
            // fold2
            // 
            this.fold2.Location = new System.Drawing.Point(476, 233);
            this.fold2.Name = "fold2";
            this.fold2.Size = new System.Drawing.Size(112, 34);
            this.fold2.TabIndex = 1;
            this.fold2.Text = "棄牌";
            this.fold2.UseVisualStyleBackColor = true;
            this.fold2.Click += new System.EventHandler(this.fold2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 285);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(292, 144);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(388, 285);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(294, 144);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // winnerButton
            // 
            this.winnerButton.BackColor = System.Drawing.Color.Red;
            this.winnerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winnerButton.Location = new System.Drawing.Point(286, 473);
            this.winnerButton.Name = "winnerButton";
            this.winnerButton.Size = new System.Drawing.Size(112, 34);
            this.winnerButton.TabIndex = 3;
            this.winnerButton.Text = "結果與贏家";
            this.winnerButton.UseVisualStyleBackColor = false;
            this.winnerButton.Click += new System.EventHandler(this.winnerButton_Click);
            // 
            // cardtype2
            // 
            this.cardtype2.Location = new System.Drawing.Point(454, 473);
            this.cardtype2.Name = "cardtype2";
            this.cardtype2.Size = new System.Drawing.Size(150, 30);
            this.cardtype2.TabIndex = 4;
            // 
            // cardtype1
            // 
            this.cardtype1.Location = new System.Drawing.Point(81, 473);
            this.cardtype1.Name = "cardtype1";
            this.cardtype1.Size = new System.Drawing.Size(150, 30);
            this.cardtype1.TabIndex = 4;
            // 
            // WinnerTextbox
            // 
            this.WinnerTextbox.Location = new System.Drawing.Point(177, 565);
            this.WinnerTextbox.Name = "WinnerTextbox";
            this.WinnerTextbox.Size = new System.Drawing.Size(347, 30);
            this.WinnerTextbox.TabIndex = 5;
            this.WinnerTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "player2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(276, 199);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(150, 30);
            this.info.TabIndex = 5;
            // 
            // formrestart
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(724, 667);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.WinnerTextbox);
            this.Controls.Add(this.cardtype1);
            this.Controls.Add(this.cardtype2);
            this.Controls.Add(this.winnerButton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.fold2);
            this.Controls.Add(this.follow2);
            this.Controls.Add(this.fold1);
            this.Controls.Add(this.follow1);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.labelstart);
            this.Name = "formrestart";
            this.Text = "卡牌遊戲";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labelstart;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button follow1;
        private System.Windows.Forms.Button follow2;
        private System.Windows.Forms.Button fold1;
        private System.Windows.Forms.Button fold2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button winnerButton;
        private System.Windows.Forms.TextBox cardtype2;
        private System.Windows.Forms.TextBox cardtype1;
        private System.Windows.Forms.TextBox WinnerTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox info;
    }
}

