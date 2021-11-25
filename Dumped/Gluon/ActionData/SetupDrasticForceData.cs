using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SetupDrasticForceData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _stackSize;

		[SerializeField]
		[HideInInspector]
		private int[] _arrayForceRate;

		[SerializeField]
		[HideInInspector]
		private float _stackDuration;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public int stackSize => default(int);

		public int[] arrayForceRate => null;

		public float stackDuration => default(float);

		public bool guarantee => default(bool);
	}
}
