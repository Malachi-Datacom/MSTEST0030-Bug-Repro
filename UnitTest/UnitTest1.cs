namespace UnitTest;

public class DoesWarnMsTest0030
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.Fail();
    }
}

public class DoesNotWarnMsTest0030
{
    [TestInitialize]
    public void Initialize()
    {

    }

    [TestMethod]
    public void TestMethod1()
    {

    }
}