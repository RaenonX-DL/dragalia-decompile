/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickActiveGaugeUI : CharaGimmickBaseGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform _rootRt;
		[SerializeField]
		protected RectTransform[] _iconAnimRt;
		[SerializeField]
		protected RectTransform[] _gaugeAnimRt;
		[SerializeField]
		protected InGameGaugeUISpriteRenderer[] _gauge;
		[SerializeField]
		protected SpriteRenderer[] _iconAnimImage;
		[SerializeField]
		protected SpriteRenderer[] _gaugeAnimImage;
		[SerializeField]
		protected SpriteRenderer[] _gaugeAnimImage2;
		[Header]
		[SerializeField]
		protected Vector2 _tweenIconSize;
		[SerializeField]
		protected float _tweenIconTime;
		[SerializeField]
		protected Vector2 _tweenGaugeSize;
		[SerializeField]
		protected float _tweenGaugeTime;
		protected VisibleUIObject _visible;
		protected Sequence[] _seqIconAnim;
		protected Sequence[] _seqGaugeAnim;
		protected float[] _lastGaugeValue;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public CharaGimmickActiveGaugeUI __4__this;
			public int idx;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _SetGaugeValue_b__0(float v);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public CharaGimmickActiveGaugeUI __4__this;
			public int idx;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _PlayAnimIcon_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public CharaGimmickActiveGaugeUI __4__this;
			public int idx;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _PlayAnimGauge_b__0();
		}
	
		// Constructors
		public CharaGimmickActiveGaugeUI();
	
		// Methods
		public static CharaGimmickActiveGaugeUI Create(CharacterBase chara, GameObject parent, int siblingIndex = -1);
		protected virtual void Initialize(CharacterBase chara);
		protected void OnDestroy();
		public override void Show();
		public override void Hide();
		public override bool IsVisible();
		public override void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false);
		protected void PlayAnimIcon(int idx);
		protected void PlayAnimGauge(int idx);
		protected void FlashAnim();
		protected void SetAlpha(ref SpriteRenderer sprite, float alpha);
		public override int GetGaugeType();
		public override float GetGaugeMoveTime();
	}
}
