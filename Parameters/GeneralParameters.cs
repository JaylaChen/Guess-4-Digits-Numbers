using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessDigitsMainForm.Parameters
{
    public class GeneralParameters
    {
        private int max = 10;
        private List<string> allCandidates = new List<string>();
        private Random random = new Random();
        private string target;

        public List<string> GenerateAll()
        {
            for (int p = 0; p < max; p++)
            {
                for (int q = 0; q < max; q++)
                {
                    for (int r = 0; r < max; r++)
                    {
                        for (int s = 0; s < max; s++)
                        {
                            if (p != q && p != r && p != s && q != r && q != s && r != s)
                            {
                                this.allCandidates.Add(p.ToString() + q.ToString() + r.ToString() + s.ToString());
                            }
                        }
                    }
                }
            }
            return this.allCandidates;
        }

        public string RandomPick(List<string> inputList)
        {
            if (inputList.Count > 0)
            {
                target = inputList[random.Next(0, inputList.Count - 1)];
            }
            else
            {
                target = string.Empty;
            }
            return this.target;
        }
    }
}