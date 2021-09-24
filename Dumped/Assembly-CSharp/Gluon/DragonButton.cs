/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DragonButton : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
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
		[Header]
		[SerializeField]
		private float expansionTime;
		[SerializeField]
		private float moveTime;
		[SerializeField]
		private float gaugeOffsetX;
		[SerializeField]
		private Color32 inactiveTimeColor;
		[Range]
		[SerializeField]
		private float inactiveTimeContrast;
		[Range]
		[SerializeField]
		private float inactiveTimeSaturation;
		[Range]
		[SerializeField]
		private float inactiveTimeBrightness;
		[Range]
		[SerializeField]
		private float inactiveTimeBrightnessDeep;
		[SerializeField]
		private int flashCount;
		[SerializeField]
		private float flashTime;
		[Range]
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
		private const float tweenerExpansionEndValue = 3.1415927f;
		private const float minTimerVolume = 0.01f;
		private bool isClonedMaterial;
		private bool isUpdate;
		private static bool _isLeftFlag;
		private RectTransform buttonEffectRt;
		private Tweener tweenerButtonEffectColor;
		private Tweener tweenerButtonEffectFlash;
		private Tweener tweenerButtonEffectScale;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public Action<DragonButton> onClick;
			public DragonButton __4__this;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		// Constructors
		public DragonButton();
		static DragonButton();
	
		// Methods
		public static DragonButton Create(GameObject parent, int index, Action<DragonButton> onClick, bool isLeft);
		public void Initialize(Action<DragonButton> onClick);
		public void OnDestroy();
		public override void FastUpdate();
		public static bool CanUse(CharacterBase charaBase);
		public static bool CanUseAndIsInsideUI(CharacterBase charaBase);
		private void UpdateUI(bool isForce = false);
		public bool IsEnableTransformCondition();
		private void SetImageInvalidActive(bool isActive);
		private bool IsImageInvalidActive();
		public void SetGaugeRate(float rate, bool isForce = false, bool isImmediate = false, bool isWithEffectAndSE = true);
		public void SetImage(ElementalType elm, Material face);
		public void SetImage();
		public void VisibleButton(bool v);
		public void SetActionMaxValue(Action onMaxValue);
		public void Visible(bool b);
		public bool IsVisible();
		public void Validate(bool b);
		private void CheckInactive(bool trigger, bool recast, bool noUse, bool isMaxNow);
		public void EnterUI();
		public void LeaveUI();
		public Vector2 GetButtonPosition();
		public Vector2 GetButtonSize();
		public Vector2 GetGaugePosition();
		public int GetSiblingIndex();
		private void StartExpansion();
		private void OnUpdateExpansion(float value);
		private void OnUpdateButtonEffectColor(float value);
		private void OnCompleteButtonEffectColor();
		private void OnUpdateButtonEffectFlash(float value);
		private void OnUpdateButtonEffectScale(float value);
		private void StartButtonEffect();
		[CompilerGenerated]
		private void _EnterUI_b__62_0(float t);
		[CompilerGenerated]
		private void _EnterUI_b__62_1();
		[CompilerGenerated]
		private void _LeaveUI_b__63_0(float t);
		[CompilerGenerated]
		private void _LeaveUI_b__63_1();
	}
}
