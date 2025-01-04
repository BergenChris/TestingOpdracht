namespace AmusementParkScale.Tests;
using NUnit.Framework;


[TestFixture]
public class TestsScreen
{
   

    [Test]
   
    public void Test1_1_IsThereAScreen()
    {
        var newScreen = new Screen();
    }

    [Test]
 
    public void Test1_2_TextOnScreen()
    {
        var newScreen = new Screen();
        newScreen.text = "hello";
        Assert.That(newScreen.text, Does.Contain("hello"));
    }

    [Test]
  
    public void Test1_3_ColoronScreen()
    {
        var newScreen = new Screen();
        newScreen.color = ConsoleColor.Red;
        Assert.That(newScreen.color, Is.EqualTo(ConsoleColor.Red));
    }

    [Test]
    public void Test1_4_ColorMatchesText()
    {
        var newScreen = new Screen("allowed");
        newScreen.Work(newScreen);
        Assert.That(newScreen.color, Is.EqualTo(ConsoleColor.Green));
        newScreen.text = "not allowed";
        newScreen.Work(newScreen);
        Assert.That(newScreen.color, Is.EqualTo(ConsoleColor.Red));
        newScreen.text = "jibberish";
        newScreen.Work(newScreen);
        Assert.That(newScreen.color, Is.EqualTo(ConsoleColor.Red));
        newScreen.text = null;
        newScreen.Work(newScreen);
        Assert.That(newScreen.color, Is.EqualTo(ConsoleColor.Red));
    }


}

[TestFixture]
public class TestsPerson 
{
    [Test]

    public void Test2_1_IsThereAPerson()
    {
        var newPerson = new Person();
    }

    [Test]
    public void Test2_2_DoesThePersonHaveParameterWeight()
    {
        var newPerson = new Person();
        newPerson.weight = 0;
        Assert.That(newPerson.weight, Is.EqualTo(0));
    }

    [Test]
    public void Test2_3_CanYouWeighAPerson()
    {
        var newPerson = new Person();
        newPerson.weight = 0;
        double weight= newPerson.Weigh(newPerson);
        Assert.That(newPerson.weight,Is.EqualTo(weight));
    }

    [Test]
    public void Test2_4_WeighEqualToWeight() 
    {
        var newPerson = new Person();
        newPerson.weight = 0;
        double notWeight = 1;
        double weight = newPerson.Weigh(newPerson);

        //compare with wrong value
        Assert.That(newPerson.weight, Is.Not.EqualTo(notWeight));
        //compare with value from weighing
        Assert.That(newPerson.weight, Is.EqualTo(weight));

    }

    [Test]
    public void Test2_5_CorrectInputType() 
    {
        var newPerson1 = new Person(10.5);
        Assert.That(newPerson1.weight, Is.EqualTo(10.5));
        var newPerson2 = new Person("10.5");
        Assert.That(newPerson2.weight, Is.EqualTo(10.5));
        
        

    }
    [TestFixture]
    public class TestsDecisionBasedOnweight
    {
        [Test]
        public void Test1_1_IsThereADecision() 
        {
            DecisionBasedOnweight decision = new DecisionBasedOnweight();
        }
    }


}