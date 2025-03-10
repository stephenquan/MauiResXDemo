using System.Globalization;

namespace MauiResXDemo;
public class StringFormatConverter : IMultiValueConverter
{
	public object? Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		=> (values.Length >= 1 && values[0] is string format)
			? string.Format(format, values.Skip(1).ToArray())
			: null;
	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		=> throw new NotImplementedException();
}