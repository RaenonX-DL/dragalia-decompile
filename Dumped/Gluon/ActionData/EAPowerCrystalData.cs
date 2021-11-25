using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class EAPowerCrystalData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _abilityId;

		[SerializeField]
		[HideInInspector]
		private EnemyAbilityProcPowerCrystal.ConditionType _conditionType;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public int abilityId => default(int);

		public EnemyAbilityProcPowerCrystal.ConditionType conditionType => default(EnemyAbilityProcPowerCrystal.ConditionType);

		public bool guarantee => default(bool);
	}
}
