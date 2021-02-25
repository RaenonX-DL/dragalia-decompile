/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartySelectPopupCell : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public CommonIcon characterIcon;
		public CommonIcon dragonIcon;
		public GameObject noDragonMark;
		public CommonIcon weaponIcon;
		public CommonIcon[] amuletIcon;
		public GameObject[] noAmuletMark;
		[SerializeField]
		private GameObject abilityCrestPanel;
		[Header]
		[SerializeField]
		public Transform charaDecoNode;
		public Transform dragonDecoNode;
		public Transform weaponDecoNode;
		public Transform[] amuletDecoNode;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text characterNameText;
		public UnityEngine.UI.Text plusValText;
		public UnityEngine.UI.Text manaCircleText;
		public UnityEngine.UI.Text charaHpText;
		public UnityEngine.UI.Text charaAtkText;
		[SerializeField]
		private UnityEngine.UI.Text emptyAbilityCrestText;
		[Header]
		[SerializeField]
		private Image[] exAbility1Icons;
		[SerializeField]
		private Image[] exAbility2Icons;
		[SerializeField]
		private CommonExAbilityCell[] exAbilityCells;
		[SerializeField]
		private Sprite abilityIconBlankSprite;
		[SerializeField]
		private Material abilityIconBlankMaterial;
		[Header]
		[SerializeField]
		private Image skill3Icon;
		[SerializeField]
		private Image skill4Icon;
		private int skill3Id;
		private int skill3Level;
		private int skill3MaxLevel;
		private int skill4Id;
		private int skill4Level;
		private int skill4MaxLevel;
		private int memberIndex;
		private PartyList partyDataList;
		private CommonIconListSortDeco charaDeco;
		private CommonIconListSortDeco dragonDeco;
		private CommonIconListSortDeco weaponDeco;
		private CommonIconListSortDeco[] amuletDeco;
		private CommonPartyPowerCalculateData[] multiPartyPowerCalculateDatas;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public ExAbilityDialog exAbilityDialog;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _OnExAbilityButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public SkillAbilityDetailPopup popup;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal void _OnSkill3ButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public SkillAbilityDetailPopup popup;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal void _OnSkill4ButtonPressed_b__0();
		}
	
		// Constructors
		public PartySelectPopupCell();
	
		// Methods
		public void Setup(int partyNo, int memberIndex, PartyList clearParty = null);
		private void InitWithData();
		private static Color GetColor(CommonParamCalculate.OutGame.ManaCircleTextColor manaColor);
		private void SetAmulet(CommonIcon icon, CommonIconListSortDeco deco, GameObject noAmuletMark, int keyId, int slotNum, int maxSlotCount, ref int totalPlus, ref int totalMaxPlus, ref bool isAllEquip);
		public void OnExAbilityButtonPressed();
		public void OnSkill3ButtonPressed();
		public void OnSkill4ButtonPressed();
	}
}
