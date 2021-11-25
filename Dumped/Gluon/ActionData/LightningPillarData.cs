using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class LightningPillarData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _chargeTime;

		[SerializeField]
		[HideInInspector]
		private string _hitAttributeLabel;

		[SerializeField]
		[HideInInspector]
		private float _waitTime;

		[SerializeField]
		[HideInInspector]
		private float _cyclicInterval;

		[SerializeField]
		[HideInInspector]
		private string _cyclicHitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private float _cyclicHitRadius;

		[SerializeField]
		[HideInInspector]
		private string _cyclicEffectLabel;

		[SerializeField]
		[HideInInspector]
		private float _signTime;

		[SerializeField]
		[HideInInspector]
		private string _signEffectLabel;

		[SerializeField]
		[HideInInspector]
		private int _childActionId;

		public float chargeTime => default(float);

		public string hitAttributeLabel => null;

		public float waitTime => default(float);

		public float cyclicInterval => default(float);

		public string cyclicHitAttrLabel => null;

		public float cyclicHitRadius => default(float);

		public string cyclicEffectLabel => null;

		public float signTime => default(float);

		public string signEffectLabel => null;

		public int childActionId => default(int);
	}
}
