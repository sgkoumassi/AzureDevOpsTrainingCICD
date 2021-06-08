using System;
using System.Collections.Generic;
using System.Text;
using TDDNUnit;
using NUnit.Framework;

namespace KataTest.Test
{
    [TestFixture]
    public class TestCalculateString
    {
        private CalculateString calculateString;

        [SetUp]
        public void setUp()
        {
            calculateString = new CalculateString();
        }

        [TestCase]
        public void shouldReturnZeroWhenNullOrEmptyString()
        {
            Assert.AreEqual(0, calculateString.calculateStr(""));
        }

        [TestCase]
        public void shouldReturValueWhenSingleValueReplied()
        {
            Assert.AreEqual(2, calculateString.calculateStr("2"));
        }

        [TestCase]
        public void shouldReturnSumWhenTwoValuesReplied()
        {
            Assert.AreEqual(8, calculateString.calculateStr("2,6"));
        }

        [TestCase]
        public void shouldReturnSumWhenTwoValuesRepliedNewLineDelimited()
        {
            Assert.AreEqual(8, calculateString.calculateStr("2\n6"));
        }

        [TestCase]
        public void shouldReturnSumWhenThreeValuesRepliedNewLineAndCommaDelimited()
        {
            Assert.AreEqual(9, calculateString.calculateStr("2\n6,1"));
        }

        [TestCase]
        public void shouldReturnSumWhenValuesWithNégativeValueReplied()
        {
            Assert.AreEqual(7, calculateString.calculateStr("2\n6,-1"));
        }

        [TestCase]
        public void shouldNégativeValueReplied()
        {
            Assert.AreEqual(-1, calculateString.calculateStr("-1"));
        }

        [TestCase]
        public void IgnoreNumbersGreaterThan1000ValueReplied()
        {
            Assert.AreEqual(6, calculateString.calculateStr("1000,1,2\n3"));
        }
    }
}
