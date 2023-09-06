namespace TestDateFormat;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectDate()
    {
        string input = "10/11/1997";
        string expected = "1997-11-10";
        string output = DateFormatter.ChangeFormat(input);

        Assert.AreEqual(expected, output);
    }

    [Test]
    public void Inverted()
    {
        string input = "1997/11/10";
        string expected = "1997-11-10";
        string output = DateFormatter.ChangeFormat(input);

        Assert.AreEqual(expected, output);
    }

    [Test]
    public void Empty()
    {
        string input = "";
        string expected = "1997-11-10";
        string output = DateFormatter.ChangeFormat(input);

        Assert.AreEqual(expected, output);
    }

}