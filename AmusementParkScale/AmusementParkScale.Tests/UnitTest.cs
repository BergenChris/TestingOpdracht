namespace AmusementParkScale.Tests;
using NUnit.Framework;
using Moq;



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
        var newScreen = new Screen();
        newScreen.Work("allowed");
        Assert.That(newScreen.color, Is.EqualTo(ConsoleColor.Green));
     
        newScreen.Work("not allowed");
        Assert.That(newScreen.color, Is.EqualTo(ConsoleColor.Red));
  
        newScreen.Work("testing");
        Assert.That(newScreen.color, Is.EqualTo(ConsoleColor.Red));

        newScreen.Work(null);
        Assert.That(newScreen.color, Is.EqualTo(ConsoleColor.Red));
    }


}


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
        int setWeight = 80;
        var newPerson = new Mock<IPerson>();
        newPerson.Setup(p => p.Weigh()).Returns(setWeight);
        double weight= newPerson.Object.Weigh();
        Assert.That(weight,Is.EqualTo(setWeight));
    }

    [Test]
    public void Test2_4_WeighEqualToWeight() 
    {
        var newPerson = new Mock<IPerson>();
        newPerson.Setup(p=>p.Weigh()).Returns(0);
        double notWeight = 1;
        double weight = newPerson.Object.Weigh();

        //compare with wrong value
        Assert.That(newPerson.Object.weight, Is.Not.EqualTo(notWeight));
        //compare with value from weighing
        Assert.That(newPerson.Object.weight, Is.EqualTo(weight));

    }

    [Test]
    public void Test2_5_CorrectInputType() 
    {
        var newPerson1 = new Person(10.5);
        Assert.That(newPerson1.weight, Is.EqualTo(10.5));
        var newPerson2 = new Person("10.5");
        Assert.That(newPerson2.weight, Is.EqualTo(10.5));
        
        

    }
}


public class TestsDecisionBasedOnWeight
{
    [Test]
    public void Test3_1_IsThereADecision()
    {
        DecisionBasedOnWeight decision = new DecisionBasedOnWeight();
    }

    [Test]
    public void Test3_2_CanItAcceptAPerson()
    {
        DecisionBasedOnWeight decision = new DecisionBasedOnWeight(new Person());
    }

    [Test]
    public void Test3_3_ExtractWeightFromPersonWithParams()
    {
        DecisionBasedOnWeight decision1 = new DecisionBasedOnWeight(new Person(80.5));
        Assert.That(decision1.person.weight, Is.EqualTo(80.5));
    }

    [Test]
    public void Test3_4_GetConditions()
    {
        DecisionBasedOnWeight decision = new DecisionBasedOnWeight();
        Assert.That(decision.minWeight, Is.EqualTo(60));
        Assert.That(decision.maxWeight, Is.EqualTo(100));
    }

    [Test]
    public void Test3_5_SetConditions()
    {
        DecisionBasedOnWeight decision = new DecisionBasedOnWeight();
        decision.Conditions(60, 100);
        Assert.That(decision.minWeight, Is.EqualTo(60));
        Assert.That(decision.maxWeight, Is.EqualTo(100));

    }


}


public class TestsEnter
{
    [Test]
    public void Test4_1_CanICallEnter() 
    {
        Enter enter = new Enter();
    }

    [Test]
    public void Test4_2_CanICallEnterWithParams() 
    {
        Enter enter = new Enter(0,3,new DecisionBasedOnWeight( new Person(80)));
    }

    [Test]
    public void Test4_3_DoesEnterWork() 
    {
        Enter enter = new Enter(0, 3, new DecisionBasedOnWeight( new Person(80)));
        Assert.That(enter.Work(), Is.True);
        enter.decision =  new DecisionBasedOnWeight( new Person(130) );
        Assert.That(enter.Work(), Is.False);
    }

    [Test]
    public void Test4_4_TooManyFailsNoEntry()
    {
        Enter enter = new Enter(3, 3, new DecisionBasedOnWeight(new Person(80)));
        Assert.That(enter.Work(), Is.False);
        Enter enter1 = new Enter(0, 0, new DecisionBasedOnWeight(new Person(80)));
        Assert.That(enter1.Work(), Is.False);
    }
}