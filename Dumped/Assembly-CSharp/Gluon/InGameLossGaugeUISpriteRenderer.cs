/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameLossGaugeUISpriteRenderer : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private GameObject rootObj;
		[SerializeField]
		private SpriteRenderer bgImage;
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
		private Color baseColor;
		[SerializeField]
		private Color maxColor;
		[SerializeField]
		private Color dyingColor;
		[SerializeField]
		private Color incColor;
		[SerializeField]
		private Color blinkColor0;
		[SerializeField]
		private Color blinkColor1;
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
		private Transform gainBarRT;
		private Transform baseBarRT;
		private GameObject blinkGameObj;
		private Vector3 gaugeSize;
		private float gaugeWidth;
		private float gainRemainTime;
		private float lastValue;
		private Color srcColor;
		private Color blinkColor;
		private Tweener blinkTweener;
		private VisibleUIObject rootVisible;
		private bool bgImageEnabled;
		private bool gainBarEnabled;
		private bool baseBarEnabled;
		private bool blinkImageEnabled;
	
		// Constructors
		public InGameLossGaugeUISpriteRenderer();
	
		// Methods
		public void Initialize();
		public override void FastUpdate();
		public void SetValue(float value, bool immediate);
		public float GetValue();
		public bool IsDying();
		public bool IsMax();
		public void Visible(bool value);
		public bool IsVisible();
		public bool IsChanging();
		public void SetBlink(bool on, int index = 0);
		public bool IsBlink();
		private void SetBarSize(float value);
		private void SetBaseMaskSize(float value);
		private float GetBaseMaskValue();
		private bool WaitTime(ref float t, ref float remainTime);
		private void SetBaseColor(Color color);
		private void SetBGSprite(int idx);
		private void SetBaseSprite(int idx);
		private void StartBlink();
		private void StopBlink();
		private void OnUpdateBlink(float v);
		private void SetVisibleSpriteRenderer();
	}
}
