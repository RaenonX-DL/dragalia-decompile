using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SetupEventHealData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _chargeTime;

		[SerializeField]
		[HideInInspector]
		private float _waitTime;

		[SerializeField]
		[HideInInspector]
		private string _healHitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private string _effName;

		[SerializeField]
		[HideInInspector]
		private string _seName;

		public float chargeTime => default(float);

		public float waitTime => default(float);

		public string healHitAttrLabel => null;

		public string effName => null;

		public string seName => null;
	}
}
