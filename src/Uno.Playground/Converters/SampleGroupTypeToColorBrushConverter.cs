namespace Uno.UI.Demo.Converters
{
	public class SampleGroupTypeToColorBrushConverter : IValueConverter
	{
		public object FeaturedTypeColorBrush { get; set; } = null!;
		public object ComponentTypeColorBrush { get; set; } = null!;

		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if (value == null || System.Convert.ToString(value, CultureInfo.InvariantCulture) == "Featured")
			{
				return FeaturedTypeColorBrush;
			}
			else
			{
				return ComponentTypeColorBrush;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}
