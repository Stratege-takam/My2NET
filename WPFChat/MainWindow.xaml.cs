using appSimple.BO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFChat
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public List<Chat> chats = new List<Chat>();
		public MainWindow()
		{
			InitializeComponent();
			InitChat();
		}

		public void InitChat()
		{
			chats = new List<Chat>()
			{
				new Chat()
				{
					Id = 1,
					 Date = DateTime.Now,
					  Message ="Image result for WPFdocs.microsoft.com "
				},
				new Chat()
				{
					Id = 2,
					 Date = DateTime.Now,
					  Message ="Windows Presentation Foundation (WPF) is a graphical subsystem by Microsoft for rendering user interfaces in Windows - based applications.WPF, previously known as Avalon, was initially "
				},
				new Chat()
				{
					Id = 3,
					 Date = DateTime.Now,
					  Message ="released as part of.NET Framework 3.0 in 2006."
				}
			};

			foreach (var chat in chats)
			{
				TextBlock textBlock = new TextBlock();
				textBlock.Text = chat.Message;
				this.stckMessageList.Children.Add(textBlock);
			}
		}

		private void BtnAdd_Click(object sender, RoutedEventArgs e)
		{
			if (!string.IsNullOrEmpty( this.txtMessage.Text))
			{
				TextBlock textBlock = new TextBlock();
				textBlock.Text = txtMessage.Text;
				this.stckMessageList.Children.Add(textBlock);
				txtMessage.Text = "";
			}
		}

		private void BtnClear_Click(object sender, RoutedEventArgs e)
		{
			this.stckMessageList.Children.Clear();
		}

		private void txtMessage_KeyUp(object sender, KeyEventArgs e)
		{
			if(e.Key == Key.Enter)
			{
				BtnAdd_Click(sender, e);
			}
		}
	}
}
