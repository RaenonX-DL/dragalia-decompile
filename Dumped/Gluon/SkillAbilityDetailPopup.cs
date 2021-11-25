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
			WeaponAbility
		}

		public Image iconImage;

		public Text nameText;

		public Text detailText;

		public Transform iconDecoNode;

		public Text conditionMessage;

		public Text titleText;

		public GameObject weaponElementalUnmatchedNode;

		[SerializeField]
		private RectTransform popupFrame;

		[SerializeField]
		private RectTransform popupCenter;

		[SerializeField]
		private RectTransform actionParamDetailScrollView;

		[SerializeField]
		private Text actionParamDetailSkillText;

		[HideInInspector]
		public string abilityConditionMessage;

		private CommonIconListSortDeco iconDeco;

		private const string prefabPath = "Prefabs/OutGame/UnitDetail/SkillAbilityDetailPopup";

		private int id;

		private int level;

		private int maxLevel;

		private PopupType popupType;

		private bool displayObtainingMessage;

		private bool displayWeaponElementalUnmatchedMessage;

		private ElementalType elementalType;

		private List<int> duplicationAbilityIds;

		private AbilityConst.UnitType giftType;

		private bool isFirstExAbility;

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

		public static SkillAbilityDetailPopup CreateAbilityDetailPopup(int abilityId, ElementalType elementalType, bool displayObtainingMessage, List<int> duplicationAbilityIds, AbilityConst.UnitType abilityGiftType)
		{
			return null;
		}

		public static SkillAbilityDetailPopup CreateExAbilityDetailPopup(int exAbilityId, bool displayObtainingMessage, bool isFirstAbility = false)
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

		private void SetNameText(string name, ElementalType type = ElementalType.NONE)
		{
		}

		private void SetDetailText(string detail, ElementalType type = ElementalType.NONE)
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
