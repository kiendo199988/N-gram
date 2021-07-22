using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace N_gram
{
    class TreeGenerator
    {
        private Ngram ngram;

        public TreeGenerator(Ngram n)
        {
            this.ngram = n;
        }

        //generate tree for original function
        public void GenerateTreeImage()
        {
            GenerateTextFile();
            Process dot = new Process();

            dot.StartInfo.FileName = @"dot.exe";
            dot.StartInfo.Arguments = "-Tpng -ongramTree.png graph.dot";
            dot.Start();
            dot.WaitForExit();
        }

        //generate a text that helps to build a tree image
        public string WriteTextFileWithFormula(Ngram currentNode)
        {
            string text = "";
            if (currentNode.GetParent() == null)
            {
                text += "node" + currentNode.GetIndex() + " [ label = \"" + "root" + "\" ]" + "\n";
            }
            else
            {
                text += "node" + currentNode.GetIndex() + " [ label = \"" + currentNode.GetWord() + "\n" + currentNode.GetFrequency()+"\n"+currentNode.GetProbability() + "\" ]" + "\n";
            }
            if (currentNode.GetChildren() != null)
            {
                foreach(Ngram child in currentNode.GetChildren())
                {
                    text += "node" + currentNode.GetIndex() + " -- " + "node" + child.GetIndex() + "\n";
                    text += WriteTextFileWithFormula(child);
                    //if (child.GetChildren() != null)
                    //{
                    //    foreach(Ngram grandChild in child.GetChildren())
                    //    {
                    //    }
                    //}
                }
                
            }

          
            return text;
        }

        //generate a text file to create a tree image
        private void GenerateTextFile()
        {
            string s = "graph ngram{node [ fontname = \"arial\"]" + "\n" + this.WriteTextFileWithFormula(this.ngram) + "\n" + "}";
            try
            {
                using (StreamWriter sw = new StreamWriter("./graph.dot"))
                {
                    sw.WriteLine(s);
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }

       
    }
}
