namespace AmusementParkScale.Tests;
using NUnit.Framework;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

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
}