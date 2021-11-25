using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class BuffFieldAttachmentData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private bool _isAttachToBuffField;

		[SerializeField]
		[HideInInspector]
		private bool _isAttachToSelfBuffField;

		[SerializeField]
		[HideInInspector]
		private bool _enableApplyMultipleDebuff;

		[SerializeField]
		[HideInInspector]
		private EffectData _fieldEffect;

		[SerializeField]
		[HideInInspector]
		private string _hitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private float _hitDelaySec;

		[SerializeField]
		[HideInInspector]
		private bool _useSameComponent;

		[SerializeField]
		[HideInInspector]
		private bool _useElementalHit;

		[SerializeField]
		[HideInInspector]
		private string _seName;

		[SerializeField]
		[HideInInspector]
		private string[] _elementalHitLabel;

		public bool isAttachToBuffField => default(bool);

		public bool isAttachToSelfBuffField => default(bool);

		public bool enableApplyMultipleDebuff => default(bool);

		public EffectData fieldEffect => null;

		public string hitAttrLabel => null;

		public float hitDelaySec => default(float);

		public bool useSameComponent => default(bool);

		public bool useElementalHit => default(bool);

		public string seName => null;

		public string[] elementalHitLabel => null;
	}
}
