/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.AssetBundle;
using Gluon.Master;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SelectableCastleStoryDownloadPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text confirmText;
		public UnityEngine.UI.Text downloadText;
		public UnityEngine.UI.Text wifiText;
		public UnityEngine.UI.Text helpText;
		public UnityEngine.UI.Text allDataNum;
		public UnityEngine.UI.Text voiceDataNum;
		public UnityEngine.UI.Text descText;
		public UnityEngine.UI.Text shortageText;
		public UnityEngine.UI.Text beforeUseNumText;
		public UnityEngine.UI.Text afterUseNumText;
		public UnityEngine.UI.Text possessionNumText;
		public UnityEngine.UI.Text captionUnlockItemText;
		public Image itemIconImage;
		private bool isToQuest;
		private UnitStoryListCellData data;
		private Action onComplete;
		private DownloadOperation downloadOperation;
		private DownloadOperation downloadOperationWithoutVoice;
		private bool exceptVoiceOnFullDownload;
		private const string prefabPath = "Prefabs/OutGame/Fort/UnitStoryList/SelectableCastleStoryDownloadPopup";
	
		// Constructors
		public SelectableCastleStoryDownloadPopup();
	
		// Methods
		protected override void Awake();
		public static void CreateForQuest(int questId, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, Action onComplete);
		public static void CreateForCastleStory(UnitStoryListCellData data, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice);
		public static void CreateForEventStory(EventStoryElement data, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, Action onComplete);
		private void InitForQuest(int questId, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, Action onComplete);
		private void InitForCastleStory(UnitStoryListCellData data, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice);
		private void InitForEventStory(EventStoryElement data, DownloadOperation downloadOperation, DownloadOperation downloadOperationWithoutVoice, Action onComplete);
		private void SetDownloadSize(long fullSize, long noVoiceSize);
		public void OnDownloadButtonPressed();
		public void OnFullDownloadToggled(bool arg);
		public void OnNoVoiceDownloadToggled(bool arg);
		[CompilerGenerated]
		private void _Awake_b__20_0();
		[CompilerGenerated]
		private void _Awake_b__20_1();
		[CompilerGenerated]
		private void _InitForQuest_b__24_0();
		[CompilerGenerated]
		private void _OnDownloadButtonPressed_b__28_0();
	}
}
