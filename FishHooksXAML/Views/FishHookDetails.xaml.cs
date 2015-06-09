using System;
using System.Collections.Generic;
using Xamarin.Forms;
using FishHooksXAML.Models;
using Xamarin.Forms;

namespace FishHooksXAML.Views
{
	public partial class FishHookDetails : ContentPage
	{
		public FishHookDetails (FishHook fishHook)
		{
			InitializeComponent ();
			this.BindingContext = fishHook;
			Click.Clicked += (object sender, EventArgs e) => {
				var text = myLabel.ToString();
				if (text == null) {
					return;
				}
				Navigation.PushAsync (new NewPage(text));
			};
		}

		public void OnClickItem(object sender, FocusEventArgs args)
		{
			var text = args.ToString ();
			if (text == null) {
				return;
			}
			Navigation.PushAsync (new NewPage(text));
		}
	}
}

