using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    [TestFixture]
    public class TestCounter
    {
        // arrange
        private Counter _counter;

        [SetUp]
        public void SetUp()
        {
            
            _counter = new Counter("test");
        }

        // act and assert
        [Test]
        public void TestInitialise()
        {
            Assert.That(_counter.Ticks, Is.EqualTo(0));
        }

        [Test]
        public void TestIncrement()
        {
            _counter.Increment();
            Assert.That(_counter.Ticks, Is.EqualTo(1));
        }

        [Test]
        public void TestIncrementMultiple()
        {
            _counter.Increment();
            _counter.Increment();
            _counter.Increment();
            Assert.That(_counter.Ticks, Is.EqualTo(3));
        }

        [Test]
        public void TestReset()
        {
            _counter.Increment();
            _counter.Increment();
            _counter.Increment();
            _counter.Reset();
            Assert.That(_counter.Ticks, Is.EqualTo(0));
        }
    }
}
