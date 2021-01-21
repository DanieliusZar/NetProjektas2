using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotekaTEST;

namespace ManoProjektas
{
    public partial class FilmForm : Form
    {
        public FilmForm()
        {
            InitializeComponent();
            
        }

        public FilmForm(string title, string episode, string director, string producer, List<String> characters, string releaseDate, Image filmImage)
        {
            InitializeComponent();
            title_P.Text = title;
            episode_P.Text = episode;
            director_P.Text = director;
            producer_P.Text = producer;
            releaseDate_P.Text = releaseDate;
            pictureBox1.BackgroundImage = filmImage;

            foreach (String characterName in characters)
            {
                charactersView.Items.Add(characterName);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void title_P_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void episode_P_Click(object sender, EventArgs e)
        {

        }
    }
}
