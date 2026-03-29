namespace Uno.UI.Demo
{
#if __WASM__
	[Preserve]
#endif
	public class SampleCategory
	{
#if __WASM__
		[Preserve]
#endif
		public SampleCategory() { }
		public string CategoryId { get; set; } = null!;
		public string Title { get; set; } = null!;
		public Sample[] Samples { get; set; } = null!;
		public string DefaultIconPath { get; set; } = null!;
		public string DefaultIconAccentPath { get; set; } = null!;
	}
}