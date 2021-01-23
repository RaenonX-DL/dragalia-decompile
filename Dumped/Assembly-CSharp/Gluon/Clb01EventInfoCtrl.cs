/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class Clb01EventInfoCtrl : EventInfoCtrlBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text[] materialTexts;
		[SerializeField]
		private Image[] materialIcons;
		[SerializeField]
		private UnityEngine.UI.Text friendlyPointText;
		[SerializeField]
		private UnityEngine.UI.Text hintText;
		[SerializeField]
		private UnityEngine.UI.Text hintTitleText;
		[Header]
		[SerializeField]
		public Transform[] miniCharaParentNodes;
		public Button[] miniCharaButtons;
		public Transform miniCharaInvalidParentNode;
		public FlashPlayerManager flashPlayerManager;
		private FlashPlayer[] miniCharaFlashPlayers;
		private int[] miniCharaFlashPlayerIds;
		private readonly Vector3 defaultMiniCharaSize;
		private const int specialMinicharaId = 3;
		private int hidingIndex;
		private int index1;
		private int index2;
		public const string miniCharaFlashPrefabPathTemplate = "Prefabs/OutGame/EventQuest/{0}/pf_EventQuestMiniCharacter{1:D3}";
		public const int miniCharaCount = 3;
		[SerializeField]
		private Gauge gauge;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public Clb01EventInfoCtrl __4__this;
			public int incomingIndex;
			public int posIndex;
			public TouchGuardObject guard;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _DoChangeMiniChara_b__0();
			internal void _DoChangeMiniChara_b__1();
		}
	
		// Constructors
		public Clb01EventInfoCtrl();
	
		// Methods
		public static Clb01EventInfoCtrl Create(Transform parent);
		protected override void Start();
		private void OnDestroy();
		public List<int> GetMiniCharaFlashPlayerList();
		public static string GetMiniCharaFlashPlayerPath(int eventId, int charaIndex);
		private void LoadMiniChara(List<int> miniCharaIdList);
		public void InitBindMiniChara(List<int> enabledMiniCharaList);
		private void InitBindMiniChara(int hidingIndex, int index1, int index2);
		public void OnMiniCharaTouched(int posIndex);
		public override void OnResetTopImageAndTalk();
		private void DoChangeMiniChara(int posIndex, int incomingIndex);
		public override void SetEventInfo();
		private void SetEventHintText();
	}
}
