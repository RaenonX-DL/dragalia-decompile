using System;
using UnityEngine;

namespace Cute.Core
{
	public class AndroidEmulatorDetectCallback : AndroidJavaProxy
	{
		private Action<bool> finishCallback;

		public AndroidEmulatorDetectCallback(Action<bool> finishCallback)
		{
		}

		private void onReceiveResult(bool isEmulator)
		{
		}
	}
}
