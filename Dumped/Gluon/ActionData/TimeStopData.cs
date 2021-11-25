using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class TimeStopData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsTimeStop.SwitchingType _switching;

		[SerializeField]
		[HideInInspector]
		private float _productionDelay01;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public Gluon.ActionPartsTimeStop.SwitchingType switching => default(Gluon.ActionPartsTimeStop.SwitchingType);

		public float productionDelay01 => default(float);

		public bool guarantee => default(bool);
	}
}
