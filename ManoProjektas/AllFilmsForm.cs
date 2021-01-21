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
    public partial class AllFilmsForm : Form
    {
        private StarWars repo = new CashingProvider(new Provider());
        public AllFilmsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FirstMovie_Click(object sender, EventArgs e)
        {
            List<String> characterNames = new List<String>();
            var films = repo.GetFilms();
            var characters = repo.GetCharacters();
            Film film = films[0];
            characterNames = getCharacterNames(film, characters);
            FilmForm f2 = new FilmForm(film.Title, film.Episode, film.Director, film.Producer, characterNames, film.ReleaseDate, FirstMovie.BackgroundImage);
            f2.ShowDialog();
        }

        private void SecondMovie_Click(object sender, EventArgs e)
        {
            List<String> characterNames = new List<String>();
            var films = repo.GetFilms();
            var characters = repo.GetCharacters();
            Film film = films[1];
            characterNames = getCharacterNames(film, characters);
            FilmForm f2 = new FilmForm(film.Title, film.Episode, film.Director, film.Producer, characterNames, film.ReleaseDate, SecondMovie.BackgroundImage);
            f2.ShowDialog();

        }

        private void ThirdMovie_Click(object sender, EventArgs e)
        {
            List<String> characterNames = new List<String>();
            var films = repo.GetFilms();
            var characters = repo.GetCharacters();
            Film film = films[2];
            characterNames = getCharacterNames(film, characters);

            FilmForm f2 = new FilmForm(film.Title, film.Episode, film.Director, film.Producer, characterNames, film.ReleaseDate, ThirdMovie.BackgroundImage);
            f2.ShowDialog();
        }

        private void FourthMovie_Click(object sender, EventArgs e)
        {
            List<String> characterNames = new List<String>();
            var films = repo.GetFilms();
            var characters = repo.GetCharacters();
            Film film = films[3];

            characterNames = getCharacterNames(film, characters);
            FilmForm f2 = new FilmForm(film.Title, film.Episode, film.Director, film.Producer, characterNames, film.ReleaseDate, FourthMovie.BackgroundImage);
            f2.ShowDialog();
        }

        private void FifthMovie_Click(object sender, EventArgs e)
        {
            List<String> characterNames = new List<String>();
            var films = repo.GetFilms();
            var characters = repo.GetCharacters();
            Film film = films[4];

            characterNames = getCharacterNames(film, characters);
            FilmForm f2 = new FilmForm(film.Title, film.Episode, film.Director, film.Producer, characterNames, film.ReleaseDate, FifthMovie.BackgroundImage);
            f2.ShowDialog();
        }

        private void SixthMovie_Click(object sender, EventArgs e)
        {
            List<String> characterNames = new List<String>();
            var films = repo.GetFilms();
            var characters = repo.GetCharacters();

            Film film = films[5];

            characterNames = getCharacterNames(film, characters);

            FilmForm f2 = new FilmForm(film.Title, film.Episode, film.Director, film.Producer, characterNames, film.ReleaseDate, SixthMovie.BackgroundImage);
            f2.ShowDialog();
        }

        public List<String> getCharacterNames(Film film, IList<Character> characters)
        {
            List<String> filmCharacterLinks = new List<String>();
            List<String> characterNames = new List<String>();


            foreach (String loopFilmCharacter in film.Characters)
            {
                filmCharacterLinks.Add(loopFilmCharacter);
            }

            foreach (Character loopCharacter in characters)
            {
                
                if (filmCharacterLinks.Contains(loopCharacter.Url))
                {
                    characterNames.Add(loopCharacter.Name);
                }
            }
            return characterNames;
        }
    }
}
