using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ScapegoatRitesData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private string _hitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private string _effName;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public string hitAttrLabel => null;

		public string effName => null;

		public bool guarantee => default(bool);
	}
}
