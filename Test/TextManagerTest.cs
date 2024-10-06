using ConsoleP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;

namespace Test
{
    
    public class TextManagerTest
    {
        TextManager textManagerGloabl;
        public TextManagerTest()
        {
            textManagerGloabl = new TextManager("hola hola este es un texto de prueba");
        }

        [Theory]
        [InlineData("Hola mundo", 2)]
        [InlineData("", 0)]
        public void CountWords(string text, int expected)
        {
            //Arrange
            var textmanager = new TextManager(text);

            //Act
            var result = textmanager.CountWords();

            //Assert
            //Assert.True(result > 1);
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(TestManagerClassData))]
        public void CountWords_ClassData(string text, int expected)
        {
            //Arrange
            var textmanager = new TextManager(text);

            //Act
            var result = textmanager.CountWords();

            //Assert
            //Assert.True(result > 1);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindWord()
        {
            //Arrange 
            //var textManager = new TextManager("hola hola este es un texto de prueba");

            var result = textManagerGloabl.FindWord("hola", false);

            Assert.Contains(0, result);
        }

        [Fact]
        public void FindExactWord()
        {
            //Arrange 
            //var textManager = new TextManager("hola hola este es un texto de prueba");

            var result = textManagerGloabl.FindExactWord("hola", true);

            Assert.IsType<List<Match>>(result);
        }

        [Fact]
        public void FindExactWord_Exception()
        {
            //Arrange 
            //var textManager = new TextManager("hola hola este es un texto de prueba");


            Assert.ThrowsAny<Exception>(() => textManagerGloabl.FindExactWord(null, true));
        }


    }
}
