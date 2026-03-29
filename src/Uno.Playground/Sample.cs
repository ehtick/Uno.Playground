namespace Uno.UI.Demo
{
#if __WASM__
	[Preserve]
#endif
	public class Sample
	{
		public string Id { get; set; } = null!;
		public string Title { get; set; } = null!;
		public string Description { get; set; } = null!;
		public string[] Keywords { get; set; } = null!;
		public string IconPath { get; set; } = null!;
		public string IconAccentPath { get; set; } = null!;
	}
}