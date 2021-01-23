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
	public class InGameAnimUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform[] _animRt;
		[SerializeField]
		protected SpriteRenderer[] _animImage;
		[Header]
		[SerializeField]
		[Tooltip]
		protected int _loopCount;
		[SerializeField]
		[Tooltip]
		protected float _startWaitTime;
		[SerializeField]
		[Tooltip]
		protected AnimData[] _animData;
		protected Sequence _seqAnim;
		protected Color[] _originColor;
		protected Action _onComplete;
		protected bool _isEnableScaleAnim;
		protected bool _isEnableFadeAnim;
	
		// Nested types
		[Serializable]
		public class AnimData
		{
			// Fields
			[Tooltip]
			public Vector3 scale;
			[Range]
			[Tooltip]
			public float fade;
			[Tooltip]
			public float animTime;
			[Tooltip]
			public float afterWaitTime;
			[Tooltip]
			public Ease ease;
			[HideInInspector]
			public Vector3 prevScale;
			[HideInInspector]
			public float prevFade;
	
			// Constructors
			public AnimData();
		}
	
		// Constructors
		public InGameAnimUI();
	
		// Methods
		public void Awake();
		public void Initialize(Action onComplete);
		public void OnDestroy();
		public bool Play(bool isForce = false);
		public void Stop();
		public bool IsPlaying();
		protected virtual void ApplyImageData(AnimData data);
		protected virtual void OnUpdateScale(Vector3 scale);
		protected virtual void OnUpdateFade(float fade);
		[CompilerGenerated]
		private void _Play_b__14_0();
	}
}
