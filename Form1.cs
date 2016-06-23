using GuessDigitsMainForm.Parameters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessDigitsMainForm
{
    public partial class GuessDigitsMainForm : Form
    {
        //共用參數
        private GeneralParameters candidatesMax = new GeneralParameters();

        private List<string> dataBase;

        public List<string> DataBase
        {
            get { return this.dataBase; }
        }

        private Random random = new Random();

        //userGuessMode的參數
        private string answer;

        public string Answer
        {
            get { return this.answer; }
        }

        private int cntUserGuess = 0;

        public int CntUserGuess
        {
            get { return this.cntUserGuess; }
        }

        //PC Guess的參數
        private List<string> candidateSet;

        public List<string> CandidateSet
        {
            get { return this.candidateSet; }
        }

        private string target;

        public string Target
        {
            get { return this.target; }
        }

        private int cntPcGuess = 0;

        public int CntPcGuess
        {
            get { return this.cntPcGuess; }
        }

        public GuessDigitsMainForm()
        {
            InitializeComponent();
        }

        private void userGuessModeButton_Click(object sender, EventArgs e)
        {
            this.dataBase = this.candidatesMax.GenerateAll();
            this.answer = this.candidatesMax.RandomPick(this.DataBase);
            userGuessMsgLabel.Text = "謎底已經產生，輸入你猜測的答案吧";
            userGuessModeButton.Visible = false;
            userInputTextBox.Visible = true;
            userGuessButton.Visible = true;
            userInputLogTextBox.Visible = true;
            showAnswerButton.Visible = true;
        }

        private void userGuessButton_Click(object sender, EventArgs e)
        {
            UserInput userInput = new UserInput();
            userInput.Message = userInputTextBox.Text;
            userGuessMsgLabel.Text = userInput.Message;
            if (userGuessMsgLabel.Text == string.Empty)
            {
                string[] match = userInput.Match(userInputTextBox.Text, this.answer);
                this.cntUserGuess++;
                userGuessMsgLabel.Text = "您已經猜了" + this.CntUserGuess.ToString() + "次";
                userInputLogTextBox.AppendText(userInputTextBox.Text + ":" + match[0] + "A" + match[1] + "B" + "\n");
                if (match[0] == "4")
                {
                    MessageBox.Show("恭喜你猜對了");
                }
            }
            userInputTextBox.Clear();
        }

        private void showAnswerButton_Click(object sender, EventArgs e)
        {
            userGuessMsgLabel.Text = "答案是" + this.Answer;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // reset UserGuessMode的所有參數
            this.answer = string.Empty;
            this.cntUserGuess = 0;

            userInputLogTextBox.Clear();
            userGuessModeButton.Visible = true;

            userInputTextBox.Visible = false;
            userGuessButton.Visible = false;
            userInputLogTextBox.Visible = false;
            showAnswerButton.Visible = false;
            userCheckMsgLabel.Visible = false;

            userGuessMsgLabel.Text = "按下 我猜電腦 來產生謎底";

            //reset PC GuessMode的所有參數
            this.target = string.Empty;
            this.cntPcGuess = 0;

            pcInputLogTextBox.Clear();
            pcGuessModeButton.Visible = true;

            userCheckATextBox.Visible = false;
            userCheckBTextBox.Visible = false;
            ALabel.Visible = false;
            BLabel.Visible = false;
            pcInputLogTextBox.Visible = false;
            pcGuessButton.Visible = false;

            pcGuessMsgLabel.Text = "心裡想好一個數字，按下 電腦猜你 吧!";
        }

        private void pcGuessModeButton_Click(object sender, EventArgs e)
        {
            this.candidateSet = this.candidatesMax.GenerateAll();
            //testLabel.Text = this.CandidateSet.Count.ToString();
            this.target = this.candidatesMax.RandomPick(this.CandidateSet);
            pcGuessMsgLabel.Text = "電腦猜你的數字是" + this.Target;
            userCheckATextBox.Visible = true;
            userCheckBTextBox.Visible = true;
            ALabel.Visible = true;
            BLabel.Visible = true;
            pcInputLogTextBox.Visible = true;
            pcGuessButton.Visible = true;
            pcGuessModeButton.Visible = false;
        }

        private void pcGuessButton_Click(object sender, EventArgs e)
        {
            PCInput pcInput = new PCInput();
            string[] userCheck = { userCheckATextBox.Text, userCheckBTextBox.Text };
            pcInput.Message = userCheck;

            userCheckMsgLabel.Text = pcInput.Message[0];
            userCheckMsgLabel.Visible = true;
            if (userCheckMsgLabel.Text == string.Empty)
            {
                this.cntPcGuess++;
                this.candidateSet = pcInput.GenerateNextSet(this.Target, this.CandidateSet, userCheck);
                pcInputLogTextBox.AppendText(this.Target + ":" + userCheckATextBox.Text + "A" + userCheckBTextBox.Text + "B" + "\n");
                if (this.CandidateSet.Count > 1)
                {
                    pcGuessMsgLabel.Text = "電腦猜第" + (this.CntPcGuess + 1).ToString() + "次";
                    this.target = pcInput.RandomPick(this.CandidateSet);
                    userCheckMsgLabel.Text = "電腦猜你的數字是" + this.Target;
                }
                else if (this.CandidateSet.Count == 1)
                {
                    this.target = pcInput.RandomPick(this.CandidateSet);
                    pcGuessMsgLabel.Text = "電腦猜第" + this.CntPcGuess.ToString() + "次";
                    userCheckMsgLabel.Text = "我知道了! 一定是" + this.Target;
                }
                else if (this.CandidateSet.Count == 0)
                {
                    pcGuessMsgLabel.Text = "請不要耍我捏!";
                }
            }
            userCheckATextBox.Clear();
            userCheckBTextBox.Clear();
        }
    }
}