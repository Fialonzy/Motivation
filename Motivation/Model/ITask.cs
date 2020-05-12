using System;
using System.Collections.Generic;
using System.Text;

namespace Motivation.Model
{
	interface ITask
	{
		IEnumerable<int> GetChecoutMonth();

		void Complete();

		void Configure(IConfigurationTask configuration);

		event EventHandler AllDone;
	}
}
