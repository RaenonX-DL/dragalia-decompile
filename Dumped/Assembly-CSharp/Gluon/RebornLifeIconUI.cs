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
	public class RebornLifeIconUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform _rootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _onRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _heartRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _ringRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _gradationRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _heart2Rt;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _onImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _heartImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _ringImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _gradationImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _heart2Image;
		private VisibleUIObject _rootVisible;
		private Sequence _animSeq;
		private Color _workColor;
		private int _index;
		[CompilerGenerated]
		private bool _isEnable_k__BackingField;
	
		// Properties
		public bool isEnable { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isVisible { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public RebornLifeIconUI __4__this;
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _PlayStartAnim_b__0(float rate);
			internal void _PlayStartAnim_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public Action onComplete;
			public RebornLifeIconUI __4__this;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _PlayConsumeAnim_b__0();
		}
	
		// Constructors
		public RebornLifeIconUI();
	
		// Methods
		public static RebornLifeIconUI Create(GameObject pobj, GameObject parent, int index, bool enable, int siblingIndex = -1);
		private void Initialize(int index, bool enable);
		private void OnDestroy();
		public void SetEnable(bool enable, bool force = false);
		public void SetVisible(bool visible);
		public void PlayStartAnim(float waitTime, Action onComplete = null);
		public void PlayBlinkAnim();
		public void PlayConsumeAnim(Action onComplete = null);
		private void SetFade(ref SpriteRenderer image, float fade);
	}
}
