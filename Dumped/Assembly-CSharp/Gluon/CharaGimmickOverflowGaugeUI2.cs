/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickOverflowGaugeUI2 : CharaGimmickBaseGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform _rootRt;
		[SerializeField]
		protected RectTransform _iconAnimRt;
		[SerializeField]
		protected RectTransform _gaugeBgAnimRt;
		[SerializeField]
		protected RectTransform _stockAnimRt;
		[SerializeField]
		protected InGameGaugeUISpriteRenderer _gauge;
		[SerializeField]
		protected SpriteRenderer _stockImage;
		[SerializeField]
		protected SpriteRenderer _baseGaugeImage;
		[SerializeField]
		protected SpriteRenderer _gaugeBgAnimImage;
		[SerializeField]
		protected SpriteRenderer _stockAnimImage;
		[SerializeField]
		protected SpriteRenderer _iconImage;
		[SerializeField]
		protected SpriteRenderer _iconAnimImage;
		[Header]
		[SerializeField]
		protected Vector2 _countAnimScale;
		[SerializeField]
		protected float _countAnimTime;
		[SerializeField]
		protected Vector2 _gaugeAnimScale;
		[SerializeField]
		protected float _gaugeAnimTime;
		[SerializeField]
		protected Color _stockNumEmptyColor;
		[SerializeField]
		protected Color _stockNumColor;
		[SerializeField]
		protected Color _stockNumMaxColor;
		[SerializeField]
		protected Color _baseGaugeEmptyColor;
		[SerializeField]
		protected Color _baseGaugeColor;
		[SerializeField]
		protected Color _baseGaugeMaxColor;
		[Header]
		[SerializeField]
		protected Sprite[] _numberSpriteList;
		protected VisibleUIObject _visible;
		protected List<float> _conditionValueList;
		protected Sequence _seqIconAnim;
		protected Sequence _seqGaugeAnim;
		protected Sequence _seqStockAnim;
		protected int _lastValue;
		protected float _gaugeMoveTime;
		protected List<GaugeData> _activeGaugeDataList;
		protected List<GaugeData> _standbyGaugeDataList;
		protected readonly int GaugeDataReserveNum;
	
		// Nested types
		protected class GaugeData
		{
			// Fields
			public float rate;
			public int stockNum;
			public bool isPlayMaxAnim;
			public bool isImmediate;
	
			// Constructors
			public GaugeData();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public CharaGimmickOverflowGaugeUI2 __4__this;
			public GaugeData data;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _ApplyGaugeDataList_b__0(float x);
		}
	
		// Constructors
		public CharaGimmickOverflowGaugeUI2();
	
		// Methods
		public static CharaGimmickOverflowGaugeUI2 Create(CharacterBase chara, GameObject parent, int siblingIndex = -1);
		protected virtual void Initialize(CharacterBase chara);
		private void OnDestroy();
		public override void FastUpdate();
		public override void Show();
		public override void Hide();
		public override bool IsVisible();
		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false);
		private void SetGaugeDataList(int value, int maxValue);
		private void SetGaugeDataListAdd(int value, int maxValue);
		private void SetGaugeDataListSub(int value, int maxValue);
		private void ApplyGaugeDataList();
		private void OnCompleteGaugeMoveAnim(GaugeData data);
		private void SetStockNum(int stockNum);
		private void SetGaugeColor(int stockNum);
		private GaugeData GetActiveGaugeData();
		private void AddStandbyGaugeDataList(GaugeData data);
		private int GetStockMaxNum();
		public override void SetAbilityData(ref List<AbilityDataElement> list);
		protected void PlayIconAnim();
		protected void PlayGaugeBgAnim();
		protected void PlayStockAnim();
		protected void SetAlpha(ref SpriteRenderer sprite, float alpha);
		private void SetIconImage(Material mat);
		public override int GetGaugeType();
		public override float GetGaugeMoveTime();
		[CompilerGenerated]
		private void _PlayIconAnim_b__52_0();
		[CompilerGenerated]
		private void _PlayGaugeBgAnim_b__53_0();
		[CompilerGenerated]
		private void _PlayStockAnim_b__54_0();
	}
}
