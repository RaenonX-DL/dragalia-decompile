using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class VolcanoData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private MarkerData _marker;

		[SerializeField]
		[HideInInspector]
		private string _hitAttributeLabel;

		[SerializeField]
		[HideInInspector]
		private string _attachEffectLabel;

		[SerializeField]
		[HideInInspector]
		private string _explosionEffectLabel;

		public MarkerData markerData => null;

		public string hitAttributeLabel => null;

		public string attachEffectLabel => null;

		public string explosionEffectLabel => null;
	}
}
