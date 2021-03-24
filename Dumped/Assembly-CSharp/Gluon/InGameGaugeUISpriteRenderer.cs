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
	public class InGameGaugeUISpriteRenderer : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private GameObject rootObj;
		[SerializeField]
		private SpriteRenderer bgImage;
		[SerializeField]
		private Transform lossMask;
		[SerializeField]
		private SpriteRenderer lossBar;
		[SerializeField]
		private Transform gainMask;
		[SerializeField]
		private SpriteRenderer gainBar;
		[SerializeField]
		private Transform baseMask;
		[SerializeField]
		private SpriteRenderer baseBar;
		[SerializeField]
		private SpriteRenderer blinkImage;
		[Header]
		[SerializeField]
		[Tooltip]
		private Sprite[] bgSprite;
		[SerializeField]
		private bool useGaugeSprite;
		[SerializeField]
		[Tooltip]
		private Sprite[] gaugeSprite;
		[Header]
		[SerializeField]
		[Tooltip]
		private Color baseColor;
		[SerializeField]
		[Tooltip]
		private Color maxColor;
		[SerializeField]
		[Tooltip]
		private Color dyingColor;
		[SerializeField]
		[Tooltip]
		private Color incColor;
		[SerializeField]
		[Tooltip]
		private Color decColor;
		[SerializeField]
		[Tooltip]
		private Color blinkColor0;
		[SerializeField]
		[Tooltip]
		private Color blinkColor1;
		[SerializeField]
		[Tooltip]
		private GaugeColorData[] gaugeColorList;
		[Header]
		[SerializeField]
		[Tooltip]
		private bool isMaskedSprite;
		[SerializeField]
		private float initialValue;
		[SerializeField]
		private float dyingRate;
		[SerializeField]
		[Tooltip]
		private float waitTime;
		[SerializeField]
		[Tooltip]
		private float diffMoveTime;
		[SerializeField]
		[Tooltip]
		private float blinkTime;
		[SerializeField]
		[Tooltip]
		private bool isNineSlice;
		[SerializeField]
		[Tooltip]
		private bool isNineSliceGraduationRound;
		[SerializeField]
		[Tooltip]
		private float nineSliceGraduationSize;
		private Transform lossBarRT;
		private Transform gainBarRT;
		private Transform baseBarRT;
		private GameObject blinkGameObj;
		private Vector3 gaugeSize;
		private float gaugeWidth;
		private float lossRemainTime;
		private float gainRemainTime;
		private float lastRate;
		private int maxNineSliceGraduationNum;
		private int gaugeColorIndex;
		private Color gaugeBaseColor;
		private Color gaugeMaxColor;
		private Color gaugeDyingColor;
		private Color gaugeIncColor;
		private Color gaugeDecColor;
		private Color gaugeBlinkColor0;
		private Color gaugeBlinkColor1;
		private Color changeColor;
		private Color baseOrgColor;
		private Color blinkOrgColor;
		private Tweener blinkTweener;
		[CompilerGenerated]
		private Action<float> _onComplete_k__BackingField;
		private VisibleUIObject rootVisible;
		[CompilerGenerated]
		private float _BlinkValue_k__BackingField;
		private bool bgImageEnabled;
		private bool lossBarEnabled;
		private bool gainBarEnabled;
		private bool baseBarEnabled;
		private bool blinkImageEnabled;
		private bool isChangeColor;
		private bool isDying;
	
		// Properties
		public Action<float> onComplete { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float BlinkValue { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float WaitTime { get; }
		public float DiffMoveTime { get; }
		public float BlinkTime { get; }
	
		// Nested types
		[Serializable]
		public class GaugeColorData
		{
			// Fields
			public Color baseColor;
			public Color maxColor;
			public Color dyingColor;
			public Color incColor;
			public Color decColor;
			public Color blinkColor0;
			public Color blinkColor1;
	
			// Constructors
			public GaugeColorData();
		}
	
		private enum BaseGaugeSpriteType
		{
			Normal = 0,
			Dying = 1,
			Max = 2
		}
	
		private enum BgSpriteType
		{
			Normal = 0,
			Dying = 1
		}
	
		// Constructors
		public InGameGaugeUISpriteRenderer();
	
		// Methods
		public void Initialize();
		public override void FastUpdate();
		public void SetGaugeColor(int gaugeColorIndex, bool immediate = false);
		public void SetValue(float value, bool immediate, bool ignoreValueApproximately = false);
		public float GetLastRate();
		public float GetCurrentRate();
		public bool IsDying();
		public bool IsMax();
		public void Visible(bool value);
		public bool IsVisible();
		public bool IsChanging();
		public void SetBlink(bool on, int index = 0);
		public bool IsBlink();
		private void SetBarSize(float value);
		private void SetLossMaskSize(float value);
		private void SetGainMaskSize(float value);
		private void SetBaseMaskSize(float value);
		private float GetBaseMaskRate();
		public float GetGainMaskRate();
		public float GetLossMaskRate();
		public float GetBaseMaskValue();
		public float GetGainMaskValue();
		private bool UpdateWaitTime(ref float t, ref float remainTime);
		private void SetBaseColor(Color color);
		private void SetBGSprite(BgSpriteType type);
		private void SetBaseGaugeSprite(BaseGaugeSpriteType type);
		private void StartBlink();
		private void StopBlink();
		private void OnUpdateBlink(float v);
		private void SetVisibleSpriteRenderer();
		public void SetDiffMoveTime(float time);
		public void SetChangeColor(Color color);
		public void SetChangeColorFlag(bool change, bool force = false);
		private void ApplyChangeColor(bool change);
		private Color GetGaugeBaseColor();
		public void SetGaugeBaseColor(Color color, bool force = false);
		private Color GetGaugeMaxColor();
		public void SetGaugeMaxColor(Color color, bool force = false);
		private Color GetGaugeDyingColor();
		private Color GetGaugeIncColor();
		private Color GetGaugeDecColor();
		private Color GetGaugeBlinkColor0();
		private Color GetGaugeBlinkColor1();
		public float GetGaugeMoveTime();
		public float GetGaugeWaitTime();
		public float GetGaugeDiffMoveTime();
	}
}
