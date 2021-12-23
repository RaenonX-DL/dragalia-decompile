using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SkillAbilityDetailPopup : PopupBase
	{
		public enum PopupType
		{
			None,
			Skill,
			Ability,
			ExAbility,
			RaidBoost,
			WeaponAbility,
			DmodeServitorPassive
		}

		public Image iconImage;

		public Text nameText;

		public Text detailText;

		public Transform iconDecoNode;

		public Text conditionMessage;

		public Text titleText;

		public GameObject weaponElementalUnmatchedNode;

		[SerializeField]
		protected RectTransform popupFrame;

		[SerializeField]
		protected RectTransform popupCenter;

		[SerializeField]
		protected RectTransform actionParamDetailScrollView;

		[SerializeField]
		protected Text actionParamDetailSkillText;

		[HideInInspector]
		public string abilityConditionMessage;

		protected CommonIconListSortDeco iconDeco;

		private const string prefabPath = "Prefabs/OutGame/UnitDetail/SkillAbilityDetailPopup";

		protected int id;

		protected int level;

		protected int maxLevel;

		protected PopupType popupType;

		protected bool displayObtainingMessage;

		protected bool displayWeaponElementalUnmatchedMessage;

		protected ElementalType elementalType;

		protected WeaponType weaponType;

		protected List<int> duplicationAbilityIds;

		protected AbilityConst.UnitType giftType;

		protected bool isFirstExAbility;

		private const int actionParamDetailFrameSize = 750;

		private const int actionParamDetailDefaultCenterSize = 555;

		private const int actionParamaDetailScrollViewSizeM = 200;

		private const int actionParamaDetailScrollViewSizeL = 270;

		public static SkillAbilityDetailPopup CreateSkillDetailPopup(int skillId, int level, int maxLevel, bool displayWeaponElementalUnmatchedMessage = false, bool isUnopenSkill = true)
		{
			return null;
		}

		public static SkillAbilityDetailPopup CreateAbilityDetailPopup(int abilityId, ElementalType elementalType, bool displayObtainingMessage)
		{
			return null;
		}

		public static SkillAbilityDetailPopup CreateWeaponAbilityDetailPopup(int abilityId, ElementalType elementalType, bool displayObtainingMessage)
		{
			return null;
		}

		public static SkillAbilityDetailPopup CreateAbilityDetailPopup(int abilityId, ElementalType elementalType, WeaponType weaponType, bool displayObtainingMessage, List<int> duplicationAbilityIds, AbilityConst.UnitType abilityGiftType)
		{
			return null;
		}

		public static SkillAbilityDetailPopup CreateExAbilityDetailPopup(int exAbilityId, bool displayObtainingMessage, bool isFirstAbility = false)
		{
			return null;
		}

		public static SkillAbilityDetailPopup CreateDmodeServitorPassiveDetailPopup(int passiveLevelId)
		{
			return null;
		}

		public static SkillAbilityDetailPopup CreateRaidBoostDetailPopup(RaidBoostPopup.RaidBoostModel.CellData data)
		{
			return null;
		}

		private void SetupWithRaidBoostData(RaidBoostPopup.RaidBoostModel.CellData data)
		{
		}

		protected override void Start()
		{
		}

		private void SetIconImage(PopupType type, string iconPath)
		{
		}

		protected void SetNameText(string name, ElementalType type = ElementalType.NONE, WeaponType weaponType = WeaponType.NONE)
		{
		}

		protected void SetDetailText(string detail, ElementalType type = ElementalType.NONE, WeaponType weaponType = WeaponType.NONE)
		{
		}

		private void SetActionParameterDetailText(int skillId, int level)
		{
		}

		private void SetLevelText(int level, bool isMax = false)
		{
		}

		private void SetConditionMessage(bool show)
		{
		}
	}
}
