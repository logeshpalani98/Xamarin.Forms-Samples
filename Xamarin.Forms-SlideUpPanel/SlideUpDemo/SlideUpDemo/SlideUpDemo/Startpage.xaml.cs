﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlideUpDemo
{
	
	public partial class Startpage : ContentPage
	{
		public Startpage ()
		{
			InitializeComponent ();
		}

	    async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new MainPage());
	    }
	}
}