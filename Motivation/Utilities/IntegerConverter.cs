using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Motivation.Utilities
{
	public class IntegerConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (!(value is string)) return 1;
			string str = (string)value;
			if (string.IsNullOrEmpty(str)) return 1;
			int result;
			if (!int.TryParse(str, out result))
				return 1;
			return result;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value.ToString();
		}
	}
}
