/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SelectableDownloadPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text mainText;
		public UnityEngine.UI.Text warnText;
		public UnityEngine.UI.Text labelText;
		public UnityEngine.UI.Text allDataText;
		public UnityEngine.UI.Text noVoiceDataText;
		public UnityEngine.UI.Text allDataNum;
		public UnityEngine.UI.Text voiceDataNum;
		public UnityEngine.UI.Text minimumDataNum;
		public UnityEngine.UI.Text descText;
		public ToggleGroup toggleGroup;
		public Toggle voiceOnToggle;
		public Toggle voiceOffToggle;
		public Toggle minimumToggle;
		public GameObject deleteSizeRoot;
		public UnityEngine.UI.Text deleteDataNum;
		private bool isPreIn;
		private DownloadOperation downloadOperation;
		private DownloadOperation downloadOperationWithoutVoice;
		private DownloadOperation downloadOperationMinimum;
		private bool updateSaveVoiceAsset;
		private bool changeOptionSetting;
		[CompilerGenerated]
		private DownloadMode _downloadMode_k__BackingField;
		private const string prefsKeyToggleSelect = "SelectableDownloadPopup/ToggleSelect";
	
		// Properties
		public bool isWithoutVoice { get; }
		private DownloadMode downloadMode { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum DownloadMode
		{
			Full = 0,
			WithoutVoice = 1,
			Minimum = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public SelectableDownloadPopup popup;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _CreateSelectableDownloadPopup_b__0();
		}
	
		// Constructors
		public SelectableDownloadPopup();
	
		// Methods
		public static SelectableDownloadPopup CreateSelectableDownloadPopup(bool isPreIn, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, DownloadOperation downloadOperationMinimum, bool updateSaveVoiceAsset, bool changeOptionSetting, long deletedSize = 0);
		protected override void Awake();
		protected override void Start();
		private void SetDownloadSize();
		public void ChangeMainTextForVoiceDownload();
		public void OnDownloadButtonPressed();
		public void OnFullDownloadToggled(bool arg);
		public void OnNoVoiceDownloadToggled(bool arg);
		public void OnMinimunDownloadToggled(bool arg);
		public static DownloadMode GetDefaultSelectedMode(bool isMinimunEnable);
	}
}
