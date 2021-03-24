/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[DisallowMultipleComponent]
	public class TweenSequenceVisualizer : MonoBehaviour
	{
		// Fields
		private Sequence mainSequence;
		public List<Sequence> workingSequenceList;
		public bool isLoop;
		public bool isResetToInitialState;
		public bool shouldAutoStart;
		public float loopInterval;
		public Transform overrideTweenTransform;
		public RectTransform overrideTweenRectTransform;
		public CanvasGroup overrideTweenCanvas;
		public Image overrideTweenImage;
		public float customEaseErrorValue;
		public List<UnityEngine.Object> recordedItemList;
	
		// Properties
		[HideInInspector]
		public Sequence sequence { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public TweenItemVisualizer[] items;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _ApplyChangesOnRun_b__0();
		}
	
		// Constructors
		public TweenSequenceVisualizer();
	
		// Methods
		private void Start();
		public void CompleteSequence();
		private void OnDestroy();
		public void KillAll();
		public bool IsCompleted();
		public bool IsActive();
		public void PlaySequence();
		public Sequence PushSequence();
		public static Sequence PushSequence(ref List<Sequence> seqList);
		public Sequence PopSequence();
		public static Sequence PopSequence(ref Sequence mainSeq, ref List<Sequence> seqList);
		public Sequence AttachAllPushedSequence();
		public static Sequence AttachAllPushedSequence(ref Sequence mainSeq, ref List<Sequence> seqList);
		public void ApplyChangesOnRun(bool bAutoStart = true, bool bOnRun = false);
	}
}
