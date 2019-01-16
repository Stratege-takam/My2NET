using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WpfResources
{
	/// <summary>
	/// Interaction logic for Page1Window.xaml
	/// </summary>
	public partial class Page1Window : Window
	{
		public Page1Window()
		{
			InitializeComponent();
		}

		private void BtnClick_Click(object sender, RoutedEventArgs e)
		{
			Page2Window page2Window = new Page2Window();
			page2Window.Show();
			this.Hide();
		}
	}
}
