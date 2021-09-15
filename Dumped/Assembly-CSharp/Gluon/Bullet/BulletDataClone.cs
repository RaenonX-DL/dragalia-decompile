/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class BulletDataClone
	{
		// Fields
		[CompilerGenerated]
		private float _seconds_k__BackingField;
		[CompilerGenerated]
		private float _duration_k__BackingField;
		[CompilerGenerated]
		private float _speed_k__BackingField;
		[CompilerGenerated]
		private InGameDef.CharacterType _characterType_k__BackingField;
		[CompilerGenerated]
		private string _hitAttrLabel_k__BackingField;
		[CompilerGenerated]
		private string[] _hitAttrLabelSubList_k__BackingField;
		[CompilerGenerated]
		private bool _useSameComponent_k__BackingField;
		[CompilerGenerated]
		private bool _noHitCheck_k__BackingField;
		[CompilerGenerated]
		private bool _useElementalHit_k__BackingField;
		private string[] _elementalHitLabel;
		[CompilerGenerated]
		private int _sameTimeHitId_k__BackingField;
		[CompilerGenerated]
		private float _waitTime_k__BackingField;
		[CompilerGenerated]
		private float _delayTime_k__BackingField;
		[CompilerGenerated]
		private bool _isDelayAffectedBySpeedFactor_k__BackingField;
		[CompilerGenerated]
		private bool _delayVisible_k__BackingField;
		[CompilerGenerated]
		private bool _isKeepDirectionOnFire_k__BackingField;
		[CompilerGenerated]
		private bool _isHitDelete_k__BackingField;
		[CompilerGenerated]
		private bool _isHitGroundDelete_k__BackingField;
		[CompilerGenerated]
		private bool _isHitInvisibleObstacle_k__BackingField;
		[CompilerGenerated]
		private bool _notHitObstacle_k__BackingField;
		[CompilerGenerated]
		private float _attenuationRate_k__BackingField;
		[CompilerGenerated]
		private BulletData.ReboundType _rebound_k__BackingField;
		[CompilerGenerated]
		private string _reboundSEName_k__BackingField;
		[CompilerGenerated]
		private bool _isSyncHitProcess_k__BackingField;
		[CompilerGenerated]
		private bool _isUseBulletModel_k__BackingField;
		[CompilerGenerated]
		private DragonDecoration _decoId_k__BackingField;
		[CompilerGenerated]
		private string _effectName_k__BackingField;
		[CompilerGenerated]
		private string _effectNameForLowestQuality_k__BackingField;
		private string[] _elementalEffectName;
		[CompilerGenerated]
		private int _effectTriggerIdx_k__BackingField;
		[CompilerGenerated]
		private bool _effectInfluencedCharaterElement_k__BackingField;
		[CompilerGenerated]
		private bool _effectUseElementalTrigger_k__BackingField;
		[CompilerGenerated]
		private bool _effectUseMarkerTrigger_k__BackingField;
		[CompilerGenerated]
		private int _effectTimedTrigger_k__BackingField;
		[CompilerGenerated]
		private int _effectTimedTriggerFrame_k__BackingField;
		[CompilerGenerated]
		private EffectObject.EraseType _effectEraseType_k__BackingField;
		[CompilerGenerated]
		private float _effectDisappearTime_k__BackingField;
		[CompilerGenerated]
		private bool _isKeepEffectAfterStop_k__BackingField;
		[CompilerGenerated]
		private bool _isSeparatelyLoadEffect_k__BackingField;
		[CompilerGenerated]
		private bool _isEffectOnGround_k__BackingField;
		[CompilerGenerated]
		private string _fireSEName_k__BackingField;
		[CompilerGenerated]
		private string _hitSEName_k__BackingField;
		[CompilerGenerated]
		private bool _hitSEFlagTerrain_k__BackingField;
		[CompilerGenerated]
		private string _hitSENameTerrain_k__BackingField;
		[CompilerGenerated]
		private bool _disablePlayNormalHitSE_k__BackingField;
		[CompilerGenerated]
		private bool _useHitCameraShake_k__BackingField;
		[CompilerGenerated]
		private CameraController.ShakeType _hitCameraShake_k__BackingField;
		[CompilerGenerated]
		private CameraController.ShakePriority _cameraShakePriority_k__BackingField;
		[CompilerGenerated]
		private bool _hitCameraShakeFlagTerrain_k__BackingField;
		[CompilerGenerated]
		private CameraController.ShakeType _hitCameraShakeTerrain_k__BackingField;
		[CompilerGenerated]
		private CameraController.ShakePriority _cameraShakePriorityTerrain_k__BackingField;
		[CompilerGenerated]
		private BulletData.GenerateStyle _generateStyle_k__BackingField;
		[CompilerGenerated]
		private string _generateNodeName_k__BackingField;
		[CompilerGenerated]
		private float _generateNear_k__BackingField;
		[CompilerGenerated]
		private int _loadPositionId_k__BackingField;
		[CompilerGenerated]
		private Vector3 _offsetPos_k__BackingField;
		[CompilerGenerated]
		private Vector3 _directionRot_k__BackingField;
		[CompilerGenerated]
		private Vector3 _offsetScale_k__BackingField;
		[CompilerGenerated]
		private bool _useOwnerScaleEffect_k__BackingField;
		[CompilerGenerated]
		private BulletObject.DirectionType _directionType_k__BackingField;
		[CompilerGenerated]
		private string _targetDistinctionTag_k__BackingField;
		[CompilerGenerated]
		private bool _deleteTargetBulletOnHit_k__BackingField;
		[CompilerGenerated]
		private float _nearest_k__BackingField;
		[CompilerGenerated]
		private bool _generateInTheWall_k__BackingField;
		[CompilerGenerated]
		private float _bulletSpeed_k__BackingField;
		[CompilerGenerated]
		private bool _useSpeedCurve_k__BackingField;
		private AnimationCurve _speedCurve;
		[CompilerGenerated]
		private float _distance_k__BackingField;
		[CompilerGenerated]
		private float _afterglow_k__BackingField;
		[CompilerGenerated]
		private float _floatingRange_k__BackingField;
		[CompilerGenerated]
		private float _homingStartSecond_k__BackingField;
		[CompilerGenerated]
		private float _homingEndSecond_k__BackingField;
		[CompilerGenerated]
		private float _homingInterpolationAngle_k__BackingField;
		[CompilerGenerated]
		private bool _useHomingInterpolationAngleCurve_k__BackingField;
		[CompilerGenerated]
		private bool _freezeHomingYAxis_k__BackingField;
		[CompilerGenerated]
		private bool _stopMovingForNoTarget_k__BackingField;
		[CompilerGenerated]
		private AnimationCurve _homingInterpolationAngleCurve_k__BackingField;
		[CompilerGenerated]
		private Vector3 _homingTargetOffsetL_k__BackingField;
		[CompilerGenerated]
		private Vector3 _homingTargetOffsetH_k__BackingField;
		[CompilerGenerated]
		private bool _isAimTargetGround_k__BackingField;
		[CompilerGenerated]
		private bool _isAimTargetNearest_k__BackingField;
		[CompilerGenerated]
		private bool _isHomingInvalidOnTargetDead_k__BackingField;
		private Gluon.ActionData.EffectData _hitEffect;
		private Gluon.ActionData.EffectData _hitEffectGround;
		[CompilerGenerated]
		private bool _useHitEffectGround_k__BackingField;
		[CompilerGenerated]
		private bool _isInvalidHitEffectOnDurationEnd_k__BackingField;
		[CompilerGenerated]
		private ActionCollision _collisionShape_k__BackingField;
		[CompilerGenerated]
		private ActionCollisionPos _collisionPosId_k__BackingField;
		[CompilerGenerated]
		private bool _isCollisionSlotFront_k__BackingField;
		[CompilerGenerated]
		private Vector3 _collisionOffset_k__BackingField;
		[CompilerGenerated]
		private bool _useOwnerScaleCollision_k__BackingField;
		[CompilerGenerated]
		private float _collisionParams01_k__BackingField;
		[CompilerGenerated]
		private float _collisionParams02_k__BackingField;
		[CompilerGenerated]
		private float _collisionParams03_k__BackingField;
		[CompilerGenerated]
		private float _collisionParams05_k__BackingField;
		[CompilerGenerated]
		private float _collisionParams06_k__BackingField;
		[CompilerGenerated]
		private float _collisionHitInterval_k__BackingField;
		[CompilerGenerated]
		private bool _useAccurateCollisionHitInterval_k__BackingField;
		private ArrangeBulletData _arrangeBullet;
		[CompilerGenerated]
		private int _addNum_k__BackingField;
		private ArrangeBulletData[] _additionalCollision;
		[CompilerGenerated]
		private bool _isAppearChild_k__BackingField;
		[CompilerGenerated]
		private bool _isAppearSpecialGimmick_k__BackingField;
		[CompilerGenerated]
		private float _appearSpecialGimmickLifeTime_k__BackingField;
		[CompilerGenerated]
		private bool _appearSpecialGimmickShowMarker_k__BackingField;
		[CompilerGenerated]
		private int _childNumber_k__BackingField;
		[CompilerGenerated]
		private int _childActionId_k__BackingField;
		[CompilerGenerated]
		private float _childDirection_k__BackingField;
		[CompilerGenerated]
		private bool _childPopedInvincible_k__BackingField;
		[CompilerGenerated]
		private BulletWithMarkerData.AppearChildRotationBase _appearChildRotationBase_k__BackingField;
		[CompilerGenerated]
		private bool _isAppearChildOnHitChara_k__BackingField;
		[CompilerGenerated]
		private bool _isChildTargetHitChara_k__BackingField;
		[CompilerGenerated]
		private bool _isChildTargetBulletTargetChara_k__BackingField;
		[CompilerGenerated]
		private string _distinctionTag_k__BackingField;
	
		// Properties
		public float seconds { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float duration { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float speed { [CompilerGenerated] get; [CompilerGenerated] set; }
		public InGameDef.CharacterType characterType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string hitAttrLabel { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string[] hitAttrLabelSubList { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool useSameComponent { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool noHitCheck { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool useElementalHit { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string[] elementalHitLabel { get; }
		public int sameTimeHitId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float waitTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float delayTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isDelayAffectedBySpeedFactor { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool delayVisible { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isKeepDirectionOnFire { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isHitDelete { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isHitGroundDelete { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isHitInvisibleObstacle { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool notHitObstacle { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float attenuationRate { [CompilerGenerated] get; [CompilerGenerated] set; }
		public BulletData.ReboundType rebound { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string reboundSEName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isSyncHitProcess { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isUseBulletModel { [CompilerGenerated] get; [CompilerGenerated] set; }
		public DragonDecoration decoId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string effectName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string effectNameForLowestQuality { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string[] elementalEffectName { get; }
		public int effectTriggerIdx { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool effectInfluencedCharaterElement { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool effectUseElementalTrigger { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool effectUseMarkerTrigger { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int effectTimedTrigger { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int effectTimedTriggerFrame { [CompilerGenerated] get; [CompilerGenerated] set; }
		public EffectObject.EraseType effectEraseType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float effectDisappearTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isKeepEffectAfterStop { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isSeparatelyLoadEffect { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isEffectOnGround { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string fireSEName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string hitSEName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool hitSEFlagTerrain { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string hitSENameTerrain { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool disablePlayNormalHitSE { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool useHitCameraShake { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CameraController.ShakeType hitCameraShake { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CameraController.ShakePriority cameraShakePriority { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool hitCameraShakeFlagTerrain { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CameraController.ShakeType hitCameraShakeTerrain { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CameraController.ShakePriority cameraShakePriorityTerrain { [CompilerGenerated] get; [CompilerGenerated] set; }
		public BulletData.GenerateStyle generateStyle { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string generateNodeName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float generateNear { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int loadPositionId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 offsetPos { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 directionRot { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 offsetScale { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool useOwnerScaleEffect { [CompilerGenerated] get; [CompilerGenerated] set; }
		public BulletObject.DirectionType directionType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string targetDistinctionTag { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool deleteTargetBulletOnHit { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float nearest { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool generateInTheWall { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float bulletSpeed { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool useSpeedCurve { [CompilerGenerated] get; [CompilerGenerated] set; }
		public AnimationCurve speedCurve { get; }
		public float distance { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float afterglow { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float floatingRange { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float homingStartSecond { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float homingEndSecond { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float homingInterpolationAngle { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool useHomingInterpolationAngleCurve { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool freezeHomingYAxis { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool stopMovingForNoTarget { [CompilerGenerated] get; [CompilerGenerated] set; }
		public AnimationCurve homingInterpolationAngleCurve { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 homingTargetOffsetL { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 homingTargetOffsetH { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isAimTargetGround { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isAimTargetNearest { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isHomingInvalidOnTargetDead { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Gluon.ActionData.EffectData hitEffect { get; set; }
		public Gluon.ActionData.EffectData hitEffectGround { get; set; }
		public bool useHitEffectGround { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isInvalidHitEffectOnDurationEnd { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ActionCollision collisionShape { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ActionCollisionPos collisionPosId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isCollisionSlotFront { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 collisionOffset { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool useOwnerScaleCollision { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float collisionParams01 { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float collisionParams02 { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float collisionParams03 { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float collisionParams05 { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float collisionParams06 { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float collisionHitInterval { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool useAccurateCollisionHitInterval { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ArrangeBulletData arrangeBullet { get; set; }
		public int addNum { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ArrangeBulletData[] additionalCollision { get; set; }
		public bool isAppearChild { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isAppearSpecialGimmick { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float appearSpecialGimmickLifeTime { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool appearSpecialGimmickShowMarker { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int childNumber { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int childActionId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float childDirection { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool childPopedInvincible { [CompilerGenerated] get; [CompilerGenerated] set; }
		public BulletWithMarkerData.AppearChildRotationBase appearChildRotationBase { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isAppearChildOnHitChara { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isChildTargetHitChara { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isChildTargetBulletTargetChara { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string distinctionTag { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public BulletDataClone();
		public BulletDataClone(BulletDataClone src);
	
		// Methods
		public void Copy(BulletDataClone src);
		public void Copy(BulletData res);
	}
}
