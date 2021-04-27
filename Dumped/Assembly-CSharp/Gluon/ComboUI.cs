/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ComboUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Transform digitTransform;
		[SerializeField]
		private RectTransform timerGaugeRt;
		[SerializeField]
		private SpriteRenderer[] imageDigit;
		[SerializeField]
		private SpriteRenderer[] imageHit;
		[SerializeField]
		private SpriteRenderer imageAdmiration;
		[SerializeField]
		private SpriteRenderer imageBg;
		[Header]
		[SerializeField]
		private Material comboMaterial;
		[SerializeField]
		private Sprite[] numbers;
		[Header]
		[SerializeField]
		private ComboData[] _comboData;
		[SerializeField]
		private Color _comboAddColor;
		[SerializeField]
		private AnimationCurve _comboColorCurve;
		[SerializeField]
		private Vector2 fadeTime;
		[SerializeField]
		private Vector2 scaleTime;
		[SerializeField]
		private Vector2 scaleAnim;
		[SerializeField]
		private Vector2 admirationScaleTime;
		[SerializeField]
		private Vector2 admirationScaleAnim;
		[SerializeField]
		private Vector3 under100Offset;
		[SerializeField]
		private Vector3[] offset001;
		[SerializeField]
		private Vector3[] offset010;
		[SerializeField]
		private Vector3[] offset100;
		[SerializeField]
		[Tooltip]
		private float delayDigitAnimTime;
		private CharacterBase _owner;
		private Tweener _twFadeIn;
		private Tweener _twFadeOut;
		private Sequence _seqDigitScale;
		private Sequence _seqDigitColor;
		private Sequence _seqAdmirationScale;
		private RectTransform _rootRt;
		private RectTransform[] _digitRtArray;
		private VisibleUIObject _rootVisible;
		private VisibleCtrl _bgVisible;
		private VisibleCtrl _admirationVisible;
		private VisibleCtrl[] _digitVisibleArray;
		private VisibleCtrl[] _hitTextVisibleArray;
		private Vector3[] _initDigitPosArray;
		private FadeState _fadeState;
		private Admiration _lastAdmiration;
		private int[] _digitValueArray;
		private bool[] _digitVisibleStateArray;
		private float _currentCountupTime;
		private float _countupTime;
		private float _initTimerGaugeScaleX;
		private float _initChainTime;
		private float _chainTime;
		private float _delayDigitAnimDuration;
		private int _countupNum;
		private int _currentCombo;
		private int _targetCombo;
		private Dictionary<Tweener, bool> _twPauseDict;
		private Dictionary<Sequence, bool> _seqPauseDict;
		private const int NumDigit = 3;
		private const int MaxComboCount = 999;
		private const float DefaultCountupTime = 0.06666667f;
		private const float MinCountupTime = 0.033333335f;
		private static readonly Vector3 DefaultScale;
	
		// Nested types
		private enum Admiration
		{
			Normal = 0,
			Cool = 1,
			Great = 2,
			Excellent = 3,
			Amazing = 4,
			Fantastic = 5
		}
	
		private enum FadeState
		{
			Idle = -1,
			FadeIn = 0,
			Stay = 1,
			FadeOut = 2
		}
	
		[Serializable]
		private class ComboData
		{
			// Fields
			public Sprite admirationSprite;
			[Range]
			public int comboCount;
			public HSVParameter hsvParameter;
	
			// Constructors
			public ComboData();
	
			// Methods
			public void Update();
		}
	
		private class VisibleCtrl
		{
			// Fields
			private bool visible;
			private SpriteRenderer renderer;
			private VisibleCtrl parent;
	
			// Constructors
			public VisibleCtrl();
	
			// Methods
			public void Initialize(SpriteRenderer r, VisibleCtrl p);
			public void Visible(bool b);
			public bool IsVisible();
			public void UpdateVisibility();
		}
	
		// Constructors
		public ComboUI();
		static ComboUI();
	
		// Methods
		public void Initialize();
		private void OnDestroy();
		public void PauseCombo(bool isPause);
		private void SetPauseSequence(Sequence seq, bool isPause);
		private void SetPauseTweener(Tweener tw, bool isPause);
		private void GetComboData(int combo, out ComboData data, out Admiration type);
		private void DisplayCombo(int comboVal, bool isPlayDigitAnim, bool isUpdateChainTime);
		public void Display(CharacterBase chara, int comboVal);
		private bool IsEnableChara(CharacterBase chara);
		private void Update();
		private float GetChainTime();
		private float GetFadeOutElapsed();
		private void ClearValue();
		private void OnUpdateFade(float value);
		private void OnCompleteFade2();
		private void OnUpdateDigitScale(float value);
		private void OnCompleteDigitScale();
		private void OnUpdateDigitColor(float value);
		private void OnCompleteDigitColor();
		private void OnUpdateAdmiration(float value);
		private void OnCompleteAdmiration();
		[CompilerGenerated]
		private void _Initialize_b__59_0();
		[CompilerGenerated]
		private void _Initialize_b__59_1(float v);
		[CompilerGenerated]
		private void _Initialize_b__59_2();
		[CompilerGenerated]
		private void _Initialize_b__59_3(float v);
		[CompilerGenerated]
		private void _Initialize_b__59_4();
		[CompilerGenerated]
		private void _Initialize_b__59_5(float v);
		[CompilerGenerated]
		private void _Initialize_b__59_6();
		[CompilerGenerated]
		private void _Initialize_b__59_7(float v);
		[CompilerGenerated]
		private void _Initialize_b__59_8();
		[CompilerGenerated]
		private void _Initialize_b__59_9(float v);
		[CompilerGenerated]
		private void _Initialize_b__59_10();
		[CompilerGenerated]
		private void _Initialize_b__59_11(float v);
		[CompilerGenerated]
		private void _Initialize_b__59_12();
	}
}
