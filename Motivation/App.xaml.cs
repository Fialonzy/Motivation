using Microsoft.Extensions.DependencyInjection;
using Motivation.Model;
using Motivation.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Motivation
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private IServiceProvider _appServiceProvider;

		protected override void OnStartup(StartupEventArgs e)
		{
			AppConfigure();

			AppServiceBuild();

			Window main = _appServiceProvider.GetService<MainWindow>();
			main.Show();
		}

		private void AppServiceBuild()
		{
			IServiceCollection collection = new ServiceCollection();
			collection.AddTransient<ITask, Model.Task>();
			collection.AddTransient<IMainViewModel, MainViewModel>();
			collection.AddSingleton<MainWindow>();
			_appServiceProvider = collection.BuildServiceProvider();
		}

		private void AppConfigure()
		{
			
		}
	}
}
