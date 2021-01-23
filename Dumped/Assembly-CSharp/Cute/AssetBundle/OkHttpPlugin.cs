/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public class OkHttpPlugin : IDisposable
	{
		// Fields
		private AndroidJavaObject okHttpDownloadObject;
	
		// Nested types
		public enum ErrorType
		{
			Timeout = 0,
			IOException = 1,
			Other = 2
		}
	
		// Constructors
		public OkHttpPlugin();
		public OkHttpPlugin(int timeout);
	
		// Methods
		public void Download(string url, string fileName, Dictionary<string, string> headers, bool checkHash, int retry, OkHttpPluginCallback callback);
		public void SetMaxRequests(int maxRequests);
		public void SetMaxRequestsPerHost(int maxRequests);
		public void Cancel();
		public void Dispose();
	}
}
