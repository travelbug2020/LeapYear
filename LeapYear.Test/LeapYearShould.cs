using NUnit.Framework;

namespace LeapYear.Test
{
    public class LeapYearShould
    {
        [Test]
        public void ReturnTrueIfYearIs2000()
        {
            var leapYears = new LeapYears();
            
            var result = leapYears.Calculate(2000);
            
            Assert.AreEqual(true, result);
        }

        [Test]
        public void ReturnTrueIfYearIs4000()
        {
            var leapYears = new LeapYears();
           
            var result = leapYears.Calculate(4000);
            
            Assert.AreEqual(true, result);
        }

        [Test]
        public void ReturnTrueIfYearIs6000()
        {
            var leapYears = new LeapYears();
           
            var result = leapYears.Calculate(6000);
            
            Assert.AreEqual(true, result);
        }

        [Test]
        public void ReturnTrueIfYearIsDivisibleBy400()
        {
            var leapYears = new LeapYears();
           
            var result = leapYears.Calculate(8000);
            
            Assert.AreEqual(true, result);
        }

        public void ReturnFalseIfDivisibleBy100ButNotBy400()
        {
            var leapYears = new LeapYears();
            
            var result = leapYears.Calculate(1700);
            
            Assert.AreEqual(false, result);
        }

        public void ReturnTrueIfDivisibleBy4ButNotBy100()
        {
            var leapYears = new LeapYears();
            
            var result = leapYears.Calculate(2008);
           
            Assert.AreEqual(true, result);
        }

        public void ReturnFalseIfNotDivisibleBy4()
        {
            var leapYears = new LeapYears();
            
            var result = leapYears.Calculate(2017);
            
            Assert.AreEqual(false, result);
        }

        



    }
}