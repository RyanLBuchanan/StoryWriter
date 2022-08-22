using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryWriter
{
    public partial class StoryWriterForm : Form
    {
        public StoryWriterForm()
        {
            InitializeComponent();
        }

        private void generateStoryButton_Click(object sender, EventArgs e)
        {
            Words words = new Words();
            const int numberOfSentences = 10;

            outputTextBox.Clear();

            for (var i = 0; i < numberOfSentences; i++)
            {
                outputTextBox.Text += words.GenerateSentence() + Environment.NewLine;
            }
        }
    }
}
