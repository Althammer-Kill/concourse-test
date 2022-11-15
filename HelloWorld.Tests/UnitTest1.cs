namespace HelloWorld.Tests;

public class UnitTest1
{
	[Fact]
	public void Test1()
	{
		Assert.Equal("Hallo Welt", Hello.Text);
	}

	[Fact]
	public void Test2()
	{
		Assert.False(true);
	}
}