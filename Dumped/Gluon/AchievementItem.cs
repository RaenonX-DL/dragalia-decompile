using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AchievementItem : MonoBehaviour
	{
		public enum AchievementType
		{
			charaLevel,
			charaManaCircle,
			weaponLevel,
			weaponLimitBreak,
			amuletLevel,
			amuletLimitBreak,
			dragonLevel,
			dragonLimitBreak,
			dragonFriendShip
		}

		[SerializeField]
		private Image clearIcon;

		[SerializeField]
		private Text itemText;

		public void SetItem(bool isClear, string str)
		{
		}

		public void SetItem(AchievementType type)
		{
		}
	}
}
