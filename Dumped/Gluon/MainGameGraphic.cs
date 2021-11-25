using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class MainGameGraphic : MonoBehaviour
	{
		[Serializable]
		public class StatusColorParam
		{
			[Flags]
			public enum UseColorFlags
			{
				BaseColor = 0x1,
				RimColor = 0x2,
				CoverColor = 0x4
			}

			public enum TransitionType
			{
				OneWay,
				RoundTrip,
				Loop,
				Break,
				AbnormalStatus
			}

			public static readonly Color defaultBaseColor;

			private static readonly Color defaultRimColor;

			private static readonly Color defaultCoverColor;

			private const float defaultBaseColorPower = 1f;

			private const float defaultRimColorPower = 0f;

			private const float defaultCoverColorPower = 0f;

			public bool enableResetColor;

			public UseColorFlags useColorFlags;

			public Color baseColor;

			public float baseColorPower;

			public Color rimColor;

			public float rimColorPower;

			public Color coverColor;

			public float coverColorPower;

			public TransitionType transitionType;

			public float forwardSec;

			public float reverseSec;

			public void GetBaseColorValue(out Color color, out float power)
			{
			}

			public void GetRimColorValue(out Color color, out float power)
			{
			}

			public void GetCoverColorValue(out Color color, out float power)
			{
			}
		}

		[Serializable]
		public class StatusColorParams
		{
			public float lerpRimWidth;

			public float lerpRimMax;

			public float lerpRimSpeed;

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
		}

		[Serializable]
		public class MiscColor
		{
			public ColorParam skillFadeoutColor;

			public Color skillButtonMainColor;

			public Color dragonButtonFlashColor;

			public Color skillButtonFlashColor;
		}

		[Serializable]
		public class ChargeMarkerColor
		{
			public Color baseColor;

			public Color frameColor;

			public Color chargeColor;

			public Color blinkColor;

			public void Set(int baseColorR, int baseColorG, int baseColorB, int baseColorA, int setFrameR, int setFrameG, int setFrameB, int setFrameA, int setChargeR, int setChargeG, int setChargeB, int setChargeA, int setBlinkR, int setBlinkG, int setBlinkB, int setBlinkA)
			{
			}
		}

		[Serializable]
		public class ChargeMarkerColors
		{
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
		}

		[SerializeField]
		private CameraGroup _mainCameraGroup;

		[SerializeField]
		private StatusColorParams _statusColorParams;

		[SerializeField]
		private ChargeMarkerColors _chargeMarkerColors;

		[SerializeField]
		private MiscColor _miscColor;

		[SerializeField]
		[Tooltip("ã\u0083\u009eã\u0083¼ã\u0082«ã\u0083¼ã\u0081®è¡\u00a8ç¤ºé\u00a0\u0098å\u009f\u009f")]
		private MarkerDrawRange _markerDrawRange;

		private Dictionary<CharacterColor.State, StatusColorParam> _statusColorParamsDictionary;

		private Dictionary<ChargeMarker.eColorType, ChargeMarkerColor> _chargeMarkerColorsDictionary;

		public CameraGroup mainCameraGroup
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public StatusColorParams statusColorParams => null;

		public MiscColor miscColor => null;

		public Dictionary<ChargeMarker.eColorType, ChargeMarkerColor> chargeMarkerColorsDictionary => null;

		public static MainGameGraphic instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public StatusColorParam GetStatusColorParam(CharacterColor.State state)
		{
			return null;
		}

		public bool GetChargeMarkerColor(ChargeMarker.eColorType type, out ChargeMarkerColor cghargeMarkerColor)
		{
			return default(bool);
		}

		public void CopyChargeMarkerColorAll(MainGameGraphic source)
		{
		}

		private void CreateColorParamsDictionary()
		{
		}

		private void CreateChargeMarkerColorsDictionary()
		{
		}

		public void SetMarkerRange([Optional] MarkerDrawRange src)
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void Update()
		{
		}

		public void StartImageEggectProduction()
		{
		}

		private IEnumerator CoImageEffectProduction()
		{
			return null;
		}

		private ImageEffectCtrlCronos GetImageEffectCtrl()
		{
			return null;
		}
	}
}
