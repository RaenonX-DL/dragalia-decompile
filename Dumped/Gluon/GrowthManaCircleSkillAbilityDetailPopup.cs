using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleSkillAbilityDetailPopup : CommonPopup
	{
		public enum PopupType
		{
			None,
			Skill,
			Ability,
			ExAbility
		}

		public Image iconImage;

		public Text nameText;

		public Text detailText;

		public Text levelText;

		public static GrowthManaCircleSkillAbilityDetailPopup Create(string dialogPath, bool showBlackLayer = true)
		{
			return null;
		}

		public void SetSkillIconImage(PopupType type, string iconName)
		{
		}

		public void SetAbilityIconImage(PopupType type, string iconName)
		{
		}

		public void SetNameText(string name)
		{
		}

		public void SetDetailText(string detail)
		{
		}

		public void SetLevelText(string level)
		{
		}
	}
}
