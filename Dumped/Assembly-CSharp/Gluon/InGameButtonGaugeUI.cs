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
	public class InGameButtonGaugeUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private GameObject rootObj;
		[SerializeField]
		private RectTransform gainMask;
		[SerializeField]
		private SpriteRenderer gainBar;
		[SerializeField]
		private RectTransform baseMask;
		[SerializeField]
		private SpriteRenderer baseBar;
		[SerializeField]
		private SpriteRenderer blinkImage;
		[SerializeField]
		private Sprite[] baseSprites;
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
		private GameObject gainGameObj;
		private GameObject baseGameObj;
		private GameObject blinkGameObj;
		private Vector2 gainMaskScale;
		private Vector2 baseMaskScale;
		private float baseMaskWorldSizeX;
		private float gainRemainTime;
		private float lastValue;
		private Color srcColor;
		private Color blinkColor;
		private Tweener blinkTweener;
	
		// Constructors
		public InGameButtonGaugeUI();
	
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
		public float GetBaseMaskValue();
		public Vector3 GetEffectPosition(Vector3 effectBaseBoss);
		private bool WaitTime(ref float t, ref float remainTime);
		private void SetBaseColor(Color color);
		private void StartBlink();
		private void StopBlink();
		private void OnUpdateBlink(float v);
	}
}
