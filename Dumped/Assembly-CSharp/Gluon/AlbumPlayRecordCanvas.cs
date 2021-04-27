/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumPlayRecordCanvas : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private OutGameBgChara chara;
		[SerializeField]
		private RectTransform charaRectTransform;
		[SerializeField]
		private AnimationUITalkWindow balloon;
		[SerializeField]
		private AlbumCharaTalkSelector charaTalkSelector;
		[SerializeField]
		private UnityEngine.UI.Text talkName;
		[SerializeField]
		private UnityEngine.UI.Text talkText;
		public TabBase categoryTab;
		public Transform listParentTransform;
		public GameObject originCell;
		public RectTransform listFrameTransform;
		public DragEventScrollRect scrollRect;
		public DragEventScrollRect dummyContentsScrollRect;
		private AlbumPlayRecordListCategory listCategory;
		private List<AlbumPlayerRecordListCellData> recordDataList;
		private string charaVoiceGroupName;
		private bool isChangeScrollLayout;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public AlbumPlayRecordCanvas __4__this;
			public OutGameTopCharaTalkSelector.TalkData talkData;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _StartBalloonAnimation_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<bool> __9__24_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SetChara_b__24_0(bool val);
		}
	
		// Constructors
		public AlbumPlayRecordCanvas();
	
		// Methods
		private void Start();
		private void LoadRecordData();
		private void ReloadList();
		public void OnCategoryTabPressed(int index);
		public void Talk(string charaVoiceGroupName, string voiceName);
		public void StartBalloonAnimation(OutGameTopCharaTalkSelector.TalkData talkData, bool dontRunCloseAnimation = false, bool ignoreDelay = false);
		public void SetTalkTextString(string text);
		public void SetTalkNameString(string text);
		public void SetChara();
		public void SetcharaVoiceGroupName(string charaVoiceGroupName);
		public void FirstVoiceStart();
	}
}
