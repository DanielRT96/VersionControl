using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    class AccountControllerPasswordTestFixture
    {
        [
            Test,
            TestCase("asd", false),
            TestCase("ASD123", false),
            TestCase("asd123", false),
            TestCase("rOvId1", false),
            TestCase("rOvId123", true)
        ]
        public void TestValidatePassword(string email, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidatePassword(email);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
}
