/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.AssetBundle
{
	public class UWRDownloader : DownloaderBase
	{
		// Fields
		private int timeout;
		private float time;
		private ICoroutineHandler coroutineHandler;
		private List<UnityWebRequest> requestList;
		private List<UWRDownloadHandler> downloadHandlerList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public UWRDownloader __4__this;
			public string fileName;
			public string url;
			public int retryCount;
			public int retry;
			public Dictionary<string, string> headers;
			public bool checkHash;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _StartDownload_b__0();
			internal void _StartDownload_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_1
		{
			// Fields
			public string tmpFileName;
			public DownloadErrorType errorType;
			public string errorMessage;
			public __c__DisplayClass9_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass9_1();
	
			// Methods
			internal void _StartDownload_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _StartDownload_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UWRDownloader __4__this;
			public string fileName;
			public string url;
			public int retryCount;
			public int retry;
			public Dictionary<string, string> headers;
			public bool checkHash;
			private __c__DisplayClass9_1 __8__1;
			private UnityWebRequest _request_5__2;
			private UWRDownloadHandler _downloadHandler_5__3;
			private bool _isTimeout_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartDownload_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public UWRDownloader(ICoroutineHandler coroutineHandler, int timeout = 0);
	
		// Methods
		protected override void DoDownload(string url, string fileName, Dictionary<string, string> headers, bool checkHash, int retry);
		public override void Cancel();
		protected void DoDownload(string url, string fileName, Dictionary<string, string> headers, bool checkHash, int retry, int retryCount);
		[IteratorStateMachine]
		private IEnumerator StartDownload(string url, string fileName, Dictionary<string, string> headers, bool checkHash, int retry, int retryCount);
		private bool IsDiskFullError(string errorMessage);
	}
}
