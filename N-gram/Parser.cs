using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_gram
{
    class Parser
    {
        private string text;
        public Parser(string text)
        {         
            this.text = text.TrimStart(' ').TrimEnd(' ');
        }

        

        //return a linked list of words or characters from an array of words or characters
        public Ngram GetNgramLinkedList(int i, string[] words)
        {
            if (i == 0)
            {
                if (words.Length == 1)
                {
                    List<Ngram> originalChildren = new List<Ngram>();
                    Ngram current = new Ngram(words[i], null);
                    originalChildren.Add(current);
                    Ngram root = new Ngram(originalChildren);
                    current.SetParent(root);
                    return current;
                }
                else
                {
                    List<Ngram> originalChildren = new List<Ngram>();
                    List<Ngram> children = new List<Ngram>();
                    Ngram child = GetNgramLinkedList(i + 1, words);
                    children.Add(child);
                    Ngram current = new Ngram(words[i], children);
                    child.SetParent(current);
                    originalChildren.Add(current);
                    Ngram root = new Ngram(originalChildren);
                    current.SetParent(root);
                    return current;
                }                                            
            }
            else
            {
                if (i < words.Length-1)
                {
                    List<Ngram> children = new List<Ngram>();
                    Ngram child = GetNgramLinkedList(i + 1, words);
                    children.Add(child);
                    Ngram current = new Ngram(words[i], children);
                    child.SetParent(current);
                    return current;
                }
                else if(i==words.Length-1)
                {
                    return new Ngram(words[i],null);
                }
                else
                {
                    return null;
                }
            }
        }

        //get a jagged array of words based on the inputted n
        public string[][] GetArraysOfNnumberOfWords(int ngram)
        {
            string newText = new string(text.Where(c => !char.IsPunctuation(c) && !char.IsDigit(c)).ToArray());
            string[] words = newText.ToLower().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (ngram <= words.Length)
            {
                string[][] wordBranches = new string[words.Length - ngram + 1][];
                for (int i = 0; i < words.Length - ngram + 1; i++)
                {
                    wordBranches[i] = new string[ngram];
                    for (int j = 0; j < ngram; j++)
                    {
                        wordBranches[i][j] = words[i + j];
                    }
                }
                return wordBranches;
            }
            else
            {
                return null;
            }
        }

        //get a jagged array of chars based on the inputted n
        public string [][] GetArraysOfNnumberOfCharacters(int ngram)
        {
            string newText = new string(text.Where(c => !char.IsWhiteSpace(c)).ToArray());
            if (ngram <= newText.Length)
            {
                string[][] charBranches = new string[newText.Length - ngram + 1][];
                for (int i = 0; i < newText.Length - ngram + 1; i++)
                {
                    charBranches[i] = new string[ngram];
                    for (int j = 0; j < ngram; j++)
                    {
                        charBranches[i][j] = newText[i + j].ToString();
                    }
                }
                return charBranches;
            }
            else
            {
                return null;
            }
        }

        public Ngram[] GetListOfNgramBranches(string[][] jaggedArray)
        {
            Ngram[] arrayOfNgramLinkedLists = new Ngram[jaggedArray.GetLength(0)];
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                Ngram ngram = GetNgramLinkedList(0, jaggedArray[i]);
                arrayOfNgramLinkedLists[i]=ngram;
            }
            return arrayOfNgramLinkedLists;
        }
       
        public Ngram Merge(Ngram[] listOfNgramBranches)
        {
            for(int i = 1; i < listOfNgramBranches.Length; i++)
            {
                MergeNode(listOfNgramBranches[i], listOfNgramBranches[0]);
            }
            return listOfNgramBranches[0].GetParent();
        }

        //merge two trees
        public void MergeNode(Ngram source, Ngram target)
        {
            if (source.GetWord() != target.GetWord())
            {
                source.SetParent(target.GetParent());
                int duplicate = 0;
                foreach (Ngram child in target.GetParent().GetChildren())
                {
                    if (child.GetWord() == source.GetWord())
                    {
                        duplicate++;
                        MergeNode(source, child);
                    }
                }
                if (duplicate == 0)
                {
                    target.GetParent().GetChildren().Add(source);
                }
            }
            else
            {
                target.SetFrequency(source.GetFrequency());
                if(source.GetChildren()!=null && target.GetChildren() != null)
                {
                    foreach (Ngram child in source.GetChildren())
                    {
                        int duplicate = 0;
                        foreach (Ngram targetChild in target.GetChildren())
                        {
                            if (child.GetWord() == targetChild.GetWord())
                            {
                                MergeNode(child, targetChild);
                                duplicate++;
                            }
                        }
                        if (duplicate == 0)
                        {
                            child.SetParent(target);
                            target.GetChildren().Add(child);
                        }
                    }
                }
                
            }
        }
    }
}
