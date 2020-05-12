using System;
using System.Collections.Generic;
using System.Text;

namespace Motivation.Model
{
	class Task : ITask
	{
		private int _countToday; // TODO: Create a daily cleaning method
		private int _dailyMin;
		private string _description;

		public event EventHandler AllDone;


		public void Complete()
		{
			_countToday++;
			if (_countToday == _dailyMin) AllDone(_description, null);
		}

		public void Configure(IConfigurationTask configuration)
		{
			if (configuration == null) throw new ArgumentNullException(nameof(configuration));
			_dailyMin = configuration.Count;
			_description = configuration.Description;
		}

		public IEnumerable<int> GetChecoutMonth()
		{
			// TODO: refactoring method
			DateTime today = DateTime.Now;
			int days = DateTime.DaysInMonth(today.Year, today.Month);
			int day = today.Day;
			List<int> result = new List<int>(days);
			for (int i = 0; i < days; i++)
			{
				result.Add(0);
			}
			result[day] = _countToday;
			return result;
		}
	}
}
