﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickAddGaugeInputUI : CharaGimmickBaseInputUI
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _fingerRt;
		[SerializeField]
		private RectTransform _fingerBgRt;
		[SerializeField]
		private RectTransform _gaugeRt;
		[SerializeField]
		private RectTransform _gaugeBlinkAnimRt;
		[SerializeField]
		private RectTransform _stepRootRt;
		[SerializeField]
		private SpriteRenderer _gaugeBlinkAnimImage;
		[SerializeField]
		private InGameGaugeUISpriteRenderer _gauge;
		[SerializeField]
		private CharaGimmickAddGaugeInputStepUI _baseStepUI;
		[Header]
		[SerializeField]
		private float _showAnimTime;
		[SerializeField]
		private float _hideAnimTime;
		[SerializeField]
		private Vector2 _gaugeAnimScale;
		[SerializeField]
		private Vector2 _gaugeAnimScale2;
		[SerializeField]
		private float _gaugeAnimTime;
		[SerializeField]
		private float _gaugeIntervalTime;
		[SerializeField]
		private float _gaugeAnimTime2;
		[SerializeField]
		[Tooltip]
		private Color[] _gaugeColor;
		private VisibleUIObject _visibleRoot;
		private Sequence _seqShow;
		private Sequence _seqHide;
		private Sequence _seqFinger;
		private Sequence _seqGauge;
		private CharacterBase _owner;
		private int _lastCount;
		private int _maxCount;
		private float _lastGaugeRate;
		private float _originGaugeBlinkAnimRootPosX;
		private List<StepData> _stepDataList;
		private List<CharaGimmickAddGaugeInputStepUI> _stepUIList;
		private bool _show;
	
		// Nested types
		private class StepData
		{
			// Fields
			[CompilerGenerated]
			private int _ShiftInputCount_k__BackingField;
			[CompilerGenerated]
			private int _PrevShiftInputCount_k__BackingField;
			[CompilerGenerated]
			private int _MaxInputCount_k__BackingField;
			[CompilerGenerated]
			private float _ShiftInputRate_k__BackingField;
			[CompilerGenerated]
			private float _DiffInputRate_k__BackingField;
	
			// Properties
			public int ShiftInputCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int PrevShiftInputCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int MaxInputCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float ShiftInputRate { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float DiffInputRate { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public StepData();
			public StepData(int maxCount);
	
			// Methods
			public void Reset();
			public void SetShiftInputCount(int prevShiftInputCount, int shiftInputCount);
			public void SetMaxInputCount(int maxInputCount);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<StepData> __9__36_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _ReserveItem_b__36_0(StepData x, StepData y);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0
		{
			// Fields
			public CharaGimmickAddGaugeInputUI __4__this;
			public bool playHideAnim;
	
			// Constructors
			public __c__DisplayClass47_0();
	
			// Methods
			internal void _PlayGaugeBgAnim_b__0();
		}
	
		// Constructors
		public CharaGimmickAddGaugeInputUI();
	
		// Methods
		public static CharaGimmickAddGaugeInputUI Create(GameObject parent, CharacterBase owner, int siblingIndex = -1);
		private void Initialize(CharacterBase owner);
		private void OnDestroy();
		public override void FastUpdate();
		public override void Show(int num);
		public override void Hide(bool anim = true);
		public override void ReserveItem(int actionId);
		private bool GetActionShiftList(ref List<StepData> list, int actionId, ref int maxInputNum);
		private void EnableItem(ref List<StepData> list);
		private void UpdateGaugeStatus(bool force = false);
		private void UpdateGaugeBlinkAnim();
		private void UpdateGaugeStatus(float curGaugevalue, float nextGaugeValue);
		public override void SetCount(int num, bool force = false, bool immediate = false);
		public void OnCompleteMaximum(float value);
		private void PlayShowAnim();
		private void PlayHideAnim();
		private void PlayFingerAnim();
		private void PlayGaugeBgAnim(bool playHideAnim = false);
		private void SetAlpha(ref SpriteRenderer sprite, float alpha);
		private void ClearAnim();
		public override int GetInputType();
		public override bool IsVisible();
		[CompilerGenerated]
		private void _PlayShowAnim_b__44_0();
		[CompilerGenerated]
		private void _PlayHideAnim_b__45_0();
		[CompilerGenerated]
		private void _PlayFingerAnim_b__46_0();
	}
}
