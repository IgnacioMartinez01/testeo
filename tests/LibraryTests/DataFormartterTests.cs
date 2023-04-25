namespace LibraryTests;

public class DataFormartterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        const string input="10/11/1997";
        const string expected="10-11-1997";
        
        Assert.That();
    }
    [Test]
     public void Test2()
     {
        const string input="1997/11/10";
        const string expected="10/11/1997";
     }

    [Test]
    public void Test3()
    {
        const string input=" ";
        const string expected="10/11/1997";
        
    }
}   
