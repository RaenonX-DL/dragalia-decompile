/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Bullet;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class BulletWithMarkerData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private InGameDef.CharacterType _characterType;
		[HideInInspector]
		[SerializeField]
		private MarkerData _marker;
		[HideInInspector]
		[SerializeField]
		private Vector3 _markerOffsetPos;
		[HideInInspector]
		[SerializeField]
		private float _bulletDuration;
		[HideInInspector]
		[SerializeField]
		private string _hitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private bool _useSameComponent;
		[HideInInspector]
		[SerializeField]
		private bool _useElementalHit;
		[HideInInspector]
		[SerializeField]
		private string[] _elementalHitLabel;
		[HideInInspector]
		[SerializeField]
		private float _waitTime;
		[HideInInspector]
		[SerializeField]
		private float _bulletDelay;
		[HideInInspector]
		[SerializeField]
		private int _traceDelay;
		[HideInInspector]
		[SerializeField]
		private bool _isHitDelete;
		[HideInInspector]
		[SerializeField]
		private bool _isUseBulletModel;
		[HideInInspector]
		[SerializeField]
		private string _effectName;
		[HideInInspector]
		[SerializeField]
		private bool _isHitAttributeShift;
		[HideInInspector]
		[SerializeField]
		private string _effectNameHAS;
		[HideInInspector]
		[SerializeField]
		private string[] _elementalEffectName;
		[HideInInspector]
		[SerializeField]
		private int _effectTriggerIdx;
		[HideInInspector]
		[SerializeField]
		private bool _effectInfluencedCharaterElement;
		[HideInInspector]
		[SerializeField]
		private bool _effectUseElementalTrigger;
		[HideInInspector]
		[SerializeField]
		private EffectObject.EraseType _effectEraseType;
		[HideInInspector]
		[SerializeField]
		private float _effectDisappearTime;
		[HideInInspector]
		[SerializeField]
		private bool _isKeepEffectAfterStop;
		[HideInInspector]
		[SerializeField]
		private float _bulletSpeed;
		[HideInInspector]
		[SerializeField]
		private float _distance;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetScale;
		[HideInInspector]
		[SerializeField]
		private bool _useOwnerScaleEffect;
		[HideInInspector]
		[SerializeField]
		private EffectData _hitEffect;
		[HideInInspector]
		[SerializeField]
		private string _hitSEName;
		[HideInInspector]
		[SerializeField]
		private bool _useHitCameraShake;
		[HideInInspector]
		[SerializeField]
		private CameraController.ShakeType _hitCameraShake;
		[HideInInspector]
		[SerializeField]
		private ArrangeBulletData _arrangeBullet;
		[HideInInspector]
		[SerializeField]
		private ActionCollision _collision;
		[HideInInspector]
		[SerializeField]
		private float _collisionParams_01;
		[HideInInspector]
		[SerializeField]
		private float _collisionParams_05;
		[HideInInspector]
		[SerializeField]
		private Vector3 _collisionOffset;
		[HideInInspector]
		[SerializeField]
		private bool _useOwnerScaleCollision;
		[HideInInspector]
		[SerializeField]
		private float _collisionHitInterval;
		[HideInInspector]
		[SerializeField]
		private int _sameTimeHitId;
		[HideInInspector]
		[SerializeField]
		private bool _isAppearChild;
		[HideInInspector]
		[SerializeField]
		private int _childNumber;
		[HideInInspector]
		[SerializeField]
		private int _childActionId;
		[HideInInspector]
		[SerializeField]
		private float _childDirection;
		[HideInInspector]
		[SerializeField]
		private AppearChildRotationBase _appearChildRotationBase;
		[HideInInspector]
		[SerializeField]
		private bool _childPopedInvincible;
		[HideInInspector]
		[SerializeField]
		private bool _isAppearChildOnHitChara;
		[HideInInspector]
		[SerializeField]
		private bool _isChildTargetHitChara;
		[HideInInspector]
		[SerializeField]
		private bool _isChildTargetBulletTargetChara;
		[HideInInspector]
		[SerializeField]
		private string _distinctionTag;
		[HideInInspector]
		[SerializeField]
		private bool _useMarkerMoveTimeCurve;
		[HideInInspector]
		[SerializeField]
		private BulletObjectWithMarker.MakerMoveTimeCurve.BaseAxisType _markerTimeCurveBaseAxis;
		[HideInInspector]
		[SerializeField]
		private float _markerTimeOffsetAngle;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _markerTimeCurveX;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _markerTimeCurveZ;
	
		// Properties
		public InGameDef.CharacterType characterType { get; }
		public MarkerData markerData { get; }
		public Vector3 markerOffsetPos { get; }
		public float bulletDuration { get; }
		public string hitAttrLabel { get; }
		public bool useSameComponent { get; }
		public bool useElementalHit { get; }
		public string[] elementalHitLabel { get; }
		public float waitTime { get; }
		public float bulletDelay { get; }
		public int traceDelay { get; }
		public bool isHitDelete { get; }
		public bool isUseBulletModel { get; }
		public string effectName { get; }
		public bool isHitAttributeShift { get; }
		public string effectNameHAS { get; }
		public string[] elementalEffectName { get; }
		public int effectTriggerIdx { get; }
		public bool effectInfluencedCharaterElement { get; }
		public bool effectUseElementalTrigger { get; }
		public EffectObject.EraseType effectEraseType { get; }
		public float effectDisappearTime { get; }
		public bool isKeepEffectAfterStop { get; }
		public float bulletSpeed { get; }
		public float distance { get; }
		public Vector3 offsetScale { get; }
		public bool useOwnerScaleEffect { get; }
		public EffectData hitEffect { get; }
		public string hitSEName { get; }
		public bool useHitCameraShake { get; }
		public CameraController.ShakeType hitCameraShake { get; }
		public ArrangeBulletData arrangeBullet { get; }
		public ActionCollision collisionShape { get; }
		public float collisionParams01 { get; }
		public float collisionParams05 { get; }
		public Vector3 collisionOffset { get; }
		public bool useOwnerScaleCollision { get; }
		public float collisionHitInterval { get; }
		public int sameTimeHitId { get; }
		public bool isAppearChild { get; }
		public int childNumber { get; }
		public int childActionId { get; }
		public float childDirection { get; }
		public AppearChildRotationBase appearChildRotationBase { get; }
		public bool childPopedInvincible { get; }
		public bool isAppearChildOnHitChara { get; }
		public bool isChildTargetHitChara { get; }
		public bool isChildTargetBulletTargetChara { get; }
		public string distinctionTag { get; }
		public bool useMarkerMoveTimeCurve { get; }
		public BulletObjectWithMarker.MakerMoveTimeCurve.BaseAxisType markerTimeCurveBaseAxis { get; }
		public float markerTimeOffsetAngle { get; }
		public AnimationCurve markerTimeCurveX { get; }
		public AnimationCurve markerTimeCurveZ { get; }
	
		// Nested types
		public enum AppearChildRotationBase
		{
			None = 0,
			AreaAnchor = 1
		}
	
		// Constructors
		public BulletWithMarkerData();
	}
}
