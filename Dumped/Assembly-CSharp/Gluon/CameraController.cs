/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[AddComponentMenu]
	public class CameraController : MonoBehaviour
	{
		// Fields
		public const string InGameCameraName = "Animations/InGame/Camera";
		private FollowCameraData[] _followCameraData;
		private GameObject goFollowCameraDataContainer;
		private CameraType camType;
		[CompilerGenerated]
		private CameraGroupCtrl _cameraGroupCtrl_k__BackingField;
		[CompilerGenerated]
		private CameraGroup _mainCmeraGroup_k__BackingField;
		[CompilerGenerated]
		private CameraGroup _silhouetteCameraGroup_k__BackingField;
		private Animator animator;
		private MODE mode;
		private uint updateCount;
		private uint updateCountPlay;
		public Transform target;
		[SerializeField]
		public float distance;
		[SerializeField]
		public Vector3 rotate;
		public Vector3 targetRotate;
		[CompilerGenerated]
		private Vector3 _defaultRotate_k__BackingField;
		private Vector3 rotateAnimationStart;
		private float rotateLerpTime;
		private float rotateTime;
		[NonSerialized]
		public float lastFollowDistance;
		[CompilerGenerated]
		private float _pinchFollowDistance_k__BackingField;
		private Vector3 _targetPosition;
		[NonSerialized]
		public Vector3 atPosition;
		[NonSerialized]
		public bool initializeCameraPos;
		[NonSerialized]
		public float targetDistance;
		private float lastDistanceOnFollow;
		[SerializeField]
		private float collisionRadius;
		[SerializeField]
		private Vector3 collisionCenterPos;
		private CameraShakeData[] shakeData;
		private GameObject goCameraShakeDataContainer;
		public CameraModeFollow modeFollow;
		[CompilerGenerated]
		private CameraModeExtraAction _modeExtraAction_k__BackingField;
		public CameraModeTargetPosition modeTargetPosition;
		private bool isChangeTarget;
		private int targetPartyIndex;
		private int targetMemberIndex;
		private bool enableConvertFovToMatchWidth;
		public Func<bool> canUpdateTransformFunc;
		public Func<float> getFollowRateFunc;
		private RuntimeAnimatorController ingameCuttAnimLoad;
		private RuntimeAnimatorController ingameCuttAnimLog;
		private float dragonBackupDistance;
		private int cameraStep;
		private float cameraTime;
		[SerializeField]
		private float dragonZoomInWaitTime;
		[SerializeField]
		private float dragonStartDistance;
		[SerializeField]
		private float dragonStartWaitTime;
		[SerializeField]
		private float dragonDefaultDistance;
		[SerializeField]
		private float dragonZoomInSpeed;
		[SerializeField]
		private float dragonZoomInAcceleration;
		[SerializeField]
		private float dragonZoomInMaxSpeed;
		[SerializeField]
		private float dragonZoomInMinSpeed;
		[SerializeField]
		private float dragonZoomOutSpeed;
		[SerializeField]
		private float dragonZoomOutAcceleration;
		[SerializeField]
		private float dragonZoomOutMaxSpeed;
		[SerializeField]
		private float dragonZoomOutMinSpeed;
		[SerializeField]
		private float fogDistanceOffset;
		private float cameraSpeed;
		[SerializeField]
		private float finishStartTime;
		[SerializeField]
		private float finishWaitTime;
		private Vector3 finishStartPos;
		[SerializeField]
		private float finishZoomInSpeed;
		[SerializeField]
		private float finishZoomInAcceleration;
		[SerializeField]
		private float finishZoomInMaxSpeed;
		[SerializeField]
		private float finishZoomInMinSpeed;
		private float finishDistance;
		private bool _finishEnd;
		[CompilerGenerated]
		private GameObject _finishFocusObject_k__BackingField;
		[SerializeField]
		private float skillWaitTime;
		private Vector3 skillStartPos;
		[SerializeField]
		private float skillZoomInSpeed;
		[SerializeField]
		private float skillZoomInAcceleration;
		[SerializeField]
		private float skillZoomInMaxSpeed;
		[SerializeField]
		private float skillZoomInMinSpeed;
		[SerializeField]
		private float skillZoomInRotateTime;
		[SerializeField]
		private float skillZoomOutSpeed;
		[SerializeField]
		private float skillZoomOutAcceleration;
		[SerializeField]
		private float skillZoomOutMaxSpeed;
		[SerializeField]
		private float skillZoomOutMinSpeed;
		[SerializeField]
		private float skillZoomOutRotateTime;
		private float zoomInValue;
		[SerializeField]
		public Vector3 skillRotate;
		private SkillDataElement skillDataElement;
		private bool isSupportSkill;
		private bool initSkillTargetPosition;
		private bool enableSkillTargetPosition;
		private Vector3 skillTargetPosition;
		[CompilerGenerated]
		private Vector3 _gatePos_k__BackingField;
		private CameraShakeData currentShakeData;
		private bool shakeActive;
		private float shakeTime;
		private Vector2 shakeRand;
		private AnimationCurve dampingCoef;
		private const float ShakeDistance = 400f;
	
		// Properties
		public FollowCameraData[] followCameraData { get; }
		public CameraType CamType { get; }
		public CameraGroupCtrl cameraGroupCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CameraGroup mainCmeraGroup { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CameraGroup silhouetteCameraGroup { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public MODE Mode { get; }
		public Vector3 defaultRotate { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float pinchFollowDistance { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 targetPosition { get; set; }
		public CameraModeExtraAction modeExtraAction { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool EnableConvertFovToMatchWidth { private get; set; }
		public bool finishEnd { get; }
		public GameObject finishFocusObject { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 gatePos { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[Serializable]
		public class FollowCameraData
		{
			// Fields
			[Tooltip]
			public float distance;
			[Tooltip]
			public float minDistance;
			[Tooltip]
			public float maxDistance;
			[Tooltip]
			public Vector3 rotate;
			[Tooltip]
			public float battleBaseSpeed;
			[Tooltip]
			public float dashBaseSpeed;
			[Tooltip]
			public float dashFrontLength;
			[Tooltip]
			public float frontLengthVerticalRatio;
			public float dashZoomOutLength;
			public float dashZoomOutTime;
			[Tooltip]
			public float longRangeAttackZoomOutLength;
			[Tooltip]
			public float longRangeAttackZoomOutTime;
			[Tooltip]
			public float longRangeAttackZoomKeepTime;
			[Tooltip]
			public float longRangeAttackFrontOffset;
			[Tooltip]
			public float longRangeAttackFrontInBaseSpeed;
			[Tooltip]
			public float longRangeAttackFrontOutBaseSpeed;
			[Tooltip]
			public float moveSpeedCoefOnZoomKeepTime;
			[Tooltip]
			public float fov;
			[Tooltip]
			public float rotateLimitY;
			[Tooltip]
			public float lookAtOffsetDistance;
	
			// Constructors
			public FollowCameraData();
		}
	
		[Serializable]
		public enum ShakeType
		{
			shakeR_xs_00 = 0,
			shakeR_s_01 = 1,
			shakeR_m_02 = 2,
			shakeR_l_03 = 3,
			shakeR_xl_04 = 4,
			shakeV_xs_05 = 5,
			shakeV_s_06 = 6,
			shakeV_m_07 = 7,
			shakeV_l_08 = 8,
			shakeV_xl_09 = 9,
			shakeS_xs_10 = 10,
			shakeS_s_11 = 11,
			shakeS_m_12 = 12,
			shakeS_l_13 = 13,
			shakeS_xl_14 = 14,
			shakeZodiarc_Roar = 15,
			shakeR_4xl_16 = 16,
			shakeDragon_Trans = 17,
			shakeR_dr_ss_18 = 18,
			shakeR_dr_sw_19 = 19,
			shakeR_dr_ms_20 = 20,
			shakeR_dr_mw_21 = 21,
			shakeR_dr_ls_22 = 22,
			shakeR_dr_lw_23 = 23,
			shakeHard_Hit = 24,
			shakeHitS = 25,
			shakeHitM = 26,
			shakeHitL = 27,
			MAX = 28
		}
	
		public enum ShakePriority
		{
			Default = 0,
			ActionParts01 = 1,
			ActionParts02 = 2,
			ActionParts03 = 3,
			ActionParts04 = 4,
			ActionParts05 = 5,
			HitAttack = 6,
			HitAttack01 = 7,
			HitAttack02 = 8,
			HitAttack03 = 9
		}
	
		public enum MODE
		{
			ANIMATION = 0,
			CUTSCENE = 1,
			FOLLOW = 2,
			DRAGON = 3,
			FINISH = 4,
			SKILL = 5,
			GATE = 6,
			EXTRAACTION = 7,
			BATTLESTART = 8,
			TARGETPOSITION = 9,
			CUTT = 10,
			VIEWER = 11,
			CMNSKILL_CHECKER = 12
		}
	
		// Constructors
		public CameraController();
	
		// Methods
		public void SetCameraGroupCtrl(CameraGroupCtrl cg);
		public void SetCameraField(float fieldOfView, float nearClipPlane, float farClipPlane);
		public void SetCameraFieldOfView(float fieldOfView);
		private void Awake();
		private void OnDestroy();
		public void LoadCutScene(string path, bool preLoadFlag = false);
		public void SetAnimatorController(bool start);
		public void PlayCut(string cutName, float startTime = 0f);
		public void SetBossCameraType(BossCamera type);
		public void SetFollowCameraData(CameraType type);
		public void LoadAnimationController(string controllerName);
		public void SkipAnimation(string stateName = null, float normalizedTime = 1f);
		public void SetAnimationSpeed(float speed);
		public void SetDefaultFollow();
		private void SetCameraMode(MODE camMode, bool clear);
		public void SetMode(MODE camMode, bool clear = true);
		public bool SetExtraAction(CameraModeExtraAction.StyleType style, GameObject target, float dist, Vector3 rot, float time, float interpolationTime);
		public void SetExtraAction(CameraModeExtraAction.StyleType style, GameObject target, float time);
		public void FinishExtraAction(bool isSkillCutInCamera);
		public MODE GetMode();
		public Vector3 GetLastTargetPosition();
		public void CheckNeedToStepIn();
		public void SetPosition(Vector3 pos);
		public Vector3 GetPosition();
		public void SetRotation(Quaternion rot);
		public Transform GetTransform();
		public Vector3 GetDefaultRotation();
		public Quaternion GetRotation();
		public float GetBossCameraMinRotX();
		public float GetBossCameraMaxRotX();
		public void Play(string animName);
		private float GetFieldOfView();
		public bool IsPlaying();
		public float PlayingLength();
		public void InitailizeCameraPosition();
		public void ResetCameraPosition();
		public Vector3 GetPlayerPosition();
		public CharacterBase GetChangeTargetChara();
		public Vector3 GetPlayerDirection();
		public void SetTargetRotate(Vector3 rot, float time);
		public void UpdateRotateAnimation();
		public void SetLookAt(float dist, Vector3 addVector);
		public void SetPositionAndRotation(Vector3 position, Quaternion rotation);
		public void SetCameraCollision(Vector3 pos, float radius);
		public void UpdateFollow();
		public static float CalcZoomSpeed(float spd, float acc, float min, float max);
		private void UpdateChangeDragon();
		private void UpdateFinish();
		public void SetSkillCamera(SkillDataElement element, bool isSupport);
		private Vector3 GetSkillTargetPosition();
		private Vector3 GetPlayerForwardPosition(float distance);
		private void UpdateSkill();
		private void UpdateGate();
		private void LateUpdate();
		public bool IsFollowing();
		public void SetShake(ShakeType type, ShakePriority prio = ShakePriority.Default);
		public void SetShakeDampingCoef(AnimationCurve animCurve);
		public void SetShake(ShakeType type, Vector3 pos);
		public void SetShake(float duration, float power);
		public Vector3 UpdateShake();
		public float GetDistance();
		public void ReloadCameraShakeData();
		public void ReloadFollowCameraData();
		public void SetTargetId(int partyIndex, int memberIndex);
		public void ResetTarget();
		public void CheckWall(Vector3 prevPos);
	}
}
