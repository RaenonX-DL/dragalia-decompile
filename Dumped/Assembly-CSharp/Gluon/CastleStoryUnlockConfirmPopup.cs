/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CastleStoryUnlockConfirmPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Fort/UnitStoryList/CastleStoryUnlockConfirmPopup";
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private Button okButton;
		[SerializeField]
		private UnityEngine.UI.Text okText;
		[SerializeField]
		private Button cancelButton;
		[SerializeField]
		private UnityEngine.UI.Text cancelText;
		[SerializeField]
		private UnityEngine.UI.Text confirmText;
		[SerializeField]
		private UnityEngine.UI.Text downloadText;
		[SerializeField]
		private UnityEngine.UI.Text wifiText;
		[SerializeField]
		private UnityEngine.UI.Text helpText;
		[SerializeField]
		private UnityEngine.UI.Text shortageText;
		[SerializeField]
		private UnityEngine.UI.Text beforeUseNumText;
		[SerializeField]
		private UnityEngine.UI.Text afterUseNumText;
		[SerializeField]
		private UnityEngine.UI.Text possessionNumText;
		[SerializeField]
		private UnityEngine.UI.Text captionUnlockItemText;
		[SerializeField]
		private Image itemIconImage;
		private bool isToQuest;
		private UnitStoryListCellData data;
		public const int combatEventItemId = 2220105;
		private Action onComplete;
	
		// Constructors
		public CastleStoryUnlockConfirmPopup();
	
		// Methods
		public static void CreateForStoryQuest(int questId, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, Action onComplete);
		public static void CreateForCastleStory(UnitStoryListCellData data, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice);
		public static void CreateForEventStory(EventStoryElement data, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, Action onComplete);
		private void InitForQuest(int questId, Action onComplete);
		private void InitForCastleStory(UnitStoryListCellData data);
		private void InitForEventStory(EventStoryElement data, Action onComplete);
		public void OnCancelButtonPressed();
		public void OnOkButtonPressed();
		[CompilerGenerated]
		private void _OnOkButtonPressed_b__27_0();
	}
}
