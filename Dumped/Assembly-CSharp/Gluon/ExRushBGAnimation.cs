/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExRushBGAnimation : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Image[] bgScrollTexts;
		public Image[] bgScrollSquares;
		[Header]
		[SerializeField]
		public GameObject bgLine;
		[Header]
		[SerializeField]
		public GameObject[] bgCircle01;
		public GameObject[] bgCircle01Small;
		public GameObject[] bgCircle01B;
		public GameObject[] bgCircle02;
		public GameObject[] bgCircle02B;
		public GameObject[] bgCircle03;
		public GameObject[] bgCircle04;
		public CanvasGroup[] bgCircle06;
		public CanvasGroup[] bgCircle06B;
		[Header]
		[SerializeField]
		public float bgSquareScrollSpeedX;
		public float bgSquareScrollSpeedY;
		public float bgTextScrollSpeedY;
		public float bgCircle01Speed;
		public float bgCircle01SmallSpeed;
		public float bgCircle01BSpeed;
		public float bgCircle02Speed;
		public float bgCircle02BSpeed;
		public float bgCircle03Speed;
		public float bgCircle04Speed;
		[Header]
		[SerializeField]
		public float BgCircle02BInterval;
		public float BgCircle03Interval;
		private Material newBGScrollMat;
		private Material newBGSquareMat;
		private float oriLinePosY;
		private Coroutine enableCoroutine;
		private List<Tweener> runningTweeners;
		private List<Sequence> runningSequences;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _EnableCoroutine_d__34 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ExRushBGAnimation __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _EnableCoroutine_d__34(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ExRushBGAnimation();
	
		// Methods
		private void Start();
		private void Update();
		private void OnEnable();
		private void OnDisable();
		[IteratorStateMachine]
		private IEnumerator EnableCoroutine();
	}
}
