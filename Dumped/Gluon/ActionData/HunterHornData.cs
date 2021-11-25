using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class HunterHornData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private string _hitLabel;

		[SerializeField]
		[HideInInspector]
		private string _hitLabelBoost;

		[SerializeField]
		[HideInInspector]
		private string _seName;

		public string hitLabel => null;

		public string hitLabelBoost => null;

		public string seName => null;
	}
}
