using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_gram
{
    class BFSHandler
    {
        private Ngram root;
        public BFSHandler(Ngram root)
        {
            this.root = root;
            root.SetIndex(0);
            root.SetLevel(0);
        }


        public List<Ngram> GetListOfNgramsByLevel(int level)
        {
            List<Ngram> ngramList = new List<Ngram>();
            if(level == 0)
            {
                ngramList.Add(root);
                return ngramList;
            }
            else
            {
                Queue<Ngram> queue = new Queue<Ngram>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    Ngram u = queue.Dequeue();
                    if (u.GetChildren() != null)
                    {
                        foreach (Ngram n in u.GetChildren())
                        {
                            if (n.GetLevel() == level)
                            {
                                ngramList.Add(n);
                            }
                            else
                            {
                                queue.Enqueue(n);
                            }
                        }
                    }
                    else
                    {
                        if (u.GetLevel() == level)
                        {
                            ngramList.Add(u);
                        }
                    }
                }
                return ngramList;
            }       
        }

        public int GetNrOfNodesWithXNrOfChildren(int nrOfChildren, List<Ngram> nodes)
        {
            if(nodes != null)
            {
                int nrOfNodes = 0;
                foreach(Ngram n in nodes)
                {
                    if(n.GetChildren() != null && n.GetChildren().Count == nrOfChildren)
                    {
                        nrOfNodes++;
                    }
                }
                return nrOfNodes;
            }
            else
            {
                return 0;
            }
        }

        public List<int> GetDistinctNrOfChildren(List<Ngram> ngrams)
        {
            List<int> nrOfChildren = new List<int>();
            if(ngrams!=null)
            {
                foreach(Ngram n in ngrams)
                {
                    if (!nrOfChildren.Contains(n.GetChildren().Count))
                    {
                        nrOfChildren.Add(n.GetChildren().Count);
                    }
                }
            }
            return nrOfChildren;
        }
    }
}
