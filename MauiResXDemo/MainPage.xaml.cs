using System.Globalization;
using MauiResXDemo.Resources.Strings;

namespace MauiResXDemo;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		/*
		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";
		*/

		/*
		CounterBtn.Text = string.Format(AppStrings.BTN_CLICKED_N_TIMES, count);
		*/

		CounterBtn.SetBinding(
			Button.TextProperty,
			new MultiBinding
			{
				Bindings =
				{
					BindingBase.Create<AppStringsObj, string>(static t => t.BTN_CLICKED_N_TIMES, mode: BindingMode.OneWay, source: AppStrings.Instance),
					BindingBase.Create<int, int>(static t => t, mode: BindingMode.OneWay, source: count),
				},
				Converter = new StringFormatConverter(),
			});

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void OnLanguageClicked(object sender, EventArgs e)
	{
		Button btn = (Button)sender;
		CultureInfo.CurrentUICulture = new CultureInfo(btn.Text);
		AppStrings.Invalidate();
	}
}
