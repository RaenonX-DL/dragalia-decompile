using System;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DragonButton : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private Button button;

		[SerializeField]
		private RectTransform imageInvalidRt;

		[SerializeField]
		private RectTransform faceRt;

		[SerializeField]
		private RectTransform bodyRt;

		[SerializeField]
		private SpriteRenderer face;

		[SerializeField]
		private SpriteRenderer buttonEffect;

		[SerializeField]
		private SpriteRenderer noUseImage;

		[SerializeField]
		private ElementIconUISpriteRenderer element;

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

		private VisibleUIObject _noUseVisible;

		private VisibleUIObject _invalidVisible;

		private RectTransform rootRt;

		private bool[] lastGaugeMax;

		private bool validate;

		private bool lastValidate;

		private Tweener tweenerExpansion;

		private Tweener tweenerMove;

		private Action onMaxValue;

		private Vector3 moveInSidePos;

		private Vector3 moveOutSidePos;

		private float lastSec;

		private static readonly Color noUseHideColor;

		private ClockworkShaderControl clockworkShaderControl;

		private const float tweenerExpansionEndValue = (float)Math.PI;

		private const float minTimerVolume = 0.01f;

		private bool isClonedMaterial;

		private bool isUpdate;

		private static bool _isLeftFlag;

		private RectTransform buttonEffectRt;

		private Tweener tweenerButtonEffectColor;

		private Tweener tweenerButtonEffectFlash;

		private Tweener tweenerButtonEffectScale;

		public static DragonButton Create(GameObject parent, int index, Action<DragonButton> onClick, bool isLeft)
		{
			return null;
		}

		public void Initialize(Action<DragonButton> onClick)
		{
		}

		public void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public static bool CanUse(CharacterBase charaBase)
		{
			return default(bool);
		}

		public static bool CanUseAndIsInsideUI(CharacterBase charaBase)
		{
			return default(bool);
		}

		private void UpdateUI(bool isForce = false)
		{
		}

		public bool IsEnableTransformCondition()
		{
			return default(bool);
		}

		private void SetImageInvalidActive(bool isActive)
		{
		}

		private bool IsImageInvalidActive()
		{
			return default(bool);
		}

		public void SetGaugeRate(float rate, bool isForce = false, bool isImmediate = false, bool isWithEffectAndSE = true)
		{
		}

		public void SetImage(ElementalType elm, Material face)
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

		private void CheckInactive(bool trigger, bool recast, bool noUse, bool isMaxNow)
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
	}
}
