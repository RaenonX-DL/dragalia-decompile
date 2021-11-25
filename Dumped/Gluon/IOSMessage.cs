using System;

namespace Gluon
{
	public class IOSMessage
	{
		public string title;

		public string message;

		public string ok;

		public static IOSMessage Create(string title, string message, Action okAction)
		{
			return null;
		}

		public static IOSMessage Create(string title, string message, string ok, Action okAction)
		{
			return null;
		}

		public void init(Action okAction)
		{
		}
	}
}
