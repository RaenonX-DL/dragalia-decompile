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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		private InGameButtonGaugeUI buttonGauge1;
		[SerializeField]
		private InGameButtonGaugeUI buttonGauge2;
		[SerializeField]
		private InGameButtonGaugeUI buttonGaugeBR;
		[SerializeField]
		private ElementIconUISpriteRenderer element;
		[SerializeField]
		private RectTransform faceRt;
		[SerializeField]
		private SpriteRenderer face;
		[SerializeField]
		private RectTransform bodyRt;
		[SerializeField]
		private SpriteRenderer effect;
		[SerializeField]
		private SpriteRenderer gaugeEffect;
		[SerializeField]
		private SpriteRenderer gaugeEffectBR;
		[SerializeField]
		private SpriteRenderer buttonEffect;
		[SerializeField]
		private SpriteRenderer noUseImage;
		[Header]
		[SerializeField]
		private float expansionTime;
		[SerializeField]
		private float moveTime;
		[SerializeField]
		private float gaugeOffsetX;
		[SerializeField]
		private Color32 inactiveColor;
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
		private RectTransform ownTransform;
		private bool[] lastGaugeValue;
		private bool validate;
		private bool lastValidate;
		private Tweener tweenerExpansion;
		private Action onMaxValue;
		private MoveControlUI moveControl;
		private Vector2 inPos;
		private Vector2 outPos;
		private float lastSec;
		private static readonly Color noUseHideColor;
		private ClockworkShaderControl clockworkShaderControl;
		private const float tweenerExpansionEndValue = 3.1415927f;
		private const float minTimerVolume = 0.01f;
		private bool isClonedMaterial;
		private bool isUpdate;
		private static bool _isLeftFlag;
		private Tweener tweenerEffect;
		private int targetEffect;
		private RectTransform gaugeEffectRt;
		private Tweener tweenerGaugeEffectColor;
		private Tweener tweenerGaugeEffectScale;
		private float lastGauge2Value;
		private float _lastDpGaugeValue;
		private RectTransform buttonEffectRt;
		private Tweener tweenerButtonEffectColor;
		private Tweener tweenerButtonEffectFlash;
		private Tweener tweenerButtonEffectScale;
	
		// Nested types
		public delegate void ButtonDelegate(DragonButton sender);
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public ButtonDelegate func;
			public DragonButton __4__this;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		// Constructors
		public DragonButton();
		static DragonButton();
	
		// Methods
		public static DragonButton Create(GameObject parent, int index, ButtonDelegate click, bool isLeft);
		public void Initialize(ButtonDelegate func);
		public void OnDestroy();
		public override void FastUpdate();
		public static bool CanUse(CharacterBase charaBase);
		private void UpdateUI(bool isForce = false);
		private void SetImageInvalidActive(bool isActive);
		private bool IsImageInvalidActive();
		public void SetGaugeValue(float value, bool force = false, bool immediate = false, bool withEffectAndSE = true);
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
		private void OnMoveInactive(MoveControlUI sender);
		public Vector2 GetButtonPosition();
		public Vector2 GetButtonSize();
		public Vector2 GetGaugePosition();
		public int GetSiblingIndex();
		private void StartExpansion();
		private void OnUpdateExpansion(float value);
		private void OnUpdateEffect(float value);
		private void OnUpdateGaugeEffectColor(float value);
		private void OnUpdateGaugeEffectScale(float value);
		private void OnUpdateButtonEffectColor(float value);
		private void OnCompleteButtonEffectColor();
		private void OnUpdateButtonEffectFlash(float value);
		private void OnUpdateButtonEffectScale(float value);
		private void StartGaugeEffect();
		private void StartButtonEffect();
		private bool IsSingleGauge();
	}
}
