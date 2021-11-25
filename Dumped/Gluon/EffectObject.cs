using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using SPFX;
using UnityEngine;

namespace Gluon
{
	public class EffectObject : FastUpdateMonoBehaviour
	{
		[Serializable]
		public enum EraseType
		{
			DELETE,
			STOP,
			DISABLE_EMISSION
		}

		public enum FollowPosType
		{
			NONE,
			POSITION,
			POSITION_GROUND
		}

		[Serializable]
		public enum FollowRotType
		{
			NONE = 0,
			ROTATION = 0x10,
			ROTATION_YAW = 0x20,
			ROTATION_PITCH = 48
		}

		public enum FollowScaleType
		{
			NONE,
			SCALE
		}

		private MaterialControl[] materialControllArray;

		private ParticleSystem[] particleSystemInstances;

		private SPFXInstance particleSystemInstanceSPFX;

		private float lifeTime;

		private float lifeTimeLimit;

		private bool lifeEnd;

		private GameObject parentGameObject;

		private FollowPosType _followPosType;

		private FollowRotType _followRotType;

		private FollowScaleType _followScaleType;

		private bool _isFollowOffForStop;

		private Vector3 position;

		private Quaternion rotation;

		private Vector3 _scale;

		private Vector3[] _originalScale;

		private float _playSpeedScale;

		private float _disappearTime;

		private bool isErase;

		private bool isLoopModel;

		private Animator[] animatorArray;

		private bool existParticleSystem;

		public bool isPool;

		public CommonObjectStatus owner
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

		public GameObject ParentGameObject => null;

		public bool _isAdjustAttackSpeed
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float _attackSpeedScale
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float totalPlaySpeedScale => default(float);

		public EraseType _eraseType
		{
			[CompilerGenerated]
			get
			{
				return default(EraseType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public InGameDef.CharacterType _charaType
		{
			[CompilerGenerated]
			get
			{
				return default(InGameDef.CharacterType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int auraGroup
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

		public void Clear()
		{
		}

		public void SetOwner(CommonObjectStatus obj)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void KickTrigger(int trigger)
		{
		}

		public bool IsSPFX()
		{
			return default(bool);
		}

		public bool IsLoop()
		{
			return default(bool);
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void FastUpdate()
		{
		}

		public void UpdateCallSPFX()
		{
		}

		public bool IsPlaying()
		{
			return default(bool);
		}

		public void Pause(bool isPause)
		{
		}

		public void PausePlaySpeed(bool isPause)
		{
		}

		public void SetShow(bool isShow)
		{
		}

		public bool IsShow()
		{
			return default(bool);
		}

		private void SetupParticleScale()
		{
		}

		private void SetupMaterialControl()
		{
		}

		public void SetLifeLimit(float limit)
		{
		}

		private void LateUpdate()
		{
		}

		public void UpdatePose()
		{
		}

		public void SetLocalPosition(Vector3 localPosition)
		{
		}

		public void SetLocalRotation(Quaternion localRotation)
		{
		}

		public void SetScale(Vector3 scale)
		{
		}

		public void SetEraseType(EraseType type, float time)
		{
		}

		public void SetEnableEmission(bool enable)
		{
		}

		public void Stop(float life)
		{
		}

		private void StopParticle(float life)
		{
		}

		private void ReleaseObject()
		{
		}

		public void SetParent(GameObject parent)
		{
		}

		public void SetDefaultFollowType()
		{
		}

		public void SetFollowType(FollowPosType posType, FollowRotType rotType)
		{
		}

		public void SetFollowPositionType(FollowPosType posType)
		{
		}

		public void SetFollowRotationType(FollowRotType rotType)
		{
		}

		public void SetFollowScaleType(FollowScaleType scaleType)
		{
		}

		public void SetFollowOffForStop(bool flag)
		{
		}

		public void SetIsLoopModel()
		{
		}

		public void SetPlaySpeedScale(float scale)
		{
		}

		public float GetPlaySpeedScale()
		{
			return default(float);
		}

		public void AdjustAttackSpeed(bool flag)
		{
		}

		public void SetAttackSpeedScale(float scale)
		{
		}

		public void SetBindTarget(Transform transform)
		{
		}

		public void SetColor(Color color)
		{
		}

		public void SetAuraGroup(int groupId)
		{
		}
	}
}
