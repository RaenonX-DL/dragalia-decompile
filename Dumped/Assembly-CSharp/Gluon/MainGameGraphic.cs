/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MainGameGraphic : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CameraGroup _mainCameraGroup;
		[SerializeField]
		private StatusColorParams _statusColorParams;
		[SerializeField]
		private ChargeMarkerColors _chargeMarkerColors;
		[SerializeField]
		private MiscColor _miscColor;
		[SerializeField]
		[Tooltip]
		private MarkerDrawRange _markerDrawRange;
		private Dictionary<CharacterColor.State, StatusColorParam> _statusColorParamsDictionary;
		private Dictionary<ChargeMarker.eColorType, ChargeMarkerColor> _chargeMarkerColorsDictionary;
		[CompilerGenerated]
		private static MainGameGraphic _instance_k__BackingField;
	
		// Properties
		public CameraGroup mainCameraGroup { get; set; }
		public StatusColorParams statusColorParams { get; }
		public MiscColor miscColor { get; }
		public Dictionary<ChargeMarker.eColorType, ChargeMarkerColor> chargeMarkerColorsDictionary { get; }
		public static MainGameGraphic instance { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Nested types
		[Serializable]
		public class StatusColorParam
		{
			// Fields
			public static readonly Color defaultBaseColor;
			private static readonly Color defaultRimColor;
			private static readonly Color defaultCoverColor;
			private const float defaultBaseColorPower = 1f;
			private const float defaultRimColorPower = 0f;
			private const float defaultCoverColorPower = 0f;
			public bool enableResetColor;
			public UseColorFlags useColorFlags;
			public Color baseColor;
			[Range]
			public float baseColorPower;
			public Color rimColor;
			[Range]
			public float rimColorPower;
			public Color coverColor;
			[Range]
			public float coverColorPower;
			public TransitionType transitionType;
			public float forwardSec;
			public float reverseSec;
	
			// Nested types
			[Flags]
			public enum UseColorFlags
			{
				BaseColor = 1,
				RimColor = 2,
				CoverColor = 4
			}
	
			public enum TransitionType
			{
				OneWay = 0,
				RoundTrip = 1,
				Loop = 2,
				Break = 3,
				AbnormalStatus = 4
			}
	
			// Constructors
			public StatusColorParam();
			static StatusColorParam();
	
			// Methods
			public void GetBaseColorValue(out Color color, out float power);
			public void GetRimColorValue(out Color color, out float power);
			public void GetCoverColorValue(out Color color, out float power);
		}
	
		[Serializable]
		public class StatusColorParams
		{
			// Fields
			[Range]
			public float lerpRimWidth;
			[Range]
			public float lerpRimMax;
			[Range]
			public float lerpRimSpeed;
			[Range]
			public float lerpRimOffset;
			public StatusColorParam poisonParam;
			public StatusColorParam burnParam;
			public StatusColorParam flashheatParam;
			public StatusColorParam crashWindParam;
			public StatusColorParam darkabsParam;
			public StatusColorParam destroyfireParam;
			public StatusColorParam freezeParam;
			public StatusColorParam paralysisParam;
			public StatusColorParam frostbiteParam;
			public StatusColorParam darknessParam;
			public StatusColorParam curseParam;
			public StatusColorParam slowMoveParam;
			public StatusColorParam sleepParam;
			public StatusColorParam swoonParam;
			public StatusColorParam breakParam;
			public StatusColorParam fromDragonParam;
			public StatusColorParam damageParam;
			public StatusColorParam damageDragonParam;
			public StatusColorParam damagePartsParam;
			public StatusColorParam damagePartsDragonParam;
			public StatusColorParam healHpParam;
			public StatusColorParam healSpParam;
	
			// Constructors
			public StatusColorParams();
		}
	
		[Serializable]
		public class MiscColor
		{
			// Fields
			public ColorParam skillFadeoutColor;
			public Color skillButtonMainColor;
			public Color dragonButtonFlashColor;
			public Color skillButtonFlashColor;
	
			// Constructors
			public MiscColor();
		}
	
		[Serializable]
		public class ChargeMarkerColor
		{
			// Fields
			public Color baseColor;
			public Color frameColor;
			public Color chargeColor;
			public Color blinkColor;
	
			// Constructors
			public ChargeMarkerColor();
	
			// Methods
			public void Set(int baseColorR, int baseColorG, int baseColorB, int baseColorA, int setFrameR, int setFrameG, int setFrameB, int setFrameA, int setChargeR, int setChargeG, int setChargeB, int setChargeA, int setBlinkR, int setBlinkG, int setBlinkB, int setBlinkA);
		}
	
		[Serializable]
		public class ChargeMarkerColors
		{
			// Fields
			public ChargeMarkerColor playerNormal;
			public ChargeMarkerColor enemyNormal;
			public ChargeMarkerColor enemyVolcano;
			public ChargeMarkerColor teamBlue;
			public ChargeMarkerColor teamRed;
			public ChargeMarkerColor playerPowerUp;
			public ChargeMarkerColor enemyShare;
			public ChargeMarkerColor playerBuffField;
			public ChargeMarkerColor playerDebuffField;
			public ChargeMarkerColor playerRecoveryField;
	
			// Constructors
			public ChargeMarkerColors();
		}
	
		[CompilerGenerated]
		private sealed class _CoImageEffectProduction_d__35 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MainGameGraphic __4__this;
			private ImageEffectCtrlCronos _imageEffectCtrl_5__2;
			private float _waitSec_5__3;
			private float _fadeTimeMax_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoImageEffectProduction_d__35(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MainGameGraphic();
	
		// Methods
		public StatusColorParam GetStatusColorParam(CharacterColor.State state);
		public bool GetChargeMarkerColor(ChargeMarker.eColorType type, out ChargeMarkerColor cghargeMarkerColor);
		public void CopyChargeMarkerColorAll(MainGameGraphic source);
		private void CreateColorParamsDictionary();
		private void CreateChargeMarkerColorsDictionary();
		public void SetMarkerRange(MarkerDrawRange src = null);
		protected virtual void Awake();
		protected virtual void OnDestroy();
		protected virtual void Update();
		public void StartImageEggectProduction();
		[IteratorStateMachine]
		private IEnumerator CoImageEffectProduction();
		private ImageEffectCtrlCronos GetImageEffectCtrl();
	}
}
