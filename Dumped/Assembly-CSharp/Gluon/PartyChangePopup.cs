/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyChangePopup : CommonPopup
	{
		// Fields
		public TabBase partyGroupTab;
		public Transform listParentTransform;
		public GameObject originCell;
		private PartyChangePopupCell[] cells;
		public UnityEngine.UI.Text popupTopText;
		public Action<int, bool> partyChangeAction;
		public Action<int, bool> partyCopyAction;
		public Action<int, PartyList> partySetAction;
		private int nowGroupIndex;
		private int nowPartyIndex;
		private int selectGroupIndex;
		private int clearPartySampleDataIndex;
		private PartyList questClearParty;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public CommonPopup popup;
			public PartyChangePopup __4__this;
			public int partyIndex;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _CopyButtonAction_b__0();
			internal void _CopyButtonAction_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public PartyDetailPopup popup;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _OnQuestClearPartyPopDetailButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public PartyChangeQuestClearPartyRegistPopup popup;
			public PartyChangePopup __4__this;
			public int partyIndex;
			public Action registAction;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _SetButtonAction_b__0();
			internal void _SetButtonAction_b__1();
			internal void _SetButtonAction_b__2();
		}
	
		// Constructors
		public PartyChangePopup();
	
		// Methods
		public static PartyChangePopup Create();
		public void InitPopup(int questId, int partyGroupIndex = -1, int partyIndex = -1, bool isHideCopyButton = false);
		public void InitPopup(int sampleDataIndex);
		public override void StartShowAnimation(UnityEvent onCompleted = null);
		private void OnSelectedGroupTab(int index);
		private void ReloadCell();
		private void ChangeButtonAction(int partyIndex);
		private void CopyButtonAction(int partyIndex);
		private void OnQuestClearPartyPopDetailButtonPressed(int questId, int partyIndex);
		private void CreateQuestClearPartyData();
		private void SetButtonAction(int partyIndex);
		[CompilerGenerated]
		private void _StartShowAnimation_b__16_0();
	}
}
