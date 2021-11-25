using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class TanatosHitPivotBulletData : PivotBulletData
	{
		[SerializeField]
		[HideInInspector]
		private int[] _countdouwnParam;

		[SerializeField]
		[HideInInspector]
		private int[] _countdouwnParam2;

		public int[] countdouwnParam => null;

		public int[] countdouwnParam2 => null;
	}
}
