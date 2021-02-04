using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace PicassoTest.Tests
{
    class FizzBuzzTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetOutput_NumberIsMultipleOf3And5_ReturnsFizzBuzz()
        {

            //Act
            var result = FizzBuzz.GetOutput(15);

            //Assert
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_NumberIsMultipleOf3_ReturnsFizz()
        {

            //Act
            var result = FizzBuzz.GetOutput(3);

            //Assert
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_NumberIsMultipleOf5_ReturnsBuzz()
        {

            //Act
            var result = FizzBuzz.GetOutput(5);

            //Assert
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_NumberIsNotMultipleOf3Or5_ReturnsNumberInString()
        {

            //Act
            var result = FizzBuzz.GetOutput(7);

            //Assert
            Assert.That(result, Is.EqualTo("7"));
        }
    }
}