/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Bullet;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class AutomaticFireData : BulletData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsAutomaticFire.TargetPattern _pattern;
		[HideInInspector]
		[SerializeField]
		private float _generateInterval;
		[HideInInspector]
		[SerializeField]
		private bool _noTimeRestriction;
		[HideInInspector]
		[SerializeField]
		private bool _isBulletLimit;
		[HideInInspector]
		[SerializeField]
		private int _bulletLimitNum;
		[HideInInspector]
		[SerializeField]
		private float _generateRangeMin;
		[HideInInspector]
		[SerializeField]
		private float _generateRangeMax;
		[HideInInspector]
		[SerializeField]
		private bool _isFireNoTarget;
		[HideInInspector]
		[SerializeField]
		private bool _isLookTarget;
		[HideInInspector]
		[SerializeField]
		private bool _isGenerateToDeadTarget;
		[HideInInspector]
		[SerializeField]
		private bool _useMarker;
		[HideInInspector]
		[SerializeField]
		private MarkerData _marker;
		[HideInInspector]
		[SerializeField]
		private int _traceDelay;
		[HideInInspector]
		[SerializeField]
		private float _bulletDelay;
		[HideInInspector]
		[SerializeField]
		private EffectData _noticeEffect;
		[HideInInspector]
		[SerializeField]
		private MultiBulletData.NoticeEffectBase _noticeEffectBase;
		[HideInInspector]
		[SerializeField]
		private Vector3 _noticeEffectOffsetRot;
		[HideInInspector]
		[SerializeField]
		private float _noticeEffectDelay;
		[HideInInspector]
		[SerializeField]
		private float _interval_Special01;
	
		// Properties
		public ActionPartsAutomaticFire.TargetPattern pattern { get; }
		public float generateInterval { get; }
		public bool noTimeRestriction { get; }
		public bool isBulletLimit { get; }
		public int bulletLimitNum { get; }
		public float generateRangeMin { get; }
		public float generateRangeMax { get; }
		public bool isFireNoTarget { get; }
		public bool isLookTarget { get; }
		public bool isGenerateToDeadTarget { get; }
		public bool useMarker { get; }
		public MarkerData markerData { get; }
		public int traceDelay { get; }
		public float bulletDelay { get; }
		public EffectData noticeEffect { get; }
		public MultiBulletData.NoticeEffectBase noticeEffectBase { get; }
		public Vector3 noticeEffectOffsetRot { get; }
		public float noticeEffectDelay { get; }
		public float interval_Special01 { get; }
	
		// Constructors
		public AutomaticFireData();
	}
}
