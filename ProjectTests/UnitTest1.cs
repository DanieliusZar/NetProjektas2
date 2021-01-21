using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotekaTEST;
using System.Collections.Generic;
namespace ProjectTests
{


    class TestProvider : StarWars
    {

        public IList<Film> Films;
        public IList<Character> Characters;
        public int GetFilmsCounter { get; private set; }
        public int GetCharacterCounter { get; private set; }
        public IList<Film> GetFilms()
        {
            GetFilmsCounter++;
            return Films;
        }

        public IList<Character> GetCharacters()
        {
            GetCharacterCounter++;
            return Characters;
        }
    }


    
        [TestClass]
     public class testMehtod
    {
        [TestMethod]
        public void testFilmCaching()
        {
            var testProv = new TestProvider { Films = new List<Film> { new Film { Title = "testTitle" } } };
            var cachingProvider = new CashingProvider(testProv);
            
            var films1 = cachingProvider.GetFilms();
            Assert.AreEqual(1, testProv.GetFilmsCounter);

            var films2 = cachingProvider.GetFilms();

            Assert.AreEqual(1, testProv.GetFilmsCounter);
            Assert.AreEqual(films1, films2);
        }

        [TestMethod]
        public void testCharacterCaching()
        {
            var testProv = new TestProvider { Characters = new List<Character> { new Character { Name = "testName" } } };
            var cachingProvider = new CashingProvider(testProv);

            var characters1 = cachingProvider.GetCharacters();
            Assert.AreEqual(1, testProv.GetCharacterCounter);

            var characters2 = cachingProvider.GetCharacters();
            Assert.AreEqual(1, testProv.GetCharacterCounter);

            Assert.AreEqual(characters1, characters2);
        }

    }
}
