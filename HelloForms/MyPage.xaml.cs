using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloForms
{
	public partial class MyPage : ContentPage
	{
		public MyPage ()
		{
			InitializeComponent ();
		}

		protected async void btClick(object sender, EventArgs args) {
			await Navigation.PushModalAsync(new MyPage2());
		}
	}
}

