/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class BulletObject : BulletBase
	{
		// Fields
		private BulletState _state;
		[CompilerGenerated]
		private CharacterBase _owner_k__BackingField;
		protected Vector3 _initialPosition;
		protected Quaternion _initialRotation;
		[CompilerGenerated]
		private Vector3 _ShotDirEuler_k__BackingField;
		protected Vector3 _direction;
		protected CommonObjectStatus _target;
		protected CharacterBase _targetChara;
		protected Vector3 _aimingPoint;
		protected float _speed;
		private const float BASE_FPS = 60f;
		protected float _duration;
		private float _distance;
		protected float _delayTime;
		protected bool _delayVisible;
		protected float _afterDistance;
		[CompilerGenerated]
		private float _elapsedTime_k__BackingField;
		[CompilerGenerated]
		private float _elapsedTimeForEff_k__BackingField;
		private bool kickedEffTrig;
		[CompilerGenerated]
		private bool _isStarted_k__BackingField;
		[CompilerGenerated]
		private int _bulletUniqueId_k__BackingField;
		protected int _actionId;
		protected int _skillId;
		protected int _actionProductId;
		[CompilerGenerated]
		private int _chargeLv_k__BackingField;
		protected bool isValidLifespan;
		[CompilerGenerated]
		private bool _isForceDelete_k__BackingField;
		[CompilerGenerated]
		private bool _isHitEnd_k__BackingField;
		[CompilerGenerated]
		private bool _enableHitCheck_k__BackingField;
		[CompilerGenerated]
		private bool _isFormationChild_k__BackingField;
		[CompilerGenerated]
		private Transform _cacheTransform_k__BackingField;
		private bool skipMisfire;
		[CompilerGenerated]
		private ActionStartParameter _actionStartParam_k__BackingField;
		protected HomingData _homingData;
		private BulletDataClone _data;
		protected CollisionHitAttribute _hitAttribute;
		protected HitException _hitException;
		protected CollisionHitAttribute _hitAttribute2nd;
		private bool _isCheckHit2nd;
		protected EffectObject _effectObject;
		protected EffectObject _groundHitEffectObject;
		private float _floatingRot;
		[CompilerGenerated]
		private bool _forcedHitDelete_k__BackingField;
		private bool _hasArrange;
		private EnemyAppearEnemyMultiPlayService.AppearEnemyInfo _applyEnemyInfo;
		private int _syncedImportantTaskId;
		private bool _addedComponent;
		private bool _isHitProcessReceived;
	
		// Properties
		public BulletState state { get; set; }
		[SerializeField]
		protected CharacterBase owner { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 ShotDirEuler { [CompilerGenerated] private get; [CompilerGenerated] set; }
		public float elapsedTime { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		protected float elapsedTimeForEff { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isStarted { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int bulletUniqueId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int actionId { get; }
		public int skillId { get; }
		public int actionProductId { get; }
		public int chargeLv { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isForceDelete { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isHitEnd { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public bool enableHitCheck { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isFormationChild { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Transform cacheTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool SkipMisfire { set; }
		public ActionStartParameter actionStartParam { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected BulletDataClone data { get; }
		public bool forcedHitDelete { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected bool isHitDelete { get; }
		public bool AddedComponent { get; }
	
		// Nested types
		public enum BulletState
		{
			DELAY = 0,
			MOVE = 1,
			AFTER = 2,
			FORMATION = 3
		}
	
		[Serializable]
		public enum DirectionType
		{
			DEFAULT = 0,
			TARGET = 1,
			TARGET_GROUND = 2,
			FLOATING = 3,
			JUST_UNDER = 4,
			MARKER = 5,
			AREA_ANCHOR = 6,
			TARGET_FLAT = 7,
			TAGGED_BULLET = 8
		}
	
		public class HomingData
		{
			// Fields
			private CharacterBase owner;
			public float startTime;
			public float endTime;
			public float addAngle;
			public bool useAngleCurve;
			public AnimationCurve addAngleCurve;
			public Vector3 targetOffset;
			public bool isAimTargetGround;
			public bool isInvalidOnTargetDead;
			private float timeCount;
	
			// Properties
			public bool isActive { get; }
	
			// Constructors
			public HomingData();
	
			// Methods
			public void Initialize(BulletDataClone data, CharacterBase owner);
			public bool CalculateDirection(Transform ownerTransform, Vector3 target, Vector3 forward, float deltaTime, ref Vector3 direction, bool isTargetDead);
		}
	
		// Constructors
		public BulletObject();
	
		// Methods
		public static Type Generate<Type>(GameObject parent, CharacterBase owner, bool isUseBulletModel = false, DragonDecoration decoId = DragonDecoration.NONE, bool setPoolParent = false)
			where Type : BulletObject;
		protected virtual void Clear();
		public void SetBulletData(BulletData data);
		public void SetBulletData(BulletDataClone data);
		public void SetDelayTime(float time);
		public void SetHitAttributeLabel(string label);
		public void SetHitAttributeLabel2nd(string label);
		public void SetupWallCheckOrigin(bool useSelfPos);
		public void SetHomingInterpolationAngleCurve(AnimationCurve curve, bool isUse);
		public void SetActionIds(int actionId, int skillId, int productId);
		public virtual bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Quaternion rotation);
		public virtual bool InitializeForMultiBullet(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Quaternion rotation, float bulletDelayTime, float bulletDuration);
		private bool CreateHitAttributeForPlayer(ref CollisionHitAttribute hitAttribute, int actionId, int skillId, string label);
		private bool CreateHitAttributeForEnemy(ref CollisionHitAttribute hitAttribute, int actionId, string label);
		protected void SetupCollisionParameter(CollisionHitAttribute hitAttribute, BulletDataClone data);
		protected void SetupHitAttribute(CollisionHitAttribute hitAttribute, bool dummyObject = true);
		protected virtual void Awake();
		protected virtual void Start();
		private void OnDestroy();
		protected override void OnDisable();
		protected virtual void ReleaseChild();
		public override void FastUpdate();
		protected virtual bool OnUpdate();
		protected virtual bool UpdateFormation();
		protected virtual void PostUpdate();
		protected void LookTarget();
		protected bool UpdateMove();
		protected void UpdateHoming();
		private bool UpdateAfter();
		protected virtual bool CheckCollision();
		public override void OnCollided(GameObject target, bool isPropagation);
		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public override void OnNotCollided(CharacterBase chara);
		public override bool IsExcept(CharacterBase chara);
		protected bool IsHitPenetratableObject(GameObject target);
		protected void HitProcess(bool effOnSurface = false, bool genArrangeBullet = true);
		public static void SetupArrangeBulletData(ref BulletDataClone bulletData, ArrangeBulletData ab, CharacterBase owner, int skillId);
		public static void SetArrangeBulletEffect(ref BulletDataClone bulletData, ArrangeBulletData ab, CharacterBase owner, int skillId);
		private Vector3 CalculatePower();
		protected bool UpdateDelayTime();
		protected virtual bool UpdateDurationTime();
		public virtual void PlayEffect();
		protected bool CanPlayEffect();
		public void StopEffect(bool immediately = false);
		public void PauseEffect(bool isPause);
		public void RestoreEffect();
		protected void PlayHitEffect();
		protected void PlayFireSE();
		protected void PlayHitSE(CharacterBase target = null);
		protected void PlayHitSETerrain();
		protected virtual void StopSE();
		protected void PlayHitCameraShake();
		protected void PlayHitCameraShakeTerrain();
		protected Vector3 GetAimingPoint();
		protected float CorrectFps(float val);
		private void Rebound(Vector3 move, RaycastHit hitInfo);
		public static string GetHitAttributeLabel(CharacterBase owner, BulletData data);
		public static string GetHitAttributeLabel(CharacterBase owner, BulletDataClone data, int index);
		private void CheckLifespan();
		protected void AppearChild(GameObject hitObject = null);
		public void SetAppearChildTaskId(int taskId);
		private void AppearChildHostSync(EnemyCharacter enemyOwner, EnemyCharacter child, Vector3 popPos, CharacterBase childTarget);
		private void AppearChildNoSync(EnemyCharacter enemyOwner, EnemyCharacter child, Vector3 popPos, CharacterBase childTarget);
		public void SendHitProcess(bool effOnSurface, bool isHitEnd, bool genArrangeBullet);
		public virtual void OnReceiveBulletEvent(BulletEvent recvEvent);
	}
}
