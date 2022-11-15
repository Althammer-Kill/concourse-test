using Newtonsoft.Json.Linq;

#warning "Test"

public static class Hello
{
	public static string Text => "Hallo Welt";

	public static void Main()
	{
		JObject obj = new();
		Console.WriteLine(Text);
		GC.KeepAlive(obj);
	}
}