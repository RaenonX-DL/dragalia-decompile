using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class EALinkedEnemyBuffData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private bool _onoff;

		[SerializeField]
		[HideInInspector]
		private int[] _linkedId;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public bool onoff => default(bool);

		public int[] linkedId => null;

		public bool guarantee => default(bool);
	}
}
