using System.Collections;
using System.Collections.Generic;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon.Bullet
{
	public class BulletObjectWithMarker : BulletObject
	{
		protected enum State
		{
			Init,
			Delay,
			MarkerSet,
			MarkerRun,
			Fire,
			BulletRun,
			After,
			End
		}

		public class MakerMoveTimeCurve
		{
			public enum BaseAxisType
			{
				World,
				AreaAnchor,
				Owner
			}

			public BaseAxisType _axisType;

			public float _offsetAngle;

			public AnimationCurve _curveX;

			public AnimationCurve _curveZ;

			public Vector3 Evaluate(float frame)
			{
				return default(Vector3);
			}
		}

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

		protected override void Clear()
		{
		}

		private void OnMarkerClear(ChargeMarker marker, bool canRemove)
		{
		}

		public virtual bool Initialize(CharacterBase owner, CommonObjectStatus target, float waitCount, float delay, float bulletDuration, int traceDelay, string hitAttrLabel, MarkerData markerData, Vector3 position, Quaternion rotation, float tempoScale = 1f, bool useLegacyClearMarker = false)
		{
			return default(bool);
		}

		protected virtual void SetState(State state)
		{
		}

		protected override void Start()
		{
		}

		protected override bool OnUpdate()
		{
			return default(bool);
		}

		protected virtual bool State_Init()
		{
			return default(bool);
		}

		protected virtual bool State_Delay()
		{
			return default(bool);
		}

		protected virtual bool State_MarkerSet()
		{
			return default(bool);
		}

		protected virtual bool State_MarkerRun()
		{
			return default(bool);
		}

		protected virtual bool State_Fire()
		{
			return default(bool);
		}

		protected virtual bool State_BulletRun()
		{
			return default(bool);
		}

		protected virtual bool State_After()
		{
			return default(bool);
		}

		protected virtual bool State_End()
		{
			return default(bool);
		}

		private void Trace()
		{
		}

		protected void MoveMarkerTimeCurve()
		{
		}

		public void SetupMarkerMoveTimeCurve(MakerMoveTimeCurve.BaseAxisType axisType, float offsetAngle, AnimationCurve curveX, AnimationCurve curveZ)
		{
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public static string GetHitAttributeLabel(CharacterBase owner, BulletWithMarkerData data)
		{
			return null;
		}

		public void SetNoticeEffect(Gluon.ActionData.EffectData eff_data, float delaytime, MultiBulletData.NoticeEffectBase noticeEffectBase, Vector3 offsetRot)
		{
		}

		public void SetFromCharaToMarkerWithCollision(float fromCharaToMarkerTime, bool isfromCharaToMarkerWithCollision, float collisonDelayTime)
		{
		}

		private IEnumerator CoNoticeEffect()
		{
			return null;
		}

		public void SetMarkerData(MarkerData marker_data)
		{
		}

		private void BulletRunDuringDelay()
		{
		}
	}
}
