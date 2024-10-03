using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class TestClock
    {
        // arrange
        Clock clock;

        [SetUp]
        public void SetUp()
        {

            clock = new Clock("testClock");
        }

        // act and assert
        [Test]
        public void TestInitialise()
        {
            Assert.That(clock.Seconds.Ticks, Is.EqualTo(0));
            Assert.That(clock.Minutes.Ticks, Is.EqualTo(0));
            Assert.That(clock.Hours.Ticks, Is.EqualTo(0));
        }

        [Test]
        public void TestTick()
        {
            clock.Tick();
            Assert.That(clock.Seconds.Ticks, Is.EqualTo(1));
        }

        [Test]
        public void TestReset()
        {
            clock.Reset();
            Assert.That(clock.Seconds.Ticks, Is.EqualTo(0));
            Assert.That(clock.Minutes.Ticks, Is.EqualTo(0));
            Assert.That(clock.Hours.Ticks, Is.EqualTo(0));

        }

        [Test]
        public void GetCurrentTime()
        {
            for (int i = 0; i < 30; i++)
            {
                clock.Tick();
                
            }
            string currentTime = clock.GetCurrentTime();
            Assert.That(currentTime, Is.EqualTo("00:00:30"));
        }



    }
}
