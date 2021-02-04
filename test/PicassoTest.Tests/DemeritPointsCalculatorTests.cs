using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace PicassoTest.Tests
{
    class DemeritPointsCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateDemeritPoints_SpeedUnder0_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            
            var calculator = new DemeritPointsCalculator ();

            //Act
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(-3));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedOverMax_ThrowsArgumentOutOfRangeException()
        {
            //Arrange

            var calculator = new DemeritPointsCalculator();

            //Act
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(301));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedEqualsLimit_Returns0()
        {
            //Arrange
            var calculator = new DemeritPointsCalculator();

            //Act
            var result = calculator.CalculateDemeritPoints(65);

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedUnderLimit_Returns0()
        {
            //Arrange
            var calculator = new DemeritPointsCalculator();

            //Act
            var result = calculator.CalculateDemeritPoints(64);

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedOverLimit_ReturnsNumber()
        {
            //Arrange
            var calculator = new DemeritPointsCalculator();

            //Act
            var result = calculator.CalculateDemeritPoints(100);

            //Assert
            Assert.That(result, Is.EqualTo(7));
        }
    }
}