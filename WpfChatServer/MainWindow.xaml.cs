using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfChatServer
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		//private ObservableCollection<string> _myChatState { get; set; } = new ObservableCollection<string>();
		public ObservableCollection<string> MyChatState => App.ChatStates;
		public MainWindow()
		{
			InitializeComponent();
			var url = "http://localhost:8080/";
			TxtUrl.Text = url;
			DataContext = this;
		}


		private void RunServer(string url)
		{
			
			using (WebApp.Start<Startup>(url))
			{
				//Console.WriteLine($"Server running at {url}");
				//Console.ReadLine();
				TxtError.Text = $"Server running at {url}";
				TxtError.Foreground = Brushes.Green;
			}
		}

		private void BtnRunServer_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				RunServer(TxtUrl.Text);
				
			}
			catch (Exception ex)
			{
				TxtError.Text = ex.Message;
				TxtError.Foreground = Brushes.Red;
			}
		}
	}
}
