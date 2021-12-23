using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Bullet
{
	public class BulletObject : BulletBase
	{
		public enum BulletState
		{
			DELAY,
			MOVE,
			AFTER,
			FORMATION
		}

		[Serializable]
		public enum DirectionType
		{
			DEFAULT,
			TARGET,
			TARGET_GROUND,
			FLOATING,
			JUST_UNDER,
			MARKER,
			AREA_ANCHOR,
			TARGET_FLAT,
			TAGGED_BULLET
		}

		public class HomingData
		{
			private CharacterBase owner;

			public float startTime;

			public float endTime;

			public float addAngle;

			public bool useAngleCurve;

			public AnimationCurve addAngleCurve;

			public Vector3 targetOffset;

			public bool isAimTargetGround;

			public bool isInvalidOnTargetDead;

			public bool freezeHomingYAxis;

			public bool stopMovingForNoTarget;

			private bool homingStarted;

			private float timeCount;

			public bool isActive => default(bool);

			public void Initialize(BulletDataClone data, CharacterBase owner)
			{
			}

			public bool CalculateDirection(Transform ownerTransform, Vector3 target, Vector3 forward, float deltaTime, ref Vector3 direction, bool isTargetDead, CharacterBase targetChara)
			{
				return default(bool);
			}
		}

		private BulletState _state;

		protected Vector3 _initialPosition;

		protected Quaternion _initialRotation;

		protected Vector3 _direction;

		protected CommonObjectStatus _target;

		protected CharacterBase _targetChara;

		protected Vector3 _aimingPoint;

		protected float _speed;

		private const float BASE_FPS = 60f;

		protected float _duration;

		private float _distance;

		protected float _delayTime;

		protected bool _isDelayAffectedBySpeedFactor;

		protected bool _delayVisible;

		protected float _afterDistance;

		private bool kickedEffTrig;

		protected int _actionId;

		protected int _skillId;

		protected int _actionProductId;

		protected bool isValidLifespan;

		private bool skipMisfire;

		protected HomingData _homingData;

		private BulletDataClone _data;

		protected CollisionHitAttribute _hitAttribute;

		protected HitException _hitException;

		protected CollisionHitAttribute[] _hitAttributeSubList;

		protected HitException[] _hitExceptionSubList;

		private int _checkingSubHitIndex;

		protected EffectObject _effectObject;

		protected EffectObject _groundHitEffectObject;

		private float _floatingRot;

		private bool _hasArrange;

		private EnemyAppearEnemyMultiPlayService.AppearEnemyInfo _applyEnemyInfo;

		private int _syncedImportantTaskId;

		private bool _addedComponent;

		private bool _isHitProcessReceived;

		public BulletState state
		{
			get
			{
				return default(BulletState);
			}
			set
			{
			}
		}

		[SerializeField]
		protected CharacterBase owner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CharacterBase Owner => null;

		public Vector3 ShotDirEuler
		{
			[CompilerGenerated]
			private get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float duration => default(float);

		public float elapsedTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected float elapsedTimeForEff
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isStarted
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int bulletUniqueId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int actionId => default(int);

		public int skillId => default(int);

		public int actionProductId => default(int);

		public int chargeLv
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isForceDelete
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isHitEnd
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool enableHitCheck
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isFormationChild
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Transform cacheTransform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool SkipMisfire
		{
			set
			{
			}
		}

		public ActionStartParameter actionStartParam
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public BulletObjectSyncMove SyncMove
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override bool AutoDeleteOnAreaChange => default(bool);

		public BulletDataClone data => null;

		public CollisionHitAttribute hitAttribute => null;

		public bool forcedHitDelete
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected bool isHitDelete => default(bool);

		public bool AddedComponent => default(bool);

		public static Type Generate<Type>(GameObject parent, CharacterBase owner, bool isUseBulletModel = false, DragonDecoration decoId = DragonDecoration.NONE, bool setPoolParent = false, bool enableSyncMove = false) where Type : BulletObject
		{
			return null;
		}

		protected virtual void Clear()
		{
		}

		public void SetBulletData(BulletData data)
		{
		}

		public void SetBulletData(BulletDataClone data)
		{
		}

		public void SetDelayTime(float time)
		{
		}

		public void SetHitAttributeLabel(string label)
		{
		}

		public void SetupWallCheckOrigin(bool useSelfPos)
		{
		}

		public void SetHomingInterpolationAngleCurve(AnimationCurve curve, bool isUse)
		{
		}

		public void SetActionIds(int actionId, int skillId, int productId)
		{
		}

		public virtual bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Quaternion rotation)
		{
			return default(bool);
		}

		public void SetOnHitCountAdded(Action<int> onHitCountAdded)
		{
		}

		public virtual bool InitializeForMultiBullet(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Quaternion rotation, float bulletDelayTime, float bulletDuration)
		{
			return default(bool);
		}

		private bool CreateHitAttributeForPlayer(ref CollisionHitAttribute hitAttribute, int actionId, int skillId, string label)
		{
			return default(bool);
		}

		private bool CreateHitAttributeForEnemy(ref CollisionHitAttribute hitAttribute, int actionId, string label)
		{
			return default(bool);
		}

		protected void SetupCollisionParameter(CollisionHitAttribute hitAttribute, BulletDataClone data)
		{
		}

		protected void SetupHitAttribute(CollisionHitAttribute hitAttribute, bool dummyObject = true)
		{
		}

		public void SetupActionStartParam(CharacterBase owner, ActionContainer container)
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void ReleaseChild()
		{
		}

		public override void FastUpdate()
		{
		}

		protected virtual bool OnUpdate()
		{
			return default(bool);
		}

		protected virtual bool UpdateFormation()
		{
			return default(bool);
		}

		protected virtual void PostUpdate()
		{
		}

		protected void LookTarget()
		{
		}

		protected virtual bool UpdateMove()
		{
			return default(bool);
		}

		protected void UpdateHoming()
		{
		}

		private bool UpdateAfter()
		{
			return default(bool);
		}

		protected virtual bool CheckCollision()
		{
			return default(bool);
		}

		protected CollisionHitAttribute GetCurrentCheckingHitAttribute()
		{
			return null;
		}

		protected HitException GetCurrentCheckingHitException()
		{
			return null;
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public override void OnNotCollided(CharacterBase chara)
		{
		}

		public override bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}

		protected bool IsHitPenetratableObject(GameObject target)
		{
			return default(bool);
		}

		protected void HitProcess(bool effOnSurface = false, bool genArrangeBullet = true)
		{
		}

		public static void SetupArrangeBulletData(ref BulletDataClone bulletData, ArrangeBulletData ab, CharacterBase owner, int skillId)
		{
		}

		public static void SetArrangeBulletEffect(ref BulletDataClone bulletData, ArrangeBulletData ab, CharacterBase owner, int skillId)
		{
		}

		private Vector3 CalculatePower()
		{
			return default(Vector3);
		}

		protected bool UpdateDelayTime()
		{
			return default(bool);
		}

		protected virtual bool UpdateDurationTime()
		{
			return default(bool);
		}

		public virtual void PlayEffect()
		{
		}

		protected bool CanPlayEffect()
		{
			return default(bool);
		}

		public virtual void StopEffect(bool immediately = false)
		{
		}

		public void PauseEffect(bool isPause)
		{
		}

		public void RestoreEffect()
		{
		}

		protected void PlayHitEffect()
		{
		}

		protected void PlayFireSE()
		{
		}

		protected void PlayHitSE([Optional] CharacterBase target)
		{
		}

		protected void PlayHitSETerrain()
		{
		}

		protected virtual void StopSE()
		{
		}

		protected void PlayHitCameraShake()
		{
		}

		protected void PlayHitCameraShakeTerrain()
		{
		}

		protected Vector3 GetAimingPoint()
		{
			return default(Vector3);
		}

		protected float CorrectFps(float val)
		{
			return default(float);
		}

		private void Rebound(Vector3 move, RaycastHit hitInfo)
		{
		}

		private bool ReboundSpecificBullet(Vector3 move)
		{
			return default(bool);
		}

		public static string GetHitAttributeLabel(CharacterBase owner, BulletData data)
		{
			return null;
		}

		public static string GetHitAttributeLabel(CharacterBase owner, BulletDataClone data, int index, [Optional] BulletObject bullet)
		{
			return null;
		}

		private void CheckLifespan()
		{
		}

		protected void AppearChild([Optional] GameObject hitObject)
		{
		}

		public void SetAppearChildTaskId(int taskId)
		{
		}

		private void AppearChildHostSync(EnemyCharacter enemyOwner, EnemyCharacter child, Vector3 popPos, CharacterBase childTarget)
		{
		}

		private void AppearChildNoSync(EnemyCharacter enemyOwner, EnemyCharacter child, Vector3 popPos, CharacterBase childTarget)
		{
		}

		public void SendHitProcess(bool effOnSurface, bool isHitEnd, bool genArrangeBullet)
		{
		}

		public virtual void OnReceiveBulletEvent(BulletEvent recvEvent)
		{
		}
	}
}
