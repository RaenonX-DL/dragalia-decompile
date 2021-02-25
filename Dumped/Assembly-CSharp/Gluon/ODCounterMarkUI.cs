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
	public class ODCounterMarkUI : CharacterMarkUI
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _rootRt;
		[SerializeField]
		private RectTransform _animRt;
		[SerializeField]
		private SpriteRenderer _iconImage;
		[SerializeField]
		private SpriteRenderer _arrowImage;
		private VisibleUIObject _rootVisible;
		private RectTransform _iconRt;
		private RectTransform _arrowRt;
		private Vector3 _targetPos;
		private Vector2 _adjustPos2D;
		private Sequence _animSeq;
		private Sequence _iconLoopAnimSeq;
		private Sequence _arrowLoopAnimSeq;
	
		// Constructors
		public ODCounterMarkUI();
	
		// Methods
		public void Initialize();
		private void OnDestroy();
		public void Show(Vector3 pos, Vector2 adjustPos2D);
		public void Hide();
		public override bool IsVisible();
		private void LateUpdate();
		public void SetPosition(Vector3 pos, Vector2 adjustPos2D);
		private void UpdatePosition();
		private void PlayShowAnim();
		private void PlayLoopAnim();
		[CompilerGenerated]
		private void _PlayShowAnim_b__20_0();
		[CompilerGenerated]
		private void _PlayLoopAnim_b__21_0();
	}
}
