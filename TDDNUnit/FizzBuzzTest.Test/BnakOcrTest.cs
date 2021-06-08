using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDDNUnit;

namespace KataTest.Test
{

//    #region BankOcr

//    [NUnit.Framework.TestFixture]
//    public class BnakOcrTest
//    {
//        private BankOcrNumbers OcrNumbers;

//        [SetUp]
//        public void setUp()
//        {
//            OcrNumbers = new BankOcrNumbers();
//        }

        
//        [TestCase]
//        public void Recognizes_0()
//        {
//            var rows =
//                " _ \n" +
//                "| |\n" +
//                "|_|\n" +
//                "   ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("0", actual);
//        }

//        [TestCase]
//        public void Recognizes_1()
//        {
//            var rows =
//                "   \n" +
//                "  |\n" +
//                "  |\n" +
//                "   ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("1", actual);
//        }

//        [TestCase]
//        public void Unreadable_but_correctly_sized_inputs_return_()
//        {
//            var rows =
//                "   \n" +
//                "  _\n" +
//                "  |\n" +
//                "   ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("?", actual);
//        }

//        [TestCase]
//        public void Input_with_a_number_of_lines_that_is_not_a_multiple_of_four_raises_an_error()
//        {
//            var rows =
//                " _ \n" +
//                "| |\n" +
//                "   ";
//            Assert.Throws<ArgumentException>(() => OcrNumbers.Convert(rows));
//        }

//        [TestCase]
//        public void Input_with_a_number_of_columns_that_is_not_a_multiple_of_three_raises_an_error()
//        {
//            var rows =
//                "    \n" +
//                "   |\n" +
//                "   |\n" +
//                "    ";
//            Assert.Throws<ArgumentException>(() => OcrNumbers.Convert(rows));
//        }

//        [TestCase]
//        public void Recognizes_110101100()
//        {
//            var rows =
//                "       _     _        _  _ \n" +
//                "  |  || |  || |  |  || || |\n" +
//                "  |  ||_|  ||_|  |  ||_||_|\n" +
//                "                           ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("110101100", actual);
//        }

//        [TestCase]
//        public void Garbled_numbers_in_a_string_are_replaced_with_()
//        {
//            var rows =
//                "       _     _           _ \n" +
//                "  |  || |  || |     || || |\n" +
//                "  |  | _|  ||_|  |  ||_||_|\n" +
//                "                           ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("11?10?1?0", actual);
//        }

//        [TestCase]
//        public void Recognizes_2()
//        {
//            var rows =
//                " _ \n" +
//                " _|\n" +
//                "|_ \n" +
//                "   ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("2", actual);
//        }

//        [TestCase]
//        public void Recognizes_3()
//        {
//            var rows =
//                " _ \n" +
//                " _|\n" +
//                " _|\n" +
//                "   ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("3", actual);
//        }

//        [TestCase]
//        public void Recognizes_4()
//        {
//            var rows =
//                "   \n" +
//                "|_|\n" +
//                "  |\n" +
//                "   ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("4", actual);
//        }

//        [TestCase]
//        public void Recognizes_5()
//        {
//            var rows =
//                " _ \n" +
//                "|_ \n" +
//                " _|\n" +
//                "   ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("5", actual);
//        }

//        [TestCase]
//        public void Recognizes_6()
//        {
//            var rows =
//                " _ \n" +
//                "|_ \n" +
//                "|_|\n" +
//                "   ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("6", actual);
//        }

//        [TestCase]
//        public void Recognizes_7()
//        {
//            var rows =
//                " _ \n" +
//                "  |\n" +
//                "  |\n" +
//                "   ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("7", actual);
//        }

//        [TestCase]
//        public void Recognizes_8()
//        {
//            var rows =
//                " _ \n" +
//                "|_|\n" +
//                "|_|\n" +
//                "   ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("8", actual);
//        }

//        [TestCase]
//        public void Recognizes_9()
//        {
//            var rows =
//                " _ \n" +
//                "|_|\n" +
//                " _|\n" +
//                "   ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("9", actual);
//        }

//        [TestCase]
//        public void Recognizes_string_of_decimal_numbers()
//        {
//            var rows =
//                "    _  _     _  _  _  _  _  _ \n" +
//                "  | _| _||_||_ |_   ||_||_|| |\n" +
//                "  ||_  _|  | _||_|  ||_| _||_|\n" +
//                "                              ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("1234567890", actual);
//        }

//        [TestCase]
//        public void Numbers_separated_by_empty_lines_are_recognized_lines_are_joined_by_commas_()
//        {
//            var rows =
//                "    _  _ \n" +
//                "  | _| _|\n" +
//                "  ||_  _|\n" +
//                "         \n" +
//                "    _  _ \n" +
//                "|_||_ |_ \n" +
//                "  | _||_|\n" +
//                "         \n" +
//                " _  _  _ \n" +
//                "  ||_||_|\n" +
//                "  ||_| _|\n" +
//                "         ";
//            var actual = OcrNumbers.Convert(rows);
//            Assert.AreEqual("123,456,789", actual);
//        }
//    }
//    #endregion
}
