using UnityEngine;

namespace Gluon
{
	public class UnitSkillAndAbilityPage : MonoBehaviour
	{
		[SerializeField]
		[Header("Cells")]
		public UnitDetailSkillInfoCell SkillCell;

		public UnitDetailAbilityInfoCell abilityOneCell;

		public UnitDetailAbilityInfoCell abilityTwoCell;

		[HideInInspector]
		public UnitDetailCanvas parentCanvas;

		private UnitDetailModel.UnitDetailType unitType;

		public void SetupSkillAndAbilityPage(UnitDetailModel.UnitDetailType type)
		{
		}

		private void SetSkillInfo()
		{
		}

		private void SetAbilityInfo()
		{
		}
	}
}
