using Xunit;
using Iceland_Task;

public class ItemTests
{
    [Fact]
    public void AgedBrieTest()
    {
        AgedBrie TestAgedBrie = new AgedBrie(1, 1);

        TestAgedBrie.UpdateInventory();

        Assert.Equal(0, TestAgedBrie.SellIn);
        Assert.Equal(2, TestAgedBrie.Quality);
    }

    [Fact]
    public void ChristmasCrackerTest()
    {
        ChristmasCracker TestChristmasCracker = new ChristmasCracker(-1, 2);

        TestChristmasCracker.UpdateInventory();

        Assert.Equal(-2, TestChristmasCracker.SellIn);
        Assert.Equal(2, TestChristmasCracker.Quality);
    }

    [Fact]
    public void FreshItemTest()
    {
        FreshItem TestFreshItem = new FreshItem(-1, 5);

        TestFreshItem.UpdateInventory();

        Assert.Equal(-2, TestFreshItem.SellIn);
        Assert.Equal(1, TestFreshItem.Quality);
    }

    [Fact]
    public void FrozenItemTest()
    {
        FrozenItem TestFrozenItem = new FrozenItem(2, 2);

        TestFrozenItem.UpdateInventory();

        Assert.Equal(1, TestFrozenItem.SellIn);
        Assert.Equal(1, TestFrozenItem.Quality);
    }

    [Fact]
    public void SoapTest()
    {
        Soap TestSoap = new Soap(2, 2);

        TestSoap.UpdateInventory();

        Assert.Equal(2, TestSoap.SellIn);
        Assert.Equal(2, TestSoap.Quality);
    }

    [Fact]
    public void ItemTestQualityMax()
    {
        AgedBrie TestAgedBrie = new AgedBrie(5, 50);
        ChristmasCracker TestChristmasCracker = new ChristmasCracker(1, 60);

        TestAgedBrie.UpdateInventory();
        TestChristmasCracker.UpdateInventory();

        Assert.Equal(50, TestAgedBrie.Quality);
        Assert.Equal(50, TestChristmasCracker.Quality);
    }

    [Fact]
    public void ItemTestQualityMin()
    {
        FreshItem TestFreshItem = new FreshItem(7, 0);
        FrozenItem TestFrozenItem = new FrozenItem(-2, -5);

        TestFreshItem.UpdateInventory();
        TestFrozenItem.UpdateInventory();

        Assert.Equal(0, TestFreshItem.Quality);
        Assert.Equal(0, TestFrozenItem.Quality);
    }
}
