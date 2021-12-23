using System.Collections.Generic;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipStatusPopup : CommonPopup
	{
		[SerializeField]
		private CommonIcon charaIcon;

		[SerializeField]
		private Text charaNameText;

		[SerializeField]
		private Text manaCircleText;

		[SerializeField]
		private Text hpText;

		[SerializeField]
		private Text attackText;

		[SerializeField]
		private Text powerText;

		[SerializeField]
		private CommonIcon weaponIcon;

		[SerializeField]
		private CommonIcon dragonIcon;

		[SerializeField]
		private CommonIcon[] crestIcons;

		[SerializeField]
		private CommonIcon talismanIcon;

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

		public static PartyEquipStatusPopup Create()
		{
			return null;
		}

		public void InitEquipScene(PartySettingList partySettingList, bool isEquipSetPopup = false)
		{
		}

		public void InitEquipSet(int charaId, int index, bool canSelectEquipSet = true)
		{
		}

		private void Initialize(PartySettingList partySettingList)
		{
		}

		private void SetCrest(CommonIcon icon, Transform decoNode, bool hasSlot, int crestId)
		{
		}

		public void OnAbilityButtonPressed(int index)
		{
		}

		public void OnExAbilityButtonPressed(int index)
		{
		}

		public void OnSkillButtonPressed(int index)
		{
		}

		public void OnShareSkillButtonPressed(int index)
		{
		}

		public void OnEventButtonPressed()
		{
		}

		public void OnUnionButtonPressed()
		{
		}
	}
}
