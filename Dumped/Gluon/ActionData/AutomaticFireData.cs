using System;
using Gluon.Bullet;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class AutomaticFireData : BulletData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.Bullet.ActionPartsAutomaticFire.TargetPattern _pattern;

		[SerializeField]
		[HideInInspector]
		private float _generateInterval;

		[SerializeField]
		[HideInInspector]
		private bool _noTimeRestriction;

		[SerializeField]
		[HideInInspector]
		private bool _isBulletLimit;

		[SerializeField]
		[HideInInspector]
		private int _bulletLimitNum;

		[SerializeField]
		[HideInInspector]
		private float _generateRangeMin;

		[SerializeField]
		[HideInInspector]
		private float _generateRangeMax;

		[SerializeField]
		[HideInInspector]
		private bool _isFireNoTarget;

		[SerializeField]
		[HideInInspector]
		private bool _isLookTarget;

		[SerializeField]
		[HideInInspector]
		private bool _isGenerateToDeadTarget;

		[SerializeField]
		[HideInInspector]
		private bool _useMarker;

		[SerializeField]
		[HideInInspector]
		private MarkerData _marker;

		[SerializeField]
		[HideInInspector]
		private int _traceDelay;

		[SerializeField]
		[HideInInspector]
		private float _bulletDelay;

		[SerializeField]
		[HideInInspector]
		private EffectData _noticeEffect;

		[SerializeField]
		[HideInInspector]
		private MultiBulletData.NoticeEffectBase _noticeEffectBase;

		[SerializeField]
		[HideInInspector]
		private Vector3 _noticeEffectOffsetRot;

		[SerializeField]
		[HideInInspector]
		private float _noticeEffectDelay;

		[SerializeField]
		[HideInInspector]
		private float _interval_Special01;

		public Gluon.Bullet.ActionPartsAutomaticFire.TargetPattern pattern => default(Gluon.Bullet.ActionPartsAutomaticFire.TargetPattern);

		public float generateInterval => default(float);

		public bool noTimeRestriction => default(bool);

		public bool isBulletLimit => default(bool);

		public int bulletLimitNum => default(int);

		public float generateRangeMin => default(float);

		public float generateRangeMax => default(float);

		public bool isFireNoTarget => default(bool);

		public bool isLookTarget => default(bool);

		public bool isGenerateToDeadTarget => default(bool);

		public bool useMarker => default(bool);

		public MarkerData markerData => null;

		public int traceDelay => default(int);

		public float bulletDelay => default(float);

		public EffectData noticeEffect => null;

		public MultiBulletData.NoticeEffectBase noticeEffectBase => default(MultiBulletData.NoticeEffectBase);

		public Vector3 noticeEffectOffsetRot => default(Vector3);

		public float noticeEffectDelay => default(float);

		public float interval_Special01 => default(float);
	}
}
