using System;
using Wisej.Web;

namespace WisejWebDesktopApplication4
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.Desktop = new MyDesktop();

			Window3 window = new Window3();
			window.Show();
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}