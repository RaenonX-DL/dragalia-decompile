/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class BulletObjectWithMarker : BulletObject
	{
		// Fields
		protected State _state;
		protected MarkerData _markerData;
		protected ChargeMarker _marker;
		protected Vector3 _markerPosition;
		protected Vector3 _ownerPosition;
		protected Quaternion _ownerRotation;
		protected float _tempoScale;
		protected float _markingTiming;
		protected float _fireTiming;
		protected float _markingDuration;
		protected float _markerTraceSec;
		protected float _bulletDuration;
		protected float _fromCharaToMarkerTime;
		protected bool _isfromCharaToMarkerWithCollision;
		protected bool _isFromCharaToMarker;
		protected bool _isFirstTimeDelay;
		protected float _collisonDelayTime;
		protected bool _hasHit;
		protected bool _hasHitProcess;
		protected ChargeMarker.TraceType _traceType;
		protected List<Vector3> _logTargetPosition;
		protected int _traceDelay;
		private int _currentIdx;
		private Gluon.ActionData.EffectData _noticeEffectData;
		private float _noticeEffectDelay;
		private MultiBulletData.NoticeEffectBase _noticeEffectBase;
		private Vector3 _noticeEffectOffsetRot;
		protected EffectObject _noticeEffectObject;
		private bool _resetBulletPrevPos;
		private bool _useLegacyClearMarker;
		protected MakerMoveTimeCurve _markerMoveTimeCurve;
		private Vector3 _prePosMMTC;
	
		// Nested types
		protected enum State
		{
			Init = 0,
			Delay = 1,
			MarkerSet = 2,
			MarkerRun = 3,
			Fire = 4,
			BulletRun = 5,
			After = 6,
			End = 7
		}
	
		public class MakerMoveTimeCurve
		{
			// Fields
			public BaseAxisType _axisType;
			public float _offsetAngle;
			public AnimationCurve _curveX;
			public AnimationCurve _curveZ;
	
			// Nested types
			public enum BaseAxisType
			{
				World = 0,
				AreaAnchor = 1,
				Owner = 2
			}
	
			// Constructors
			public MakerMoveTimeCurve();
	
			// Methods
			public Vector3 Evaluate(float frame);
		}
	
		[CompilerGenerated]
		private sealed class _CoNoticeEffect_d__56 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BulletObjectWithMarker __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoNoticeEffect_d__56(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BulletObjectWithMarker();
	
		// Methods
		protected override void Clear();
		private void OnMarkerClear(ChargeMarker marker, bool canRemove);
		public virtual bool Initialize(CharacterBase owner, CommonObjectStatus target, float waitCount, float delay, float bulletDuration, int traceDelay, string hitAttrLabel, MarkerData markerData, Vector3 position, Quaternion rotation, float tempoScale = 1f, bool useLegacyClearMarker = false);
		protected virtual void SetState(State state);
		protected override void Start();
		protected override bool OnUpdate();
		protected virtual bool State_Init();
		protected virtual bool State_Delay();
		protected virtual bool State_MarkerSet();
		protected virtual bool State_MarkerRun();
		protected virtual bool State_Fire();
		protected virtual bool State_BulletRun();
		protected virtual bool State_After();
		protected virtual bool State_End();
		private void Trace();
		protected void MoveMarkerTimeCurve();
		public void SetupMarkerMoveTimeCurve(MakerMoveTimeCurve.BaseAxisType axisType, float offsetAngle, AnimationCurve curveX, AnimationCurve curveZ);
		public override void OnCollided(GameObject target, bool isPropagation);
		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public static string GetHitAttributeLabel(CharacterBase owner, BulletWithMarkerData data);
		public void SetNoticeEffect(Gluon.ActionData.EffectData eff_data, float delaytime, MultiBulletData.NoticeEffectBase noticeEffectBase, Vector3 offsetRot);
		public void SetFromCharaToMarkerWithCollision(float fromCharaToMarkerTime, bool isfromCharaToMarkerWithCollision, float collisonDelayTime);
		[IteratorStateMachine]
		private IEnumerator CoNoticeEffect();
		public void SetMarkerData(MarkerData marker_data);
		private void BulletRunDuringDelay();
	}
}
