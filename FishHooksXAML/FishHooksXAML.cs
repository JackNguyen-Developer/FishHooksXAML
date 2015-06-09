using System;
using System.Collections.Generic;
using Xamarin.Forms;
using FishHooksXAML.Views;
using Xamarin.Forms;

namespace FishHooksXAML
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			/**
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
					}
				}
			};
			**/
			MainPage = GetMainPage ();

		}

		public static Page GetMainPage()
		{
			var fishHook = new FishHooksPage ();
			return new NavigationPage (fishHook);
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

