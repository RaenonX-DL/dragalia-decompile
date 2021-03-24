/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DownloadErrorPopup : MonoBehaviour
	{
		// Fields
		private const string Title = "Title";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0
		{
			// Fields
			public CommonPopup popup;
			public UnityAction onDownloadFailed;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _CreateDownloadErrorPopup_b__0();
			internal void _CreateDownloadErrorPopup_b__1();
		}
	
		// Constructors
		public DownloadErrorPopup();
	
		// Methods
		public static void CreateDownloadErrorPopup(DownloadErrorType type, UnityAction onDownloadFailed);
	}
}
