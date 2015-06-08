using System;
using System.Collections.Generic;
using Xamarin.Forms;
using FishHooksXAML.Models;
using FishHooksXAML.ViewModels;


namespace FishHooksXAML.Views
{
	public partial class FishHooksPage : ContentPage
	{
		public FishHooksPage ()
		{
			InitializeComponent ();
			this.BindingContext = new FishHookViewModel ();

		}

		public void OnItemSelected(object sender, ItemTappedEventArgs args)
		{
			var fishHook = args.Item as FishHook;
			if (fishHook == null) {
				return;
			}
			Navigation.PushAsync (new FishHookDetails (fishHook));
			list.SelectedItem = null;
		}
	}
}

