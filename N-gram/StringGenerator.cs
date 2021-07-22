using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_gram
{
    class StringGenerator
    {
        private Ngram root;
        private Ngram intermediateNgram;
        public StringGenerator(Ngram root)
        {
            this.root = root;
        }

        public Ngram GetNgramChildByProbability(Ngram ngram)
        {
            Random rnd = new Random();
            double num = rnd.NextDouble();
            Ngram chosenOne = null;
            if (ngram.GetChildren() != null && ngram.GetChildren().Count > 0)
            {
                double[] probabilities = new double[ngram.GetChildren().Count];
                double[] probabilityIntervals = new double[ngram.GetChildren().Count];
                for (int i = 0; i < ngram.GetChildren().Count; i++)
                {
                    probabilities[i] = ngram.GetChildren()[i].GetProbability();
                }

                for (int i = 0; i < probabilities.Length; i++)
                {
                    if (i == 0)
                    {
                        probabilityIntervals[i] = probabilities[i];
                    }
                    else
                    {
                        probabilityIntervals[i] = probabilityIntervals[i - 1] + probabilities[i];
                    }
                }

                for (int i = 0; i < probabilityIntervals.Length; i++)
                {
                    if (i == 0)
                    {
                        if (num <= probabilityIntervals[i])
                        {
                            chosenOne = ngram.GetChildren()[i];
                        }
                    }
                    else
                    {
                        if (num > probabilityIntervals[i - 1] && num <= probabilityIntervals[i])
                        {
                            chosenOne = ngram.GetChildren()[i];
                        }
                    }
                }
            }
            return chosenOne;
        }

        //Generate new word based on the nr of clicks
        public string GenerateNewWordsByUnit(int unit)
        {
            string newWord = GetNgramChildByProbability(intermediateNgram).GetWord();
            intermediateNgram = GetNgramChildByProbability(intermediateNgram);
            return newWord;
        }


        //it should return a list of strings by provided unit
        public Ngram[] GetNgramChildByUnit(Ngram[] ngrams, int unit)
        {
            if (unit > 0)
            {

                Ngram[] ngramsArray = new Ngram[unit];
                Ngram ngram = GetNgramChildByProbability(ngrams[0]);
                unit--;
            }
            else
            {
                string notice = "when the function reaches a leaf, where it should go next. It should go back to the root ffs";
            }
            return null;
        }
    }
}
