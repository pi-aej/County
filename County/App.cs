using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace County
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage { 
				Content = new MultiCounterView(
					new List<CounterView>()
					{
						new CounterView(new Counter(0)),
						new CounterView(new Counter(1)),
						new CounterView(new Counter(2))
					}
				)
			};
		}
	}
}

