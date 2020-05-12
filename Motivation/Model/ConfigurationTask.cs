using System;
using System.Collections.Generic;
using System.Text;

namespace Motivation.Model
{
	class ConfigurationTask : IConfigurationTask
	{
		private readonly string _description;
		private readonly int _count;

		public ConfigurationTask(string description, int count)
		{
			if (string.IsNullOrEmpty(description)) throw new ArgumentNullException(nameof(description));
			if (count < 1) throw new ArgumentException("Property cannot by <1", nameof(count));
			_description = description;
			_count = count;
		}

		public string Description => _description;

		public int Count => _count;
	}
}
