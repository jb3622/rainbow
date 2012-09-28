using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RainbowApp
{
    public partial class FormRainbow : Form
    {
        public FormRainbow()
        {
            InitializeComponent();    
        }

        public List<string> RainbowColoursList()
        {
            List<string> ColoursOfTheRainbow = new List<string>();
            ColoursOfTheRainbow.Add("Red");
            ColoursOfTheRainbow.Add("Orange");
            ColoursOfTheRainbow.Add("Yellow");
            ColoursOfTheRainbow.Add("Green");
            ColoursOfTheRainbow.Add("Blue");
            ColoursOfTheRainbow.Add("Indigo");
            ColoursOfTheRainbow.Add("Violet");

            return (ColoursOfTheRainbow);
        }

        public List<string> Alphabetise(List<string> words)
        {
            words.Sort();
            return (words);
        }

        private void bttnAlphabetise_Click(object sender, EventArgs e)
        {
            List<string> OrderedColours = Alphabetise(RainbowColoursList());

            int i = 1;
            //MessageBox.Show("The colours of the rainbow will show alphabetically");
            foreach(string colour in OrderedColours)
            {
                MessageBox.Show(colour, "Colour" + i++ + "[alphabetical]");
            }
        }

        private void bttnDisplayUnsorted_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (string colour in RainbowColoursList())
            {
                MessageBox.Show(colour, "Colour" + i++);
            }
        }

    }
}
