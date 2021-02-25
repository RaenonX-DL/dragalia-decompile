/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipStatusPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private CommonIcon charaIcon;
		[SerializeField]
		private UnityEngine.UI.Text charaNameText;
		[SerializeField]
		private UnityEngine.UI.Text manaCircleText;
		[SerializeField]
		private UnityEngine.UI.Text hpText;
		[SerializeField]
		private UnityEngine.UI.Text attackText;
		[SerializeField]
		private UnityEngine.UI.Text powerText;
		[SerializeField]
		private CommonIcon weaponIcon;
		[SerializeField]
		private CommonIcon dragonIcon;
		[SerializeField]
		private CommonIcon[] crestIcons;
		[SerializeField]
		private Image[] skillIcons;
		[SerializeField]
		private Image[] charaAbilityIcons;
		[SerializeField]
		private Image[] charaAbilityLockIcons;
		[SerializeField]
		private Image[] editSkillIcons;
		[SerializeField]
		private Image[] exAbilityIcons;
		[SerializeField]
		private Transform charaDecoNode;
		[SerializeField]
		private Transform dragonDecoNode;
		[SerializeField]
		private Transform weaponDecoNode;
		[SerializeField]
		private Transform[] crestDecoNodes;
		[SerializeField]
		private Image[] crestLockIcons;
		[SerializeField]
		private Image[] skillLockIcons;
		[SerializeField]
		private GameObject bonusButtonBase;
		[SerializeField]
		private GameObject unionBonusButtonObject;
		[SerializeField]
		private GameObject eventBonusButtonObject;
		[SerializeField]
		private GameObject[] crestInfoUIBases;
		[SerializeField]
		private GameObject[] editSkillInfoUIBases;
		private List<EventBonusPopup.EventBonusCharaInfo> eventAbilityInfo;
		private List<UnionBonusPopup.UnionBonusInfo> unionBonusCharaInfoList;
		private ElementalType charaElementalType;
		private int[] exAbilityIds;
		private int[] skillIds;
		private int[] skillLevels;
		private int[] skillMaxLevels;
		private int[] shareSkillIds;
		private int[] shareSkillLevels;
		private int[] shareSkillMaxLevels;
		private int[] abilityIds;
		private bool[] isLockedAbility;
		private int currentCharacterIndexInParty;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0
		{
			// Fields
			public EventBonusPopup popup;
	
			// Constructors
			public __c__DisplayClass47_0();
	
			// Methods
			internal void _OnEventButtonPressed_b__0();
		}
	
		// Constructors
		public PartyEquipStatusPopup();
	
		// Methods
		public static PartyEquipStatusPopup Create();
		public void InitEquipScene(PartySettingList partySettingList, bool isEquipSetPopup = false);
		public void InitEquipSet(int charaId, int index, bool canSelectEquipSet = true);
		private void Initialize(PartySettingList partySettingList);
		private void SetCrest(CommonIcon icon, Transform decoNode, bool hasSlot, int crestId);
		public void OnAbilityButtonPressed(int index);
		public void OnExAbilityButtonPressed(int index);
		public void OnSkillButtonPressed(int index);
		public void OnShareSkillButtonPressed(int index);
		public void OnEventButtonPressed();
		public void OnUnionButtonPressed();
	}
}
