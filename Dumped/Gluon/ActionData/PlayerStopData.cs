using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class PlayerStopData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsPlayerStop.SwitchingType _switching;

		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsPlayerStop.StopTypes _stopType;

		[SerializeField]
		[HideInInspector]
		private bool _acrossAction;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public Gluon.ActionPartsPlayerStop.SwitchingType switching => default(Gluon.ActionPartsPlayerStop.SwitchingType);

		public Gluon.ActionPartsPlayerStop.StopTypes stopType => default(Gluon.ActionPartsPlayerStop.StopTypes);

		public bool acrossAction => default(bool);

		public bool guarantee => default(bool);
	}
}
