using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class B00255Data : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _expanLength;

		[SerializeField]
		[HideInInspector]
		private float _expanSec;

		[SerializeField]
		[HideInInspector]
		private float _rollingCnt;

		[SerializeField]
		[HideInInspector]
		private float _rollingSec;

		[SerializeField]
		[HideInInspector]
		private string _ringEffect;

		[SerializeField]
		[HideInInspector]
		private string _beamEffect;

		[SerializeField]
		[HideInInspector]
		private string _optionEffect;

		[SerializeField]
		[HideInInspector]
		private string _rollingSe;

		[SerializeField]
		[HideInInspector]
		private string _beamSe;

		[SerializeField]
		[HideInInspector]
		private int _effectTriggerIdx;

		[SerializeField]
		[HideInInspector]
		private bool _effectInfluencedCharaterElement;

		[SerializeField]
		[HideInInspector]
		private string _hitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private bool _useElementalHit;

		[SerializeField]
		[HideInInspector]
		private string[] _elementalHitLabel;

		public float expanLength => default(float);

		public float expanSec => default(float);

		public float rollingCnt => default(float);

		public float rollingSec => default(float);

		public string ringEffect => null;

		public string beamEffect => null;

		public string optionEffect => null;

		public string rollingSe => null;

		public string beamSe => null;

		public int effectTriggerIdx => default(int);

		public bool effectInfluencedCharaterElement => default(bool);

		public string hitAttrLabel => null;

		public bool useElementalHit => default(bool);

		public string[] elementalHitLabel => null;
	}
}
