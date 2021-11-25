using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using Gluon.ActionData;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class ChargeMarker : CommonObjectStatus
	{
		public enum eType
		{
			Circle,
			Line,
			Cross_01,
			Cross_02,
			Fan30,
			Fan100,
			Arrow,
			ArrowCircle,
			Fan120,
			Fan180,
			Donuts,
			Fan60,
			Fan90,
			Fan150,
			Fan210,
			Fan240,
			Fan270,
			Fan15,
			Fan45,
			Fan10,
			Tube180,
			Fan300,
			Fan330,
			EnumMax
		}

		public enum eColorType
		{
			Player,
			EnemyNormal,
			Dummy_002,
			EnemyUninvincible,
			Dummy_004,
			TeamBlue,
			TeamRed,
			PlayerPowerUp,
			EnemyShare,
			PlayerBuffField,
			PlayerDebuffField,
			playerRecoveryField
		}

		public enum TraceType
		{
			None,
			Self,
			Target,
			TargetFullTime,
			TargetFullTime_PlayerWithSupport,
			TargetFixedTime,
			SelfFullTime
		}

		private enum eState
		{
			None,
			Target,
			Charge,
			ChargeAfter,
			ImpactWait,
			Close,
			Manual
		}

		public enum PlayerAIEscapeDirection
		{
			Default,
			Back,
			Side,
			Side_L,
			Side_R,
			FanNearest,
			FanNearest2,
			SideRot90Degree
		}

		public static float[] fanAngles;

		[SerializeField]
		private eType _type;

		[SerializeField]
		private Material _chargeMaterial;

		[SerializeField]
		private Material _otherMaterial;

		[SerializeField]
		private float _maxChargeEdgeSize;

		[SerializeField]
		private float _maxChargeEdgePower;

		[SerializeField]
		private float _maxChargeInsideSize;

		private static readonly float DefaultDurationSec;

		private float _durationSec;

		private static readonly float DefaultChargeAfterSec;

		private float _chargeAfterSec;

		private static readonly float DefaultMarkerLength;

		private float _markerLength;

		private static readonly float DefaultMarkerWidth;

		private float _markerWidth;

		public static readonly float markerHeight;

		private InGameDef.CharacterType charaType;

		private float _elapsedSec;

		protected GameObject goFrame;

		private bool _isImpactWait;

		public bool ignoredImpactWaitForPlayerColor;

		public const float FLASH_TIME = 0.2f;

		private float[] chargeDuration;

		private int[] activateOnImpact;

		private Vector3 _basePos;

		private Vector3 _targetPos;

		private Vector3 startScale;

		private TraceType _traceType;

		public float nearRange;

		public float farRange;

		private bool _isSudden;

		private bool _isGroundHeight;

		protected Color _colorBack;

		protected Color _colorCharge;

		protected Color _colorBlink;

		protected Color _colorFrame;

		private readonly Color _colorFlash;

		private CollisionTransform _collisionTrans;

		private float _awakeDuration;

		private static readonly float AwakeSecRate;

		private const float CloseDuration = 0.1f;

		private eState _state;

		private Tweener _blinkTween;

		private Tweener _tweenerClose;

		private Tweener _tweenerFlashColor;

		private List<Renderer> _chargeRenderersList;

		private List<Renderer> _otherRenderersList;

		private MaterialPropertyBlock _chargeMaterialPropertyBlock;

		private MaterialPropertyBlock _otherMaterialPropertyBlock;

		private CharacterBase _firstTargetPlayer;

		private bool _clearFromActionContainer;

		public bool ignoredByPlayerAI;

		public CommonObjectStatus targetingPlayerAIChara;

		public PlayerAIEscapeDirection playerAIEscapeDir;

		private bool ignoreRotForTargetP;

		public Action<int> onChargeImpact;

		public Action<ChargeMarker, bool> onClear;

		public eType type => default(eType);

		public float durationSec => default(float);

		public float traceSec
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

		public float markerLength => default(float);

		public float markerWidth => default(float);

		public bool isActiveMeshRendererOn
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

		public CommonObjectStatus attachObj
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

		public Vector3 basePos => default(Vector3);

		public Vector3 targetPos
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool isUpdateByTargetPos
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

		public Vector3 initPos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 offsetPos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 impactPos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Vector3 endScale
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

		public bool pause
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

		public bool isExistTarget
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

		public CommonObjectStatus target
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

		public int groupId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public CharacterBase ownerChara
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

		public ActionContainer actionContainer
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

		private void SetMaterialPropertyBlock()
		{
		}

		public virtual void Reset()
		{
		}

		public void Clear()
		{
		}

		public void Clear(bool fromActionContainer)
		{
		}

		private static CollisionHitAttribute CreateCollisionHitAttribute(ActionMarkerElement markerElm, InGameDef.CharacterType type)
		{
			return null;
		}

		public static ChargeMarker Create(ActionMarker markerId, InGameDef.CharacterType type, Vector3 pos, Vector3 forward)
		{
			return null;
		}

		public static ChargeMarker Create(eType shape, eColorType color, Vector3 pos, float rotY, float length, float width, float chargeSec, float chargeAfterSec = 0f, float traceSec = 0f, TraceType trace = TraceType.None, bool sudden = false, float tempoScale = 1f, [Optional] CharacterBase owner)
		{
			return null;
		}

		public static ChargeMarker Create(MarkerData data, CharacterBase owner, CommonObjectStatus target, float tempoScale = 1f)
		{
			return null;
		}

		public static ChargeMarker Create(MarkerData data, Vector3 pos, float rotY, float tempoScale = 1f, [Optional] CharacterBase owner, float dynamicLength = 0f)
		{
			return null;
		}

		private void SetParam_A(eColorType colorType, Vector3 pos, float rotY, float tmpDuration, float tmpChargeAfter, float tmpTraceSec, float length, float width = 0f)
		{
		}

		private void SetParam_B(MarkerData data, CharacterBase owner, CommonObjectStatus target_, float tempoScale = 1f)
		{
		}

		private void SetParam_C(MarkerData data, Vector3 pos, float rotY, float tempoScale = 1f, float dynamicLength = 0f)
		{
		}

		private void SetParam_D(MarkerData data, CharacterBase owner, Vector3 pos, float rotY, float ofsScale = 1f, float tempoScale = 1f)
		{
		}

		private void SetParam_E(eColorType color, Vector3 pos, float rotY, float length, float width, float chargeSec, float chargeAfterSec, float traceSec, TraceType trace, bool sudden, float tempoScale = 1f)
		{
		}

		private void UpdateChargeMaterialParam(float chargeRate)
		{
		}

		protected virtual void SetPartsParam()
		{
		}

		public void SetActiveState(bool active)
		{
		}

		private static eType HitAttribute2Shape(ActionCollision collision, float collisionFan = 30f)
		{
			return default(eType);
		}

		public void SetImpact()
		{
		}

		public void SetPowerUpColor()
		{
		}

		public bool IsInside(Vector3 pos, float radius)
		{
			return default(bool);
		}

		public Vector3 GetCenterPos()
		{
			return default(Vector3);
		}

		protected override void Awake()
		{
		}

		public bool IsEnableControl()
		{
			return default(bool);
		}

		public bool IsActive()
		{
			return default(bool);
		}

		public bool IsTargeting()
		{
			return default(bool);
		}

		public bool IsClosed()
		{
			return default(bool);
		}

		public bool IsImpact()
		{
			return default(bool);
		}

		public bool IsMatchMarkerType(eType markerType)
		{
			return default(bool);
		}

		public bool IsTargetArrowCircle()
		{
			return default(bool);
		}

		public float GetChargeMarkerScale(float dist)
		{
			return default(float);
		}

		public override void FastUpdate()
		{
		}

		private void Trace(Vector3 targetPos, float rate)
		{
		}

		private void ChargingTrace()
		{
		}

		private void Hide()
		{
		}

		public virtual void UpdatePosition(Vector3 pos)
		{
		}

		public void UpdateRotation(Quaternion rot)
		{
		}

		public void UpdateScale(float scl)
		{
		}

		public virtual void SetImpactPosition()
		{
		}

		public virtual void ForceUpdateImpactPosition(Vector3 pos)
		{
		}

		private Color GenerateColor(float r, float g, float b, float a)
		{
			return default(Color);
		}

		private void OnUpdateBlinkColor(float value)
		{
		}

		private void OnUpdateFlashColor(float value)
		{
		}

		private void OnChargeComplete()
		{
		}

		public void OnChargeCompleteForBustAttack(int chargeLv)
		{
		}

		private void OnUpdateMarkerClose(float value)
		{
		}

		private void OnUpdateMarkerKeep(float value)
		{
		}

		protected virtual void OnClose()
		{
		}

		public void SetManualMode()
		{
		}

		public void SetActiveMeshRenderer(bool active)
		{
		}

		public void SetActiveRenderer(bool active)
		{
		}

		private void UpdateManual()
		{
		}

		public void NextChargeLv(int nextLv)
		{
		}
	}
}
