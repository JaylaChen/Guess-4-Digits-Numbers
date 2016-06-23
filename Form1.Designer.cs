namespace GuessDigitsMainForm
{
    partial class GuessDigitsMainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.userGuessMsgLabel = new System.Windows.Forms.Label();
            this.userGuessModeButton = new System.Windows.Forms.Button();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.userGuessButton = new System.Windows.Forms.Button();
            this.userInputLogTextBox = new System.Windows.Forms.TextBox();
            this.showAnswerButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.pcGuessMsgLabel = new System.Windows.Forms.Label();
            this.pcGuessModeButton = new System.Windows.Forms.Button();
            this.userCheckATextBox = new System.Windows.Forms.TextBox();
            this.userCheckBTextBox = new System.Windows.Forms.TextBox();
            this.ALabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.pcInputLogTextBox = new System.Windows.Forms.TextBox();
            this.pcGuessButton = new System.Windows.Forms.Button();
            this.userCheckMsgLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userGuessMsgLabel
            // 
            this.userGuessMsgLabel.AutoSize = true;
            this.userGuessMsgLabel.Location = new System.Drawing.Point(56, 34);
            this.userGuessMsgLabel.Name = "userGuessMsgLabel";
            this.userGuessMsgLabel.Size = new System.Drawing.Size(229, 24);
            this.userGuessMsgLabel.TabIndex = 1;
            this.userGuessMsgLabel.Text = "按下 我猜電腦 來產生謎底";
            this.userGuessMsgLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userGuessModeButton
            // 
            this.userGuessModeButton.Location = new System.Drawing.Point(60, 72);
            this.userGuessModeButton.Name = "userGuessModeButton";
            this.userGuessModeButton.Size = new System.Drawing.Size(153, 36);
            this.userGuessModeButton.TabIndex = 2;
            this.userGuessModeButton.Text = "我猜電腦";
            this.userGuessModeButton.UseVisualStyleBackColor = true;
            this.userGuessModeButton.Click += new System.EventHandler(this.userGuessModeButton_Click);
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(60, 132);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(119, 31);
            this.userInputTextBox.TabIndex = 3;
            this.userInputTextBox.Visible = false;
            // 
            // userGuessButton
            // 
            this.userGuessButton.Location = new System.Drawing.Point(209, 132);
            this.userGuessButton.Name = "userGuessButton";
            this.userGuessButton.Size = new System.Drawing.Size(76, 31);
            this.userGuessButton.TabIndex = 4;
            this.userGuessButton.Text = "我猜!";
            this.userGuessButton.UseVisualStyleBackColor = true;
            this.userGuessButton.Visible = false;
            this.userGuessButton.Click += new System.EventHandler(this.userGuessButton_Click);
            // 
            // userInputLogTextBox
            // 
            this.userInputLogTextBox.Location = new System.Drawing.Point(60, 189);
            this.userInputLogTextBox.Multiline = true;
            this.userInputLogTextBox.Name = "userInputLogTextBox";
            this.userInputLogTextBox.ReadOnly = true;
            this.userInputLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userInputLogTextBox.Size = new System.Drawing.Size(225, 195);
            this.userInputLogTextBox.TabIndex = 5;
            this.userInputLogTextBox.Visible = false;
            // 
            // showAnswerButton
            // 
            this.showAnswerButton.Location = new System.Drawing.Point(60, 410);
            this.showAnswerButton.Name = "showAnswerButton";
            this.showAnswerButton.Size = new System.Drawing.Size(225, 33);
            this.showAnswerButton.TabIndex = 6;
            this.showAnswerButton.Text = "投降，跟我講答案吧!";
            this.showAnswerButton.UseVisualStyleBackColor = true;
            this.showAnswerButton.Visible = false;
            this.showAnswerButton.Click += new System.EventHandler(this.showAnswerButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(279, 449);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(163, 51);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "重新來過";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // pcGuessMsgLabel
            // 
            this.pcGuessMsgLabel.AutoSize = true;
            this.pcGuessMsgLabel.Location = new System.Drawing.Point(428, 34);
            this.pcGuessMsgLabel.Name = "pcGuessMsgLabel";
            this.pcGuessMsgLabel.Size = new System.Drawing.Size(330, 24);
            this.pcGuessMsgLabel.TabIndex = 8;
            this.pcGuessMsgLabel.Text = "心裡想好一個數字，按下 電腦猜你 吧!";
            this.pcGuessMsgLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pcGuessModeButton
            // 
            this.pcGuessModeButton.Location = new System.Drawing.Point(450, 72);
            this.pcGuessModeButton.Name = "pcGuessModeButton";
            this.pcGuessModeButton.Size = new System.Drawing.Size(138, 36);
            this.pcGuessModeButton.TabIndex = 9;
            this.pcGuessModeButton.Text = "電腦猜你";
            this.pcGuessModeButton.UseVisualStyleBackColor = true;
            this.pcGuessModeButton.Click += new System.EventHandler(this.pcGuessModeButton_Click);
            // 
            // userCheckATextBox
            // 
            this.userCheckATextBox.Location = new System.Drawing.Point(450, 133);
            this.userCheckATextBox.Name = "userCheckATextBox";
            this.userCheckATextBox.Size = new System.Drawing.Size(30, 31);
            this.userCheckATextBox.TabIndex = 10;
            this.userCheckATextBox.Visible = false;
            // 
            // userCheckBTextBox
            // 
            this.userCheckBTextBox.Location = new System.Drawing.Point(525, 132);
            this.userCheckBTextBox.Name = "userCheckBTextBox";
            this.userCheckBTextBox.Size = new System.Drawing.Size(30, 31);
            this.userCheckBTextBox.TabIndex = 11;
            this.userCheckBTextBox.Visible = false;
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(486, 140);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(23, 24);
            this.ALabel.TabIndex = 12;
            this.ALabel.Text = "A";
            this.ALabel.Visible = false;
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(561, 140);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(22, 24);
            this.BLabel.TabIndex = 13;
            this.BLabel.Text = "B";
            this.BLabel.Visible = false;
            // 
            // pcInputLogTextBox
            // 
            this.pcInputLogTextBox.Location = new System.Drawing.Point(450, 189);
            this.pcInputLogTextBox.Multiline = true;
            this.pcInputLogTextBox.Name = "pcInputLogTextBox";
            this.pcInputLogTextBox.ReadOnly = true;
            this.pcInputLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pcInputLogTextBox.Size = new System.Drawing.Size(225, 195);
            this.pcInputLogTextBox.TabIndex = 14;
            this.pcInputLogTextBox.Visible = false;
            // 
            // pcGuessButton
            // 
            this.pcGuessButton.Location = new System.Drawing.Point(612, 132);
            this.pcGuessButton.Name = "pcGuessButton";
            this.pcGuessButton.Size = new System.Drawing.Size(75, 32);
            this.pcGuessButton.TabIndex = 15;
            this.pcGuessButton.Text = "再猜!";
            this.pcGuessButton.UseVisualStyleBackColor = true;
            this.pcGuessButton.Visible = false;
            this.pcGuessButton.Click += new System.EventHandler(this.pcGuessButton_Click);
            // 
            // userCheckMsgLabel
            // 
            this.userCheckMsgLabel.AutoSize = true;
            this.userCheckMsgLabel.Location = new System.Drawing.Point(446, 79);
            this.userCheckMsgLabel.Name = "userCheckMsgLabel";
            this.userCheckMsgLabel.Size = new System.Drawing.Size(143, 24);
            this.userCheckMsgLabel.TabIndex = 16;
            this.userCheckMsgLabel.Text = "userCheckMsg";
            this.userCheckMsgLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.userCheckMsgLabel.Visible = false;
            // 
            // GuessDigitsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 513);
            this.Controls.Add(this.userCheckMsgLabel);
            this.Controls.Add(this.pcGuessButton);
            this.Controls.Add(this.pcInputLogTextBox);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.userCheckBTextBox);
            this.Controls.Add(this.userCheckATextBox);
            this.Controls.Add(this.pcGuessModeButton);
            this.Controls.Add(this.pcGuessMsgLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.showAnswerButton);
            this.Controls.Add(this.userInputLogTextBox);
            this.Controls.Add(this.userGuessButton);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.userGuessModeButton);
            this.Controls.Add(this.userGuessMsgLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GuessDigitsMainForm";
            this.Text = "猜數字遊戲";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userGuessMsgLabel;
        private System.Windows.Forms.Button userGuessModeButton;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Button userGuessButton;
        private System.Windows.Forms.TextBox userInputLogTextBox;
        private System.Windows.Forms.Button showAnswerButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label pcGuessMsgLabel;
        private System.Windows.Forms.Button pcGuessModeButton;
        private System.Windows.Forms.TextBox userCheckATextBox;
        private System.Windows.Forms.TextBox userCheckBTextBox;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.TextBox pcInputLogTextBox;
        private System.Windows.Forms.Button pcGuessButton;
        private System.Windows.Forms.Label userCheckMsgLabel;
    }
}

