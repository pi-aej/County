using System;
using Xamarin.Forms;

namespace County
{
	public class CounterView : ContentView
	{
		public CounterView (Counter viewmodel)
		{
			Content = InitializeLayout ();
			InitializeBinding (viewmodel);
		}

		Label label;
		Button button;

		View InitializeLayout()
		{
			label = new Label () {
				Text = "?"
			};

			button = new Button () {
				Text = "Increment!"
			};

			return new StackLayout () {
				Orientation = StackOrientation.Horizontal,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Children = { label, button }
			};
		}

		void InitializeBinding(ViewModelBase viewmodel)
		{
			BindingContext = viewmodel;

			label.SetBinding (Label.TextProperty, "ValueString");
			button.SetBinding (Button.CommandProperty, "Increment"); 
		}
	}
}

