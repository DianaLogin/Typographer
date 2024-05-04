
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Typographer;
using static System.Net.Mime.MediaTypeNames;


namespace Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEvery_Second_Letter_Upper()
        {
            var text = "hello world";
            var expected = "HeLlO WoRlD";
            Assert.AreEqual(expected, Typograph_Form.Every_Second_Letter_Upper(ref text));
        }

        [TestMethod]
        public void TestReplace_Every_Second_Word_Heart()
        {
            var text = "Hello World";
            var expected = "Hello ❤";
            Assert.AreEqual(expected, Typograph_Form.Replace_Every_Second_Word_Heart(ref text));
        }

        [TestMethod]
        public void TestAddNonBreakingSpaceWithLettersAndDigits()
        {
            var text = "123дня 456дождя";
            var expected = "123 дня 456 дождя";
            var result = Typograph_Form.Add_Non_Breaking_Space(ref text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAddNonBreakingSpaceWithOnlyLetters()
        {
            var text = "1кг";
            var expected = "1 кг";
            
            Assert.AreEqual(expected, Typograph_Form.Add_Non_Breaking_Space(ref text));
        }

        [TestMethod]
        public void TestReplace_Ellipsis()
        {
            var text = "Hello...World";
            var expected = "Hello…World";
            Assert.AreEqual(expected, Typograph_Form.Replace_Ellipsis(ref text));
        }

        [TestMethod]
        public void TestReplace_Plus_Minus()
        {
            var text = "Всё+-хорошо";
            var expected = "Всё±хорошо";
            Assert.AreEqual(expected, Typograph_Form.Replace_Plus_Minus(ref text));
        }

        [TestMethod]
        public void TestReplace_Quotes()
        {
            var text = "\"Всё\" хорошо";
            var expected = "«Всё» хорошо";
            Assert.AreEqual(expected, Typograph_Form.Replace_Quotes(ref text));
        }

        [TestMethod]
        public void TestReplace_Dash_To_Minus()
        {
            var text = "4-5";
            var expected = "4−-5";
            Assert.AreEqual(expected, Typograph_Form.Replace_Dash_To_Minus(ref text));
        }

        [TestMethod]
        public void TestTrue_Punctuation()
        {
            var text = "Hello,World How are you?";
            var expected = "Hello, World How are you?";
            Assert.AreEqual(expected, Typograph_Form.True_Punctuation(ref text));
        }

        [TestMethod]
        public void TestReplace_Quotes2()
        {
            var text = "\"Всё\" хорошо \"было\"";
            var expected = "«Всё» хорошо «было»";
            Assert.AreEqual(expected, Typograph_Form.Replace_Quotes(ref text));
        }

    }
}
