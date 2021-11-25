using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UnionBonusDetailPopup : CommonPopup
	{
		private const string prefabPath = "Prefabs/OutGame/Party/Party/UnionBonusDetailPopup";

		[SerializeField]
		private Image unionIcon;

		[SerializeField]
		private Text unionNameText;

		[SerializeField]
		private Image abilityIcon;

		[SerializeField]
		private Text abilityNameText;

		[SerializeField]
		private Text descriptionText;

		public static UnionBonusDetailPopup Create()
		{
			return null;
		}

		public void Setup(int charaId, UnionAbilityElement unionAbility, AbilityDataElement abilityData)
		{
		}

		public void Setup(int charaId, int unionAbilityId, int abilityId)
		{
		}

		public void Setup(UnionAbilityElement unionAbility, AbilityDataElement abilityData)
		{
		}
	}
}
