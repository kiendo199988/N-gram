using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_gram
{
    class Ngram
    {
        //fields
        private Ngram parent;
        private List<Ngram> children;
        private int frequency=1;
        private string word;
        private int index;
        private int level;

        //constructor
        public Ngram(string word,List<Ngram> children)
        {
            this.word = word;
            this.children = children;
            
        }

        public Ngram(List<Ngram> children)
        {
            this.children = children;
            this.parent = null;          
        }


        //method
        public int GetLevel()
        {
            return this.level;
        }
        public void SetLevel(int i)
        {
            this.level = i;
            if (this.GetChildren() != null && this.GetChildren().Count > 0)
            {
                foreach(Ngram child in this.GetChildren())
                {
                    child.SetLevel(i + 1);
                }
            }
        }

       
        public void SetIndex(int id)
        {
            this.index = id;
        }

        public int GetIndex()
        {
            return this.index;
        }

        //get max number of children
        public int GetMaxNrChildren()
        {
            if (this.GetChildren() != null && GetChildren().Count > 0)
            {
                int count = GetChildren().Count;
                foreach (Ngram child in GetChildren())
                {
                    int childMax = child.GetMaxNrChildren();
                    if (childMax > count)
                    {
                        count = childMax;
                    }
                }
                return count;
            }
            else
            {
                return 0;
            }
        }


        public void SetIndexForChildrenNode(int maxNrOfChildren)
        {
            if(this.GetChildren()!=null && this.GetChildren().Count > 0)
            {
                foreach (Ngram child in this.GetChildren())
                {
                    child.SetIndex(maxNrOfChildren * this.GetIndex() + this.GetChildren().IndexOf(child)+1);
                    child.SetIndexForChildrenNode(maxNrOfChildren);
                }
            }
        }
        public void SetParent(Ngram p)
        {
            this.parent = p;
        }

        public Ngram GetParent()
        {
            return this.parent;
        }
        public void AddChild(Ngram child)
        {
            this.children.Add(child);
        }

        public List<Ngram> GetChildren()
        {
            return this.children;
        }
        public string GetWord()
        {
            return this.word;
        }

        public int GetFrequency()
        {
            return this.frequency;
        }

        public int SetFrequency(int target)
        {
            this.frequency += target;
            return this.frequency;
        }

        public double GetProbability()
        {
            if (this.GetParent().GetParent() != null)
            {
                return Math.Round(this.GetFrequency() / Convert.ToDouble(this.GetParent().GetFrequency()),2);
            }
            else
            {
                return Math.Round(this.GetFrequency() / this.GetRootSumOfChildrenFrequency(),2);
            }
        }

        public double GetRootSumOfChildrenFrequency()
        {
            int childrenFrequency = 0;
            if (this.GetParent() != null)
            {
                foreach (Ngram child in this.GetParent().GetChildren())
                {
                    childrenFrequency += child.GetFrequency();
                }
            }
            return childrenFrequency;
        }

       
    }
}
