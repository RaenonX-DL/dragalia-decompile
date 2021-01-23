/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FullDownloadPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text mainText;
		public UnityEngine.UI.Text warnText;
		public UnityEngine.UI.Text labelText;
		public UnityEngine.UI.Text allDataText;
		public UnityEngine.UI.Text noVoiceDataText;
		public UnityEngine.UI.Text allDataNum;
		public UnityEngine.UI.Text voiceDataNum;
		public UnityEngine.UI.Text descText;
		public ToggleGroup toggleGroup;
		public bool isPreIn;
		[CompilerGenerated]
		private static bool _isManifestDownloaded_k__BackingField;
		private TitleScene titleScene;
		private DownloadOperation fullDownloadOperation;
		private DownloadOperation noVoiceDownloadOperation;
		private bool exceptVoiceOnFullDownload;
	
		// Properties
		public static bool isManifestDownloaded { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public FullDownloadPopup popup;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _CreateFullDownloadPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public CommonPopup popup;
			public UnityAction onDownloadFailed;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _CreateDownloadErrorPopup_b__0();
			internal void _CreateDownloadErrorPopup_b__1();
		}
	
		// Constructors
		public FullDownloadPopup();
	
		// Methods
		public static FullDownloadPopup CreateFullDownloadPopup(bool isPreIn, TitleScene titleScene);
		protected override void Awake();
		private void SetDownloadSize(long fullSize, long noVoiceSize);
		private static void CreateDownloadErrorPopup(DownloadErrorType type, UnityAction onDownloadFailed);
		public void OnDownloadButtonPressed();
		public void OnFullDownloadToggled(bool arg);
		public void OnNoVoiceDownloadToggled(bool arg);
	}
}
