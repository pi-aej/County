using System;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;


namespace County
{
	public class MultiCounterView : ContentView
	{
		class MultiCounterViewModel : ViewModelBase
		{
			MultiCounterView _view;
			public MultiCounterViewModel(MultiCounterView view)
			{
				_view = view;
			}

			public Command IncrementAll {
				get 
				{
					return new Command (
						delegate (object o)
						{
							foreach(var v in _view._counters)
							{
								var vm = (v.BindingContext as Counter);
								if(vm != null)
								{
									vm.Increment.Execute(o);
								}
							}
						});
				}
			}
		};

		IEnumerable<CounterView> _counters;
		public MultiCounterView (IEnumerable<CounterView> counters)
		{
			_counters = counters;
			Content = InitializeLayout ();
			InitializeBinding ();
		}

		Button button;

		View InitializeLayout ()
		{
			button = new Button () {
				Text = "Increment All!"
			};

			var layout = new StackLayout () {
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			layout.Children.Add (button);

			foreach (var c in _counters) 
			{
				layout.Children.Add (c);
			}

			return layout;
		}

		void InitializeBinding ()
		{
			BindingContext = new MultiCounterViewModel (this);

			button.SetBinding (Button.CommandProperty, "IncrementAll");
		}
	}
}

