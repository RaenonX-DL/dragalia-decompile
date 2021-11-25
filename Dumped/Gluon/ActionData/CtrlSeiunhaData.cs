using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class CtrlSeiunhaData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsCtrlSeiunha.Order _order;

		[SerializeField]
		[HideInInspector]
		private InGameDef.CharacterType _characterType;

		[SerializeField]
		[HideInInspector]
		private string _hitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private string _hitAttrLabelExplosion;

		[SerializeField]
		[HideInInspector]
		private float _radius;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetPos;

		[SerializeField]
		[HideInInspector]
		private float _offsetDir;

		[SerializeField]
		[HideInInspector]
		private float _bulletSpeed;

		[SerializeField]
		[HideInInspector]
		private float _lifetime;

		[SerializeField]
		[HideInInspector]
		private float _afterglowTime;

		[SerializeField]
		[HideInInspector]
		private bool _isHoming;

		[SerializeField]
		[HideInInspector]
		private float _scaleSpeed;

		[SerializeField]
		[HideInInspector]
		private float _radiusMax;

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private string _seFire;

		[SerializeField]
		[HideInInspector]
		private string _seExplosion;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public Gluon.ActionPartsCtrlSeiunha.Order order => default(Gluon.ActionPartsCtrlSeiunha.Order);

		public InGameDef.CharacterType characterType => default(InGameDef.CharacterType);

		public string hitAttrLabel => null;

		public string hitAttrLabelExplosion => null;

		public float radius => default(float);

		public Vector3 offsetPos => default(Vector3);

		public float offsetDir => default(float);

		public float bulletSpeed => default(float);

		public float lifetime => default(float);

		public float afterglowTime => default(float);

		public bool isHoming => default(bool);

		public float scaleSpeed => default(float);

		public float radiusMax => default(float);

		public string effectName => null;

		public string seFire => null;

		public string seExplosion => null;

		public bool guarantee => default(bool);
	}
}
