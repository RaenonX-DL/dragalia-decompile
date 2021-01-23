/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class SecureHttpsConnectionCallback : AndroidJavaProxy
	{
		// Fields
		private Action<byte[]> onSucceededCallback;
		private Action<string> onFailedCallback;
		private Action<int> onStatusCodeCallback;
	
		// Constructors
		public SecureHttpsConnectionCallback(Action<byte[]> onSucceededCallback, Action<string> onFailedCallback, Action<int> onStatusCodeCallback);
	
		// Methods
		public override AndroidJavaObject Invoke(string methodName, object[] javaArgs);
		private void OnSucceeded(AndroidJavaObject result);
		private void OnFailed(AndroidJavaObject result);
		private void OnStatusCode(AndroidJavaObject result);
	}
}
