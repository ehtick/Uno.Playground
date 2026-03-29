namespace Uno.UI.Demo.Converters
{
	public class BoolToDefaultValueConverter : IValueConverter
	{
		public object NullOrFalseValue { get; set; } = null!;
		public object TrueValue { get; set; } = null!;

		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if (value == null || !System.Convert.ToBoolean(value, CultureInfo.InvariantCulture))
			{
				return NullOrFalseValue;
			}
			else
			{
				return TrueValue;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}
}
