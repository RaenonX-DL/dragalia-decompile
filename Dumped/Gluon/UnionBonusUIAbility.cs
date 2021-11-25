using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UnionBonusUIAbility : MonoBehaviour
	{
		[SerializeField]
		private Image unionIcon;

		[SerializeField]
		private Text abilityNameText;

		[SerializeField]
		private Text needUnionCountText;

		private int charaId;

		private UnionAbilityElement unionAbility;

		private AbilityDataElement abilityData;

		private bool showPartyUnionBonus;

		public void Setup(int charaId, UnionAbilityElement unionAbility, AbilityDataElement abilityData)
		{
		}

		public void Setup(int requiredCount, int abilityId, UnionAbilityElement unionBonus)
		{
		}

		public void OnPressed()
		{
		}
	}
}
