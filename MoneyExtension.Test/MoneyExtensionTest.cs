namespace MoneyExtension.Test;

[TestClass]
public class MoneyExtensionTest
{
    [TestMethod]
    public void ShouldConverDecimalToInt()
    {
        decimal value = 279.98m;
        int cents = value.ToCents();
        
        Assert.AreEqual(27998, cents);

    }
}