using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class RebornData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		[SerializeField]
		[HideInInspector]
		private float _range;

		[SerializeField]
		[HideInInspector]
		private bool _withSpCharge;

		public bool guarantee => default(bool);

		public float range => default(float);

		public bool withSpCharge => default(bool);
	}
}
