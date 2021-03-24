/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaCircleGaugeMiasmaUI : CharaCircleGaugeUI
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform _iconAnimRootRt;
		[SerializeField]
		protected RectTransform _iconAnimRt;
		[SerializeField]
		protected SpriteRenderer _iconAnimImage;
		[SerializeField]
		protected InGameAnimUI _glowAnimUI;
		[Header]
		[SerializeField]
		[Tooltip]
		protected Vector2 _iconAnimScale;
		[SerializeField]
		[Tooltip]
		protected Vector2 _iconAnimAlpha;
		[SerializeField]
		[Tooltip]
		protected Ease _iconAnimEase;
		[SerializeField]
		[Tooltip]
		protected float _animWaitTime;
		[Range]
		[SerializeField]
		[Tooltip]
		protected float _grayScaleMulti;
		protected VisibleUIObject _iconAnimVisible;
		protected bool _initializedGrayScale;
	
		// Constructors
		public CharaCircleGaugeMiasmaUI();
	
		// Methods
		public static CharaCircleGaugeMiasmaUI Create(GameObject parent, CharacterBase owner, BossBreakUI bossBreakUI, float adjustPosY, int siblingIndex = -1);
		protected override void Initialize(CharacterBase owner, BossBreakUI bossBreakUI, Type gaugeType, float adjustPosY);
		protected override void UpdateAnim();
		protected override void PlayAnim();
		protected override void StopAnim();
		protected override Color GetGaugeColor(float rate);
		private void InitGrayScale();
		protected bool CopyMaterial(ref SpriteRenderer image);
		public override void SetGrayScale(bool b, bool isForce = false);
		protected void SetGrayScaleParam(ref SpriteRenderer image, bool isGrayScale, float grayScaleMulti = 1f);
	}
}
