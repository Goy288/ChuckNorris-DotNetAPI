using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;

namespace FactDispenser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            IEnumerable<string> categories = Task.Run(() => ChuckNorrisClient.GetCategories()).Result;
            InitializeComponent();
            foreach (var cat in categories)
            {
                cBoxTypes.Items.Add(cat);
            }
            cBoxTypes.SelectedIndex = 0;
        }

        private async void BtnDispense_Click(object sender, EventArgs e)
        {
            Joke j = await ChuckNorrisClient.GetRandomJoke();
            lblFact.Text = j.JokeText;
        }
    }
}
