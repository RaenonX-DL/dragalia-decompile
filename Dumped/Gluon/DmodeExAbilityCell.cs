using UnityEngine;

namespace Gluon
{
	public class DmodeExAbilityCell : UnitDetailAbilityInfoCell
	{
		public enum Type
		{
			ExAbility,
			LinkedExAbility,
			Ability
		}

		private int id;

		private Type type;

		private ElementalType element;

		public GameObject exAbilityBG;

		public void Setup(int id, Type type, ElementalType element = ElementalType.NOELEMENT, AbilityConst.UnitType unitType = AbilityConst.UnitType.None)
		{
		}

		public void OnPressed()
		{
		}
	}
}
