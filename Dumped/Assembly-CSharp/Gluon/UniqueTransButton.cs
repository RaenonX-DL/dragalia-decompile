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
	public class UniqueTransButton : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Button button;
		[SerializeField]
		private RectTransform invalidRt;
		[SerializeField]
		private InGameButtonGaugeUI buttonGauge1;
		[SerializeField]
		private InGameButtonGaugeUI buttonGauge2;
		[SerializeField]
		private RectTransform iconRt;
		[SerializeField]
		private SpriteRenderer icon;
		[SerializeField]
		private RectTransform offsetRt;
		[SerializeField]
		private RectTransform buttonFrameEffectRt;
		[SerializeField]
		private SpriteRenderer buttonFrameEffect;
		[SerializeField]
		private RectTransform noUseRt;
		[SerializeField]
		private SpriteRenderer noUseImage;
		[SerializeField]
		private CircleGauge _utpGaugeCtrl;
		[SerializeField]
		private SpriteRenderer _utpGaugeImage;
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
		[SerializeField]
		[Tooltip]
		private float utpGaugeRequireRate;
		[SerializeField]
		[Tooltip]
		private float utpGaugeMaxRate;
		[SerializeField]
		[Tooltip]
		private Color32 utpGaugeDefaultColor;
		[SerializeField]
		[Tooltip]
		private Color32 utpGaugeMaxColor;
		private VisibleUIObject invalidVisible;
		private VisibleUIObject noUseVisible;
		private CharacterBase _lastOwner;
		private RectTransform ownTransform;
		private bool[] lastUtpGaugeValue;
		private bool validate;
		private bool lastValidate;
		private Tweener tweenerExpansion;
		private Action onMaxValue;
		private MoveControlUI moveControl;
		private Vector2 inPos;
		private Vector2 outPos;
		private float lastSec;
		private ClockworkShaderControl clockworkShaderControl;
		private const float tweenerExpansionEndValue = 3.1415927f;
		private const float minTimerVolume = 0.01f;
		private bool isClonedMaterial;
		private bool isUpdate;
		private static bool _isLeftFlag;
		private float _lastUtpRate;
		private bool lastChangeTrans;
		private bool lastRecast;
		private float _lastDpGaugeValue;
		private RectTransform buttonEffectRt;
		private Tweener tweenerButtonEffectColor;
		private Tweener tweenerButtonEffectFlash;
		private Tweener tweenerButtonEffectScale;
	
		// Nested types
		public delegate void ButtonDelegate(UniqueTransButton sender);
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0
		{
			// Fields
			public ButtonDelegate func;
			public UniqueTransButton __4__this;
	
			// Constructors
			public __c__DisplayClass57_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		// Constructors
		public UniqueTransButton();
		static UniqueTransButton();
	
		// Methods
		public static UniqueTransButton Create(GameObject parent, int index, ButtonDelegate click, bool isLeft);
		public void Initialize(ButtonDelegate func);
		public void OnDestroy();
		public override void FastUpdate();
		private void UpdateUI(bool isOwnerChange = false, bool isForce = false);
		private void SetImageInvalidActive(bool isActive);
		private bool IsImageInvalidActive();
		public void SetDPGaugeValue(float value, bool force = false, bool immediate = false);
		public void SetUTPGaugeValue(CharacterBase owner, int val, int maxVal, int requireVal, bool force = false);
		public void SetImage(Material mat);
		public void SetImage();
		public void VisibleButton(bool v);
		public void SetActionMaxValue(Action onMaxValue);
		public void Visible(bool b);
		public bool IsVisible();
		public void Validate(bool b);
		private void CheckInactive(bool utpTrigger, bool modeChange, bool recast, bool noUse, bool isMaxNow, bool isOwnerChange);
		public void EnterUI();
		public void LeaveUI();
		private void OnMoveInactive(MoveControlUI sender);
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
		public static bool CanUse(PlayerCharacter player);
		public static bool CanUseAndIsInsideUI(PlayerCharacter player);
	}
}
