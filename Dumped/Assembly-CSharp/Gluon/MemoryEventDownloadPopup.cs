/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MemoryEventDownloadPopup : PopupBase
	{
		// Fields
		[SerializeField]
		public Image logo;
		public Toggle voiceOnToggle;
		public Toggle voiceOffToggle;
		public UnityEngine.UI.Text donwloadSizeText;
		public UnityEngine.UI.Text withoutVoiceDownloadSizeText;
		private Action onDone;
		private Action onCancel;
		private DownloadOperation operation;
		private DownloadOperation withoutVoiceOperation;
		private int eventId;
		private const string prefabPath = "Prefabs/OutGame/QuestSelect/Popup/MemoryEventDownloadPopup";
	
		// Constructors
		public MemoryEventDownloadPopup();
	
		// Methods
		public static MemoryEventDownloadPopup Create(int eventId, DownloadOperation operation, DownloadOperation withoutVoiceOperation, Action onDone, Action onCancel);
		protected override void Start();
		private void SetDownloadSize();
		public void OnOKButtonPressed();
		public void OnCancelButtonPressed();
		[CompilerGenerated]
		private void _OnOKButtonPressed_b__14_0();
	}
}
