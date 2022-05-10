using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CometaReader
{
    public partial class MainForm : Form
    {
        private bool isOpen = false; //if doc was opened
        private string[] strippedText; //text, splitted by spaces
        private bool isStop = false; //if stop button was clicked
        private int lastWordIndex = 0; //store last shown word index
        
        public MainForm()
        {
            InitializeComponent();
            playButton.Enabled = false;
            pauseButton.Enabled = false;
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            //reading the file
            string text = System.IO.File.ReadAllText(filename);
            strippedText = text.Split(' '); //split by space

            if (text.Length == 0)
            {
                MessageBox.Show("File is empty!");
            }
            else
            {
                isOpen = true;
                playButton.Enabled = true;
            }
        }

        //we need to center the text by the second word. So we need to add spaces to start or end of the displayed text
        private int countChars(string[] words, int index)
        {
            string firstWord = "";
            string secondWord = "";
            string thirdWord = "";
            if (index != 0)
            {
                firstWord = words[index - 1];
            }
            secondWord = words[index];
            if (index + 1 < words.Length)
            {
                thirdWord = words[index + 1];
            }

            int lenOfFirstWord = firstWord.Length;
            int lenOfThirdWord = thirdWord.Length;
            int dif = lenOfFirstWord - lenOfThirdWord;

            return dif; 
        }
        
        //coloring the text (by selection in the RichTextEdit)
        private void colorText(string[] words, int index, int dif)
        {
            int addedDif = dif >= 0 ? 0 : Math.Abs(dif);

            bool isStartWord = false;
            if (index == 0)
            {
                isStartWord = true;
            }

            if (isStartWord)
            {
                richTextBox.Select(0, words[index].Length + addedDif);
                richTextBox.SelectionColor = Color.Black;
                if (words.Length != 1)
                {
                    richTextBox.Select(1 + words[index].Length + +addedDif, 1 + words[index].Length + +addedDif + words[index + 1].Length);
                    richTextBox.SelectionColor = Color.Gray;
                }
            }
            else
            {
                richTextBox.Select(0, words[index-1].Length + addedDif);
                richTextBox.SelectionColor = Color.Gray;
                richTextBox.Select(words[index - 1].Length + 1 + addedDif, words[index - 1].Length + 1 + addedDif + words[index].Length);
                richTextBox.SelectionColor = Color.Black;
                if (index + 1 < words.Length)
                {
                    richTextBox.Select(words[index - 1].Length + 2 + words[index].Length + addedDif, words[index - 1].Length + 2 + words[index].Length + words[index + 1].Length + addedDif);
                    richTextBox.SelectionColor = Color.Gray;
                }
            }

        }

        //we use async for the async sleep (this avoids freezing)
        async private void playButton_Click(object sender, EventArgs e)
        {
            isStop = false;
            playButton.Enabled = false;
            pauseButton.Enabled = true;
            int dif = 0; //spaces for the text allignment

            //if text from the file exists and file is open
            if (strippedText.Length > 0 && isOpen)
            {
                for (int i = lastWordIndex; i < strippedText.Length; i++)
                {
                    statLabel.Text = (i + 1) + " of " + strippedText.Length + " words"; //text for the counter of words
                    richTextBox.Clear();

                    //count the needed spaces
                    dif = countChars(strippedText, i);

                    //displaying the text
                    if ((i - 1) > -1)
                    {
                        richTextBox.AppendText(strippedText[i-1]);
                        richTextBox.AppendText(" ");
                        richTextBox.AppendText(strippedText[i]);
                    }
                    else
                    {
                        richTextBox.AppendText(strippedText[i]);
                    }

                    if ((i + 1) < (strippedText.Length))
                    {
                        richTextBox.AppendText(" ");
                        richTextBox.AppendText(strippedText[i+1]);
                    }

                    //adding spaces
                    for (int j = 0; j < Math.Abs(dif); j++)
                    {
                        if (dif >= 0)
                        {
                            richTextBox.Text += " ";
                        }
                        else
                        {
                            richTextBox.Text = " " + richTextBox.Text;
                        }    
                    }

                    //coloring
                    colorText(strippedText, i, dif);

                    //sleep for the next iteration
                    await Task.Delay((int)numericUpDown.Value * 10);

                    if (isStop)
                    {
                        lastWordIndex = i;
                        break;
                    }
                }

                if (!isStop)
                {
                    playButton.Enabled = false;
                    pauseButton.Enabled = false;
                }
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            isStop = true;
            playButton.Enabled = true;
            pauseButton.Enabled = false;
        }

    }
}
