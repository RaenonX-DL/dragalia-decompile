using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SeitentaiseiHealData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _checkEnemyId;

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private string _hitAttributeLabel;

		[SerializeField]
		[HideInInspector]
		private float _healIntervalSec;

		public int checkEnemyId => default(int);

		public string effectName => null;

		public string hitAttributeLabel => null;

		public float healIntervalSec => default(float);
	}
}
