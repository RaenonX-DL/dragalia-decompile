using System;
using Gluon.CharacterUniqueGimmick;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class DollData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsDoll.Mode _mode;

		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsDoll.TargetType _targetType;

		[SerializeField]
		[HideInInspector]
		private float _targetRange;

		[SerializeField]
		[HideInInspector]
		private float _dollDuration;

		[SerializeField]
		[HideInInspector]
		private string _popEffect;

		[SerializeField]
		[HideInInspector]
		private int _timeupEffTrigger;

		[SerializeField]
		[HideInInspector]
		private string _popSE;

		[SerializeField]
		[HideInInspector]
		private string _timeupSE;

		[SerializeField]
		[HideInInspector]
		private CtrlDoll.DamageType _dmgType;

		[SerializeField]
		[HideInInspector]
		private bool _noHitDragon;

		[SerializeField]
		[HideInInspector]
		private bool _killOnRelease;

		[SerializeField]
		[HideInInspector]
		private bool _cancelAbnormal;

		[SerializeField]
		[HideInInspector]
		private bool _visible;

		[SerializeField]
		[HideInInspector]
		private bool _canTransform;

		[SerializeField]
		[HideInInspector]
		private string _logId;

		[SerializeField]
		[HideInInspector]
		private float _durationOfField;

		[SerializeField]
		[HideInInspector]
		private Vector2 _centerOfField;

		[SerializeField]
		[HideInInspector]
		private float _radiusOfField;

		[SerializeField]
		[HideInInspector]
		private float _limitTimeOfField;

		[SerializeField]
		[HideInInspector]
		private string _fieldEffect;

		[SerializeField]
		[HideInInspector]
		private string _fieldSE;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public Gluon.ActionPartsDoll.Mode mode => default(Gluon.ActionPartsDoll.Mode);

		public Gluon.ActionPartsDoll.TargetType targetType => default(Gluon.ActionPartsDoll.TargetType);

		public float targetRange => default(float);

		public float dollDuration => default(float);

		public string popEffect => null;

		public int timeupEffTrigger => default(int);

		public string popSE => null;

		public string timeupSE => null;

		public CtrlDoll.DamageType dmgType => default(CtrlDoll.DamageType);

		public bool noHitDragon => default(bool);

		public bool killOnRelease => default(bool);

		public bool cancelAbnormal => default(bool);

		public bool visible => default(bool);

		public bool canTransform => default(bool);

		public string logId => null;

		public float durationOfField => default(float);

		public Vector2 centerOfField => default(Vector2);

		public float radiusOfField => default(float);

		public float limitTimeOfField => default(float);

		public string fieldEffect => null;

		public string fieldSE => null;

		public bool guarantee => default(bool);
	}
}
