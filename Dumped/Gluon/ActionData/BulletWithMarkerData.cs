using System;
using Gluon.Bullet;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class BulletWithMarkerData : ActionParts.PartsData
	{
		public enum AppearChildRotationBase
		{
			None,
			AreaAnchor
		}

		[SerializeField]
		[HideInInspector]
		private InGameDef.CharacterType _characterType;

		[SerializeField]
		[HideInInspector]
		private Gluon.Bullet.ActionPartsBulletWithMarker.GenerateType _generateType;

		[SerializeField]
		[HideInInspector]
		private MarkerData _marker;

		[SerializeField]
		[HideInInspector]
		private Vector3 _markerOffsetPos;

		[SerializeField]
		[HideInInspector]
		private float _bulletDuration;

		[SerializeField]
		[HideInInspector]
		private string _hitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private bool _useSameComponent;

		[SerializeField]
		[HideInInspector]
		private bool _useElementalHit;

		[SerializeField]
		[HideInInspector]
		private string[] _elementalHitLabel;

		[SerializeField]
		[HideInInspector]
		private float _waitTime;

		[SerializeField]
		[HideInInspector]
		private float _bulletDelay;

		[SerializeField]
		[HideInInspector]
		private int _traceDelay;

		[SerializeField]
		[HideInInspector]
		private bool _isHitDelete;

		[SerializeField]
		[HideInInspector]
		private bool _isUseBulletModel;

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private bool _isHitAttributeShift;

		[SerializeField]
		[HideInInspector]
		private string _effectNameHAS;

		[SerializeField]
		[HideInInspector]
		private string[] _elementalEffectName;

		[SerializeField]
		[HideInInspector]
		private int _effectTriggerIdx;

		[SerializeField]
		[HideInInspector]
		private bool _effectInfluencedCharaterElement;

		[SerializeField]
		[HideInInspector]
		private bool _effectUseElementalTrigger;

		[SerializeField]
		[HideInInspector]
		private bool _isSeparatelyLoadEffect;

		[SerializeField]
		[HideInInspector]
		private EffectObject.EraseType _effectEraseType;

		[SerializeField]
		[HideInInspector]
		private float _effectDisappearTime;

		[SerializeField]
		[HideInInspector]
		private bool _isKeepEffectAfterStop;

		[SerializeField]
		[HideInInspector]
		private bool _isEffectOnGround;

		[SerializeField]
		[HideInInspector]
		private float _bulletSpeed;

		[SerializeField]
		[HideInInspector]
		private float _distance;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetScale;

		[SerializeField]
		[HideInInspector]
		private bool _useOwnerScaleEffect;

		[SerializeField]
		[HideInInspector]
		private EffectData _hitEffect;

		[SerializeField]
		[HideInInspector]
		private string _hitSEName;

		[SerializeField]
		[HideInInspector]
		private bool _useHitCameraShake;

		[SerializeField]
		[HideInInspector]
		private CameraController.ShakeType _hitCameraShake;

		[SerializeField]
		[HideInInspector]
		private ArrangeBulletData _arrangeBullet;

		[SerializeField]
		[HideInInspector]
		private ActionCollision _collision;

		[SerializeField]
		[HideInInspector]
		private float _collisionParams_01;

		[SerializeField]
		[HideInInspector]
		private float _collisionParams_05;

		[SerializeField]
		[HideInInspector]
		private Vector3 _collisionOffset;

		[SerializeField]
		[HideInInspector]
		private bool _useOwnerScaleCollision;

		[SerializeField]
		[HideInInspector]
		private float _collisionHitInterval;

		[SerializeField]
		[HideInInspector]
		private bool _useAccurateCollisionHitInterval;

		[SerializeField]
		[HideInInspector]
		private int _sameTimeHitId;

		[SerializeField]
		[HideInInspector]
		private bool _isAppearChild;

		[SerializeField]
		[HideInInspector]
		private int _childNumber;

		[SerializeField]
		[HideInInspector]
		private int _childActionId;

		[SerializeField]
		[HideInInspector]
		private float _childDirection;

		[SerializeField]
		[HideInInspector]
		private AppearChildRotationBase _appearChildRotationBase;

		[SerializeField]
		[HideInInspector]
		private bool _childPopedInvincible;

		[SerializeField]
		[HideInInspector]
		private bool _isAppearChildHostSync;

		[SerializeField]
		[HideInInspector]
		private bool _isAppearChildOnHitChara;

		[SerializeField]
		[HideInInspector]
		private bool _isChildTargetHitChara;

		[SerializeField]
		[HideInInspector]
		private bool _isChildTargetBulletTargetChara;

		[SerializeField]
		[HideInInspector]
		private string _distinctionTag;

		[SerializeField]
		[HideInInspector]
		private bool _useMarkerMoveTimeCurve;

		[SerializeField]
		[HideInInspector]
		private BulletObjectWithMarker.MakerMoveTimeCurve.BaseAxisType _markerTimeCurveBaseAxis;

		[SerializeField]
		[HideInInspector]
		private float _markerTimeOffsetAngle;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _markerTimeCurveX;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _markerTimeCurveZ;

		public InGameDef.CharacterType characterType => default(InGameDef.CharacterType);

		public Gluon.Bullet.ActionPartsBulletWithMarker.GenerateType generateType => default(Gluon.Bullet.ActionPartsBulletWithMarker.GenerateType);

		public MarkerData markerData => null;

		public Vector3 markerOffsetPos => default(Vector3);

		public float bulletDuration => default(float);

		public string hitAttrLabel => null;

		public bool useSameComponent => default(bool);

		public bool useElementalHit => default(bool);

		public string[] elementalHitLabel => null;

		public float waitTime => default(float);

		public float bulletDelay => default(float);

		public int traceDelay => default(int);

		public bool isHitDelete => default(bool);

		public bool isUseBulletModel => default(bool);

		public string effectName => null;

		public bool isHitAttributeShift => default(bool);

		public string effectNameHAS => null;

		public string[] elementalEffectName => null;

		public int effectTriggerIdx => default(int);

		public bool effectInfluencedCharaterElement => default(bool);

		public bool effectUseElementalTrigger => default(bool);

		public bool isSeparatelyLoadEffect => default(bool);

		public EffectObject.EraseType effectEraseType => default(EffectObject.EraseType);

		public float effectDisappearTime => default(float);

		public bool isKeepEffectAfterStop => default(bool);

		public bool isEffectOnGround => default(bool);

		public float bulletSpeed => default(float);

		public float distance => default(float);

		public Vector3 offsetScale => default(Vector3);

		public bool useOwnerScaleEffect => default(bool);

		public EffectData hitEffect => null;

		public string hitSEName => null;

		public bool useHitCameraShake => default(bool);

		public CameraController.ShakeType hitCameraShake => default(CameraController.ShakeType);

		public ArrangeBulletData arrangeBullet => null;

		public ActionCollision collisionShape => default(ActionCollision);

		public float collisionParams01 => default(float);

		public float collisionParams05 => default(float);

		public Vector3 collisionOffset => default(Vector3);

		public bool useOwnerScaleCollision => default(bool);

		public float collisionHitInterval => default(float);

		public bool useAccurateCollisionHitInterval => default(bool);

		public int sameTimeHitId => default(int);

		public bool isAppearChild => default(bool);

		public int childNumber => default(int);

		public int childActionId => default(int);

		public float childDirection => default(float);

		public AppearChildRotationBase appearChildRotationBase => default(AppearChildRotationBase);

		public bool childPopedInvincible => default(bool);

		public bool isAppearChildHostSync => default(bool);

		public bool isAppearChildOnHitChara => default(bool);

		public bool isChildTargetHitChara => default(bool);

		public bool isChildTargetBulletTargetChara => default(bool);

		public string distinctionTag => null;

		public bool useMarkerMoveTimeCurve => default(bool);

		public BulletObjectWithMarker.MakerMoveTimeCurve.BaseAxisType markerTimeCurveBaseAxis => default(BulletObjectWithMarker.MakerMoveTimeCurve.BaseAxisType);

		public float markerTimeOffsetAngle => default(float);

		public AnimationCurve markerTimeCurveX => null;

		public AnimationCurve markerTimeCurveZ => null;
	}
}
