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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ComboUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Transform digitTransform;
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
		private const int numDigit = 3;
		private const int maxComboCount = 999;
		private Tweener _tweenerFadeIn;
		private Tweener _tweenerFadeOut;
		private Sequence _sequenceFade;
		private Sequence _sequenceDigitScale;
		private Sequence _sequenceDigitColor;
		private Sequence _sequenceAdmirationScale;
		private FadeState fadeState;
		private int[] valueArray;
		private bool[] bArray;
		private RectTransform[] trsDigit;
		private VisibleCtrl rootVisible;
		private VisibleCtrl admirationVisible;
		private VisibleCtrl[] digitVisible;
		private VisibleCtrl[] hitVisible;
		private Vector3[] numbersInitLocalPosition;
		private RectTransform rootRt;
		private Admiration lastAdmiration;
		private const float minTime = 0.06666667f;
		private float currentTime;
		private int currentCombo;
		private int targetCombo;
		private Dictionary<Sequence, bool> sequencePauseDict;
		private static int numAdmiration;
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
		private static int GetNumAdmiration();
		public void Initialize();
		private void OnDestroy();
		public void PauseCombo(bool isPause);
		private void SetPauseSequence(Sequence seq, bool isPause);
		private void GetComboData(int combo, out ComboData data, out Admiration type);
		private void DisplayCombo(int comboVal);
		public void Display(int comboVal);
		private void Update();
		private float StopFade();
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
		private void _Initialize_b__50_0();
		[CompilerGenerated]
		private void _Initialize_b__50_1();
		[CompilerGenerated]
		private void _Initialize_b__50_2(float v);
		[CompilerGenerated]
		private void _Initialize_b__50_3();
		[CompilerGenerated]
		private void _Initialize_b__50_4(float v);
		[CompilerGenerated]
		private void _Initialize_b__50_5();
		[CompilerGenerated]
		private void _Initialize_b__50_6(float v);
		[CompilerGenerated]
		private void _Initialize_b__50_7();
		[CompilerGenerated]
		private void _Initialize_b__50_8(float v);
		[CompilerGenerated]
		private void _Initialize_b__50_9();
		[CompilerGenerated]
		private void _Initialize_b__50_10(float v);
		[CompilerGenerated]
		private void _Initialize_b__50_11();
		[CompilerGenerated]
		private void _Initialize_b__50_12(float v);
		[CompilerGenerated]
		private void _Initialize_b__50_13();
	}
}
