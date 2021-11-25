using System;

namespace Gluon
{
	public class ActionCallback : ActionBase
	{
		protected Action _callback;

		public ActionCallback(Action callback)
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}
	}
}
