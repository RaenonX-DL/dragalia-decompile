using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class EnemyAbilityData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _abilityId;

		[SerializeField]
		[HideInInspector]
		private bool _onoff;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public int abilityId => default(int);

		public bool onoff => default(bool);

		public bool guarantee => default(bool);
	}
}
