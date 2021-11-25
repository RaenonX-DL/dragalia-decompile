using System;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UniqueTransButton : FastUpdateMonoBehaviour
	{
		public delegate void ButtonDelegate(UniqueTransButton sender);

		[SerializeField]
		[Header("component")]
		private Button button;

		[SerializeField]
		private RectTransform invalidRt;

		[SerializeField]
		private RectTransform iconRt;

		[SerializeField]
		private RectTransform offsetRt;

		[SerializeField]
		private RectTransform buttonFrameEffectRt;

		[SerializeField]
		private RectTransform noUseRt;

		[SerializeField]
		private SpriteRenderer icon;

		[SerializeField]
		private SpriteRenderer buttonFrameEffect;

		[SerializeField]
		private SpriteRenderer noUseImage;

		[SerializeField]
		private SpriteRenderer _utpGaugeImage;

		[SerializeField]
		private CircleGauge _utpGaugeCtrl;

		[SerializeField]
		private DragonPointGaugeUI dpGaugeUI;

		[SerializeField]
		[Header("parameter")]
		private float expansionTime;

		[SerializeField]
		private float moveTime;

		[SerializeField]
		private float gaugeOffsetX;

		[SerializeField]
		private Color32 inactiveTimeColor;

		[SerializeField]
		private float inactiveTimeContrast;

		[SerializeField]
		private float inactiveTimeSaturation;

		[SerializeField]
		private float inactiveTimeBrightness;

		[SerializeField]
		private float inactiveTimeBrightnessDeep;

		[SerializeField]
		private int flashCount;

		[SerializeField]
		private float flashTime;

		[SerializeField]
		private float maxFlashPower;

		[SerializeField]
		[Tooltip("å\u009bºæ\u009c\u0089å¤\u0089èº«ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®å¤\u0089èº«å\u008f\u00afè\u0083½å\u0089²å\u0090\u0088")]
		private float utpGaugeRequireRate;

		[SerializeField]
		[Tooltip("å\u009bºæ\u009c\u0089å¤\u0089èº«ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®æ\u009c\u0080å¤§å\u0089²å\u0090\u0088")]
		private float utpGaugeMaxRate;

		[SerializeField]
		[Tooltip("å\u009bºæ\u009c\u0089å¤\u0089èº«ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®é\u0080\u009aå\u00b8\u00b8æ\u0099\u0082ã\u0082«ã\u0083©ã\u0083¼")]
		private Color32 utpGaugeDefaultColor;

		[SerializeField]
		[Tooltip("å\u009bºæ\u009c\u0089å¤\u0089èº«ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®æ\u009c\u0080å¤§æ\u0099\u0082ã\u0082«ã\u0083©ã\u0083¼")]
		private Color32 utpGaugeMaxColor;

		private VisibleUIObject invalidVisible;

		private VisibleUIObject noUseVisible;

		private CharacterBase _lastOwner;

		private RectTransform rootRt;

		private bool[] lastUtpGaugeValue;

		private bool validate;

		private bool lastValidate;

		private Tweener tweenerExpansion;

		private Tweener tweenerMove;

		private Action onMaxValue;

		private Vector2 moveInSidePos;

		private Vector2 moveOutSidePos;

		private float lastSec;

		private ClockworkShaderControl clockworkShaderControl;

		private const float tweenerExpansionEndValue = (float)Math.PI;

		private const float minTimerVolume = 0.01f;

		private bool isClonedMaterial;

		private bool isUpdate;

		private static bool _isLeftFlag;

		private float _lastUtpRate;

		private bool lastChangeTrans;

		private bool lastRecast;

		private RectTransform buttonEffectRt;

		private Tweener tweenerButtonEffectColor;

		private Tweener tweenerButtonEffectFlash;

		private Tweener tweenerButtonEffectScale;

		public static UniqueTransButton Create(GameObject parent, int index, ButtonDelegate click, bool isLeft)
		{
			return null;
		}

		public void Initialize(ButtonDelegate func)
		{
		}

		public void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		private void UpdateUI(bool isOwnerChange = false, bool isForce = false)
		{
		}

		private void SetImageInvalidActive(bool isActive)
		{
		}

		private bool IsImageInvalidActive()
		{
			return default(bool);
		}

		public void SetDPGaugeRate(float rate, bool isForce = false, bool isImmediate = false, bool isWithEffectAndSE = true)
		{
		}

		public void SetUTPGaugeValue(CharacterBase owner, int val, int maxVal, int requireVal, bool force = false)
		{
		}

		public void SetImage(Material mat)
		{
		}

		public void SetImage()
		{
		}

		public void VisibleButton(bool v)
		{
		}

		public void SetActionMaxValue(Action onMaxValue)
		{
		}

		public void Visible(bool b)
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public void Validate(bool b)
		{
		}

		private void CheckInactive(bool utpTrigger, bool modeChange, bool recast, bool noUse, bool isMaxNow, bool isOwnerChange)
		{
		}

		public void EnterUI()
		{
		}

		public void LeaveUI()
		{
		}

		public Vector2 GetButtonPosition()
		{
			return default(Vector2);
		}

		public Vector2 GetButtonSize()
		{
			return default(Vector2);
		}

		public Vector2 GetGaugePosition()
		{
			return default(Vector2);
		}

		public int GetSiblingIndex()
		{
			return default(int);
		}

		private void StartExpansion()
		{
		}

		private void OnUpdateExpansion(float value)
		{
		}

		private void OnUpdateButtonEffectColor(float value)
		{
		}

		private void OnCompleteButtonEffectColor()
		{
		}

		private void OnUpdateButtonEffectFlash(float value)
		{
		}

		private void OnUpdateButtonEffectScale(float value)
		{
		}

		private void StartButtonEffect()
		{
		}

		public static bool CanUse(PlayerCharacter player)
		{
			return default(bool);
		}

		public static bool CanUseAndIsInsideUI(PlayerCharacter player)
		{
			return default(bool);
		}
	}
}
