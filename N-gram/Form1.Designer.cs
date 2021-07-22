namespace N_gram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.richTbInputText = new System.Windows.Forms.RichTextBox();
            this.richTbOuputText = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNrOfChildrenHistogram = new System.Windows.Forms.ComboBox();
            this.btnShowHistogramOfNrOfChildren = new System.Windows.Forms.Button();
            this.chartNrOfChildren = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.tbReadFromFile = new System.Windows.Forms.TextBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnViewTree = new System.Windows.Forms.Button();
            this.rbWord = new System.Windows.Forms.RadioButton();
            this.rbCharacter = new System.Windows.Forms.RadioButton();
            this.tbMaxChildren = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnClearOutputTb = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxSmartToken = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbNgram = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNrOfChildren)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNgram)).BeginInit();
            this.SuspendLayout();
            // 
            // richTbInputText
            // 
            this.richTbInputText.Location = new System.Drawing.Point(24, 117);
            this.richTbInputText.Name = "richTbInputText";
            this.richTbInputText.Size = new System.Drawing.Size(530, 258);
            this.richTbInputText.TabIndex = 0;
            this.richTbInputText.Text = "";
            this.richTbInputText.TextChanged += new System.EventHandler(this.richTbInputText_TextChanged);
            // 
            // richTbOuputText
            // 
            this.richTbOuputText.Location = new System.Drawing.Point(21, 117);
            this.richTbOuputText.Name = "richTbOuputText";
            this.richTbOuputText.Size = new System.Drawing.Size(505, 258);
            this.richTbOuputText.TabIndex = 1;
            this.richTbOuputText.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 27);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Parse";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbDepth
            // 
            this.tbDepth.Location = new System.Drawing.Point(168, 22);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(48, 22);
            this.tbDepth.TabIndex = 3;
            this.tbDepth.Text = "1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnClearInput);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbNrOfChildrenHistogram);
            this.panel1.Controls.Add(this.btnShowHistogramOfNrOfChildren);
            this.panel1.Controls.Add(this.chartNrOfChildren);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbReadFromFile);
            this.panel1.Controls.Add(this.btnReadFile);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnViewTree);
            this.panel1.Controls.Add(this.rbWord);
            this.panel1.Controls.Add(this.rbCharacter);
            this.panel1.Controls.Add(this.tbMaxChildren);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTbInputText);
            this.panel1.Controls.Add(this.tbDepth);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 719);
            this.panel1.TabIndex = 4;
            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(24, 387);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(81, 36);
            this.btnClearInput.TabIndex = 18;
            this.btnClearInput.Text = "Clear";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Level";
            // 
            // cmbNrOfChildrenHistogram
            // 
            this.cmbNrOfChildrenHistogram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNrOfChildrenHistogram.FormattingEnabled = true;
            this.cmbNrOfChildrenHistogram.Location = new System.Drawing.Point(433, 399);
            this.cmbNrOfChildrenHistogram.Name = "cmbNrOfChildrenHistogram";
            this.cmbNrOfChildrenHistogram.Size = new System.Drawing.Size(121, 24);
            this.cmbNrOfChildrenHistogram.TabIndex = 16;
            this.cmbNrOfChildrenHistogram.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnShowHistogramOfNrOfChildren
            // 
            this.btnShowHistogramOfNrOfChildren.Location = new System.Drawing.Point(289, 387);
            this.btnShowHistogramOfNrOfChildren.Name = "btnShowHistogramOfNrOfChildren";
            this.btnShowHistogramOfNrOfChildren.Size = new System.Drawing.Size(138, 36);
            this.btnShowHistogramOfNrOfChildren.TabIndex = 15;
            this.btnShowHistogramOfNrOfChildren.Text = "Show Histogram";
            this.btnShowHistogramOfNrOfChildren.UseVisualStyleBackColor = true;
            this.btnShowHistogramOfNrOfChildren.Click += new System.EventHandler(this.btnShowHistogramOfNrOfChildren_Click);
            // 
            // chartNrOfChildren
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNrOfChildren.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNrOfChildren.Legends.Add(legend1);
            this.chartNrOfChildren.Location = new System.Drawing.Point(24, 438);
            this.chartNrOfChildren.Name = "chartNrOfChildren";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Number of nodes";
            this.chartNrOfChildren.Series.Add(series1);
            this.chartNrOfChildren.Size = new System.Drawing.Size(530, 278);
            this.chartNrOfChildren.TabIndex = 4;
            this.chartNrOfChildren.Text = "chart1";
            this.chartNrOfChildren.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "file:";
            // 
            // tbReadFromFile
            // 
            this.tbReadFromFile.Location = new System.Drawing.Point(250, 76);
            this.tbReadFromFile.Name = "tbReadFromFile";
            this.tbReadFromFile.Size = new System.Drawing.Size(166, 22);
            this.tbReadFromFile.TabIndex = 13;
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(422, 75);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(132, 23);
            this.btnReadFile.TabIndex = 12;
            this.btnReadFile.Text = "Read From File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unit";
            // 
            // btnViewTree
            // 
            this.btnViewTree.Location = new System.Drawing.Point(473, 20);
            this.btnViewTree.Name = "btnViewTree";
            this.btnViewTree.Size = new System.Drawing.Size(81, 27);
            this.btnViewTree.TabIndex = 10;
            this.btnViewTree.Text = "View tree";
            this.btnViewTree.UseVisualStyleBackColor = true;
            this.btnViewTree.Click += new System.EventHandler(this.btnViewTree_Click);
            // 
            // rbWord
            // 
            this.rbWord.AutoSize = true;
            this.rbWord.Checked = true;
            this.rbWord.Location = new System.Drawing.Point(115, 77);
            this.rbWord.Name = "rbWord";
            this.rbWord.Size = new System.Drawing.Size(63, 21);
            this.rbWord.TabIndex = 9;
            this.rbWord.TabStop = true;
            this.rbWord.Text = "Word";
            this.rbWord.UseVisualStyleBackColor = true;
            // 
            // rbCharacter
            // 
            this.rbCharacter.AutoSize = true;
            this.rbCharacter.Location = new System.Drawing.Point(24, 77);
            this.rbCharacter.Name = "rbCharacter";
            this.rbCharacter.Size = new System.Drawing.Size(91, 21);
            this.rbCharacter.TabIndex = 8;
            this.rbCharacter.Text = "Character";
            this.rbCharacter.UseVisualStyleBackColor = true;
            // 
            // tbMaxChildren
            // 
            this.tbMaxChildren.Location = new System.Drawing.Point(395, 22);
            this.tbMaxChildren.Name = "tbMaxChildren";
            this.tbMaxChildren.Size = new System.Drawing.Size(48, 22);
            this.tbMaxChildren.TabIndex = 7;
            this.tbMaxChildren.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max Nr. of Children:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Depth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.btnClearOutputTb);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.checkBoxSmartToken);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Controls.Add(this.chart2);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.richTbOuputText);
            this.panel2.Location = new System.Drawing.Point(614, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 716);
            this.panel2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Single Child Percentage";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(494, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 22);
            this.textBox2.TabIndex = 22;
            // 
            // btnClearOutputTb
            // 
            this.btnClearOutputTb.Location = new System.Drawing.Point(108, 71);
            this.btnClearOutputTb.Name = "btnClearOutputTb";
            this.btnClearOutputTb.Size = new System.Drawing.Size(81, 27);
            this.btnClearOutputTb.TabIndex = 21;
            this.btnClearOutputTb.Text = "Clear";
            this.btnClearOutputTb.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Generated Unit";
            // 
            // checkBoxSmartToken
            // 
            this.checkBoxSmartToken.AutoSize = true;
            this.checkBoxSmartToken.Location = new System.Drawing.Point(415, 74);
            this.checkBoxSmartToken.Name = "checkBoxSmartToken";
            this.checkBoxSmartToken.Size = new System.Drawing.Size(111, 21);
            this.checkBoxSmartToken.TabIndex = 19;
            this.checkBoxSmartToken.Text = "Smart Token";
            this.checkBoxSmartToken.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 22);
            this.textBox1.TabIndex = 18;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(21, 72);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(81, 26);
            this.btnGenerate.TabIndex = 17;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(21, 387);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(505, 278);
            this.chart2.TabIndex = 16;
            this.chart2.Text = "chart2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(64, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 196);
            this.listBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ouput";
            // 
            // pbNgram
            // 
            this.pbNgram.Location = new System.Drawing.Point(1158, 12);
            this.pbNgram.Name = "pbNgram";
            this.pbNgram.Size = new System.Drawing.Size(726, 716);
            this.pbNgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNgram.TabIndex = 15;
            this.pbNgram.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 749);
            this.Controls.Add(this.pbNgram);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNrOfChildren)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNgram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTbInputText;
        private System.Windows.Forms.RichTextBox richTbOuputText;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbDepth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnViewTree;
        private System.Windows.Forms.RadioButton rbWord;
        private System.Windows.Forms.RadioButton rbCharacter;
        private System.Windows.Forms.TextBox tbMaxChildren;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbReadFromFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNrOfChildren;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnClearOutputTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxSmartToken;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pbNgram;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbNrOfChildrenHistogram;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.Button btnShowHistogramOfNrOfChildren;
    }
}

