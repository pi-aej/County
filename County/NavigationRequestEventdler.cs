using System;
using System.Collections.Generic;

namespace County
{
	public delegate void NavigationRequestEventHandler(object sender, NavigationRequestEventArgs e);

	public class NavigationRequestEventArgs : EventArgs
	{
		public NavigationRequestEventArgs(string name, params object[] data)
		{
			ViewName = name;
			Args = data;
		}

		public string ViewName;
		public IEnumerable<object> Args;
	}

}

