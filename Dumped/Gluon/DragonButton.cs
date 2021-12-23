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
		protected Button button;

		[SerializeField]
		protected RectTransform iconRt;

		[SerializeField]
		protected RectTransform bodyRt;

		[SerializeField]
		protected SpriteRenderer iconImage;

		[SerializeField]
		protected SpriteRenderer buttonEffectImage;

		[SerializeField]
		protected SpriteRenderer noUseImage;

		[SerializeField]
		protected ElementIconUISpriteRenderer elementIconUI;

		[SerializeField]
		protected DragonPointGaugeUI dpGaugeUI;

		[SerializeField]
		[Header("parameter")]
		protected float expansionTime;

		[SerializeField]
		protected float moveTime;

		[SerializeField]
		protected float gaugeOffsetX;

		[SerializeField]
		protected Color32 inactiveTimeColor;

		[SerializeField]
		protected float inactiveTimeContrast;

		[SerializeField]
		protected float inactiveTimeSaturation;

		[SerializeField]
		protected float inactiveTimeBrightness;

		[SerializeField]
		protected float inactiveTimeBrightnessDeep;

		[SerializeField]
		protected int flashCount;

		[SerializeField]
		protected float flashTime;

		[SerializeField]
		protected float maxFlashPower;

		protected RectTransform rootRt;

		protected RectTransform buttonEffectRt;

		protected VisibleUIObject noUseVisible;

		protected bool[] lastIsMax;

		protected bool validate;

		protected bool lastValidate;

		protected Tweener twExpansion;

		private Tweener twMove;

		protected Action onMaxValue;

		protected Vector2 moveInSidePos;

		protected Vector2 moveOutSidePos;

		protected float lastRecastSec;

		protected ClockworkShaderControl clockworkShaderCtrl;

		protected bool isClonedMaterial;

		protected bool isUpdate;

		protected bool isLeftFlag;

		protected Tweener twButtonEffect;

		protected Tweener twButtonEffectFlash;

		protected const float tweenerExpansionEndValue = (float)Math.PI;

		protected const float clockworkMinTimerVolume = 0.01f;

		public static DragonButton Create(GameObject parent, int index, Action<DragonButton> onClick, bool isLeft)
		{
			return null;
		}

		protected void Initialize(Action<DragonButton> onClick, bool isLeft)
		{
		}

		public void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		protected virtual void UpdateUI(bool isForce = false)
		{
		}

		protected bool IsEnableTransformCondition()
		{
			return default(bool);
		}

		private void CheckInactive(bool trigger, bool recast, bool noUse, bool isMaxNow)
		{
		}

		protected void SetInvalidActive(bool isActive)
		{
		}

		protected void SetEnableButton(bool b, bool isForce = false)
		{
		}

		public void SetGaugeRate(float rate, bool isForce = false, bool isImmediate = false, bool isWithEffectAndSE = true)
		{
		}

		public void SetIcon(ElementalType elementType, Material material)
		{
		}

		protected void SetIcon(Material material)
		{
		}

		public void SetIcon()
		{
		}

		public void Visible(bool b)
		{
		}

		public bool IsVisible()
		{
			return default(bool);
		}

		public void VisibleButton(bool v)
		{
		}

		public void SetActionMaxValue(Action onMaxValue)
		{
		}

		public void Validate(bool b)
		{
		}

		public void EnterUI()
		{
		}

		public void LeaveUI()
		{
		}

		protected void OnMoveInactive(MoveControlUI sender)
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

		protected void StartExpansion()
		{
		}

		protected void OnUpdateExpansion(float value)
		{
		}

		protected void OnCompleteButtonEffectColor()
		{
		}

		protected void OnUpdateButtonEffectFlash(float value)
		{
		}

		protected void StartButtonEffect()
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
	}
}
