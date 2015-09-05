using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloForms
{
	public partial class MyPage3 : ContentPage
	{
		public MyPage3 ()
		{
			InitializeComponent ();
			var x = new System.Random ();
			int res = x.Next (0, 100);
			result.Text = res +" %";
			if (res > 50) {
				img.Source = "heartRED.png";

			}

		}
	
	}
}

