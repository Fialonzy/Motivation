using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Motivation.ViewModel
{
	class BaseViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyCnagnged(string propertyName)
		{
			if (string.IsNullOrEmpty(propertyName)) throw new ArgumentNullException(nameof(propertyName));
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
