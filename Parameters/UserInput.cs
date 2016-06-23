using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessDigitsMainForm.Parameters
{
    public class UserInput
    {
        private enum userInputStatusCode { Success, NonDigits, NotEqualTo4, Repeat };

        private userInputStatusCode statusCode;
        private string message;
        private int userInputInt;

        public string Message
        {
            get { return this.message; }
            set
            {
                int cnt = 0;
                bool isItInt = int.TryParse(value, out this.userInputInt);
                if (isItInt == false)
                {
                    statusCode = userInputStatusCode.NonDigits;
                }
                else
                {
                    if (value.Length != 4)
                    {
                        statusCode = userInputStatusCode.NotEqualTo4;
                    }
                    else
                    {
                        for (int i = 0; i < value.Length; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                if (value[i] == value[j] && i != j)
                                {
                                    cnt++;
                                }
                            }
                        }

                        if (cnt != 0)
                        {
                            statusCode = userInputStatusCode.Repeat;
                        }
                        else
                        {
                            statusCode = userInputStatusCode.Success;
                        }
                    }
                }

                switch (statusCode)
                {
                    case userInputStatusCode.Success:
                        this.message = string.Empty;
                        break;

                    case userInputStatusCode.NonDigits:
                        this.message = "您輸入了非數字的字元喔!";
                        break;

                    case userInputStatusCode.NotEqualTo4:
                        this.message = "您輸入超過或不足四個數字";
                        break;

                    case userInputStatusCode.Repeat:
                        this.message = "您輸入重複的數字";
                        break;
                }
            }
        }

        private string[] match = new string[2];

        public string[] Match(string input, string answer)
        {
            int cntA = 0;
            int cntB = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                for (int j = 0; j < answer.Length; j++)
                {
                    if (input[i] == answer[j])
                    {
                        if (i == j)
                        {
                            cntA++;
                        }
                        else
                            cntB++;
                    }
                }
            }
            match[0] = cntA.ToString();
            match[1] = cntB.ToString();

            return this.match;
        }
    }
}