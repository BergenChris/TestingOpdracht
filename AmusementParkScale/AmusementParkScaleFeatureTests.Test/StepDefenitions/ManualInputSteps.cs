using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmusementParkScale;
using NUnit.Framework;
using System.IO;
using System.Text;

namespace AmusementParkScaleFeatureTests.Test.StepDefenitions
{
    public class ManualInputSteps
    {
        [Test]
        public void Test_3_Invalid_Inputs()
        {
            // Arrange
            var invalidInputs = new string[] { "abc", "5", "123a", "123", "xyz", "456", "gdhd" };  // Simulate 3 invalid inputs and 2 good inputs
            var fails = 0;
            var correct = 0;
            var maxFails = 3;
            var attempts = 0;
            var output = new StringBuilder();
            

            // Act
            foreach (var input in invalidInputs)
            {
                try
                {
                    Person person = new Person(input);
                    correct++;
                }
                catch (Exception)
                {
                    fails++;
                    output.AppendLine("Error");
                    output.AppendLine("-----");
                    output.AppendLine("Invalid input, please try again.");
                }
                finally
                {
                    attempts++;
                }

                if (fails >= maxFails)
                {
                    
                    break;
                }
            }

            // Assert
            Assert.That(attempts-correct, Is.EqualTo(fails));  // Ensure only  failed attempts are catched in fails
            Assert.That(3, Is.EqualTo(fails)); // ensure it stops at 3 fails
            Assert.That(attempts, Is.Not.EqualTo(invalidInputs.Length)); // prove the 6th value was never used
           
        }
    }
}
