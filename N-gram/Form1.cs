using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace N_gram
{
    public partial class Form1 : Form
    {
        private Parser parser;
        private Ngram root;
        private BFSHandler bFSHandler;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Kien's Ngram";
        }

        private void richTbInputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            if (richTbInputText.Text != "" && tbDepth.Text != "")
            {
                Parser parser = new Parser(richTbInputText.Text);
                int n = Convert.ToInt32(tbDepth.Text);
                if (rbWord.Checked)
                {
                    string[][] words = parser.GetArraysOfNnumberOfWords(n);
                    Ngram[] ngramList = parser.GetListOfNgramBranches(words);
                    Ngram root = parser.Merge(ngramList);
                    root.SetIndex(0);
                    root.SetLevel(0);
                    root.SetIndexForChildrenNode(root.GetMaxNrChildren());
                    BFSHandler bFSHandler = new BFSHandler(root);
                    //listBox1.Items.Add(root.GetMaxNrChildren());
                    foreach (Ngram c in bFSHandler.GetListOfNgramsByLevel(2))
                    {
                        listBox1.Items.Add(c.GetWord() + " - " + c.GetFrequency() + " - " + c.GetProbability());
                    }

                    
                }
                else if (rbCharacter.Checked)
                {
                    string[][] chars = parser.GetArraysOfNnumberOfCharacters(n);
                    Ngram[] ngramList = parser.GetListOfNgramBranches(chars);
                    Ngram root = parser.Merge(ngramList);
                    foreach (Ngram c in root.GetChildren())
                    {
                        listBox1.Items.Add(c.GetWord() + " - " + c.GetFrequency());
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach (var series in chartNrOfChildren.Series)
            {
                series.Points.Clear();
            }

            if (richTbInputText.Text != "" && tbDepth.Text !="")
            {
                cmbNrOfChildrenHistogram.Items.Clear();
                parser = new Parser(richTbInputText.Text);
                int n = Convert.ToInt32(tbDepth.Text);
                if (rbWord.Checked)
                {
                    string[][] words = parser.GetArraysOfNnumberOfWords(n);
                    Ngram[] ngramList = parser.GetListOfNgramBranches(words);
                    root = parser.Merge(ngramList);
                    root.SetIndex(0);
                    root.SetLevel(0);
                    root.SetIndexForChildrenNode(root.GetMaxNrChildren());
                    for (int i = 0; i < n; i++)
                    {
                        cmbNrOfChildrenHistogram.Items.Add(i);
                    }
                    bFSHandler = new BFSHandler(root);                  
                }
                else if (rbCharacter.Checked)
                {
                    string[][] chars = parser.GetArraysOfNnumberOfCharacters(n);
                    Ngram[] ngramList = parser.GetListOfNgramBranches(chars);
                    root = parser.Merge(ngramList);
                    root.SetIndex(0);
                    root.SetLevel(0);
                    root.SetIndexForChildrenNode(root.GetMaxNrChildren());
                    for (int i = 0; i < n; i++)
                    {
                        cmbNrOfChildrenHistogram.Items.Add(i);
                    }
                    bFSHandler = new BFSHandler(root);
                }
            }
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewTree_Click(object sender, EventArgs e)
        {
            if (root != null)
            {
                TreeGenerator treeGenerator = new TreeGenerator(root);
                treeGenerator.GenerateTreeImage();
                pbNgram.ImageLocation = "ngramTree.png";         
            }
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            richTbInputText.Clear();
            foreach (var series in chartNrOfChildren.Series)
            {
                series.Points.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnShowHistogramOfNrOfChildren_Click(object sender, EventArgs e)
        {
            foreach (var series in chartNrOfChildren.Series)
            {
                series.Points.Clear();
            }
            if (root != null)
            {             
                List<Ngram> ngramsAtGivenLevel = bFSHandler.GetListOfNgramsByLevel(Convert.ToInt32(cmbNrOfChildrenHistogram.SelectedItem));          
                List<int> distictNrOfChildren = bFSHandler.GetDistinctNrOfChildren(ngramsAtGivenLevel);
                foreach (int nrOfChildren in distictNrOfChildren)
                {
                    chartNrOfChildren.Series["Number of nodes"].Points.AddXY(nrOfChildren+" child(ren)", bFSHandler.GetNrOfNodesWithXNrOfChildren(nrOfChildren, ngramsAtGivenLevel));
                    listBox1.Items.Add(nrOfChildren);
                }
                
            }

        }
    }
}
