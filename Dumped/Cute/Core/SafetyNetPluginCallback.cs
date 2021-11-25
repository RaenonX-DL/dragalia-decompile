using System;
using UnityEngine;

namespace Cute.Core
{
	public class SafetyNetPluginCallback : AndroidJavaProxy
	{
		private Action<string> onSucceededCallback;

		private Action<string> onFailedCallback;

		public SafetyNetPluginCallback(Action<string> onSucceededCallback, Action<string> onFailedCallback)
		{
		}

		public override AndroidJavaObject Invoke(string methodName, object[] args)
		{
			return null;
		}
	}
}
