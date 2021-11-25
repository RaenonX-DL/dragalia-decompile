using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class EnemyBoostData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private bool _onoff;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public bool onoff => default(bool);

		public bool guarantee => default(bool);
	}
}
