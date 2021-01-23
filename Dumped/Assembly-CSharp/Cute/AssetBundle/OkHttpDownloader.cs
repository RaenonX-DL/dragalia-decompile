/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public class OkHttpDownloader : DownloaderBase
	{
		// Fields
		private OkHttpPlugin okHttpPlugin;
		private readonly OkHttpPluginCallback callback;
	
		// Constructors
		public OkHttpDownloader(int timeout = 10);
	
		// Methods
		public void SetMaxRequestsPerHost(int maxRequests);
		public void SetMaxRequests(int maxRequests);
		protected override void DoDownload(string url, string fileName, Dictionary<string, string> headers, bool checkHash, int retry);
		public override void Cancel();
		public override void Dispose();
	}
}
