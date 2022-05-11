using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Anagram.Tests
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void Reverse_NullOrEmpty_String()
        {
            //arrange
            AnagramApp anagram = new AnagramApp();
            string arg = null;
            string expected = "String is null";
            //act
            string result = anagram.Reverse(arg);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reverse_String_ReverseString()
        {
            //arrange
            AnagramApp anagram = new AnagramApp();
            string arg = "  a1bcd    efg!h";
            string expected = "  d1cba    hgf!e";
            //act
            string result = anagram.Reverse(arg);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reverse_1Word_ReverseString()
        {
            //arrange
            AnagramApp anagram = new AnagramApp();
            string arg = "  a1bc2def    ";
            string expected = "  f1ed2cba    ";
            //act
            string result = anagram.Reverse(arg);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reverse_WordsWithOnlyLetter_ReverseString()
        {
            //arrange
            AnagramApp anagram = new AnagramApp();
            string arg = "abcde    xyz   asdfghg cvbn ";
            string expected = "edcba    zyx   ghgfdsa nbvc ";
            //act
            string result = anagram.Reverse(arg);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reverse_WordsWithoutLetter_ReverseString()
        {
            //arrange
            AnagramApp anagram = new AnagramApp();
            string arg = "123!4@    &&73 ?$23    ";
            string expected = "123!4@    &&73 ?$23    ";
            //act
            string result = anagram.Reverse(arg);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reverse_WordsWithOnlySpace_ReverseString()
        {
            //arrange
            AnagramApp anagram = new AnagramApp();
            string arg = "         ";
            string expected = "String is empty";
            //act
            string result = anagram.Reverse(arg);
            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reverse_5Words_ReverseString()
        {
            //arrange
            AnagramApp anagram = new AnagramApp();
            string arg = " qw1ert  a1sd!f@ zxcv    123?@4 fgh@@jk        ";
            string expected = " tr1ewq  f1ds!a@ vcxz    123?@4 kjh@@gf        ";
            //act
            string result = anagram.Reverse(arg);
            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
