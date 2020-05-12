using Motivation.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Motivation.ViewModel
{
	class MainViewModel : BaseViewModel, IMainViewModel
	{
		private readonly ITask _task;
		private int _frequency = 1;
		private string _title = "Task";
		private ICommand _applySettingsCommand; // TODO: create initialize
		private ICommand _completeCommand; // TODO: create initialize

		public MainViewModel(ITask task)
		{
			_task = task;
			_task.AllDone += AllDone;

			_completeCommand = new RelayCommand(Complete);
			_applySettingsCommand = new RelayCommand(ApplySettings);
		}

		private void AllDone(object sender, EventArgs e)
		{
			MessageBox.Show($"{Title} -- COMPLETE!");
		}

		public int Frequency 
		{ 
			get => _frequency; 
			set 
			{
				_frequency = value;
				OnPropertyCnagnged(nameof(Frequency));
			} 
		}
		public string Title 
		{ 
			get => _title; 
			set
			{
				_title = value;
				OnPropertyCnagnged(nameof(Title));
			}
		}

		public ICommand ApplySettingsCommand => _applySettingsCommand;

		public ICommand CompleteCommand => _completeCommand;

		private void ApplySettings(object o)
		{
			IConfigurationTask configuration = new ConfigurationTask(Title, Frequency);
			_task.Configure(configuration);
		}

		private void Complete(object o)
		{
			_task.Complete();
		}
	}
}
