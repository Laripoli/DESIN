using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace PicassoTest.Tests
{
    class ReservationComplexTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PayReservation_MoreMoneyThanPrice_Returns0()
        {
            //Arrange
            var reservation = new ReservationComplex { Price = 10};

            //Act
            var result = reservation.PayReservation(new UserComplex()
            {
                Money = 11
            });

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void PayReservation_LessMoneyThanPrice_ThrowsNotImplementedException()
        {
            //Arrange
            var reservation = new ReservationComplex { Price = 10 };

            //Act
            var user = new UserComplex { Money = 9 };
            
            //Assert
            Assert.Throws<NotImplementedException>(() => reservation.PayReservation(user));
        }
    }
}
