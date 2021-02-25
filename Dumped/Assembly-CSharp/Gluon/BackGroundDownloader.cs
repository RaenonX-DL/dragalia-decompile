/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BackGroundDownloader : SingletonMonoBehaviour<Gluon.BackGroundDownloader>
	{
		// Fields
		[CompilerGenerated]
		private bool _isDownloading_k__BackingField;
		private int prevDownloadProcessCount;
	
		// Properties
		public bool isDownloading { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public BackGroundDownloader __4__this;
			public DownloadOperation downloadOperation;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _DoBackgroundDownload_b__0();
			internal void _DoBackgroundDownload_b__1(DownloadErrorType type, string error);
		}
	
		// Constructors
		public BackGroundDownloader();
	
		// Methods
		private void Start();
		public void DoBackgroundDownload();
		public void StopDownload();
	}
}
