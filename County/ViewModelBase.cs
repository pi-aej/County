using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace County
{
	public class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public event NavigationRequestEventHandler NavigationChange;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		protected void NavigationRequest(string name, params object[] args)
		{
			var handler = NavigationChange;
			if (handler != null)
			{
				handler(this, new NavigationRequestEventArgs(name, args));
			}
		}
	}
}