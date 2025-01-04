namespace AmusementParkScale.Tests;
using NUnit.Framework;


[TestFixture]
public class Tests
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
        newScreen.text = "allowed";
        Assert.That(newScreen.color, Is.EqualTo(ConsoleColor.Green));
        newScreen.text = "not allowed";
        Assert.That(newScreen.color, Is.EqualTo(ConsoleColor.Red));
        newScreen.text = "jibberish";
        Assert.That(newScreen.color, Is.EqualTo(ConsoleColor.Red));


    }
}