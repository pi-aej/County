using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace County
{
	public class Counter : ViewModelBase
	{
		int value = 0;

		public string ValueString
		{
			get
			{
				return string.Format ("{0} clicks!", value);
			}
		}

		public Command Increment
		{
			get 
			{
				return new Command (
					delegate() {
						++value;
						OnPropertyChanged ("ValueString");
					});
			}
		}

		public Counter (int initial = 0)
		{
			value = initial;
		}
	}
}

