/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.ActionData;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ChargeMarker : CommonObjectStatus
	{
		// Fields
		public static float[] fanAngles;
		[SerializeField]
		private eType _type;
		[SerializeField]
		private Material _chargeMaterial;
		[SerializeField]
		private Material _otherMaterial;
		[Range]
		[SerializeField]
		private float _maxChargeEdgeSize;
		[Range]
		[SerializeField]
		private float _maxChargeEdgePower;
		[Range]
		[SerializeField]
		private float _maxChargeInsideSize;
		private static readonly float DefaultDurationSec;
		private float _durationSec;
		private static readonly float DefaultChargeAfterSec;
		private float _chargeAfterSec;
		[CompilerGenerated]
		private float _traceSec_k__BackingField;
		private static readonly float DefaultMarkerLength;
		private float _markerLength;
		private static readonly float DefaultMarkerWidth;
		private float _markerWidth;
		public static readonly float markerHeight;
		[CompilerGenerated]
		private bool _isActiveMeshRendererOn_k__BackingField;
		private InGameDef.CharacterType charaType;
		private float _elapsedSec;
		protected GameObject goFrame;
		[CompilerGenerated]
		private CommonObjectStatus _attachObj_k__BackingField;
		private bool _isImpactWait;
		public bool ignoredImpactWaitForPlayerColor;
		public const float FLASH_TIME = 0.2f;
		private float[] chargeDuration;
		private int[] activateOnImpact;
		private Vector3 _basePos;
		private Vector3 _targetPos;
		[CompilerGenerated]
		private bool _isUpdateByTargetPos_k__BackingField;
		[CompilerGenerated]
		private Vector3 _initPos_k__BackingField;
		[CompilerGenerated]
		private Vector3 _offsetPos_k__BackingField;
		[CompilerGenerated]
		private Vector3 _impactPos_k__BackingField;
		private Vector3 startScale;
		[CompilerGenerated]
		private Vector3 _endScale_k__BackingField;
		[CompilerGenerated]
		private bool _pause_k__BackingField;
		[CompilerGenerated]
		private bool _isExistTarget_k__BackingField;
		[CompilerGenerated]
		private CommonObjectStatus _target_k__BackingField;
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
		[CompilerGenerated]
		private int _groupId_k__BackingField;
		[CompilerGenerated]
		private CharacterBase _ownerChara_k__BackingField;
		[CompilerGenerated]
		private ActionContainer _actionContainer_k__BackingField;
		private bool _clearFromActionContainer;
		public bool ignoredByPlayerAI;
		public CommonObjectStatus targetingPlayerAIChara;
		public PlayerAIEscapeDirection playerAIEscapeDir;
		private bool ignoreRotForTargetP;
		public Action<int> onChargeImpact;
		public Action<ChargeMarker, bool> onClear;
	
		// Properties
		public eType type { get; }
		public float durationSec { get; }
		public float traceSec { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float markerLength { get; }
		public float markerWidth { get; }
		public bool isActiveMeshRendererOn { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CommonObjectStatus attachObj { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 basePos { get; }
		public Vector3 targetPos { get; set; }
		public bool isUpdateByTargetPos { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 initPos { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector3 offsetPos { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector3 impactPos { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Vector3 endScale { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool pause { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isExistTarget { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CommonObjectStatus target { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int groupId { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public CharacterBase ownerChara { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ActionContainer actionContainer { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum eType
		{
			Circle = 0,
			Line = 1,
			Cross_01 = 2,
			Cross_02 = 3,
			Fan30 = 4,
			Fan100 = 5,
			Arrow = 6,
			ArrowCircle = 7,
			Fan120 = 8,
			Fan180 = 9,
			Donuts = 10,
			Fan60 = 11,
			Fan90 = 12,
			Fan150 = 13,
			Fan210 = 14,
			Fan240 = 15,
			Fan270 = 16,
			Fan15 = 17,
			Fan45 = 18,
			Fan10 = 19,
			Tube180 = 20,
			Fan300 = 21,
			Fan330 = 22,
			EnumMax = 23
		}
	
		public enum eColorType
		{
			Player = 0,
			EnemyNormal = 1,
			Dummy_002 = 2,
			EnemyUninvincible = 3,
			Dummy_004 = 4,
			TeamBlue = 5,
			TeamRed = 6,
			PlayerPowerUp = 7,
			EnemyShare = 8,
			PlayerBuffField = 9,
			PlayerDebuffField = 10,
			playerRecoveryField = 11
		}
	
		public enum TraceType
		{
			None = 0,
			Self = 1,
			Target = 2,
			TargetFullTime = 3,
			TargetFullTime_PlayerWithSupport = 4,
			TargetFixedTime = 5,
			SelfFullTime = 6
		}
	
		private enum eState
		{
			None = 0,
			Target = 1,
			Charge = 2,
			ChargeAfter = 3,
			ImpactWait = 4,
			Close = 5,
			Manual = 6
		}
	
		public enum PlayerAIEscapeDirection
		{
			Default = 0,
			Back = 1,
			Side = 2,
			Side_L = 3,
			Side_R = 4,
			FanNearest = 5,
			SideRot90Degree = 6
		}
	
		// Constructors
		public ChargeMarker();
		static ChargeMarker();
	
		// Methods
		private void SetMaterialPropertyBlock();
		public virtual void Reset();
		public void Clear();
		public void Clear(bool fromActionContainer);
		private static CollisionHitAttribute CreateCollisionHitAttribute(ActionMarkerElement markerElm, InGameDef.CharacterType type);
		public static ChargeMarker Create(ActionMarker markerId, InGameDef.CharacterType type, Vector3 pos, Vector3 forward);
		public static ChargeMarker Create(eType shape, eColorType color, Vector3 pos, float rotY, float length, float width, float chargeSec, float chargeAfterSec = 0f, float traceSec = 0f, TraceType trace = TraceType.None, bool sudden = false, float tempoScale = 1f, CharacterBase owner = null);
		public static ChargeMarker Create(MarkerData data, CharacterBase owner, CommonObjectStatus target, float tempoScale = 1f);
		public static ChargeMarker Create(MarkerData data, Vector3 pos, float rotY, float tempoScale = 1f, CharacterBase owner = null);
		private void SetParam_A(eColorType colorType, Vector3 pos, float rotY, float tmpDuration, float tmpChargeAfter, float tmpTraceSec, float length, float width = 0f);
		private void SetParam_B(MarkerData data, CharacterBase owner, CommonObjectStatus target_, float tempoScale = 1f);
		private void SetParam_C(MarkerData data, Vector3 pos, float rotY, float tempoScale = 1f);
		private void SetParam_D(MarkerData data, CharacterBase owner, Vector3 pos, float rotY, float ofsScale = 1f, float tempoScale = 1f);
		private void SetParam_E(eColorType color, Vector3 pos, float rotY, float length, float width, float chargeSec, float chargeAfterSec, float traceSec, TraceType trace, bool sudden, float tempoScale = 1f);
		private void UpdateChargeMaterialParam(float chargeRate);
		protected virtual void SetPartsParam();
		public void SetActiveState(bool active);
		private static eType HitAttribute2Shape(ActionCollision collision, float collisionFan = 30f);
		public void SetImpact();
		public void SetPowerUpColor();
		public bool IsInside(Vector3 pos, float radius);
		public Vector3 GetCenterPos();
		protected override void Awake();
		public bool IsEnableControl();
		public bool IsActive();
		public bool IsTargeting();
		public bool IsClosed();
		public bool IsImpact();
		public bool IsMatchMarkerType(eType markerType);
		public bool IsTargetArrowCircle();
		public float GetChargeMarkerScale(float dist);
		public override void FastUpdate();
		private void Trace(Vector3 targetPos, float rate);
		private void ChargingTrace();
		private void Hide();
		public virtual void UpdatePosition(Vector3 pos);
		public void UpdateRotation(Quaternion rot);
		public void UpdateScale(float scl);
		public virtual void SetImpactPosition();
		public virtual void ForceUpdateImpactPosition(Vector3 pos);
		private Color GenerateColor(float r, float g, float b, float a);
		private void OnUpdateBlinkColor(float value);
		private void OnUpdateFlashColor(float value);
		private void OnChargeComplete();
		public void OnChargeCompleteForBustAttack(int chargeLv);
		private void OnUpdateMarkerClose(float value);
		private void OnUpdateMarkerKeep(float value);
		protected virtual void OnClose();
		public void SetManualMode();
		public void SetActiveMeshRenderer(bool active);
		public void SetActiveRenderer(bool active);
		private void UpdateManual();
		public void NextChargeLv(int nextLv);
	}
}
