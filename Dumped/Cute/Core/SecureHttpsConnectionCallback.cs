using System;
using UnityEngine;

namespace Cute.Core
{
	public class SecureHttpsConnectionCallback : AndroidJavaProxy
	{
		private Action<byte[]> onSucceededCallback;

		private Action<string> onFailedCallback;

		private Action<int> onStatusCodeCallback;

		public SecureHttpsConnectionCallback(Action<byte[]> onSucceededCallback, Action<string> onFailedCallback, Action<int> onStatusCodeCallback)
		{
		}

		public override AndroidJavaObject Invoke(string methodName, object[] javaArgs)
		{
			return null;
		}

		private void OnSucceeded(AndroidJavaObject result)
		{
		}

		private void OnFailed(AndroidJavaObject result)
		{
		}

		private void OnStatusCode(AndroidJavaObject result)
		{
		}
	}
}
