/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartySelectPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private PartySelectPopupCell[] cells;
		public Image partyGroupIcon;
		public Sprite[] partyGroupSprites;
		public UnityEngine.UI.Text partyNameText;
		[SerializeField]
		private UnityEngine.UI.Text powerText;
		[SerializeField]
		private GameObject pagerParent;
		[SerializeField]
		private float pagerWidth;
		private int selectPartyNo;
		private int selectPartyGroup;
		private List<PartyPager> pagers;
		private UnityAction onPartyChanged;
		private const string popupPrefabPath = "Prefabs/OutGame/QuestSupportSelect/Popup/PartySelectPopup";
		private const string raidPopupPrefabPath = "Prefabs/OutGame/QuestSupportSelect/Popup/RaidPartySelectPopup";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public PartyChangePopup popup;
			public PartySelectPopup __4__this;
			public int nowPartyIndex;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _OnPartyChangeButtonPressed_b__0(int partyIndex, bool isOtherGroupLoad);
			internal void _OnPartyChangeButtonPressed_b__1();
		}
	
		// Constructors
		public PartySelectPopup();
	
		// Methods
		public static PartySelectPopup Create(bool isRaidBattle, UnityAction onPartyChanged);
		private void Initialize(UnityAction onPartyChanged);
		private void UpdatePartyData();
		public void OnOk();
		public void OnCloseButton();
		private void OnPagerPressed(int pressedPagerIndex);
		public void OnPartyChangeButtonPressed();
		public void OnArrowPressed(int increment);
		private void ReloadPager();
		[CompilerGenerated]
		private void _Initialize_b__14_0(int index);
		[CompilerGenerated]
		private void _OnOk_b__16_0();
		[CompilerGenerated]
		private void _ReloadPager_b__21_0(int index);
	}
}
