using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Sub_Valid_Hernandez()
        {
            Assert.AreEqual(3, Program.Subtract("3", "0"));
            Assert.AreEqual(0, Program.Subtract("0", "0"));
            Assert.AreEqual(10, Program.Subtract("20", "10"));
        }
        [Test]
        public void Sub_Invalid_Hernandez()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }
        [Test]
        public void Sub_Null_Hernandez()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        [Test]
        public void Div_Valid_Hernandez()
        {
            Assert.AreEqual(3, Program.Divide("6", "2"));
            Assert.AreEqual(5, Program.Divide("10", "2"));
            Assert.AreEqual(6, Program.Divide("60", "10"));
        }
        [Test]
        public void Div_Invalid_Hernandez()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }
        [Test]
        public void Div_Null_Hernandez()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        [Test]
        public void Mult_Valid_Hernandez()
        {
            Assert.AreEqual(0, Program.Multiply("3", "0"));
            Assert.AreEqual(1, Program.Multiply("1", "1"));
            Assert.AreEqual(70, Program.Multiply("7", "10"));
        }
        [Test]
        public void Mult_Invalid_Hernandez()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }
        [Test]
        public void Mult_Null_Hernandez()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        [Test]
        public void Pow_Valid_Hernandez()
        {
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(2, Program.Power("2", "1"));
            Assert.AreEqual(1, Program.Power("1", "0"));
        }
        [Test]
        public void Pow_Invalid_Hernandez()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }
        [Test]
        public void Pow_Null_Hernandez()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
