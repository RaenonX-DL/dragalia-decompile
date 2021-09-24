/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using SPFX;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EffectObject : FastUpdateMonoBehaviour
	{
		// Fields
		private MaterialControl[] materialControllArray;
		private ParticleSystem[] particleSystemInstances;
		private SPFXInstance particleSystemInstanceSPFX;
		[CompilerGenerated]
		private CommonObjectStatus _owner_k__BackingField;
		[CompilerGenerated]
		private Transform _cacheTransform_k__BackingField;
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
		[CompilerGenerated]
		private bool __isAdjustAttackSpeed_k__BackingField;
		[CompilerGenerated]
		private float __attackSpeedScale_k__BackingField;
		[CompilerGenerated]
		private EraseType __eraseType_k__BackingField;
		private float _disappearTime;
		private bool isErase;
		private bool isLoopModel;
		private Animator[] animatorArray;
		private bool existParticleSystem;
		public bool isPool;
		[CompilerGenerated]
		private InGameDef.CharacterType __charaType_k__BackingField;
		[CompilerGenerated]
		private int _auraGroup_k__BackingField;
	
		// Properties
		public CommonObjectStatus owner { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Transform cacheTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public GameObject ParentGameObject { get; }
		public bool _isAdjustAttackSpeed { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float _attackSpeedScale { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float totalPlaySpeedScale { get; }
		public EraseType _eraseType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public InGameDef.CharacterType _charaType { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int auraGroup { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Serializable]
		public enum EraseType
		{
			DELETE = 0,
			STOP = 1,
			DISABLE_EMISSION = 2
		}
	
		public enum FollowPosType
		{
			NONE = 0,
			POSITION = 1,
			POSITION_GROUND = 2
		}
	
		[Serializable]
		public enum FollowRotType
		{
			NONE = 0,
			ROTATION = 16,
			ROTATION_YAW = 32,
			ROTATION_PITCH = 48
		}
	
		public enum FollowScaleType
		{
			NONE = 0,
			SCALE = 1
		}
	
		// Constructors
		public EffectObject();
	
		// Methods
		public void Clear();
		public void SetOwner(CommonObjectStatus obj);
		private void Awake();
		private void Start();
		public void KickTrigger(int trigger);
		public bool IsSPFX();
		public bool IsLoop();
		protected override void OnEnable();
		protected override void OnDisable();
		public override void FastUpdate();
		public void UpdateCallSPFX();
		public bool IsPlaying();
		public void Pause(bool isPause);
		public void PausePlaySpeed(bool isPause);
		public void SetShow(bool isShow);
		public bool IsShow();
		private void SetupParticleScale();
		private void SetupMaterialControl();
		public void SetLifeLimit(float limit);
		private void LateUpdate();
		public void UpdatePose();
		public void SetLocalPosition(Vector3 localPosition);
		public void SetLocalRotation(Quaternion localRotation);
		public void SetScale(Vector3 scale);
		public void SetEraseType(EraseType type, float time);
		public void SetEnableEmission(bool enable);
		public void Stop(float life);
		private void StopParticle(float life);
		private void ReleaseObject();
		public void SetParent(GameObject parent);
		public void SetDefaultFollowType();
		public void SetFollowType(FollowPosType posType, FollowRotType rotType);
		public void SetFollowPositionType(FollowPosType posType);
		public void SetFollowRotationType(FollowRotType rotType);
		public void SetFollowScaleType(FollowScaleType scaleType);
		public void SetFollowOffForStop(bool flag);
		public void SetIsLoopModel();
		public void SetPlaySpeedScale(float scale);
		public float GetPlaySpeedScale();
		public void AdjustAttackSpeed(bool flag);
		public void SetAttackSpeedScale(float scale);
		public void SetBindTarget(Transform transform);
		public void SetColor(Color color);
		public void SetAuraGroup(int groupId);
	}
}
