/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartySwitchPopupCell : PartyChangePopupCell
	{
		// Fields
		public Button historyButton;
		[SerializeField]
		private UnityEngine.UI.Text historyButtonText;
		public GameObject[] MaskList;
		[SerializeField]
		private GameObject limitedElementBalloon;
		[SerializeField]
		private Image limitedElementIcon;
		private bool isUseClearParty;
		private int cellIndex;
		private int partyIndex;
		private PartySwitchLocation partySwitchLocation;
		private Action<int, int, bool> formationAction;
		private Action<int, int> partyChangeAction;
		private Action<int> copyPartyAction;
		private Action historyButtonAction;
		private Action updatePartyNamesAction;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public PartyChangePopup popup;
			public PartySwitchPopupCell __4__this;
			public bool isOtherPartySelecting;
			public int prevPartyIndex;
			public Action __9__3;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _OnPartyChangeButtonPressed_b__0(int selectPartyIndex, bool isOtherGroupLoad);
			internal void _OnPartyChangeButtonPressed_b__1(int copyIndex, bool isOtherGroupLoad);
			internal void _OnPartyChangeButtonPressed_b__3();
			internal void _OnPartyChangeButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public PartyDetailPopup popup;
			public PartySwitchPopupCell __4__this;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _OnDetailButtonPressed_b__0();
			internal void _OnDetailButtonPressed_b__1();
			internal void _OnDetailButtonPressed_b__2();
		}
	
		// Constructors
		public PartySwitchPopupCell();
	
		// Methods
		public void SetupCellData(PartySwitchLocation location, int questId, int partyIndex, int cellIndex, Action<int, int, bool> formationAction = null, Action<int, int> partyChangeAction = null, Action<int> copyPartyAction = null, Action historyButtonAction = null, Action updatePartyNamesAction = null);
		public void SetLimitedElementBalloon(ElementalType elementalType);
		public void OnFormationButtonPressed();
		public void OnHistoryButtonPressed();
		private void CheckLostUnit(int cellIndex);
		public void OnPartyChangeButtonPressed();
		private void ChangeButtonAction(int selectPartyIndex);
		protected override void OnDetailButtonPressed();
		protected override void OnCharaIconPressed(int tag);
	}
}
