/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyChangePopupCell : MonoBehaviour
	{
		// Fields
		public Image elementIcon;
		public UnityEngine.UI.Text partyName;
		public UnityEngine.UI.Text partyPower;
		public CommonUnitIcon[] commonUnitIcons;
		public GameObject[] emptyIconObjects;
		public Button changeButton;
		public Button copyButton;
		public Button setButton;
		public Action<int> setCallBack;
		public Action registButtonAction;
		public Action<int, int> detailButtonAction;
		protected int questId;
		private int partyIndex;
		private Action<int> changeCallBack;
		private Action<int> copyCallBack;
		private PartyList questClearPartyList;
		private static readonly int maxSlotGroupCount;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public PartyDetailPopup popup;
			public PartyChangePopupCell __4__this;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _OnDetailButtonPressed_b__0();
			internal void _OnDetailButtonPressed_b__1();
			internal void _OnDetailButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public PartyDetailPopup popup;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _OnRegistPopupCellQuestClearPrtyDetailPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public PartyDetailPopup popup;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _OnRegistPopupCellDetailPressed_b__0();
		}
	
		// Constructors
		public PartyChangePopupCell();
		static PartyChangePopupCell();
	
		// Methods
		public void SetupCellData(int questId);
		public void UpdateCell(int partyIndex, Action<int> changeCallBack, Action<int> copyCallBack, PartyList partyList = null);
		protected virtual void OnDetailButtonPressed();
		public void OnRegistPopupCellQuestClearPrtyDetailPressed();
		public void OnRegistPopupCellDetailPressed();
		public void OnChangeButtonPressed();
		protected virtual void OnCharaIconPressed(int tag);
		public void OnCopyButtonPressed();
		public void OnSetButtonPressed();
		public void SetDispClearPartySetButton(bool isShow);
		private int GetQuestClearPartyPowerParam(AtgenSearchQuestClearPartyList searchQuestClearPartyList);
	}
}
