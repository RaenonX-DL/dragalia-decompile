using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitDetailAbilityInfoCell : UnitDetailInfoBaseCell
	{
		[SerializeField]
		[Header("ExAbility")]
		public Text exAbilityDescription;

		public static bool startBatch;

		private ElementalType elementalType;

		private bool isAbility;

		private AbilityPageData abilityPageData;

		private bool isFirstAbility;

		public override void IconPressed()
		{
		}

		public void SetAbilityInfo(AbilityConst.UnitType giftType, int abilityId, bool isAbilityEnabled, ElementalType type)
		{
		}

		public void SetAbilityInfo(AbilityPageData data)
		{
		}

		public void SetExAbilityInfo(int abilityId, bool isAbilityEnabled)
		{
		}
	}
}
