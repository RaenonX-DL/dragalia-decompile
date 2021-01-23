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
	public class PartyEquipStatusPopup : PopupBase
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
	
		// Constructors
		public PartyEquipStatusPopup();
	
		// Methods
		public static PartyEquipStatusPopup Create(PartySettingList partySettingList);
		public void Initialize(PartySettingList partySettingList);
		private void SetCrest(CommonIcon icon, Transform decoNode, bool hasSlot, int crestId);
		public void OnAbilityButtonPressed(int index);
		public void OnExAbilityButtonPressed(int index);
		public void OnSkillButtonPressed(int index);
		public void OnShareSkillButtonPressed(int index);
	}
}
