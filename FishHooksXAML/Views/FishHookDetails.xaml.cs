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
		}
	}
}

