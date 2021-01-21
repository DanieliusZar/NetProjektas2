using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace BibliotekaTEST
{
    public interface StarWars
    {
        IList<Film> GetFilms();
        IList<Character> GetCharacters();
    }

    class Response <T>
    {
        public IList<T> Results { get; set; }
       // public IList<T> Result  { get; set; }
    }

    public class Provider : StarWars
    {
        private static  HttpClient client = new HttpClient();
        public IList<Film> GetFilms()
        {
                if(client.BaseAddress == null)
                {
                    client.BaseAddress = new Uri("https://swapi.dev/api/");
                }

                string filmsJson = client.GetStringAsync("films").Result;
                var filmList = JsonConvert.DeserializeObject<Response<Film>>(filmsJson);
                return filmList.Results;
        }

        public IList<Character> GetCharacters()
        {
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri("https://swapi.dev/api/");
            }

            string charactersJson = client.GetStringAsync("people").Result;
            var charactersList = JsonConvert.DeserializeObject<Response<Character>>(charactersJson);
            return charactersList.Results;
        }

    }

    public class CashingProvider : StarWars
    {
        private readonly StarWars m_provider;
        private IList<Film> m_films = null;
        private IList<Character> m_characters = null;
        public CashingProvider(StarWars provider)
        {
            m_provider = provider;
        }

        public IList<Film> GetFilms()
        {
            if(m_films != null)
            {
                return m_films;
            }

            return m_films = m_provider.GetFilms();
        }

        public IList<Character> GetCharacters()
        {
            if(m_characters != null)
            {
                return m_characters;
            }

            return m_characters = m_provider.GetCharacters();
        }
    }

}
