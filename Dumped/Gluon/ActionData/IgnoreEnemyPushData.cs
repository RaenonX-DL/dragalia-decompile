using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class IgnoreEnemyPushData : ActionParts.PartsData
	{
		public static readonly int ENEMY_PARAM_NUM;

		[SerializeField]
		[HideInInspector]
		private int[] _paramId;

		[SerializeField]
		[HideInInspector]
		private bool _onoff;

		public int[] paramId => null;

		public bool onoff => default(bool);
	}
}
