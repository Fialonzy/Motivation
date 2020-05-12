using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Motivation.ViewModel
{
	public interface IMainViewModel
	{
		int Frequency { get; set; }

		string Title { get; set; }

		ICommand ApplySettingsCommand { get; }

		ICommand CompleteCommand { get; }
	}
}
