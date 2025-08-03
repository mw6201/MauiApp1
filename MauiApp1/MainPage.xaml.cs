﻿namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Artur ist {count} cool";
		else
			CounterBtn.Text = $"Artur ist {count} cool";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
