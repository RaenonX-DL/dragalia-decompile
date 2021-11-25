using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class TanatosHitData : HitData
	{
		[SerializeField]
		[HideInInspector]
		private int[] _countdouwnParam;

		[SerializeField]
		[HideInInspector]
		private int[] _countdouwnParam2;

		[SerializeField]
		[HideInInspector]
		private string _customHitLabel;

		public int[] countdouwnParam => null;

		public int[] countdouwnParam2 => null;

		public string customHitLabel => null;
	}
}
