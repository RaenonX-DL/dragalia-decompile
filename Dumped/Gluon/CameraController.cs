using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	[AddComponentMenu("Camera-Control/CameraController")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		public class FollowCameraData
		{
			[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0081\u008bã\u0082\u0089ã\u0081®ã\u0082«ã\u0083¡ã\u0083©ã\u0081®è·\u009dé\u009b¢ï¼\u0088ç\u008f¾å\u009c\u00a8å\u0080¤ï¼\u0089[m]")]
			public float distance;

			[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0081\u008bã\u0082\u0089ã\u0081®ã\u0082«ã\u0083¡ã\u0083©ã\u0081®è·\u009dé\u009b¢ï¼\u0088æ\u009c\u0080å°\u008få\u0080¤ï¼\u0089[m]")]
			public float minDistance;

			[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0081\u008bã\u0082\u0089ã\u0081®ã\u0082«ã\u0083¡ã\u0083©ã\u0081®è·\u009dé\u009b¢ï¼\u0088æ\u009c\u0080å¤§å\u0080¤ï¼\u0089[m]")]
			public float maxDistance;

			[Tooltip("ã\u0082«ã\u0083¡ã\u0083©ã\u0081®æ\u0096¹å\u0090\u0091ã\u0082\u0092è\u00a8\u0088ç®\u0097ã\u0081\u0099ã\u0082\u008bã\u0081\u009fã\u0082\u0081ã\u0081®å\u009b\u009eè»¢è§\u0092åº¦[åº¦]\nx:Yaw y:Pitch z:Roll")]
			public Vector3 rotate;

			[Tooltip("ã\u0083\u0080ã\u0083\u0083ã\u0082·ã\u0083¥æ\u0099\u0082ä»¥å¤\u0096ã\u0081®ã\u0082«ã\u0083¡ã\u0083©ã\u0081®ã\u0083\u0099ã\u0083¼ã\u0082¹ç§»å\u008b\u0095é\u0080\u009fåº¦")]
			public float battleBaseSpeed;

			[Tooltip("ã\u0083\u0080ã\u0083\u0083ã\u0082·ã\u0083¥æ\u0099\u0082ã\u0081®ã\u0082«ã\u0083¡ã\u0083©ã\u0081®ã\u0083\u0099ã\u0083¼ã\u0082¹ç§»å\u008b\u0095é\u0080\u009fåº¦")]
			public float dashBaseSpeed;

			[Tooltip("å\u0089\u008dæ\u0096¹ã\u0081«æ³\u00a8è¦\u0096ç\u0082¹ã\u0082\u0092ç§»å\u008b\u0095ã\u0081\u0095ã\u0081\u009bã\u0082\u008bè·\u009dé\u009b¢[m]")]
			public float dashFrontLength;

			[Tooltip("å\u0089\u008dæ\u0096¹ã\u0081«æ³\u00a8è¦\u0096ç\u0082¹ã\u0082\u0092ç§»å\u008b\u0095ã\u0081\u0095ã\u0081\u009bã\u0082\u008bè·\u009dé\u009b¢ ã\u0081«ã\u0081\u008bã\u0081\u0091ã\u0082\u008bå\u0080\u008dç\u008e\u0087[0-1.0]")]
			public float frontLengthVerticalRatio;

			public float dashZoomOutLength;

			public float dashZoomOutTime;

			[Tooltip("é\u0081\u00a0è·\u009dé\u009b¢æ­¦å\u0099\u00a8æ\u0094»æ\u0092\u0083ã\u0081§å¼\u0095ã\u0081\u008fè·\u009dé\u009b¢[m]")]
			public float longRangeAttackZoomOutLength;

			[Tooltip("é\u0081\u00a0è·\u009dé\u009b¢æ­¦å\u0099\u00a8æ\u0094»æ\u0092\u0083ã\u0081§â\u0086\u0091ã\u0081®è·\u009dé\u009b¢ã\u0081«å\u0088°é\u0081\u0094ã\u0081\u0099ã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®æ\u0099\u0082é\u0096\u0093[sec]")]
			public float longRangeAttackZoomOutTime;

			[Tooltip("é\u0081\u00a0è·\u009dé\u009b¢æ­¦å\u0099\u00a8æ\u0094»æ\u0092\u0083ã\u0081§æ\u009c\u0080å¤§è·\u009dé\u009b¢ã\u0082\u0092ç¶­æ\u008c\u0081ã\u0081\u0099ã\u0082\u008bæ\u0099\u0082é\u0096\u0093[sec]")]
			public float longRangeAttackZoomKeepTime;

			[Tooltip("é\u0081\u00a0è·\u009dé\u009b¢æ­¦å\u0099\u00a8æ\u0094»æ\u0092\u0083ã\u0081§å\u0089\u008dæ\u0096¹ã\u0081\u00b8æ³\u00a8è¦\u0096ç\u0082¹ã\u0082\u0092ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088ã\u0081\u0095ã\u0081\u009bã\u0082\u008bè·\u009dé\u009b¢[m]")]
			public float longRangeAttackFrontOffset;

			[Tooltip("é\u0081\u00a0è·\u009dé\u009b¢æ­¦å\u0099\u00a8æ\u0094»æ\u0092\u0083ã\u0081§å\u0089\u008dæ\u0096¹ã\u0081\u00b8æ³\u00a8è¦\u0096ç\u0082¹ã\u0082\u0092ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088ã\u0081\u0095ã\u0081\u009bã\u0082\u008bå\u009fºæ\u009c¬é\u0080\u009fåº¦[m/s]")]
			public float longRangeAttackFrontInBaseSpeed;

			[Tooltip("é\u0081\u00a0è·\u009dé\u009b¢æ­¦å\u0099\u00a8æ\u0094»æ\u0092\u0083ã\u0081§å\u0089\u008dæ\u0096¹ã\u0081\u00b8ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088ã\u0081\u0095ã\u0081\u009bã\u0081\u009fæ³\u00a8è¦\u0096ç\u0082¹ã\u0082\u0092å\u0085\u0083ã\u0081®ä½\u008dç½®ã\u0081«æ\u0088»ã\u0081\u0099å\u009fºæ\u009c¬é\u0080\u009fåº¦[m/s]")]
			public float longRangeAttackFrontOutBaseSpeed;

			[Tooltip("ã\u0082ºã\u0083¼ã\u0083\u00a0ã\u0082­ã\u0083¼ã\u0083\u0097æ\u0099\u0082ã\u0081«ç§»å\u008b\u0095é\u0080\u009fåº¦ã\u0081«ã\u0081\u008bã\u0081\u0091ã\u0082\u008bä¿\u0082æ\u0095°")]
			public float moveSpeedCoefOnZoomKeepTime;

			[Tooltip("ç\u0094»è§\u0092ï¼\u0088FOVï¼\u0089\n0ã\u0081®å\u00a0\u00b4å\u0090\u0088ã\u0081\u00afã\u0083\u0087ã\u0083\u0095ã\u0082©å\u0080¤45Â°")]
			public float fov;

			[Tooltip("Yè»\u00b8å\u009b\u009eè»¢ã\u0081®é\u0099\u0090åº¦è§\u0092[åº¦]\nï¼\u009aã\u0082\u00afã\u0083­ã\u0083\u008eã\u0082¹æ\u0088¦ã\u0082«ã\u0083¡ã\u0083©ç\u0094\u00a8")]
			public float rotateLimitY;

			[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0082\u0092å\u008e\u009fç\u0082¹æ\u0096¹å\u0090\u0091ã\u0081«ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088ã\u0081\u0099ã\u0082\u008bè·\u009dé\u009b¢[m]\nï¼\u009aã\u0082\u00afã\u0083­ã\u0083\u008eã\u0082¹æ\u0088¦ã\u0082«ã\u0083¡ã\u0083©ç\u0094\u00a8")]
			public float lookAtOffsetDistance;
		}

		[Serializable]
		public enum ShakeType
		{
			shakeR_xs_00,
			shakeR_s_01,
			shakeR_m_02,
			shakeR_l_03,
			shakeR_xl_04,
			shakeV_xs_05,
			shakeV_s_06,
			shakeV_m_07,
			shakeV_l_08,
			shakeV_xl_09,
			shakeS_xs_10,
			shakeS_s_11,
			shakeS_m_12,
			shakeS_l_13,
			shakeS_xl_14,
			shakeZodiarc_Roar,
			shakeR_4xl_16,
			shakeDragon_Trans,
			shakeR_dr_ss_18,
			shakeR_dr_sw_19,
			shakeR_dr_ms_20,
			shakeR_dr_mw_21,
			shakeR_dr_ls_22,
			shakeR_dr_lw_23,
			shakeHard_Hit,
			shakeHitS,
			shakeHitM,
			shakeHitL,
			MAX
		}

		public enum ShakePriority
		{
			Default,
			ActionParts01,
			ActionParts02,
			ActionParts03,
			ActionParts04,
			ActionParts05,
			HitAttack,
			HitAttack01,
			HitAttack02,
			HitAttack03
		}

		public enum MODE
		{
			ANIMATION,
			CUTSCENE,
			FOLLOW,
			DRAGON,
			FINISH,
			SKILL,
			GATE,
			EXTRAACTION,
			BATTLESTART,
			TARGETPOSITION,
			CUTT,
			VIEWER,
			CMNSKILL_CHECKER
		}

		public const string InGameCameraName = "Animations/InGame/Camera";

		private FollowCameraData[] _followCameraData;

		private GameObject goFollowCameraDataContainer;

		private CameraType camType;

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

		private Vector3 rotateAnimationStart;

		private float rotateLerpTime;

		private float rotateTime;

		[NonSerialized]
		public float lastFollowDistance;

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

		private CameraShakeData currentShakeData;

		private bool shakeActive;

		private float shakeTime;

		private Vector2 shakeRand;

		private AnimationCurve dampingCoef;

		private const float ShakeDistance = 400f;

		public FollowCameraData[] followCameraData => null;

		public CameraType CamType => default(CameraType);

		public CameraGroupCtrl cameraGroupCtrl
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

		public CameraGroup mainCmeraGroup
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

		public CameraGroup silhouetteCameraGroup
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

		public MODE Mode => default(MODE);

		public Vector3 defaultRotate
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float pinchFollowDistance
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

		public Vector3 targetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public CameraModeExtraAction modeExtraAction
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

		public bool EnableConvertFovToMatchWidth
		{
			private get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool finishEnd => default(bool);

		public GameObject finishFocusObject
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

		public Vector3 gatePos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetCameraGroupCtrl(CameraGroupCtrl cg)
		{
		}

		public void SetCameraField(float fieldOfView, float nearClipPlane, float farClipPlane)
		{
		}

		public void SetCameraFieldOfView(float fieldOfView)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void LoadCutScene(string path, bool preLoadFlag = false)
		{
		}

		public void SetAnimatorController(bool start)
		{
		}

		public void PlayCut(string cutName, float startTime = 0f)
		{
		}

		public void SetBossCameraType(BossCamera type)
		{
		}

		public void SetFollowCameraData(CameraType type)
		{
		}

		public void LoadAnimationController(string controllerName)
		{
		}

		public void SkipAnimation([Optional] string stateName, float normalizedTime = 1f)
		{
		}

		public void SetAnimationSpeed(float speed)
		{
		}

		public void SetDefaultFollow()
		{
		}

		private void SetCameraMode(MODE camMode, bool clear)
		{
		}

		public void SetMode(MODE camMode, bool clear = true)
		{
		}

		public bool SetExtraAction(CameraModeExtraAction.StyleType style, GameObject target, float dist, Vector3 rot, float time, float interpolationTime)
		{
			return default(bool);
		}

		public void SetExtraAction(CameraModeExtraAction.StyleType style, GameObject target, float time)
		{
		}

		public void FinishExtraAction(bool isSkillCutInCamera)
		{
		}

		public MODE GetMode()
		{
			return default(MODE);
		}

		public Vector3 GetLastTargetPosition()
		{
			return default(Vector3);
		}

		public void CheckNeedToStepIn()
		{
		}

		public void SetPosition(Vector3 pos)
		{
		}

		public Vector3 GetPosition()
		{
			return default(Vector3);
		}

		public void SetRotation(Quaternion rot)
		{
		}

		public Transform GetTransform()
		{
			return null;
		}

		public Vector3 GetDefaultRotation()
		{
			return default(Vector3);
		}

		public Quaternion GetRotation()
		{
			return default(Quaternion);
		}

		public float GetBossCameraMinRotX()
		{
			return default(float);
		}

		public float GetBossCameraMaxRotX()
		{
			return default(float);
		}

		public void Play(string animName)
		{
		}

		private float GetFieldOfView()
		{
			return default(float);
		}

		public bool IsPlaying()
		{
			return default(bool);
		}

		public float PlayingLength()
		{
			return default(float);
		}

		public void InitailizeCameraPosition()
		{
		}

		public void ResetCameraPosition()
		{
		}

		public Vector3 GetPlayerPosition()
		{
			return default(Vector3);
		}

		public CharacterBase GetChangeTargetChara()
		{
			return null;
		}

		public Vector3 GetPlayerDirection()
		{
			return default(Vector3);
		}

		public void SetTargetRotate(Vector3 rot, float time)
		{
		}

		public void UpdateRotateAnimation()
		{
		}

		public void SetLookAt(float dist, Vector3 addVector)
		{
		}

		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
		}

		public void SetCameraCollision(Vector3 pos, float radius)
		{
		}

		public void UpdateFollow()
		{
		}

		public static float CalcZoomSpeed(float spd, float acc, float min, float max)
		{
			return default(float);
		}

		private void UpdateChangeDragon()
		{
		}

		private void UpdateFinish()
		{
		}

		public void SetSkillCamera(SkillDataElement element, bool isSupport)
		{
		}

		private Vector3 GetSkillTargetPosition()
		{
			return default(Vector3);
		}

		private Vector3 GetPlayerForwardPosition(float distance)
		{
			return default(Vector3);
		}

		private void UpdateSkill()
		{
		}

		private void UpdateGate()
		{
		}

		private void LateUpdate()
		{
		}

		public bool IsFollowing()
		{
			return default(bool);
		}

		public void SetShake(ShakeType type, ShakePriority prio = ShakePriority.Default)
		{
		}

		public void SetShakeDampingCoef(AnimationCurve animCurve)
		{
		}

		public void SetShake(ShakeType type, Vector3 pos)
		{
		}

		public void SetShake(float duration, float power)
		{
		}

		public Vector3 UpdateShake()
		{
			return default(Vector3);
		}

		public float GetDistance()
		{
			return default(float);
		}

		public void ReloadCameraShakeData()
		{
		}

		public void ReloadFollowCameraData()
		{
		}

		public void SetTargetId(int partyIndex, int memberIndex)
		{
		}

		public void ResetTarget()
		{
		}

		public void CheckWall(Vector3 prevPos)
		{
		}

		public bool IsSkillCutInCameraHiddenEffectsEmpty()
		{
			return default(bool);
		}
	}
}
