/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class SafetyNetPluginCallback : AndroidJavaProxy
	{
		// Fields
		private Action<string> onSucceededCallback;
		private Action<string> onFailedCallback;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public SafetyNetPluginCallback __4__this;
			public object[] args;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _Invoke_b__0();
			internal void _Invoke_b__1();
		}
	
		// Constructors
		public SafetyNetPluginCallback(Action<string> onSucceededCallback, Action<string> onFailedCallback);
	
		// Methods
		public override AndroidJavaObject Invoke(string methodName, object[] args);
	}
}
