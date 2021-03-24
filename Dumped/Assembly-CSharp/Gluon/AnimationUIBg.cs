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
	public class AnimationUIBg : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private bool expandToCanvasSize;
		[Header]
		[SerializeField]
		public float enterFrame;
		[Header]
		[SerializeField]
		public Vector3 enterOffset;
		[Header]
		[SerializeField]
		public float enterSize;
		[Header]
		[SerializeField]
		public bool enterAlphaChange;
		[Header]
		[SerializeField]
		public float exitFrame;
		[Header]
		[SerializeField]
		public Vector3 exitOffset;
		[Header]
		[SerializeField]
		public float exitSize;
		public Canvas canvas;
		[CompilerGenerated]
		private bool _skipExitAnimation_k__BackingField;
		private RectTransform rectTransform;
		private CanvasGroup canvasGroup;
		private Vector2 initialSize;
		private Vector3 initialPosition;
		private Sequence runningSeq;
	
		// Properties
		public bool skipExitAnimation { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public AnimationUIBg();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		public void ResetInitialPosAndSize();
		public void ResetAlpha();
		public void InitAlpha();
		public void StartEnterAnimation();
		public void StartExitAnimation();
		[CompilerGenerated]
		private void _StartEnterAnimation_b__23_0(float x);
		[CompilerGenerated]
		private void _StartEnterAnimation_b__23_1(float x);
		[CompilerGenerated]
		private void _StartExitAnimation_b__24_0(float x);
		[CompilerGenerated]
		private void _StartExitAnimation_b__24_1(float x);
		[CompilerGenerated]
		private void _StartExitAnimation_b__24_2();
	}
}
