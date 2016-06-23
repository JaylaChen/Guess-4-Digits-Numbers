using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessDigitsMainForm.Parameters
{
    public class PCInput
    {
        private string[] message = new string[2];
        private int userCheckAInt;
        private int userCheckBInt;

        public string[] Message
        {
            get { return this.message; }
            set
            {
                this.message[1] = string.Empty;
                bool isADigit = int.TryParse(value[0], out userCheckAInt);
                bool isBDigit = int.TryParse(value[1], out userCheckBInt);

                if (!isADigit || !isBDigit)
                {
                    this.message[0] = "您輸入了非數字";
                }
                else
                {
                    if (userCheckAInt + userCheckBInt > 4 || (userCheckAInt == 3 && userCheckBInt == 1))
                    {
                        this.message[0] = "沒有這種組合喔!";
                    }
                    else if (userCheckAInt == 4 && userCheckBInt == 0)
                    {
                        this.message[0] = "哈哈! 我聰明吧!";
                    }
                    else
                    {
                        this.message[0] = string.Empty;
                    }
                }
            }
        }

        private List<string> elementToRemove = new List<string>();
        private List<string> nextCandidateSet = new List<string>();

        public List<string> GenerateNextSet(string target, List<string> candidateSet, string[] userCheck)
        {
            foreach (string element in candidateSet)
            {
                int cntA = 0;
                int cntB = 0;
                for (int i = 0; i < target.Length; i++)
                {
                    for (int j = 0; j < target.Length; j++)
                    {
                        if (element[i] == target[j])
                        {
                            if (i == j)
                            {
                                cntA++;
                            }
                            else
                            {
                                cntB++;
                            }
                        }
                    }
                }

                if (cntA != int.Parse(userCheck[0]) || cntB != int.Parse(userCheck[1]))
                {
                    this.elementToRemove.Add(element);
                }
            }

            foreach (string element2 in elementToRemove)
            {
                candidateSet.Remove(element2);
            }

            nextCandidateSet = candidateSet;
            return nextCandidateSet;
        }

        private string nextTarget;
        private Random random = new Random();

        public string RandomPick(List<string> inputList)
        {
            if (inputList.Count > 0)
            {
                nextTarget = inputList[random.Next(0, inputList.Count - 1)];
            }
            else
            {
                nextTarget = string.Empty;
            }

            return nextTarget;
        }
    }
}