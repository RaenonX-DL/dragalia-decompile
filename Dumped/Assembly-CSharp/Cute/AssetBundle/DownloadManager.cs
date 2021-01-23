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
	public class DownloadManager : MonoBehaviour
	{
		// Fields
		private DownloaderBase downloader;
		private static DownloadManager instance;
		private static int timeout;
	
		// Properties
		public static int TimeOut { set; }
		public static DownloadManager Instance { get; }
		private DownloaderBase Downloader { get; }
	
		// Constructors
		public DownloadManager();
		static DownloadManager();
	
		// Methods
		public void Download(string url, string filePath, Dictionary<string, string> headers, bool checkHash, int retry, DownloaderBase.ResponseCB responseCB, DownloaderBase.FailureCB failureCB);
		public void SetMaxRequestsPerHost(int maxRequests);
		public void SetMaxRequests(int maxRequests);
		public void Cancel();
		private void OnDestroy();
	}
}
