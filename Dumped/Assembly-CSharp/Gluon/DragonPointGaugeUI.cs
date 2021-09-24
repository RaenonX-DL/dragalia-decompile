/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DragonPointGaugeUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private InGameButtonGaugeUI _buttonGauge1;
		[SerializeField]
		private InGameButtonGaugeUI _buttonGauge2;
		[SerializeField]
		protected SpriteRenderer _gaugeEffect;
		[SerializeField]
		protected SpriteRenderer _gaugeLineEffect;
		[Header]
		[SerializeField]
		[Tooltip]
		protected GaugeParam[] _gaugeParams;
		protected DispType _dispType;
		protected RectTransform _gaugeEffectRt;
		protected Tweener _twGaugeEffect;
		protected Tweener _twGaugeLineEffect;
		protected int _targetGaugeLineEffect;
		protected float _rate;
		protected float _gaugeValue1;
		protected float _gaugeValue2;
	
		// Nested types
		[Serializable]
		protected class GaugeParam
		{
			// Fields
			[SerializeField]
			protected Sprite[] _gaugeSprites;
			[SerializeField]
			protected Color _gaugeColor;
	
			// Properties
			public Sprite[] gaugeSprites { get; }
			public Color gaugeColor { get; }
	
			// Constructors
			public GaugeParam();
		}
	
		public enum DispType
		{
			Valid_01 = 0,
			Valid_02 = 1,
			Invalid = 2
		}
	
		// Constructors
		public DragonPointGaugeUI();
	
		// Methods
		public void Initialize(DispType type);
		public void OnDestroy();
		public void UpdateUI();
		public void SetDispType(DispType type, bool isForce = false);
		public bool SetGaugeRate(float rate, bool isForce = false, bool isImmediate = false, bool isWithEffectAndSE = true);
		public float GetGaugeRate1();
		public float GetGaugeRate2();
		public void StartGaugeEffect();
		protected void OnUpdateEffect(float value);
		[CompilerGenerated]
		private void _Initialize_b__15_0(float t);
	}
}
