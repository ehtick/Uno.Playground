namespace Uno.UI.Demo.TemplateSelectors
{
	public class SampleItemTemplateSelector : DataTemplateSelector
	{
		public DataTemplate DemoSampleItemTemplate { get; set; } = null!;

		public DataTemplate ComponentSampleItemTemplate { get; set; } = null!;

		protected override DataTemplate SelectTemplateCore(object item)
		{
			return Select(item);
		}

		protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
		{
			return Select(item);
		}

		private DataTemplate Select(object item)
		{
			var sampleItem = item as Sample;

			if (sampleItem == null)
			{
				return ComponentSampleItemTemplate;
			}

			if (sampleItem.Description != null)
			{
				return DemoSampleItemTemplate;
			}
			return ComponentSampleItemTemplate;
		}
	}
}
