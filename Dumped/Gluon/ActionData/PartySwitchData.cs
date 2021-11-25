using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class PartySwitchData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		[SerializeField]
		[HideInInspector]
		private MainGameCtrl.PartySwitchPhase _phase;

		[SerializeField]
		[HideInInspector]
		private int _nextActionId;

		[SerializeField]
		[HideInInspector]
		private float _minWaitSec;

		public bool guarantee => default(bool);

		public MainGameCtrl.PartySwitchPhase phase => default(MainGameCtrl.PartySwitchPhase);

		public int nextActionId => default(int);

		public float minWaitSec => default(float);
	}
}
