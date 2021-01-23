/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public class OkHttpPluginCallback : AndroidJavaProxy
	{
		// Fields
		private Action<string, string> onResponseCallback;
		private Action<string, DownloadErrorType, string> onFailureCallback;
	
		// Constructors
		public OkHttpPluginCallback(Action<string, string> onResponseCallback, Action<string, DownloadErrorType, string> onFailureCallback);
	
		// Methods
		public void onResponse(string url, string protocol);
		public void onFailure(string url, int errorType, string errorMsg);
	}
}
