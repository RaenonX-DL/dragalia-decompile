using System;

namespace Gluon
{
	public class IOSDialog
	{
		public string title;

		public string message;

		public string yes;

		public string no;

		public static IOSDialog Create(string title, string message, Action yesAction, Action noAction)
		{
			return null;
		}

		public static IOSDialog Create(string title, string message, string yes, string no, Action yesAction, Action noAction)
		{
			return null;
		}

		private void init(Action yesAction, Action noAction)
		{
		}
	}
}
