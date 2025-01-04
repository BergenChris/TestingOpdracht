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

    public void Test1_1_IsThereAScreen()
    {
        var newPerson = new Person();
    }
}